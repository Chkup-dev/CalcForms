using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhysCalc
{
    public partial class FormFaChoose : Form
    {
        public FormFaChoose()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Form ifrm = new FormFa();
            ifrm.Left = this.Left;
            ifrm.Top = this.Top;
            ifrm.Show();
            this.Hide();
        }

        private void FormFaChoose_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form ifrm = Application.OpenForms[1];
            ifrm.StartPosition = FormStartPosition.Manual;
            ifrm.Left = this.Left;
            ifrm.Top = this.Top;
            ifrm.Show();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Form ifrm = new FormFaG();
            ifrm.Left = this.Left;
            ifrm.Top = this.Top;
            ifrm.Show();
            this.Hide();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Form ifrm = new FormFaP();
            ifrm.Left = this.Left;
            ifrm.Top = this.Top;
            ifrm.Show();
            this.Hide();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            Form ifrm = new FormFaV();
            ifrm.Left = this.Left;
            ifrm.Top = this.Top;
            ifrm.Show();
            this.Hide();
        }
    }
}
