using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITMO.ADO.NET.Ex02
{
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();
        }

        private void ClientFormbutton_Click(object sender, EventArgs e)
        {
            ClientForm clientF = new ClientForm();
            clientF.Show();
            this.Hide();
        }

        private void EmployeeFormbutton_Click(object sender, EventArgs e)
        {
            EmployeeForm empF = new EmployeeForm();
            empF.Show();
            this.Hide();
        }
    }
}
