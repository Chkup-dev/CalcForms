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
    public partial class FormFm : Form
    {
        public FormFm()
        {
            InitializeComponent();
        }

        private void FormFm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form ifrm = Application.OpenForms[2];
            ifrm.StartPosition = FormStartPosition.Manual;
            ifrm.Left = this.Left;
            ifrm.Top = this.Top;
            ifrm.Show();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string lineF = textBox7.Text;
            string lineg = textBox6.Text;
            double valueF = 0;
            double valueg = 0;
            try
            {
                valueF = Convert.ToDouble(lineF);
                valueg = Convert.ToDouble(lineg);
            }
            catch (Exception)
            {

            }
            double Result = valueF / valueg;
            textBox5.Text = Convert.ToString(Result) + "Кг";
        }
    }
}
