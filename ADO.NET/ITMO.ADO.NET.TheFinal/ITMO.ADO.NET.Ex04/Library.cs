using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CodeFirst;

namespace ITMO.ADO.NET.Ex04
{
    public partial class Library : Form
    {
        SampleContext context = new SampleContext();
        public Library()
        {
            InitializeComponent();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            try
            {
                Reader reader = new Reader
                {
                    LastName = this.LastNametextBox.Text,
                    FirstName = this.FirstNametextBox.Text,
                    Birthday = this.dateOfBirthTimePicker.Value,
                    PhoneNum = this.PhoneNumbtextBox.Text,
                    email = this.EmailtextBox.Text,                   
                };
                context.Readers.Add(reader);
                context.SaveChanges();             
                LastNametextBox.Text = String.Empty;
                FirstNametextBox.Text = String.Empty;
                dateOfBirthTimePicker.Value = DateTime.Today;
                PhoneNumbtextBox.Text = String.Empty;
                EmailtextBox.Text = String.Empty;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.ToString());
            }
        }
        private void Output()
        {
            if (this.ReadersradioButton.Checked == true)
                dataGridView1.DataSource = context.Readers.ToList();
            else if (this.BooksradioButton.Checked == true)
                dataGridView1.DataSource = context.Books.ToList();           
        }

        private void Showbutton_Click(object sender, EventArgs e)
        {
            Output();
            var query = from b in context.Readers
                        orderby b.LastName
                        select b;
        }

        private void Library_Load(object sender, EventArgs e)
        {
            context.Books.Add(new Book
            {
                Author = "Пушкин А.С.",
                Title = "Евгений Онегин",
                Year = 2012,
                PagesNum = 112
            });
            context.Books.Add(new Book
            {
                Author = "Носов Н.Н.",
                Title = "Приключения Незнайки и его друзей",
                Year = 2000,
                PagesNum = 336
            });
            context.Books.Add(new Book
            {
                Author = "Чуковский К.И.",
                Title = "Золотые страницы",
                Year = 2003,
                PagesNum = 274
            });
            context.SaveChanges();       
        }
    }
}
