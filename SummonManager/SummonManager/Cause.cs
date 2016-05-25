using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SummonManager
{
    public partial class Cause : Form
    {
        public string cause = "";
        public bool result = false;
        public Cause()
        {
            InitializeComponent();
            textBox1.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.result             = false;
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Укажите причину!");
                return;
            }
            this.cause              = textBox1.Text;
            this.result             = true;
            this.Close();
        }
    }
}
