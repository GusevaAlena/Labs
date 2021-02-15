using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ITMO.ADO.NET.DatasetDesigner
{
    public partial class Form1 : Form
    {
  
        public Form1()
        {
            InitializeComponent();
        }

        private void GetCustomerButton_Click(object sender, EventArgs e)
        {
            NorthwindDataSet NorthwindDataset1 = new NorthwindDataSet();
            NorthwindDataSetTableAdapters.CustomersTableAdapter
                CustomersTableAdapter1 = new NorthwindDataSetTableAdapters.CustomersTableAdapter();
            CustomersTableAdapter1.Fill(NorthwindDataset1.Customers);
            foreach (NorthwindDataSet.CustomersRow NwCustomer in NorthwindDataset1.Customers.Rows)
            {
                CustomersListBox.Items.Add(NwCustomer.CompanyName);
            }
        }
        
    }
}
