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
    public partial class FormFaG : Form
    {
        public FormFaG()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string lineFa = textBox6.Text;
            string linep = textBox7.Text;
            string lineV = textBox8.Text;
            double valueFa = 0;
            double valuep = 0;
            double valueV = 0;
            try
            {
                valueFa = Convert.ToDouble(lineFa);
                valuep = Convert.ToDouble(linep);
                valueV = Convert.ToDouble(lineV);
            }
            catch (Exception)
            {

            }
            double Result = valueFa/(valuep*valueV);
            textBox9.Text = Convert.ToString(Result) + "Н/Кг";
        }

        private void FormFaG_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form ifrm = Application.OpenForms[2];
            ifrm.StartPosition = FormStartPosition.Manual;
            ifrm.Left = this.Left;
            ifrm.Top = this.Top;
            ifrm.Show();
        }
    }
}
