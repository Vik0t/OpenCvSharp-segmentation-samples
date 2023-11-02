namespace VideoCaptureForm
{
    partial class VideoCaptureForm
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VideoCaptureForm));
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.menu = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.pauseContinueBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.typesBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.threshSetBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.threshOptionsBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.colorSegmentSetBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.colorOptionsBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.debugBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.picture_in = new CodeeloUI.Controls.CodeeloPictureBox();
            this.picture_out = new CodeeloUI.Controls.CodeeloPictureBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.codeeloGradientPanel1 = new CodeeloUI.Controls.CodeeloGradientPanel();
            this.closeBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture_in)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_out)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.WorkerSupportsCancellation = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.OnProgressChanged);
            // 
            // menu
            // 
            this.menu.BackColor = System.Drawing.Color.Navy;
            this.menu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.typesBtn,
            this.toolStripMenuItem1});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menu.Size = new System.Drawing.Size(498, 26);
            this.menu.TabIndex = 2;
            this.menu.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openBtn,
            this.pauseContinueBtn,
            this.closeBtn});
            this.файлToolStripMenuItem.Font = new System.Drawing.Font("Trigram", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.файлToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Window;
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(80, 22);
            this.файлToolStripMenuItem.Text = "файл";
            // 
            // openBtn
            // 
            this.openBtn.BackColor = System.Drawing.SystemColors.MenuText;
            this.openBtn.ForeColor = System.Drawing.SystemColors.Window;
            this.openBtn.Name = "openBtn";
            this.openBtn.Size = new System.Drawing.Size(308, 22);
            this.openBtn.Text = "открыть";
            this.openBtn.Click += new System.EventHandler(this.openBtn_Click);
            // 
            // pauseContinueBtn
            // 
            this.pauseContinueBtn.BackColor = System.Drawing.SystemColors.ControlText;
            this.pauseContinueBtn.ForeColor = System.Drawing.SystemColors.Window;
            this.pauseContinueBtn.Name = "pauseContinueBtn";
            this.pauseContinueBtn.Size = new System.Drawing.Size(308, 22);
            this.pauseContinueBtn.Text = "пауза/продолжить";
            this.pauseContinueBtn.Click += new System.EventHandler(this.pauseContinueBtn_Click);
            // 
            // typesBtn
            // 
            this.typesBtn.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.threshSetBtn,
            this.colorSegmentSetBtn});
            this.typesBtn.Enabled = false;
            this.typesBtn.Font = new System.Drawing.Font("Trigram", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.typesBtn.ForeColor = System.Drawing.SystemColors.Window;
            this.typesBtn.Name = "typesBtn";
            this.typesBtn.Size = new System.Drawing.Size(98, 22);
            this.typesBtn.Text = "режим";
            // 
            // threshSetBtn
            // 
            this.threshSetBtn.BackColor = System.Drawing.SystemColors.MenuText;
            this.threshSetBtn.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.threshOptionsBtn});
            this.threshSetBtn.ForeColor = System.Drawing.SystemColors.Window;
            this.threshSetBtn.Name = "threshSetBtn";
            this.threshSetBtn.Size = new System.Drawing.Size(202, 22);
            this.threshSetBtn.Text = "threshold";
            this.threshSetBtn.Click += new System.EventHandler(this.threshSetBtn_Click);
            // 
            // threshOptionsBtn
            // 
            this.threshOptionsBtn.BackColor = System.Drawing.SystemColors.MenuText;
            this.threshOptionsBtn.ForeColor = System.Drawing.SystemColors.Window;
            this.threshOptionsBtn.Name = "threshOptionsBtn";
            this.threshOptionsBtn.Size = new System.Drawing.Size(220, 22);
            this.threshOptionsBtn.Text = "калибровка";
            this.threshOptionsBtn.Click += new System.EventHandler(this.threshOptionsBtn_Click);
            // 
            // colorSegmentSetBtn
            // 
            this.colorSegmentSetBtn.BackColor = System.Drawing.SystemColors.MenuText;
            this.colorSegmentSetBtn.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.colorOptionsBtn});
            this.colorSegmentSetBtn.ForeColor = System.Drawing.Color.White;
            this.colorSegmentSetBtn.Name = "colorSegmentSetBtn";
            this.colorSegmentSetBtn.Size = new System.Drawing.Size(202, 22);
            this.colorSegmentSetBtn.Text = "color";
            this.colorSegmentSetBtn.Click += new System.EventHandler(this.colorSegmentSetBtn_Click);
            // 
            // colorOptionsBtn
            // 
            this.colorOptionsBtn.BackColor = System.Drawing.SystemColors.MenuText;
            this.colorOptionsBtn.ForeColor = System.Drawing.SystemColors.Window;
            this.colorOptionsBtn.Name = "colorOptionsBtn";
            this.colorOptionsBtn.Size = new System.Drawing.Size(220, 22);
            this.colorOptionsBtn.Text = "калибровка";
            this.colorOptionsBtn.Click += new System.EventHandler(this.colorOptionsBtn_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.debugBtn});
            this.toolStripMenuItem1.Font = new System.Drawing.Font("Trigram", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.toolStripMenuItem1.ForeColor = System.Drawing.SystemColors.Window;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(146, 22);
            this.toolStripMenuItem1.Text = "настройки";
            // 
            // debugBtn
            // 
            this.debugBtn.BackColor = System.Drawing.SystemColors.MenuText;
            this.debugBtn.ForeColor = System.Drawing.Color.White;
            this.debugBtn.Name = "debugBtn";
            this.debugBtn.Size = new System.Drawing.Size(205, 22);
            this.debugBtn.Text = "доп. кадры";
            this.debugBtn.Click += new System.EventHandler(this.debugBtn_Click);
            // 
            // picture_in
            // 
            this.picture_in.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picture_in.BackColor = System.Drawing.Color.Transparent;
            this.picture_in.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            this.picture_in.BorderColorFirst = System.Drawing.Color.Navy;
            this.picture_in.BorderColorSecond = System.Drawing.Color.Indigo;
            this.picture_in.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.picture_in.BorderSize = 4;
            this.picture_in.DrawBorder = true;
            this.picture_in.DrawBorderInside = false;
            this.picture_in.DrawCircle = false;
            this.picture_in.GradientDirection = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.picture_in.Image = ((System.Drawing.Image)(resources.GetObject("picture_in.Image")));
            this.picture_in.InitialImage = null;
            this.picture_in.Location = new System.Drawing.Point(3, 3);
            this.picture_in.Name = "picture_in";
            this.picture_in.Size = new System.Drawing.Size(492, 273);
            this.picture_in.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picture_in.TabIndex = 7;
            this.picture_in.TabStop = false;
            this.picture_in.UseGradient = true;
            this.picture_in.Click += new System.EventHandler(this.picture_in_Click);
            // 
            // picture_out
            // 
            this.picture_out.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picture_out.BackColor = System.Drawing.Color.Transparent;
            this.picture_out.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Round;
            this.picture_out.BorderColorFirst = System.Drawing.Color.Navy;
            this.picture_out.BorderColorSecond = System.Drawing.Color.Indigo;
            this.picture_out.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.picture_out.BorderSize = 4;
            this.picture_out.DrawBorder = true;
            this.picture_out.DrawBorderInside = false;
            this.picture_out.DrawCircle = false;
            this.picture_out.GradientDirection = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.picture_out.Image = ((System.Drawing.Image)(resources.GetObject("picture_out.Image")));
            this.picture_out.InitialImage = null;
            this.picture_out.Location = new System.Drawing.Point(3, 282);
            this.picture_out.Name = "picture_out";
            this.picture_out.Size = new System.Drawing.Size(492, 273);
            this.picture_out.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picture_out.TabIndex = 8;
            this.picture_out.TabStop = false;
            this.picture_out.UseGradient = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.picture_out, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.picture_in, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 26);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(498, 558);
            this.tableLayoutPanel1.TabIndex = 9;
            // 
            // codeeloGradientPanel1
            // 
            this.codeeloGradientPanel1.AccessibleRole = null;
            this.codeeloGradientPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.codeeloGradientPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.codeeloGradientPanel1.CausesValidation = false;
            this.codeeloGradientPanel1.ColorFillFirst = System.Drawing.Color.Navy;
            this.codeeloGradientPanel1.ColorFillSecond = System.Drawing.Color.Indigo;
            this.codeeloGradientPanel1.DrawGradient = true;
            this.codeeloGradientPanel1.GradientDirection = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.codeeloGradientPanel1.Location = new System.Drawing.Point(346, 48);
            this.codeeloGradientPanel1.MaximumSize = new System.Drawing.Size(999, 999);
            this.codeeloGradientPanel1.Name = "codeeloGradientPanel1";
            this.codeeloGradientPanel1.Size = new System.Drawing.Size(152, 536);
            this.codeeloGradientPanel1.TabIndex = 6;
            // 
            // closeBtn
            // 
            this.closeBtn.BackColor = System.Drawing.SystemColors.WindowText;
            this.closeBtn.ForeColor = System.Drawing.SystemColors.Window;
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(308, 22);
            this.closeBtn.Text = "закрыть";
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // VideoCaptureForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuText;
            this.ClientSize = new System.Drawing.Size(498, 584);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.codeeloGradientPanel1);
            this.Controls.Add(this.menu);
            this.MinimumSize = new System.Drawing.Size(80, 150);
            this.Name = "VideoCaptureForm";
            this.Text = "VideoCaptureForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormClose);
            this.Load += new System.EventHandler(this.VideoCaptureForm_Load);
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture_in)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_out)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openBtn;
        private System.Windows.Forms.ToolStripMenuItem pauseContinueBtn;
        private CodeeloUI.Controls.CodeeloPictureBox picture_in;
        private CodeeloUI.Controls.CodeeloPictureBox picture_out;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private CodeeloUI.Controls.CodeeloGradientPanel codeeloGradientPanel1;
        private System.Windows.Forms.ToolStripMenuItem debugBtn;
        private System.Windows.Forms.ToolStripMenuItem typesBtn;
        private System.Windows.Forms.ToolStripMenuItem threshSetBtn;
        private System.Windows.Forms.ToolStripMenuItem colorSegmentSetBtn;
        private System.Windows.Forms.ToolStripMenuItem threshOptionsBtn;
        private System.Windows.Forms.ToolStripMenuItem colorOptionsBtn;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ToolStripMenuItem closeBtn;
    }
}

