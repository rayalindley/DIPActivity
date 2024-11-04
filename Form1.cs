using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageProcessingLecture1
{
    public partial class Form1 : Form
    {
        Bitmap loaded, processed;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            featurelabel.Text = "DIGITAL IMAGER PROCESSING";
            featurelabel.Size = new Size(100, 50);
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        private void pixelCopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            featurelabel.Text = "BASIC COPY";
            processed = new Bitmap(loaded.Width, loaded.Height);
            Color pixel;

            for(int x=0;x<loaded.Width; x++)
            {
                for(int y=0;y<loaded.Height; y++)
                {
                    pixel = loaded.GetPixel(x,y);
                    processed.SetPixel(x,y,pixel);
                }
            }

            pictureBox2.Image = processed;
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            processed.Save(saveFileDialog1.FileName);
        }

        private void greyscalingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            featurelabel.Text = "GREYSCALE";
            processed = new Bitmap(loaded.Width, loaded.Height);
            Color pixel;
            int avg;

            for(int x=0; x<loaded.Width; x++)
            {
                for(int y=0; y<loaded.Height; y++)
                {
                    pixel = loaded.GetPixel(x,y);
                    avg = (int)(pixel.R+pixel.G+pixel.B)/3;
                    Color grey = Color.FromArgb(avg, avg, avg);
                    processed.SetPixel(x,y,grey);
                }
            }

            pictureBox2.Image = processed;
        }

        private void histogramToolStripMenuItem_Click(object sender, EventArgs e)
        {
            featurelabel.Text = "HISTOGRAM";
            BasicDIP.Histogram(ref loaded, ref processed);
            pictureBox2.Image = processed;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void inversionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            featurelabel.Text = "COLOR INVERSION";

            processed = new Bitmap(loaded.Width, loaded.Height);
            Color pixel;;

            for (int x = 0; x < loaded.Width; x++)
            {
                for (int y = 0; y < loaded.Height; y++)
                {
                    pixel = loaded.GetPixel(x, y);
                    Color inverted = Color.FromArgb(255-pixel.R, 255-pixel.G, 255-pixel.B);
                    processed.SetPixel(x, y, inverted);
                }
            }

            pictureBox2.Image = processed;
        }

        private void sepiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            featurelabel.Text = "SEPIA";
            processed = new Bitmap(loaded.Width, loaded.Height);

            for (int x=0; x<loaded.Width; x++)
            {
                for (int y=0; y<loaded.Height; y++)
                {
                    Color pixel = loaded.GetPixel(x, y);

                    int sepiaR = Math.Min(255, (int)(0.393 * pixel.R + 0.769 * pixel.G + 0.189 * pixel.B));
                    int sepiaG = Math.Min(255, (int)(0.349 * pixel.R + 0.686 * pixel.G + 0.168 * pixel.B));
                    int sepiaB = Math.Min(255, (int)(0.272 * pixel.R + 0.534 * pixel.G + 0.131 * pixel.B));

                    processed.SetPixel(x, y, Color.FromArgb(sepiaR, sepiaG, sepiaB));
                }
            }

            pictureBox2.Image = processed;
        }

        private void subtractToolStripMenuItem_Click(object sender, EventArgs e)
        {
            subtractForm subtractForm = new subtractForm();
            subtractForm.ShowDialog();
            
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            loaded = new Bitmap(openFileDialog1.FileName);
            pictureBox1.Image = loaded;
        }
    }
}
