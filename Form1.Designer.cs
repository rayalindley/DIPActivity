namespace ImageProcessingLecture1
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openCameraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.turnOnToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.turnOffToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dIPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pixelCopyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.greyscalingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inversionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.histogramToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sepiaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.subtractToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.convolutionMatrixToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.smoothingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gaussianBlurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.meanRemovalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sharpenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.featurelabel = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.embossToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.allDirectionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lossyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.horizontalVerticalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.horizaontalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verticalToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.dIPToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(781, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openCameraToolStripMenuItem,
            this.openToolStripMenuItem,
            this.deleteImageToolStripMenuItem,
            this.saveToolStripMenuItem});
            this.fileToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(47, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openCameraToolStripMenuItem
            // 
            this.openCameraToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            this.openCameraToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.turnOnToolStripMenuItem1,
            this.turnOffToolStripMenuItem1});
            this.openCameraToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.openCameraToolStripMenuItem.Name = "openCameraToolStripMenuItem";
            this.openCameraToolStripMenuItem.Size = new System.Drawing.Size(211, 26);
            this.openCameraToolStripMenuItem.Text = "Camera";
            this.openCameraToolStripMenuItem.Click += new System.EventHandler(this.openCameraToolStripMenuItem_Click);
            // 
            // turnOnToolStripMenuItem1
            // 
            this.turnOnToolStripMenuItem1.Name = "turnOnToolStripMenuItem1";
            this.turnOnToolStripMenuItem1.Size = new System.Drawing.Size(151, 26);
            this.turnOnToolStripMenuItem1.Text = "Turn On";
            this.turnOnToolStripMenuItem1.Click += new System.EventHandler(this.turnOnToolStripMenuItem1_Click);
            // 
            // turnOffToolStripMenuItem1
            // 
            this.turnOffToolStripMenuItem1.Name = "turnOffToolStripMenuItem1";
            this.turnOffToolStripMenuItem1.Size = new System.Drawing.Size(151, 26);
            this.turnOffToolStripMenuItem1.Text = "Turn Off";
            this.turnOffToolStripMenuItem1.Click += new System.EventHandler(this.turnOffToolStripMenuItem1_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            this.openToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(211, 26);
            this.openToolStripMenuItem.Text = "Upload an Image";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // deleteImageToolStripMenuItem
            // 
            this.deleteImageToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            this.deleteImageToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.deleteImageToolStripMenuItem.Name = "deleteImageToolStripMenuItem";
            this.deleteImageToolStripMenuItem.Size = new System.Drawing.Size(211, 26);
            this.deleteImageToolStripMenuItem.Text = "Delete Image";
            this.deleteImageToolStripMenuItem.Click += new System.EventHandler(this.deleteImageToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            this.saveToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(211, 26);
            this.saveToolStripMenuItem.Text = "Save Image";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // dIPToolStripMenuItem
            // 
            this.dIPToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pixelCopyToolStripMenuItem,
            this.greyscalingToolStripMenuItem,
            this.inversionToolStripMenuItem,
            this.histogramToolStripMenuItem,
            this.sepiaToolStripMenuItem,
            this.subtractToolStripMenuItem,
            this.convolutionMatrixToolStripMenuItem});
            this.dIPToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dIPToolStripMenuItem.Name = "dIPToolStripMenuItem";
            this.dIPToolStripMenuItem.Size = new System.Drawing.Size(48, 24);
            this.dIPToolStripMenuItem.Text = "DIP";
            // 
            // pixelCopyToolStripMenuItem
            // 
            this.pixelCopyToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            this.pixelCopyToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.pixelCopyToolStripMenuItem.Name = "pixelCopyToolStripMenuItem";
            this.pixelCopyToolStripMenuItem.Size = new System.Drawing.Size(227, 26);
            this.pixelCopyToolStripMenuItem.Text = "Basic Copy";
            this.pixelCopyToolStripMenuItem.Click += new System.EventHandler(this.pixelCopyToolStripMenuItem_Click);
            // 
            // greyscalingToolStripMenuItem
            // 
            this.greyscalingToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            this.greyscalingToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.greyscalingToolStripMenuItem.Name = "greyscalingToolStripMenuItem";
            this.greyscalingToolStripMenuItem.Size = new System.Drawing.Size(227, 26);
            this.greyscalingToolStripMenuItem.Text = "Greyscale";
            this.greyscalingToolStripMenuItem.Click += new System.EventHandler(this.greyscalingToolStripMenuItem_Click);
            // 
            // inversionToolStripMenuItem
            // 
            this.inversionToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            this.inversionToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.inversionToolStripMenuItem.Name = "inversionToolStripMenuItem";
            this.inversionToolStripMenuItem.Size = new System.Drawing.Size(227, 26);
            this.inversionToolStripMenuItem.Text = "Color Inversion";
            this.inversionToolStripMenuItem.Click += new System.EventHandler(this.inversionToolStripMenuItem_Click);
            // 
            // histogramToolStripMenuItem
            // 
            this.histogramToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            this.histogramToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.histogramToolStripMenuItem.Name = "histogramToolStripMenuItem";
            this.histogramToolStripMenuItem.Size = new System.Drawing.Size(227, 26);
            this.histogramToolStripMenuItem.Text = "Histogram";
            this.histogramToolStripMenuItem.Click += new System.EventHandler(this.histogramToolStripMenuItem_Click);
            // 
            // sepiaToolStripMenuItem
            // 
            this.sepiaToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            this.sepiaToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.sepiaToolStripMenuItem.Name = "sepiaToolStripMenuItem";
            this.sepiaToolStripMenuItem.Size = new System.Drawing.Size(227, 26);
            this.sepiaToolStripMenuItem.Text = "Sepia";
            this.sepiaToolStripMenuItem.Click += new System.EventHandler(this.sepiaToolStripMenuItem_Click);
            // 
            // subtractToolStripMenuItem
            // 
            this.subtractToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            this.subtractToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.subtractToolStripMenuItem.Name = "subtractToolStripMenuItem";
            this.subtractToolStripMenuItem.Size = new System.Drawing.Size(227, 26);
            this.subtractToolStripMenuItem.Text = "Subtract";
            this.subtractToolStripMenuItem.Click += new System.EventHandler(this.subtractToolStripMenuItem_Click);
            // 
            // convolutionMatrixToolStripMenuItem
            // 
            this.convolutionMatrixToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            this.convolutionMatrixToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.smoothingToolStripMenuItem,
            this.gaussianBlurToolStripMenuItem,
            this.meanRemovalToolStripMenuItem,
            this.sharpenToolStripMenuItem,
            this.embossToolStripMenuItem1});
            this.convolutionMatrixToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.convolutionMatrixToolStripMenuItem.Name = "convolutionMatrixToolStripMenuItem";
            this.convolutionMatrixToolStripMenuItem.Size = new System.Drawing.Size(227, 26);
            this.convolutionMatrixToolStripMenuItem.Text = "Convolution Matrix";
            // 
            // smoothingToolStripMenuItem
            // 
            this.smoothingToolStripMenuItem.Name = "smoothingToolStripMenuItem";
            this.smoothingToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.smoothingToolStripMenuItem.Text = "Smoothing";
            this.smoothingToolStripMenuItem.Click += new System.EventHandler(this.smoothingToolStripMenuItem_Click);
            // 
            // gaussianBlurToolStripMenuItem
            // 
            this.gaussianBlurToolStripMenuItem.Name = "gaussianBlurToolStripMenuItem";
            this.gaussianBlurToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.gaussianBlurToolStripMenuItem.Text = "Gaussian Blur";
            this.gaussianBlurToolStripMenuItem.Click += new System.EventHandler(this.gaussianBlurToolStripMenuItem_Click);
            // 
            // meanRemovalToolStripMenuItem
            // 
            this.meanRemovalToolStripMenuItem.Name = "meanRemovalToolStripMenuItem";
            this.meanRemovalToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.meanRemovalToolStripMenuItem.Text = "Mean Removal";
            this.meanRemovalToolStripMenuItem.Click += new System.EventHandler(this.meanRemovalToolStripMenuItem_Click);
            // 
            // sharpenToolStripMenuItem
            // 
            this.sharpenToolStripMenuItem.Name = "sharpenToolStripMenuItem";
            this.sharpenToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.sharpenToolStripMenuItem.Text = "Sharpen";
            this.sharpenToolStripMenuItem.Click += new System.EventHandler(this.sharpenToolStripMenuItem_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog1_FileOk);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(31, 80);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(349, 350);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(405, 80);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(349, 350);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // featurelabel
            // 
            this.featurelabel.AutoSize = true;
            this.featurelabel.Font = new System.Drawing.Font("Impact", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.featurelabel.Location = new System.Drawing.Point(27, 43);
            this.featurelabel.Name = "featurelabel";
            this.featurelabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.featurelabel.Size = new System.Drawing.Size(0, 21);
            this.featurelabel.TabIndex = 3;
            this.featurelabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.featurelabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 50;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // embossToolStripMenuItem1
            // 
            this.embossToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.allDirectionsToolStripMenuItem,
            this.lossyToolStripMenuItem,
            this.horizontalVerticalToolStripMenuItem,
            this.horizaontalToolStripMenuItem,
            this.verticalToolStripMenuItem1});
            this.embossToolStripMenuItem1.Name = "embossToolStripMenuItem1";
            this.embossToolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            this.embossToolStripMenuItem1.Text = "Emboss";
            // 
            // allDirectionsToolStripMenuItem
            // 
            this.allDirectionsToolStripMenuItem.Name = "allDirectionsToolStripMenuItem";
            this.allDirectionsToolStripMenuItem.Size = new System.Drawing.Size(225, 26);
            this.allDirectionsToolStripMenuItem.Text = "All Directions";
            this.allDirectionsToolStripMenuItem.Click += new System.EventHandler(this.horizontalVerticaToolStripMenuItem_Click);
            // 
            // lossyToolStripMenuItem
            // 
            this.lossyToolStripMenuItem.Name = "lossyToolStripMenuItem";
            this.lossyToolStripMenuItem.Size = new System.Drawing.Size(225, 26);
            this.lossyToolStripMenuItem.Text = "Lossy";
            this.lossyToolStripMenuItem.Click += new System.EventHandler(this.lossyToolStripMenuItem_Click);
            // 
            // horizontalVerticalToolStripMenuItem
            // 
            this.horizontalVerticalToolStripMenuItem.Name = "horizontalVerticalToolStripMenuItem";
            this.horizontalVerticalToolStripMenuItem.Size = new System.Drawing.Size(225, 26);
            this.horizontalVerticalToolStripMenuItem.Text = "Horizontal & Vertical";
            this.horizontalVerticalToolStripMenuItem.Click += new System.EventHandler(this.horizontalVerticalToolStripMenuItem_Click);
            // 
            // horizaontalToolStripMenuItem
            // 
            this.horizaontalToolStripMenuItem.Name = "horizaontalToolStripMenuItem";
            this.horizaontalToolStripMenuItem.Size = new System.Drawing.Size(225, 26);
            this.horizaontalToolStripMenuItem.Text = "Horizontal";
            this.horizaontalToolStripMenuItem.Click += new System.EventHandler(this.horizaontalToolStripMenuItem_Click);
            // 
            // verticalToolStripMenuItem1
            // 
            this.verticalToolStripMenuItem1.Name = "verticalToolStripMenuItem1";
            this.verticalToolStripMenuItem1.Size = new System.Drawing.Size(225, 26);
            this.verticalToolStripMenuItem1.Text = "Vertical";
            this.verticalToolStripMenuItem1.Click += new System.EventHandler(this.verticalToolStripMenuItem1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(781, 453);
            this.Controls.Add(this.featurelabel);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "DIP Activity";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dIPToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pixelCopyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem greyscalingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inversionToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ToolStripMenuItem histogramToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sepiaToolStripMenuItem;
        private System.Windows.Forms.Label featurelabel;
        private System.Windows.Forms.ToolStripMenuItem subtractToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openCameraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem turnOnToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem turnOffToolStripMenuItem1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripMenuItem deleteImageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem convolutionMatrixToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem smoothingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gaussianBlurToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sharpenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem meanRemovalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem embossToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem allDirectionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lossyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem horizontalVerticalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem horizaontalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verticalToolStripMenuItem1;
    }
}

