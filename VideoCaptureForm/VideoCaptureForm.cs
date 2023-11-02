using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Linq.Expressions;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenCvSharp;
using OpenCvSharp.Extensions;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;

namespace VideoCaptureForm
{
    public enum ProgramModes
    {
        lineDetection,
        colorSegmentation,
        objectDetection
    }
    public partial class VideoCaptureForm : Form
    {
        private readonly VideoCapture capture;

        public VideoCaptureForm()
        {
            InitializeComponent();
            capture = new VideoCapture();
        }

        #region [ variables and form inititalization ]
        ColorOptionsForm colorOptionsForm = new ColorOptionsForm();
        ThreshOptionsForm threshOptionsForm = new ThreshOptionsForm();
        MoreFramesForm moreFramesForm;

        int lowerThreshVal, upperThreshVal, blockSize, c;
        int middle_line_length, rho_accuracy;
        int linesThresh, linesMinLength;
        double theta_accuracy;
        ProgramModes mode = ProgramModes.lineDetection;

        Mat gray, threshImg, edges, hsv, blur, mask;
        Scalar lower_val, upper_val;
        LineSegmentPoint[] lines;
        

        private void VideoCaptureForm_Load(object sender, EventArgs e)
        {
            UpdateValues();
        }

        private void FormClose(object sender, FormClosingEventArgs e)
        {
            backgroundWorker1.CancelAsync();
            capture.Dispose();
        }
        #endregion

        #region [ buttons implementation ]
        private void openBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Видео файлы |*.mp4";
            if (dialog.ShowDialog() == DialogResult.OK) // @"C:\Users\vikto\Videos\2021.01.31.mp4"
            {
                capture.Open(dialog.FileName, VideoCaptureAPIs.ANY);
                capture.BufferSize = 1;
                if (!capture.IsOpened())
                {
                    Close();
                    return;
                }
                typesBtn.Enabled = true;
                backgroundWorker1.RunWorkerAsync();
            }
        }
        public void pauseContinueBtn_Click(object sender, EventArgs e)
        {
            if (backgroundWorker1.IsBusy)
                backgroundWorker1.CancelAsync();
            else
                backgroundWorker1.RunWorkerAsync();
        }
        private void picture_in_Click(object sender, EventArgs e)
        {
            PropertyInfo imageRectangleProperty = typeof(PictureBox).GetProperty("ImageRectangle", BindingFlags.GetProperty | BindingFlags.NonPublic | BindingFlags.Instance);
            if (picture_in.Image != null)
            {
                MouseEventArgs me = (MouseEventArgs)e;
                Bitmap orig = (Bitmap)picture_in.Image;

                Color? color = null;
                switch (picture_in.SizeMode)
                {
                    case PictureBoxSizeMode.Normal:
                    case PictureBoxSizeMode.AutoSize:
                        {
                            color = orig.GetPixel(me.X, me.Y);
                            break;
                        }
                    case PictureBoxSizeMode.CenterImage:
                    case PictureBoxSizeMode.StretchImage:
                    case PictureBoxSizeMode.Zoom:
                        {
                            Rectangle rectangle = (Rectangle)imageRectangleProperty.GetValue(picture_in, null);
                            if (rectangle.Contains(me.Location))
                            {
                                using (Bitmap copy = new Bitmap(picture_in.ClientSize.Width, picture_in.ClientSize.Height))
                                {
                                    using (Graphics g = Graphics.FromImage(copy))
                                    {
                                        g.DrawImage(picture_in.Image, rectangle);
                                        color = copy.GetPixel(me.X, me.Y);
                                        Debug.Write(color);
                                        colorOptionsForm.lowerR = color.Value.R - colorOptionsForm.interValue > 0 ? color.Value.R - colorOptionsForm.interValue : 0;
                                        colorOptionsForm.lowerG = color.Value.G - colorOptionsForm.interValue > 0 ? color.Value.G - colorOptionsForm.interValue : 0;
                                        colorOptionsForm.lowerB = color.Value.B - colorOptionsForm.interValue > 0 ? color.Value.B - colorOptionsForm.interValue : 0;

                                        colorOptionsForm.upperR = color.Value.R + colorOptionsForm.interValue < 255 ? color.Value.R + colorOptionsForm.interValue : 255;
                                        colorOptionsForm.upperG = color.Value.G + colorOptionsForm.interValue < 255 ? color.Value.G + colorOptionsForm.interValue : 255;
                                        colorOptionsForm.upperB = color.Value.B + colorOptionsForm.interValue < 255 ? color.Value.B + colorOptionsForm.interValue : 255;

                                        colorOptionsForm.UpdateCircles();
                                        colorOptionsForm.UpdateValues();
                                        UpdateValues();
                                    }
                                }
                            }
                            break;
                        }
                }
            }
        }
        private void threshSetBtn_Click(object sender, EventArgs e)
        {
            mode = ProgramModes.lineDetection;
        }
        private void closeBtn_Click(object sender, EventArgs e)
        {
            StopCapture();
        }
        private void colorSegmentSetBtn_Click(object sender, EventArgs e)
        {
            mode = ProgramModes.colorSegmentation;
        }
        private void threshOptionsBtn_Click(object sender, EventArgs e)
        {
            threshOptionsForm.Show();
        }
        private void colorOptionsBtn_Click(object sender, EventArgs e)
        {
            colorOptionsForm.Show();
        }
        private void debugBtn_Click(object sender, EventArgs e)
        {
            moreFramesForm = new MoreFramesForm();
            moreFramesForm.Show();
        }
        #endregion

