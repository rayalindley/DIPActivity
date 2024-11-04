using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageProcessingLecture1
{
    static class BasicDIP
    {
        public static void Histogram(ref Bitmap a, ref Bitmap b)
        {
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

            for(int x=0; x<256; x++)
            {
                for(int y=0; y<800; y++)
                {
                    b.SetPixel(x, y, Color.White);
                }
            }

            for(int x = 0; x<256; x++)
            {
                for(int y=0; y < Math.Min(histdata[x]/5, b.Height-1); y++)
                {
                    b.SetPixel(x, (b.Height-1)-y, Color.Black);
                }
            }
        }
    }
}
