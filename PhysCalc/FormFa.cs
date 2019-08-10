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
    public partial class FormFa : Form
    {
        public FormFa()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string linep = textBox6.Text;
            string lineg = textBox7.Text;
            string lineV = textBox8.Text;
            double valuep = 0;
            double valueg = 0;
            double valueV = 0;
            try
            {
                valuep = Convert.ToDouble(linep);
                valueg = Convert.ToDouble(lineg);
                valueV = Convert.ToDouble(lineV);
            }
            catch(Exception)
            {

            }
            double Result = valuep * valueg * valueV;
            textBox9.Text = Convert.ToString(Result) + "Н";
        }

        private void FormFa_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form ifrm = Application.OpenForms[2];
            ifrm.StartPosition = FormStartPosition.Manual;
            ifrm.Left = this.Left;
            ifrm.Top = this.Top;
            ifrm.Show();
        }
    }
}
