namespace VideoCaptureForm
{
    partial class ThreshOptionsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lowThreshTrackBar = new System.Windows.Forms.TrackBar();
            this.upThreshTrackBar = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.middleLineTrackBar = new System.Windows.Forms.TrackBar();
            this.codeeloShadowEffect1 = new CodeeloUI.Components.CodeeloShadowEffect(this.components);
            this.codeeloGradientPanel1 = new CodeeloUI.Controls.CodeeloGradientPanel();
            this.codeeloGradientPanel2 = new CodeeloUI.Controls.CodeeloGradientPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.linesLenTrackBar = new System.Windows.Forms.TrackBar();
            this.label7 = new System.Windows.Forms.Label();
            this.linesThreshTrackBar = new System.Windows.Forms.TrackBar();
            this.label9 = new System.Windows.Forms.Label();
            this.codeeloGradientPanel3 = new CodeeloUI.Controls.CodeeloGradientPanel();
            this.blockSizeNum = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.cNum = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.lowThreshTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.upThreshTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.middleLineTrackBar)).BeginInit();
            this.codeeloGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.linesLenTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.linesThreshTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blockSizeNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cNum)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Trigram", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(-3, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "thresh";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Trigram", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(3, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "мин";
            // 
            // lowThreshTrackBar
            // 
            this.lowThreshTrackBar.Location = new System.Drawing.Point(4, 90);
            this.lowThreshTrackBar.Maximum = 255;
            this.lowThreshTrackBar.Name = "lowThreshTrackBar";
            this.lowThreshTrackBar.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.lowThreshTrackBar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lowThreshTrackBar.Size = new System.Drawing.Size(45, 415);
            this.lowThreshTrackBar.TabIndex = 5;
            this.lowThreshTrackBar.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.lowThreshTrackBar.Scroll += new System.EventHandler(this.lowThreshTrackBar_Scroll);
            // 
            // upThreshTrackBar
            // 
            this.upThreshTrackBar.Location = new System.Drawing.Point(54, 90);
            this.upThreshTrackBar.Maximum = 255;
            this.upThreshTrackBar.Name = "upThreshTrackBar";
            this.upThreshTrackBar.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.upThreshTrackBar.Size = new System.Drawing.Size(45, 415);
            this.upThreshTrackBar.TabIndex = 6;
            this.upThreshTrackBar.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.upThreshTrackBar.Scroll += new System.EventHandler(this.upThreshTrackBar_Scroll);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Trigram", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(279, 51);
            this.label1.TabIndex = 7;
            this.label1.Text = "калибровка";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Trigram", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(48, 76);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 15);
            this.label6.TabIndex = 10;
            this.label6.Text = "макс";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Trigram", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(154, 54);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 22);
            this.label8.TabIndex = 13;
            this.label8.Text = "line";
            // 
            // middleLineTrackBar
            // 
            this.middleLineTrackBar.Location = new System.Drawing.Point(117, 90);
            this.middleLineTrackBar.Maximum = 255;
            this.middleLineTrackBar.Name = "middleLineTrackBar";
            this.middleLineTrackBar.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.middleLineTrackBar.Size = new System.Drawing.Size(45, 415);
            this.middleLineTrackBar.TabIndex = 14;
            this.middleLineTrackBar.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.middleLineTrackBar.Scroll += new System.EventHandler(this.middleLineTrackBar_Scroll);
            // 
            // codeeloShadowEffect1
            // 
            this.codeeloShadowEffect1.BorderRadius = 6;
            this.codeeloShadowEffect1.Color = System.Drawing.Color.White;
            this.codeeloShadowEffect1.Depth = 30;
            this.codeeloShadowEffect1.ShadowPadding = new System.Windows.Forms.Padding(5);
            this.codeeloShadowEffect1.SourceControl = this.label1;
            this.codeeloShadowEffect1.UseShadowEffect = true;
            // 
            // codeeloGradientPanel1
            // 
            this.codeeloGradientPanel1.AccessibleRole = null;
            this.codeeloGradientPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.codeeloGradientPanel1.CausesValidation = false;
            this.codeeloGradientPanel1.ColorFillFirst = System.Drawing.Color.Navy;
            this.codeeloGradientPanel1.ColorFillSecond = System.Drawing.Color.Indigo;
            this.codeeloGradientPanel1.Controls.Add(this.label1);
            this.codeeloGradientPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.codeeloGradientPanel1.DrawGradient = true;
            this.codeeloGradientPanel1.GradientDirection = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.codeeloGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.codeeloGradientPanel1.Name = "codeeloGradientPanel1";
            this.codeeloGradientPanel1.Size = new System.Drawing.Size(279, 51);
            this.codeeloGradientPanel1.TabIndex = 15;
            // 
            // codeeloGradientPanel2
            // 
            this.codeeloGradientPanel2.AccessibleRole = null;
            this.codeeloGradientPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.codeeloGradientPanel2.CausesValidation = false;
            this.codeeloGradientPanel2.ColorFillFirst = System.Drawing.Color.Indigo;
            this.codeeloGradientPanel2.ColorFillSecond = System.Drawing.Color.Navy;
            this.codeeloGradientPanel2.DrawGradient = true;
            this.codeeloGradientPanel2.GradientDirection = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.codeeloGradientPanel2.Location = new System.Drawing.Point(106, 50);
            this.codeeloGradientPanel2.Name = "codeeloGradientPanel2";
            this.codeeloGradientPanel2.Size = new System.Drawing.Size(5, 463);
            this.codeeloGradientPanel2.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Trigram", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(109, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 15);
            this.label4.TabIndex = 17;
            this.label4.Text = "color";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Trigram", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(168, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 15);
            this.label5.TabIndex = 18;
            this.label5.Text = "len";
            // 
            // linesLenTrackBar
            // 
            this.linesLenTrackBar.Location = new System.Drawing.Point(168, 90);
            this.linesLenTrackBar.Maximum = 80;
            this.linesLenTrackBar.Name = "linesLenTrackBar";
            this.linesLenTrackBar.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.linesLenTrackBar.Size = new System.Drawing.Size(45, 415);
            this.linesLenTrackBar.TabIndex = 19;
            this.linesLenTrackBar.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.linesLenTrackBar.Scroll += new System.EventHandler(this.linesLenTrackBar_Scroll);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Trigram", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(207, 76);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 15);
            this.label7.TabIndex = 20;
            this.label7.Text = "thresh";
            // 
            // linesThreshTrackBar
            // 
            this.linesThreshTrackBar.Location = new System.Drawing.Point(223, 90);
            this.linesThreshTrackBar.Maximum = 80;
            this.linesThreshTrackBar.Name = "linesThreshTrackBar";
            this.linesThreshTrackBar.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.linesThreshTrackBar.Size = new System.Drawing.Size(45, 415);
            this.linesThreshTrackBar.TabIndex = 21;
            this.linesThreshTrackBar.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.linesThreshTrackBar.Scroll += new System.EventHandler(this.linesThreshTrackBar_Scroll);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Trigram", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(3, 516);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 15);
            this.label9.TabIndex = 22;
            this.label9.Text = "block:";
            // 
            // codeeloGradientPanel3
            // 
            this.codeeloGradientPanel3.AccessibleRole = null;
            this.codeeloGradientPanel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.codeeloGradientPanel3.CausesValidation = false;
            this.codeeloGradientPanel3.ColorFillFirst = System.Drawing.Color.Navy;
            this.codeeloGradientPanel3.ColorFillSecond = System.Drawing.Color.Indigo;
            this.codeeloGradientPanel3.DrawGradient = true;
            this.codeeloGradientPanel3.GradientDirection = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.codeeloGradientPanel3.Location = new System.Drawing.Point(0, 508);
            this.codeeloGradientPanel3.Name = "codeeloGradientPanel3";
            this.codeeloGradientPanel3.Size = new System.Drawing.Size(279, 5);
            this.codeeloGradientPanel3.TabIndex = 24;
            // 
            // blockSizeNum
            // 
            this.blockSizeNum.BackColor = System.Drawing.SystemColors.MenuText;
            this.blockSizeNum.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.blockSizeNum.Font = new System.Drawing.Font("Trigram", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.blockSizeNum.ForeColor = System.Drawing.SystemColors.Window;
            this.blockSizeNum.Increment = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.blockSizeNum.Location = new System.Drawing.Point(76, 516);
            this.blockSizeNum.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.blockSizeNum.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.blockSizeNum.Name = "blockSizeNum";
            this.blockSizeNum.Size = new System.Drawing.Size(53, 17);
            this.blockSizeNum.TabIndex = 26;
            this.blockSizeNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.blockSizeNum.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.blockSizeNum.ValueChanged += new System.EventHandler(this.blockSizeNum_ValueChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Trigram", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(199, 516);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(23, 15);
            this.label10.TabIndex = 27;
            this.label10.Text = "c:";
            // 
            // cNum
            // 
            this.cNum.BackColor = System.Drawing.SystemColors.MenuText;
            this.cNum.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cNum.Font = new System.Drawing.Font("Trigram", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cNum.ForeColor = System.Drawing.SystemColors.Window;
            this.cNum.Increment = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.cNum.Location = new System.Drawing.Point(223, 516);
            this.cNum.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.cNum.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.cNum.Name = "cNum";
            this.cNum.Size = new System.Drawing.Size(53, 17);
            this.cNum.TabIndex = 28;
            this.cNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cNum.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.cNum.ValueChanged += new System.EventHandler(this.cNum_ValueChanged);
            // 
            // ThreshOptionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuText;
            this.ClientSize = new System.Drawing.Size(279, 535);
            this.Controls.Add(this.cNum);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.blockSizeNum);
            this.Controls.Add(this.codeeloGradientPanel3);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.codeeloGradientPanel1);
            this.Controls.Add(this.codeeloGradientPanel2);
            this.Controls.Add(this.linesThreshTrackBar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.linesLenTrackBar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.middleLineTrackBar);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.upThreshTrackBar);
            this.Controls.Add(this.lowThreshTrackBar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "ThreshOptionsForm";
            this.Text = "OptionsForm";
            this.Load += new System.EventHandler(this.ThreshOptionsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lowThreshTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.upThreshTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.middleLineTrackBar)).EndInit();
            this.codeeloGradientPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.linesLenTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.linesThreshTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blockSizeNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cNum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TrackBar lowThreshTrackBar;
        private System.Windows.Forms.TrackBar upThreshTrackBar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TrackBar middleLineTrackBar;
        private CodeeloUI.Components.CodeeloShadowEffect codeeloShadowEffect1;
        private CodeeloUI.Controls.CodeeloGradientPanel codeeloGradientPanel1;
        private CodeeloUI.Controls.CodeeloGradientPanel codeeloGradientPanel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TrackBar linesLenTrackBar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TrackBar linesThreshTrackBar;
        private System.Windows.Forms.Label label9;
        private CodeeloUI.Controls.CodeeloGradientPanel codeeloGradientPanel3;
        private System.Windows.Forms.NumericUpDown blockSizeNum;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown cNum;
    }
}