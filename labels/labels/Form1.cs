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
        string lblDynamic = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            init();
        }

        private void Modal_GetInput(string txt)
        {
            if(!string.IsNullOrEmpty(txt))
                lblDynamic = txt;

            lbl_dynamic.Text = lblDynamic;
            count(lblDynamic);

        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            resize();
        }

        private void resize()
        {
            tableLayoutPanel1.Height = this.Height;
        }

        private void init()
        {
            resize();
            var lblDynamic = ":-)";
            lbl_dynamic.Text = lblDynamic;
            count(lblDynamic);
        }

        private void btnOpenModalView_Click(object sender, EventArgs e)
        {
            modal = new Modal(lbl_dynamic.Text);
            modal.Show();
            modal.GetInput += Modal_GetInput;
        }

        private void count(string txt)
        {
            lbl_length.Text = string.Format("Text in Label1 hat {0} Zeichen", txt.Length.ToString());
        }
    }
}
