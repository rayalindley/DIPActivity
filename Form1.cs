using DIPActivity;
using ImageProcess2;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WebCamLib;

namespace ImageProcessingLecture1
{
    public partial class Form1 : Form
    {
        Bitmap loaded, processed;
        Device[] devices;
        BasicDIP basicDIP;

        public Form1()
        {
            InitializeComponent();
            basicDIP = new BasicDIP(pictureBox1, pictureBox2);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            featurelabel.Text = "DIGITAL IMAGER PROCESSING";
            featurelabel.Size = new Size(100, 50);

            devices = DeviceManager.GetAllDevices();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled)
            {
                devices[0].Stop();
                timer1.Enabled = false;
            }

            openFileDialog1.ShowDialog();
        }

        private void pixelCopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            featurelabel.Text = "BASIC COPY";
            basicDIP.BasicCopy(ref loaded, ref processed);
        }

        private void greyscalingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            featurelabel.Text = "GREYSCALE";
            basicDIP.GreyScale(ref loaded, ref processed);
        }

        private void inversionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            featurelabel.Text = "COLOR INVERSION";
            basicDIP.ColorInversion(ref loaded, ref processed);
        }

        private void histogramToolStripMenuItem_Click(object sender, EventArgs e)
        {
            featurelabel.Text = "HISTOGRAM";
            basicDIP.Histogram(ref loaded, ref processed);
        }

        private void sepiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            featurelabel.Text = "SEPIA";
            basicDIP.Sepia(ref loaded, ref processed);
        }

        private void subtractToolStripMenuItem_Click(object sender, EventArgs e)
        {
            subtractForm subtractForm = new subtractForm();
            subtractForm.ShowDialog();

        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            processed.Save(saveFileDialog1.FileName);
        }

        

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void takeAPhotoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void turnOnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.FileName != "")
            {
                openFileDialog1.FileName = "";
                pictureBox1.Image = null;
            }

            devices[0].ShowWindow(pictureBox1);
            timer1.Enabled = true;
        }

        private void turnOffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            devices[0].Stop();
            timer1.Enabled=false;
        }

        private void openCameraToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void turnOnToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.FileName != "")
            {
                openFileDialog1.FileName = "";
                pictureBox1.Image = null;
                pictureBox2.Image = null;
            }

            featurelabel.Text = "DIGITAL IMAGER PROCESSING";
            devices[0].ShowWindow(pictureBox1);
            timer1.Enabled = true;
        }

        private void turnOffToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            devices[0].Stop();
            timer1.Enabled = false;
            featurelabel.Text = "DIGITAL IMAGER PROCESSING";
        }

        private void videoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void greyscaleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            IDataObject data;
            Image bmap;

            devices[0].Sendmessage();
            data = Clipboard.GetDataObject();

            bmap = (Image)(data.GetData("System.Drawing.Bitmap", true));

            if (bmap != null)
            {
                Bitmap b = new Bitmap(bmap);
                loaded = b;
            }
        }

        private void deleteImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(pictureBox1.Image!=null || pictureBox2.Image!=null)
            {
                pictureBox1.Image = null;
                pictureBox2.Image = null;
            }
        }

        private void smoothingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            featurelabel.Text = "SMOOTHING";
            basicDIP.Smoothing(ref loaded, ref processed, 9);
        }

        private void gaussianBlurToolStripMenuItem_Click(object sender, EventArgs e)
        {
            featurelabel.Text = "GAUSSIAN BLUR";
            basicDIP.GaussianBlur(ref loaded, ref processed, 18);
        }

        private void meanRemovalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            featurelabel.Text = "MEAN REMOVAL";
            basicDIP.MeanRemoval(ref loaded, ref processed, 8);
        }

        private void sharpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            featurelabel.Text = "SHARPEN";
            basicDIP.Sharpen(ref loaded, ref processed, 5);
        }

        private void embossToolStripMenuItem_Click(object sender, EventArgs e)
        {
            featurelabel.Text = "EMBOSS LAPLACIAN";
            basicDIP.EmbossLaplacian(ref loaded, ref processed);
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            loaded = new Bitmap(openFileDialog1.FileName);
            pictureBox1.Image = loaded;
        }
    }
}
