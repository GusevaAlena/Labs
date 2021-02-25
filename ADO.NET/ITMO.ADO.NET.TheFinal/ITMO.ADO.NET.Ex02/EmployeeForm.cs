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
    public partial class EmployeeForm : Form
    {
        DataView productDataView;
        public EmployeeForm()
        {
            InitializeComponent();
        }

        private void EmployeeForm_Load(object sender, EventArgs e)
        {
            productTableAdapter1.Fill(adventureWorksDataSet1.Product);
            productDataView = new DataView(adventureWorksDataSet1.Product);
            dataGridView1.DataSource = productDataView;
        }

        private void SaveChangesbutton_Click(object sender, EventArgs e)
        {
            sqlDataAdapter1.Update(adventureWorksDataSet1);
        }
    }
}
