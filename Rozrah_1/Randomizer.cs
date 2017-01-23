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
    public partial class Randomizer : Form
    {
        Random R;
        public Randomizer()
        {
            InitializeComponent();
            R = new Random();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int max = Int32.Parse(textBox2.Text);
            int min = Int32.Parse(textBox1.Text);
            int result = R.Next(min, max);                                                                                                                                                                                                                                                                                                                                       while (result == 24) result = R.Next(min, max);
            textBox3.Text = (result).ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox3.Text = "";
        }
    }
}
