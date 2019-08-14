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
    public partial class FormFtChoose : Form
    {
        public FormFtChoose()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Form ifrm = new FormFm();
            ifrm.Left = this.Left;
            ifrm.Top = this.Top;
            ifrm.Show();
            this.Hide();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Form ifrm = new FormFtF();
            ifrm.Left = this.Left;
            ifrm.Top = this.Top;
            ifrm.Show();
            this.Hide();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Form ifrm = new FormFtG();
            ifrm.Left = this.Left;
            ifrm.Top = this.Top;
            ifrm.Show();
            this.Hide();
        }

        private void FormFtChoose_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form ifrm = Application.OpenForms[1];
            ifrm.StartPosition = FormStartPosition.Manual;
            ifrm.Left = this.Left;
            ifrm.Top = this.Top;
            ifrm.Show();
        }
    }
}
