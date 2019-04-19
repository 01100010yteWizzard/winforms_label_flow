using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace labels
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void txtInput_TextChanged(object sender, EventArgs e)
        {
            lbl_dynamic.Text = txtInput.Text;
        }

        private void flowLayoutPanel2_Resize(object sender, EventArgs e)
        {
            var w = flowLayoutPanel2.Width;
            txtInput.Width = (w - 5);
        }
    }
}
