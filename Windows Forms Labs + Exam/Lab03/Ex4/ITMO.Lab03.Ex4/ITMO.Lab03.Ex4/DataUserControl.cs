using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITMO.Lab03.Ex4
{
    public partial class DataUserControl : UserControl
    {
        public DataUserControl()
        {
            InitializeComponent();
        }
        public string FirstName
        {
            get { return textBoxFirtsName.Text; }
            set { textBoxFirtsName.Text = value; }
        }
        public string LastName
        {
            get { return textBoxLastName.Text; }
            set { textBoxLastName.Text = value; }
        }
        public DateTime BirthDay
        {
            get { return dateTimePicker1.Value.Date; }
            set { dateTimePicker1.Value = value; }
        }
        public string TelNumber
        {
            get { return textBoxTelNumb.Text; }
            set { textBoxTelNumb.Text = value; }
        }
        public string Email
        {
            get { return textBoxMail.Text; }
            set { textBoxMail.Text = value; }
        }
     
        private void textBoxFirtsName_Validating(object sender, CancelEventArgs e)
        {
            if (textBoxFirtsName.Text == String.Empty)
            {
                e.Cancel = true;
                MessageBox.Show("Данное поле обязательно для заполнения");
            }
            else
            {
                foreach (char c in textBoxFirtsName.Text)
                {
                    if(char.IsDigit(c))
                    {
                        e.Cancel = true;
                        MessageBox.Show("Имя не может содержать цифры");
                    }
                    else
                    {
                        e.Cancel = false;
                    }
                }
            }
        }

        private void textBoxTelNumb_Validating(object sender, CancelEventArgs e)
        {
            if (textBoxTelNumb.Text == String.Empty)
            {
                e.Cancel = true;
                MessageBox.Show("Данное поле обязательно для заполнения");
            }
            else
            {
                try 
                {
                    double.Parse(textBoxTelNumb.Text);
                    e.Cancel = false;
                }
                catch
                {
                    e.Cancel = true;
                    MessageBox.Show("Номер телефона не может содержать буквы");
                }
            }
             
        }

        private void textBoxLastName_Validating(object sender, CancelEventArgs e)
        {
            if (textBoxLastName.Text==String.Empty)
            {
                e.Cancel = true;
                MessageBox.Show("Данное поле обязательно для заполнения");
            }
            foreach (char c in textBoxLastName.Text)
            {
                if (char.IsDigit(c))
                {
                    e.Cancel = true;
                    MessageBox.Show("Фамилия не может содержать цифры");
                }
                else
                {
                    e.Cancel = false;
                }
            }
        }
        public bool ValidEmail (string emailAddress, out string ErrorMes)
        {
           if (emailAddress.Length==0)
            {
                ErrorMes = "Данное поле обязательно для заполнения";
                return false;
            }
          
           if (emailAddress.IndexOf("@")>-1)
            {
                if (emailAddress.IndexOf(".", emailAddress.IndexOf("@")) > emailAddress.IndexOf("@"))
                {
                    ErrorMes = "";
                    return true;
                }               
            }
            ErrorMes = "Неправильный формат введенного e-mail адреса.\n" + "Адрес должен иметь формат вида: your@mail.ru";
            return false;
        }

        private void dateTimePicker1_Validating(object sender, CancelEventArgs e)
        {
            if (dateTimePicker1.Value>DateTime.Now)
            {
                e.Cancel = true;
                MessageBox.Show("Введенная дата не может быть больше текущей");
            }
            else
            {               
                e.Cancel = false;
            }
        }

        private void textBoxMail_Validating(object sender, CancelEventArgs e)
        {
            string ErrMsg;
            if (!ValidEmail(textBoxMail.Text, out ErrMsg))
            {
                e.Cancel = true;
                textBoxMail.Select(0, textBoxMail.Text.Length);
                this.errorProvider1.SetError(textBoxMail, ErrMsg);
            }
            else
            {
                errorProvider1.SetError(textBoxMail, ErrMsg);
            }
        }
    }
}
