using ImageProcess2;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DIPActivity
{
    internal class BasicDIP
    {
        private PictureBox pictureBox1, pictureBox2;

        public BasicDIP(PictureBox picbox1, PictureBox picbox2)
        {
            pictureBox1 = picbox1;
            pictureBox2 = picbox2;
        }

        private bool IsLoaded(Bitmap loaded)
        {
            if (loaded == null)
            {
                MessageBox.Show("No image loaded. Please ensure that your camera is capturing correctly.");
                return false;
            }

            return true;
        }

        public void BasicCopy(ref Bitmap loaded, ref Bitmap processed)
        {
            if (!IsLoaded(loaded)) return;

            processed = new Bitmap(loaded.Width, loaded.Height);
            Color pixel;

            for (int x = 0; x < loaded.Width; x++)
            {
                for (int y = 0; y < loaded.Height; y++)
                {
                    pixel = loaded.GetPixel(x, y);
                    processed.SetPixel(x, y, pixel);
                    processed.SetPixel(x, y, loaded.GetPixel(x, y));
                }
            }

            pictureBox2.Image = processed;
        }

        public void GreyScale(ref Bitmap loaded, ref Bitmap processed)
        {
            if (!IsLoaded(loaded)) return;

            processed = new Bitmap(loaded.Width, loaded.Height);
            Color pixel;
            int avg;

            for (int x = 0; x < loaded.Width; x++)
            {
                for (int y = 0; y < loaded.Height; y++)
                {
                    pixel = loaded.GetPixel(x, y);
                    avg = (int)(pixel.R + pixel.G + pixel.B) / 3;
                    Color grey = Color.FromArgb(avg, avg, avg);
                    processed.SetPixel(x, y, grey);
                }
            }

            pictureBox2.Image = processed;
        }

        public void ColorInversion(ref Bitmap loaded, ref Bitmap processed)
        {
            if (!IsLoaded(loaded)) return;

            processed = new Bitmap(loaded.Width, loaded.Height);
            Color pixel; ;

            for (int x = 0; x < loaded.Width; x++)
            {
                for (int y = 0; y < loaded.Height; y++)
                {
                    pixel = loaded.GetPixel(x, y);
                    Color inverted = Color.FromArgb(255 - pixel.R, 255 - pixel.G, 255 - pixel.B);
                    processed.SetPixel(x, y, inverted);
                }
            }

            pictureBox2.Image = processed;
        }

        public void Histogram(ref Bitmap a, ref Bitmap b)
        {
            if (!IsLoaded(a)) return;

            Color sample;
            Color grey;
            Byte greydata;

            for (int x = 0; x < a.Width; x++)
            {
                for (int y = 0; y < a.Height; y++)
                {
                    sample = a.GetPixel(x, y);
                    greydata = (byte)((sample.R + sample.G + sample.B) / 3);
                    grey = Color.FromArgb(greydata, greydata, greydata);
                    b.SetPixel(x, y, grey);
                }
            }

            int[] histdata = new int[256];
            for (int x = 0; x < a.Width; x++)
            {
                for (int y = 0; y < a.Height; y++)
                {
                    sample = a.GetPixel(x, y);
                    histdata[sample.R]++;
                }
            }

            b = new Bitmap(256, 800);

            for (int x = 0; x < 256; x++)
            {
                for (int y = 0; y < 800; y++)
                {
                    b.SetPixel(x, y, Color.White);
                }
            }

            for (int x = 0; x < 256; x++)
            {
                for (int y = 0; y < Math.Min(histdata[x] / 5, b.Height - 1); y++)
                {
                    b.SetPixel(x, (b.Height - 1) - y, Color.Black);
                }
            }

            pictureBox2.Image = b;
        }

        public void Sepia(ref Bitmap loaded, ref Bitmap processed)
        {
            if (!IsLoaded(loaded)) return;

            processed = new Bitmap(loaded.Width, loaded.Height);

            for (int x = 0; x < loaded.Width; x++)
            {
                for (int y = 0; y < loaded.Height; y++)
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

        public void Smoothing(ref Bitmap loaded, ref Bitmap processed, int weight)
        {
            if (!IsLoaded(loaded)) return;

            processed = new Bitmap(loaded);
            bool success = BitmapFilter.Smooth(processed, weight);

            if (success)
            {
                pictureBox2.Image = processed;
            }
        }

        public void GaussianBlur(ref Bitmap loaded, ref Bitmap processed, int weight)
        {
            if(!IsLoaded(loaded)) return;

            processed = new Bitmap(loaded);
            bool success = BitmapFilter.GaussianBlur(processed, weight);

            if (success)
            {
                pictureBox2.Image = processed;
            }
        }

        public void MeanRemoval(ref Bitmap loaded, ref Bitmap processed, int weight)
        {
            if (!IsLoaded(loaded)) return;

            processed = new Bitmap(loaded);
            bool success = BitmapFilter.MeanRemoval(processed, weight);

            if (success)
            {
                pictureBox2.Image = processed;
            }
        }

        public void Sharpen(ref Bitmap loaded, ref Bitmap processed, int weight)
        {
            if (!IsLoaded(loaded)) return;

            processed = new Bitmap(loaded);
            bool success = BitmapFilter.Sharpen(processed, weight);

            if (success)
            {
                pictureBox2.Image = processed;
            }
        }

        public void EmbossLaplacian(ref Bitmap loaded, ref Bitmap processed)
        {
            if (!IsLoaded(loaded)) return;

            processed = new Bitmap(loaded);
            bool success = BitmapFilter.EmbossLaplacian(processed);

            if (success)
            {
                pictureBox2.Image = processed;
            }
        }

        public enum EMBOSS { HORIZONTAL_VERTICAL, ALL_DIRECTIONS, LOSSY, HORIZONTAL_ONLY, VERTICAL_ONLY };
        
        public bool Emboss(Bitmap b, EMBOSS nType)
        {
            ConvMatrix m = new ConvMatrix();

            switch (nType)
            {
                case EMBOSS.HORIZONTAL_VERTICAL:
                    m.SetAll(0);
                    m.TopMid = m.MidLeft = m.MidRight = m.BottomMid = -1;
                    m.Pixel = 4;
                    m.Offset = 127;
                    break;
                case EMBOSS.ALL_DIRECTIONS:
                    m.SetAll(-1);
                    m.Pixel = 8;
                    m.Offset = 127;
                    break;
                case EMBOSS.LOSSY:
                    m.SetAll(-2);
                    m.TopLeft = m.TopRight = m.BottomMid = 1;
                    m.Pixel = 4;
                    m.Offset = 127;
                    break;
                case EMBOSS.HORIZONTAL_ONLY:
                    m.SetAll(0);
                    m.MidLeft = m.MidRight = -1;
                    m.Pixel = 2;
                    m.Offset = 127;
                    break;
                case EMBOSS.VERTICAL_ONLY:
                    m.SetAll(0);
                    m.TopMid = -1;
                    m.BottomMid = 1;
                    m.Offset = 127;
                    break;
            }

            return BitmapFilter.Conv3x3(b, m);
        }
    }
}
