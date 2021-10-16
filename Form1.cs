using System;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.Threading;
using System.Windows.Forms;

namespace Fractals
{
    public partial class Form1 : Form
    {
        static Random rnd = new Random();
        static int bw = 200;
        static int bh = 100;
        static double moveX = 0, moveY = 0;
        static int maxIterations = 300;
        static double startCRe = -0.75136;
        static double startCIm = 0.30022;
        static double step = 1000;
        static double zoom = 1;
        static double cRe = -36352;
        static double cIm = 62248;

        static int colorize = 9;

        static int a = 255, r = 1, g = 1, b = 0, rcon = 100, gcon = 100, bcon = 100;

        static int repeats = 5;

        static int type = 0;

        static Bitmap bmp = new Bitmap(bw, bh);

        private int ConvertBoolToInt(bool input)
        {
            if (input == true)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }

        private void numericUpDownZoom_ValueChanged(object sender, EventArgs e)
        {
            zoom = (double)numericUpDownZoom.Value;
        }

        private bool ConvertIntToBool(int input)
        {
            if (input == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void buttonGenerate_Click(object sender, EventArgs e)
        {
            if (radioButtonRandom.Checked == true)
            {
                numericUpDownCRe.Value = rnd.Next(-100000, 100001);
                numericUpDownCIm.Value = rnd.Next(-100000, 100001);
                cRe = ((double)numericUpDownCRe.Value) / 100000;
                cIm = ((double)numericUpDownCIm.Value) / 100000;
            }
            else if (radioButtonByCReIm.Checked == true)
            {
                cRe = ((double)numericUpDownCRe.Value) / 100000;
                cIm = ((double)numericUpDownCIm.Value) / 100000;
            }
            if (radioButtonRandomColors.Checked == true)
            {
                colorize = rnd.Next(9, 91);
                trackBarC.Value = colorize;
                labelC.Text = "Colorize : " + trackBarC.Value.ToString();
                a = rnd.Next(100, 256);
                trackBarA.Value = a;
                labelA.Text = "Alpha : " + trackBarA.Value.ToString();
                r = rnd.Next(0, 2);
                checkBoxR.Checked = ConvertIntToBool(r);
                g = rnd.Next(0, 2);
                checkBoxG.Checked = ConvertIntToBool(g);
                b = rnd.Next(0, 2);
                checkBoxB.Checked = ConvertIntToBool(b);
                rcon = rnd.Next(50, 101);
                numericUpDownRCon.Value = rcon;
                gcon = rnd.Next(50, 101);
                numericUpDownGCon.Value = gcon;
                bcon = rnd.Next(50, 101);
                numericUpDownBCon.Value = bcon;
            }
            else if (radioButtonUnRandomColors.Checked == true)
            {
                colorize = trackBarC.Value;
                a = trackBarA.Value;
                r = ConvertBoolToInt(checkBoxR.Checked);
                g = ConvertBoolToInt(checkBoxG.Checked);
                b = ConvertBoolToInt(checkBoxB.Checked);
                rcon = (int)numericUpDownRCon.Value;
                gcon = (int)numericUpDownGCon.Value;
                bcon = (int)numericUpDownBCon.Value;
            }
            bw = 200;
            bh = 100;
            bmp = new Bitmap(bw, bh);
            DrawFractal(bw, bh, cRe, cIm, zoom);
            if (pictureBox1.Image != null)
                pictureBox1.Image.Dispose();
            pictureBox1.Image = bmp.Clone(new Rectangle(0, 0, bmp.Width, bmp.Height), PixelFormat.DontCare);
            buttonRender.Enabled = true;
            bmp.Dispose();
        }

        private void trackBarC_Scroll(object sender, EventArgs e)
        {
            labelC.Text = "Colorize : " + trackBarC.Value.ToString();
        }

        private void trackBarA_Scroll(object sender, EventArgs e)
        {
            labelA.Text = "Alpha : " + trackBarA.Value.ToString();
        }

        private void buttonRender_Click(object sender, EventArgs e)
        {
            cRe = ((double)numericUpDownCRe.Value) / 100000;
            cIm = ((double)numericUpDownCIm.Value) / 100000;
            colorize = trackBarC.Value;
            a = trackBarA.Value;
            r = ConvertBoolToInt(checkBoxR.Checked);
            g = ConvertBoolToInt(checkBoxG.Checked);
            b = ConvertBoolToInt(checkBoxB.Checked);
            rcon = (int)numericUpDownRCon.Value;
            gcon = (int)numericUpDownGCon.Value;
            bcon = (int)numericUpDownBCon.Value;
            bw = (int)numericUpDownWidth.Value;
            bh = (int)numericUpDownHeight.Value;
            bmp = new Bitmap(bw, bh);
            DrawFractal(bw, bh, cRe, cIm, zoom);
            bmp.Save($"{DateTime.Now.Hour}-{DateTime.Now.Minute}-{DateTime.Now.Second} ({cRe} {cIm} x{zoom}).png", ImageFormat.Png);
            bmp.Dispose();
            MessageBox.Show("Successful Rendered");
            //if (type == 0)
            //{
            //    double cRe = ((double)rnd.Next(-100000, 100001)) / 100000;
            //    double cIm = ((double)rnd.Next(-100000, 100001)) / 100000;
            //    DrawFractal(bw, bh, cRe, cIm, zoom);
            //    bmp.Save($@"C:\Users\XMyRby\Pictures\Fractals\{DateTime.Now.Hour}-{DateTime.Now.Minute}-{DateTime.Now.Second} ({cRe} {cIm} x{zoom}).png", ImageFormat.Png);
            //}
            //else if (type == 1)
            //{
            //    DrawFractal(bw, bh, startCRe, startCIm, zoom);
            //    bmp.Save($@"C:\Users\XMyRby\Pictures\Fractals\{DateTime.Now.Hour}-{DateTime.Now.Minute}-{DateTime.Now.Second} ({startCRe} {startCIm} x{zoom}).png", ImageFormat.Png);
            //}
            //else if (type == 2)
            //{
            //    for (int i = 0; i < repeats; i++)
            //    {
            //        double sub = ((double)(i + 1)) / 100000 * step;
            //        DrawFractal(bw, bh, startCRe - sub, startCIm - sub, zoom);
            //        bmp.Save($@"C:\Users\XMyRby\Pictures\Fractals\{DateTime.Now.Hour}-{DateTime.Now.Minute}-{DateTime.Now.Second} ({startCRe - sub} {startCIm - sub} x{zoom}).png", ImageFormat.Png);
            //    }
            //}
            //else if (type == 3)
            //{
            //    for (int i = 0; i < repeats; i++)
            //    {
            //        zoom += i;
            //        DrawFractal(bw, bh, startCRe, startCIm, zoom);
            //        bmp.Save($@"C:\Users\XMyRby\Pictures\Fractals\{DateTime.Now.Hour}-{DateTime.Now.Minute}-{DateTime.Now.Second} ({startCRe} {startCIm} x{zoom}).png", ImageFormat.Png);
            //    }
            //}
            //else if (type == 4)
            //{
            //    for (int i = 0; i < repeats; i++)
            //    {
            //        double cRe = ((double)rnd.Next(-100000, 100001)) / 100000;
            //        double cIm = ((double)rnd.Next(-100000, 100001)) / 100000;
            //        DrawFractal(bw, bh, cRe, cIm, zoom);
            //        bmp.Save($@"C:\Users\XMyRby\Pictures\Fractals\{DateTime.Now.Hour}-{DateTime.Now.Minute}-{DateTime.Now.Second} ({cRe} {cIm} x{zoom}).png", ImageFormat.Png);
            //    }
            //}
        }
        public Form1()
        {
            InitializeComponent();
        }
        public void DrawFractal(int w, int h, double cRe, double cIm, double zoom)
        {
            double newRe, newIm, oldRe, oldIm;

            for (int x = 0; x < w; x++)
            {
                for (int y = 0; y < h; y++)
                {
                    newRe = 1.5 * (x - w / 2) / (0.5 * zoom * w) + moveX;
                    newIm = (y - h / 2) / (0.5 * zoom * h) + moveY;
                    int i;
                    for (i = 0; i < maxIterations; i++)
                    {
                        oldRe = newRe;
                        oldIm = newIm;
                        newRe = oldRe * oldRe - oldIm * oldIm + cRe;
                        newIm = 2 * oldRe * oldIm + cIm;
                        if ((newRe * newRe + newIm * newIm) > 4) break;
                    }
                    bmp.SetPixel(x, y, Color.FromArgb(a, (int)((double)(r * (colorize * i) % 255) / (100 / (double)rcon)), (int)((double)(g * (colorize * i) % 255) / (100 / (double)gcon)), (int)((double)(b * (colorize * i) % 255) / (100 / (double)bcon))));
                }
            }
        }
    }
}
