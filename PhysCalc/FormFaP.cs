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
    public partial class FormFaP : Form
    {
        public FormFaP()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string lineFa = textBox6.Text;
            string lineg = textBox7.Text;
            string lineV = textBox8.Text;
            double valueFa = 0;
            double valueg = 0;
            double valueV = 0;
            try
            {
                valueFa = Convert.ToDouble(lineFa);
                valueg = Convert.ToDouble(lineg);
                valueV = Convert.ToDouble(lineV);
            }
            catch (Exception)
            {

            }
            double Result = valueFa/(valueg * valueV);
            textBox9.Text = Convert.ToString(Result) + "Кг/м3";
        }

        private void FormFaP_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form ifrm = Application.OpenForms[2];
            ifrm.StartPosition = FormStartPosition.Manual;
            ifrm.Left = this.Left;
            ifrm.Top = this.Top;
            ifrm.Show();
        }
    }
}
