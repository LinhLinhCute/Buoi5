using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cau1_BTLop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtA_TextChanged(object sender, EventArgs e)
        {
            Control ctr = (Control)sender;
            if (ctr.Text.Trim().Length == 0)
            {
                this.errorProvider1.SetError(ctr, "Ban phai nhap so");
            }
            else
                this.errorProvider1.Clear();
           
        }

        private void txtB_TextChanged(object sender, EventArgs e)
        {
            Control ctr = (Control)sender;
            if (ctr.Text.Trim().Length == 0)
            {
                this.errorProvider1.SetError(ctr, "Ban phai nhap so");
            }
            else
                this.errorProvider1.Clear();
            
        }

        private void btnCong_Click(object sender, EventArgs e)
        {
            int a, b;
            a = int.Parse(txtA.Text);
            b = int.Parse(txtB.Text);
            txtKetQua.Text = (a + b).ToString();
        }

        private void btnTru_Click(object sender, EventArgs e)
        {
            int a, b;
            a = int.Parse(txtA.Text);
            b = int.Parse(txtB.Text);
            txtKetQua.Text = (a - b).ToString();
        }

        private void btnNhan_Click(object sender, EventArgs e)
        {
            int a, b;
            a = int.Parse(txtA.Text);
            b = int.Parse(txtB.Text);
            txtKetQua.Text = (a * b).ToString();
        }

        private void btnChia_Click(object sender, EventArgs e)
        {
            float a, b;
            a = float.Parse(txtA.Text);
            b = float.Parse(txtB.Text);
            txtKetQua.Text = (a / b).ToString();
        }

         
    }
}
