using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using SimpleCalculator;
using System.Globalization;


namespace SimpleCalculator
{
    public partial class QuadEqForm : Form
    {
        public QuadEqForm()
        {
            InitializeComponent();
        }
        private string A
        {
            get { return textBoxCoefA.Text; }
            set { textBoxCoefA.Text = value; }
        }
        private string B
        {
            get { return textBoxCoefB.Text; }
            set { textBoxCoefB.Text = value; }
        }
        private string C
        {
            get { return textBoxCoefC.Text; }
            set { textBoxCoefC.Text = value; }
        }  

        private void buttonEnter_Click(object sender, EventArgs e)
        {    
            EngiCalc encalc = this.Owner as EngiCalc;                        
            double D = Math.Pow(double.Parse(B), 2) - 4 * double.Parse(A) * double.Parse(C);
                if (D < 0)
                {
                    MessageBox.Show("Корней нет, дискрименант меньше нуля!");
                    this.Close();
                }
               else if (D == 0)
               {
                if (encalc != null)
                    encalc.Output= (-double.Parse(B) / (2 * double.Parse(A))).ToString();
                this.Close();
               }
                else if (D>0)
                {
                if (encalc != null)
                    encalc.Output = "X1 = " + ((-double.Parse(B) + Math.Sqrt(D)) / (2 * double.Parse(A))).ToString("0.###", CultureInfo.InvariantCulture) + ";"
                    + "X2 = " + ((-double.Parse(B) - Math.Sqrt(D)) / (2 * double.Parse(A))).ToString("0.###",CultureInfo.InvariantCulture);
                this.Close();
                }           
        }

        private void textBoxCoefA_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar<=47||e.KeyChar>=58) && e.KeyChar!=44 && e.KeyChar!=45&& e.KeyChar!=8)
            {
                e.Handled = true;
                MessageBox.Show("Данное поле может содержать только цифры и знаки ',', '-'");               
            }
            else
            {
                if (e.KeyChar == 44 && textBoxCoefA.Text.Contains(","))
                    e.Handled = true;
                else if (e.KeyChar == 45 && textBoxCoefA.Text.Contains("-"))
                    e.Handled = true;      
            }
        }

        private void textBoxCoefB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && e.KeyChar != 44 && e.KeyChar != 45 && e.KeyChar != 8)
            {
                e.Handled = true;
                MessageBox.Show("Данное поле может содержать только цифры и знаки ',', '-'");
            }
            else
            {
                if (e.KeyChar == 44 && textBoxCoefB.Text.Contains(","))
                    e.Handled = true;
                else if (e.KeyChar == 45 && textBoxCoefB.Text.Contains("-"))
                    e.Handled = true;
            }
        }

        private void textBoxCoefC_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && e.KeyChar != 44 && e.KeyChar != 45 && e.KeyChar != 8)
            {
                e.Handled = true;
                MessageBox.Show("Данное поле может содержать только цифры и знаки ',', '-'");
            }
            else
            {
                if (e.KeyChar == 44 && textBoxCoefC.Text.Contains(","))
                    e.Handled = true;
                else if (e.KeyChar == 45 && textBoxCoefC.Text.Contains("-"))
                    e.Handled = true;
            }
        }
    }
}
