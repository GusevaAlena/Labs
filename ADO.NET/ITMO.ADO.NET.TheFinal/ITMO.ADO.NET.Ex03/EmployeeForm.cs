using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;

namespace ITMO.ADO.NET.Ex03
{
    public partial class EmployeeForm : Form
    {
        private ApressFinancialEntities AprFinContext;
        public EmployeeForm()
        {
            InitializeComponent();
        }

        private void EmployeeForm_Load(object sender, EventArgs e)
        {
            AprFinContext = new ApressFinancialEntities();
            var Customer = from Cust in AprFinContext.Customers
                           select Cust;
            dataGridView1.DataSource = Customer.ToList();
            dataGridView1.DataSource = AprFinContext.Customers.Local.ToBindingList();         
        }

        private void SaveChangesbutton_Click(object sender, EventArgs e)
        {
            try
            {
                AprFinContext.SaveChanges();
                MessageBox.Show("Changes saved to the database");
                this.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Closebutton_Click(object sender, EventArgs e)
        {
            this.Close();
            AprFinContext.Dispose();
        }
    }
}
