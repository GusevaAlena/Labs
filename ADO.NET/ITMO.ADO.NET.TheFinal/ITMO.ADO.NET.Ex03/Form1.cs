using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITMO.ADO.NET.Ex03
{
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();
        }

        private void Clientbutton_Click(object sender, EventArgs e)
        {
            ClientForm clientF = new ClientForm();
            clientF.Show();
            this.Hide();
        }

        private void Employeebutton_Click(object sender, EventArgs e)
        {
            EmployeeForm empF = new EmployeeForm();
            empF.Show();
            this.Hide();
        }
    }
}
