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
    public partial class Modal : Form
    {
        public delegate void GetInputEventHandler(string txt);
        public event GetInputEventHandler GetInput;
        string returnVal = "";

        public Modal(string txt)
        {
            InitializeComponent();
            txtInput.Text = txt;
            count(txt);
        }

        private void txtInput_TextChanged(object sender, EventArgs e)
        {
            returnVal = txtInput.Text;
            count(returnVal);
        }

        private void bnCancel_Click(object sender, EventArgs e)
        {
            close();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            GetInput(returnVal);
            close();
        }

        private void close()
        {
            returnVal = "";
            this.Close();
        }

        private void count(string txt)
        {
            lbl_length.Text = string.Format("Text hat {0} Zeichen", txt.Length.ToString());
        }
    }
}
