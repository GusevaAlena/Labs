using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ITMO.ADO.NET.Ex02
{
    public partial class ClientForm : Form
    {
        
        public ClientForm()
        {
            InitializeComponent();
        }

        private void getproductsButton_Click(object sender, EventArgs e)
        {
            AdventureWorksDataSet AdvWrkDataSet1 = new AdventureWorksDataSet();
            AdventureWorksDataSetTableAdapters.ProductTableAdapter ProdTableAdapt1 =
                new AdventureWorksDataSetTableAdapters.ProductTableAdapter();
            ProdTableAdapt1.Fill(AdvWrkDataSet1.Product);
            foreach (AdventureWorksDataSet.ProductRow AWProd in AdvWrkDataSet1.Product.Rows)
            {
                ProductslistBox.Items.Add(AWProd.Name);
                ProductslistBox.Items.Add(AWProd.ListPrice);               
            }
        }     
    }
}