        #region [ CV functions ]
        public static Scalar ColorToHSV(Color color)
        {
            int max = Math.Max(color.R, Math.Max(color.G, color.B));
            int min = Math.Min(color.R, Math.Min(color.G, color.B));

            var hue = color.GetHue();
            var saturation = (max == 0) ? 0 : 1d - (1d * min / max);
            var value = max / 255d;

            return new Scalar(hue, saturation, value); 
        }
        public Bitmap DetectRoadLines(Mat frameMat)
        {
            //frameMat = frameMat.BilateralFilter(15, 75, 75);
            gray = frameMat.CvtColor(ColorConversionCodes.BGR2GRAY);
            threshImg = gray.AdaptiveThreshold(upperThreshVal, AdaptiveThresholdTypes.GaussianC,ThresholdTypes.BinaryInv, blockSize, c);
            edges = threshImg.Canny(lowerThreshVal, upperThreshVal, 3);
            lines = edges.HoughLinesP(rho_accuracy, theta_accuracy, linesThresh, linesMinLength, 10);
            if (lines != null)
            {
                foreach (var line in lines)
                {
                    var p1 = line.P1;
                    var p2 = line.P2;
                    double a = p1.X - p2.X;
                    double b = p1.Y - p2.Y;
                    if (Math.Sqrt(a * a + b * b) < middle_line_length)
                        Cv2.Line(frameMat, p1, p2, Scalar.Yellow, 2);
                    else
                        Cv2.Line(frameMat, p1, p2, Scalar.AntiqueWhite, 2);
                }
            }
            return frameMat.ToBitmap();
        }
        public Bitmap SegmentColors(Mat frameMat)
        {
            var size = new OpenCvSharp.Size(5,5);
            blur = frameMat.Blur(size);
            blur = blur.GaussianBlur(size,0);
            blur = blur.BilateralFilter(9, 75, 75);
            hsv = blur.CvtColor(ColorConversionCodes.BGR2HSV);

            mask = frameMat.InRange(lower_val, upper_val);
            Mat res = new Mat(); 
            Cv2.BitwiseAnd(frameMat,frameMat,res,mask);

            return res != null ? res.ToBitmap() : frameMat.ToBitmap();
        }
        #endregion

        #region [ backgroundTasks ]
        private void UpdateValues()
        {
            lowerThreshVal = threshOptionsForm.lowerThreshVal;
            upperThreshVal = threshOptionsForm.upperThreshVal;
            linesThresh = threshOptionsForm.linesThresh;
            middle_line_length = threshOptionsForm.middle_line_length;
            rho_accuracy = threshOptionsForm.rho_accuracy;
            theta_accuracy = threshOptionsForm.theta_accuracy;
            linesMinLength = threshOptionsForm.linesMinLength;
            linesThresh = threshOptionsForm.linesThresh;
            blockSize = threshOptionsForm.blockSize;
            c = threshOptionsForm.c;
            lower_val = new Scalar(colorOptionsForm.lowerB, colorOptionsForm.lowerG, colorOptionsForm.lowerR);
            upper_val = new Scalar(colorOptionsForm.upperB, colorOptionsForm.upperG, colorOptionsForm.upperR);
        }
        void StopCapture()
        {
            capture?.Release();
            backgroundWorker1?.Dispose();
            backgroundWorker1.CancelAsync();
        }
        public void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            var bgWorker = (BackgroundWorker) sender;
            int sleepTime = (int)Math.Round(1000 / capture.Fps);
            while (!bgWorker.CancellationPending)
            {
                UpdateValues();
                var frameMat = capture.RetrieveMat();
                if (frameMat.Empty())
                {
                    StopCapture();
                    break;
                }
                    
                var frameCopy = frameMat.ToBitmap();
                Bitmap frameBitmap = new Bitmap(frameCopy.Width, frameCopy.Height);
                switch (mode)
                {
                    case ProgramModes.lineDetection: { frameBitmap = DetectRoadLines(frameMat); break; }
                    case ProgramModes.colorSegmentation: { frameBitmap = SegmentColors(frameMat); break; }
                }
                bgWorker.ReportProgress(0, (frameCopy, frameBitmap));
                
                Thread.Sleep(sleepTime);
            }
        }
        
        private void OnProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            ValueTuple<Bitmap, Bitmap> images = ((Bitmap, Bitmap))e.UserState;
            picture_in.Image?.Dispose();
            picture_out.Image?.Dispose();
            picture_in.Image = images.Item1;
            picture_out.Image = images.Item2;

           
            if (moreFramesForm != null)
            {
                moreFramesForm.pictureBox1.Image?.Dispose();
                moreFramesForm.pictureBox2.Image?.Dispose();
                moreFramesForm.pictureBox3.Image?.Dispose();

                switch (mode)
                {
                    case ProgramModes.lineDetection:
                        {
                            moreFramesForm.pictureBox1.Image = threshImg?.ToBitmap();
                            moreFramesForm.pictureBox2.Image = gray?.ToBitmap();
                            moreFramesForm.pictureBox3.Image = edges?.ToBitmap();
                            break;
                        }
                    case ProgramModes.colorSegmentation:
                        {
                            moreFramesForm.pictureBox1.Image = hsv?.ToBitmap();
                            moreFramesForm.pictureBox2.Image = mask?.ToBitmap();
                            moreFramesForm.pictureBox3.Image = blur?.ToBitmap();
                            break;
                        }
                }
            }  
        }
        #endregion
    }
}
