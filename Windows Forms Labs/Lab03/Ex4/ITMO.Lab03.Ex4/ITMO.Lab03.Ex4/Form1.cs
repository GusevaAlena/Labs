using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITMO.Lab03.Ex4
{
    public partial class FormRegistration : Form
    {
        public FormRegistration()
        {
            InitializeComponent();
        }
        
        private void buttonRegistration_Click(object sender, EventArgs e)
        {            
            User u = new User(dataUserControl1.FirstName, dataUserControl1.LastName, dataUserControl1.BirthDay, dataUserControl1.TelNumber, dataUserControl1.Email);
            richTextBoxUserInfo.Text = u.ToString();
        }
    }
}
