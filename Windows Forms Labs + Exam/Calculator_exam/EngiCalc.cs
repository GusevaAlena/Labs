using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Calculator;
using System.Numerics;
using System.Globalization;



namespace SimpleCalculator
{
    public partial class EngiCalc : SimpleCalculator.CalcUI
    {
        public EngiCalc()
        {
            InitializeComponent();          
        }
        public string Output
        {
            get { return OutputDisplay.Text; }
            set { OutputDisplay.Text = value; }
        }

        private void sqr_btn_Click(object sender, EventArgs e)
        {           
            Output = Math.Pow(double.Parse(Output),2).ToString();
        }

        private void stepen_btn_Click(object sender, EventArgs e)
        {
            CalcEngine.CalcOperation(CalcEngine.Operator.eXponentiation);
        }

        private void sqrt_btn_Click(object sender, EventArgs e)
        {
            if (double.Parse(Output) >= 0)
                Output = Math.Sqrt(double.Parse(Output)).ToString();
            else
                MessageBox.Show("Квадратный корень не может быть взят из отрицательного числа");
        }

        private void sqrt3_btn_Click(object sender, EventArgs e)
        {
            if (double.Parse(Output) >= 0)
                Output = Math.Pow(double.Parse(Output), 1 / 3.0).ToString();
            else
                MessageBox.Show("Кубический корень не может быть взят из отрицательного числа");
        }

        private void reverse_btn_Click(object sender, EventArgs e)
        {
            double g = double.Parse(Output);
             Output = Math.Pow(g,-1).ToString();
        }

        public BigInteger factorial()
        {
            double EnterNum = double.Parse(Output);
            if (EnterNum >= 0 && EnterNum == (int)EnterNum)
            {
                BigInteger F = new BigInteger(1);
                for (int i = 2; i <= EnterNum; i++)
                {
                    F *= i;
                }
                return F;
            }
            else
                return 0;
        }
        private void factorial_btn_Click(object sender, EventArgs e)
        {
            backgroundWorker1.RunWorkerAsync();           
        }

        private void quadeq_btn_Click(object sender, EventArgs e)
        {
            QuadEqForm quadeqf = new QuadEqForm();
            quadeqf.Show(this);
        }
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            for (int i = 1; i < 11; i++)
            {
                BigInteger Fact = factorial();
                if (Fact >= 100000000)
                    e.Result = Fact.ToString("0.####e+0", CultureInfo.InvariantCulture);
                else if (Fact == 0)
                {
                    e.Result = "Неверно введены данные";
                    MessageBox.Show("Число должно быть целым и больше нуля!");
                }
                else
                    e.Result = Fact.ToString();
                backgroundWorker1.ReportProgress(i * 10);
            }
            
        }
        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            OutputFact.Text = e.Result.ToString();
        }
        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            OutputFact.Text = e.ProgressPercentage.ToString();
        }
    }
}
