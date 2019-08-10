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
    public partial class FormF : Form
    {
        public FormF()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Form ifrm = new FormFaChoose();
            ifrm.Left = this.Left;
            ifrm.Top = this.Top;
            ifrm.Show();
            this.Hide();
        }

        private void FormF_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form ifrm = Application.OpenForms[0];
            ifrm.StartPosition = FormStartPosition.Manual;
            ifrm.Left = this.Left; 
            ifrm.Top = this.Top; 
            ifrm.Show(); 
        }
    }
}
