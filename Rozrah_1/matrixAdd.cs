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
    public partial class matrixAdd : Form
    {
        Form1 form;
        public matrixAdd()
        {
            InitializeComponent();
        }
        public matrixAdd(Form1 f)
        {
            InitializeComponent();
            form = f;
        }

        private void matrixAdd_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //init
            int n = Int32.Parse(textBox1.Text);
            int min = Int32.Parse(textBox2.Text);
            int max = Int32.Parse(textBox3.Text);
            double[,] matrix = new double[n, n];
            System.Random r = new System.Random();
            //generate
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    matrix[i, j] = (int)r.Next(min, max);
                }
            }

            double[] matrixb = new double[n];
            for (int j = 0; j < n; j++)
            {
                matrixb[j] = (int)r.Next(min, max);
            }
            //apply
            form.A = matrix;
            form.b = matrixb;
            form.n = n;
            form.showMatrix(matrix, "A");
            form.showMatrix(matrixb, "b");
            //finish
            Close();

        }
    }
}
