using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KozlovDZ71
{
    public partial class Form1 : Form
    {
        private Form2 _form2;
        public Form1(Form2 form2)
        {
            _form2 = form2;
            InitializeComponent();
            button1.Text = "+1";
            button2.Text = "x2";
            button3.Text = "Сброс";
            label1.Text = "0";
            this.Text = "Удвоитель";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = (int.Parse(label1.Text) + 1).ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = (int.Parse(label1.Text) * 2).ToString();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            label1.Text = "1";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
