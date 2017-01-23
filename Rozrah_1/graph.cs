using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Rozrah_1
{
    public partial class graph : Form
    {
        int w = 800, h = 500;
        double[,] A;
        double[] b_num;
        double l = 3, r = 5;//, t = 250, bt = -250;
        public graph()
        {
            InitializeComponent();
        }
        public graph(double[,] inA, double[] inb)
        {
            InitializeComponent();
            A = inA;
            b_num = inb;
            button1_Click(null, null);
        }
        public graph(string f)
        {
            InitializeComponent();
            button1_Click(null, null);
        }
        public double calc(double[,] matr, double[] rezu, int row, double arg)//A, b, row
        {
            double result = 0;
            for (int i = 0; i < matr.GetLength(1); i++)
                result += matr[row, i] * Math.Pow(arg, matr.GetLength(1) - i);
            result -= rezu[row];
            return result;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                //-------------LEFT
                if (!Double.TryParse(textBox2.Text, out l))
                {
                    MessageBox.Show("Error converting left value.");
                    return;
                }
                //-------------REIGT
                if (!Double.TryParse(textBox3.Text, out r))
                {
                    MessageBox.Show("Error converting right value.");
                    return;
                }

                Bitmap b = new Bitmap(w, h);

                //base
                for (int i = 0; i < w; i++)
                    b.SetPixel(i, h/2, Color.Blue);
                for (int i = 0; i < h; i++)
                    b.SetPixel(w/2, i, Color.Blue);


                double last = 0;
                for (int i = 1; i < w-1; i++)
                {
                    double u = i * ((r - l) / (double)w) + l;
                    //MessageBox.Show(u.ToString());
                    if ((int)u != (int)last)
                        for (int j = 0; j < h; j++)
                            b.SetPixel(i, j, Color.Gray);
                    double iResult;
                    double sum = 0;
                    for (int row = 0; row < A.GetLength(0); row++)
                    {
                        iResult = calc(A, b_num, row, u);
                        sum += iResult;
                        double dotY = h - iResult - (h / 2);
                        if (dotY > 1 && dotY < h)
                            b.SetPixel(i, (int)dotY, Color.Green);
                    }
                    {
                        double dotY = h - sum - (h / 2);
                        if (dotY > 1 && dotY < h)
                            b.SetPixel(i, (int)dotY, Color.Red);
                    }
                    last = u;
                }

                b.SetPixel(0, 0, Color.Black);
                pictureBox1.Image = b;

            }
            catch (ArgumentException)
            {
                MessageBox.Show("Error in input data.");
            }
            catch (Exception)
            {
                MessageBox.Show("Unexpected exception.");
                throw;
            }
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            double u = e.X * ((r - l) / (double)w) + l;
            label1.Text=u.ToString();
        }

        private void pictureBox1_Resize(object sender, EventArgs e)
        {
            w = ((PictureBox)(sender)).Width;
            h = ((PictureBox)(sender)).Height;
        }
        
    }
}
