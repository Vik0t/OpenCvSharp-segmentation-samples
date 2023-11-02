using OpenCvSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VideoCaptureForm
{
    public partial class ColorOptionsForm : Form
    {
        public ColorOptionsForm()
        {
            InitializeComponent();
        }

        public int lowerR = 0;
        public int lowerG = 0;
        public int lowerB = 0;
        public int upperR = 255;
        public int upperG = 255;
        public int upperB = 255;
        public int interValue = 10;

        

        private void ColorOptionsForm_Load(object sender, EventArgs e)
        {
            UpdateValues();
        }

        public void UpdateValues()
        {
            lowerTrackBarR.Value = lowerR > 0 ? lowerR : 0;
            lowerTrackBarG.Value = lowerG > 0 ? lowerG : 0;
            lowerTrackBarB.Value = lowerB > 0 ? lowerB : 0;

            upperTrackBarR.Value = upperR < 255 ? upperR : 255;
            upperTrackBarG.Value = upperG < 255 ? upperG : 255;
            upperTrackBarB.Value = upperB < 255 ? upperB : 255;

            interval.Value = interValue;
        }

        public void UpdateCircles()
        {
            lowerPictureBox.BorderColorFirst = Color.FromArgb(lowerR > 0 ? lowerR : 0,
                                                              lowerG > 0 ? lowerG : 0,
                                                              lowerB > 0 ? lowerB : 0);
            lowerPictureBox.BorderColorSecond = Color.FromArgb(lowerR + interValue < 255 ? lowerR + interValue : 255,
                                                               lowerG + interValue < 255 ? lowerG + interValue : 255,
                                                               lowerB + interValue < 255 ? lowerB + interValue : 255);
            upperPictureBox.BorderColorFirst = Color.FromArgb(upperR < 255 ? upperR : 255,
                                                              upperG < 255 ? upperG : 255,
                                                              upperB < 255 ? upperB : 255);
            upperPictureBox.BorderColorSecond = Color.FromArgb(upperR - interValue > 0 ? upperR - interValue : 0,
                                                               upperG - interValue > 0 ? upperG - interValue : 0,
                                                               upperB - interValue > 0 ? upperB - interValue : 0);
        }

        private void lowerTrackBarR_Scroll(object sender, EventArgs e)
        {
            lowerR = lowerTrackBarR.Value;
            UpdateCircles();
        }
        private void lowerTrackBarG_Scroll(object sender, EventArgs e)
        {
            lowerG = lowerTrackBarG.Value;
            UpdateCircles();
        }
        private void lowerTrackBarB_Scroll(object sender, EventArgs e)
        {
            lowerB = lowerTrackBarB.Value;
            UpdateCircles();
        }
        private void upperTrackBarR_Scroll(object sender, EventArgs e)
        {
            upperR = upperTrackBarR.Value;
            UpdateCircles();
        }
        private void upperTrackBarG_Scroll(object sender, EventArgs e)
        {
            upperG = upperTrackBarG.Value;
            UpdateCircles();
        }
        private void upperTrackBarB_Scroll(object sender, EventArgs e)
        {
            upperB = upperTrackBarB.Value;
            UpdateCircles();
        }
        private void interval_ValueChanged(object sender, EventArgs e)
        {
            interValue = (int)interval.Value;
        }
    }
}
