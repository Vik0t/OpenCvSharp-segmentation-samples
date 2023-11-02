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
    public partial class ThreshOptionsForm : Form
    {
        public ThreshOptionsForm()
        {
            InitializeComponent();
        }
        public int lowerThreshVal = 150;
        public int upperThreshVal = 255;


        public int upperEdgesThreshVal = 150;

        public int middle_line_length = 60;
        public int rho_accuracy = 1;
        public double theta_accuracy = Math.PI / 180;

        public int linesThresh = 15;
        public int linesMinLength = 10;

        public int blockSize = 25;
        public int c = 17;
        private void ThreshOptionsForm_Load(object sender, EventArgs e)
        {
            lowThreshTrackBar.Value = lowerThreshVal;
            upThreshTrackBar.Value = upperThreshVal;
            middleLineTrackBar.Value = middle_line_length;
            linesLenTrackBar.Value = linesMinLength;
            linesThreshTrackBar.Value = linesThresh;
            blockSizeNum.Value = blockSize;
            cNum.Value = c;
        }

        private void lowThreshTrackBar_Scroll(object sender, EventArgs e)
        {
            lowerThreshVal = lowThreshTrackBar.Value;
        }
        private void upThreshTrackBar_Scroll(object sender, EventArgs e)
        {
            upperThreshVal = upThreshTrackBar.Value;
        }
        private void middleLineTrackBar_Scroll(object sender, EventArgs e)
        {
            middle_line_length = middleLineTrackBar.Value;
        }
        private void linesLenTrackBar_Scroll(object sender, EventArgs e)
        {
            linesMinLength = linesLenTrackBar.Value;
        }
        private void linesThreshTrackBar_Scroll(object sender, EventArgs e)
        {
            linesThresh = linesThreshTrackBar.Value;
        }
        private void blockSizeNum_ValueChanged(object sender, EventArgs e)
        {
            blockSize = (int)blockSizeNum.Value;
        }
        private void cNum_ValueChanged(object sender, EventArgs e)
        {
            c = (int)cNum.Value;
        }
    }
}
