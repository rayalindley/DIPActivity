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
    public partial class subtractForm : Form
    {
        Bitmap imageB, imageA, resultImg;

        public subtractForm()
        {
            InitializeComponent();
        }

        private void subtractForm_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            imageB = new Bitmap(openFileDialog1.FileName);
            pictureBox1.Image = imageB;
        }

        private void btnLoadBG_Click(object sender, EventArgs e)
        {
            openFileDialog2.ShowDialog();
        }

        private void openFileDialog2_FileOk(object sender, CancelEventArgs e)
        {
            Bitmap bmp = new Bitmap(openFileDialog2.FileName);
            imageA = new Bitmap(bmp, imageB.Width, imageB.Height);
            pictureBox2.Image = imageA;
        }

        private void btnSubtract_Click(object sender, EventArgs e)
        {
            resultImg = new Bitmap(imageB.Width, imageB.Height);

            Color mygreen = Color.FromArgb(0, 0, 255);
            int greygreen = (mygreen.R + mygreen.G + mygreen.B)/3;
            int threshold = 5;

            for(int x=0; x<imageB.Width; x++)
            {
                for(int y=0; y<imageB.Height; y++)
                {
                    Color pixel = imageB.GetPixel(x, y);
                    Color backpixel = imageA.GetPixel(x, y);

                    int grey = (pixel.R + pixel.G + pixel.B) / 3;
                    int subtractval = Math.Abs(grey - greygreen);

                    if(subtractval > threshold )
                        resultImg.SetPixel(x, y, backpixel);
                    else
                        resultImg.SetPixel(x, y, pixel);
                }
            }

            pictureBox3.Image = resultImg;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }
    }
}
