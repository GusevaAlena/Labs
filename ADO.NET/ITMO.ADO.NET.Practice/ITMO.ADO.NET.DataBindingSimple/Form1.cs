using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITMO.ADO.NET.DataBindingSimple
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private BindingSource productBindingSource;

        private void Form1_Load(object sender, EventArgs e)
        {
            productsTableAdapter1.Fill(northwindDataSet1.Products);
            productBindingSource = new BindingSource(northwindDataSet1, "Products");
            ProductIDTextBox.DataBindings.Add("Text", productBindingSource, "ProductID");
            ProductNameTextBox.DataBindings.Add("Text", productBindingSource, "ProductName");
        }

        private void PreviousButton_Click(object sender, EventArgs e)
        {
            productBindingSource.MovePrevious();
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            productBindingSource.MoveNext();
        }
    }
}
