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
    public partial class FormFaV : Form
    {
        public FormFaV()
        {
            InitializeComponent();
        }

        private void FormFaV_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form ifrm = Application.OpenForms[2];
            ifrm.StartPosition = FormStartPosition.Manual;
            ifrm.Left = this.Left;
            ifrm.Top = this.Top;
            ifrm.Show();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string lineFa = textBox8.Text;
            string lineg = textBox7.Text;
            string linep = textBox6.Text;
            double valueFa = 0;
            double valueg = 0;
            double valuep = 0;
            try
            {
                valueFa = Convert.ToDouble(lineFa);
                valueg = Convert.ToDouble(lineg);
                valuep = Convert.ToDouble(linep);
            }
            catch (Exception)
            {

            }
            double Result = valueFa/(valuep * valueg);
            textBox9.Text = Convert.ToString(Result) + "м3";
        }
    }
}
