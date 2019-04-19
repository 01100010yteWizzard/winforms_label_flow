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
        Modal modal;
        public Form1()
        {
            InitializeComponent();
            lbl_dynamic.Text = ":-)";

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            resize();
        }

        private void Modal_GetInput(string txt)
        {
            if(!string.IsNullOrEmpty(txt))
                lbl_dynamic.Text = txt; 
        }

        private void btnOpenModalView_Click(object sender, EventArgs e)
        {
            modal = new Modal(lbl_dynamic.Text);
            modal.Show();
            modal.GetInput += Modal_GetInput;
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            resize();
        }

        private void resize()
        {
            tableLayoutPanel1.Height = this.Height;
        }
    }
}
