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
    public partial class FormFtG : Form
    {
        public FormFtG()
        {
            InitializeComponent();
        }

        private void FormFtG_FormClosed(object sender, FormClosedEventArgs e)
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
            string linem = textBox5.Text;
            double valueF = 0;
            double valuem = 0;
            try
            {
                valueF = Convert.ToDouble(lineF);
                valuem = Convert.ToDouble(linem);
            }
            catch (Exception)
            {

            }
            double Result = valueF / valuem;
            textBox6.Text = Convert.ToString(Result) + "Н/Кг";
        }
    }
}
