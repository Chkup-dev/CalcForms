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
    public partial class FormFtF : Form
    {
        public FormFtF()
        {
            InitializeComponent();
        }

        private void FormFtF_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form ifrm = Application.OpenForms[2];
            ifrm.StartPosition = FormStartPosition.Manual;
            ifrm.Left = this.Left;
            ifrm.Top = this.Top;
            ifrm.Show();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string linem = textBox5.Text;
            string lineg = textBox6.Text;
            double valuem = 0;
            double valueg = 0;
            try
            {
                valuem = Convert.ToDouble(linem);
                valueg = Convert.ToDouble(lineg);
            }
            catch (Exception)
            {

            }
            double Result = valuem * valueg;
            textBox7.Text = Convert.ToString(Result) + "Н";
        }
    }
}
