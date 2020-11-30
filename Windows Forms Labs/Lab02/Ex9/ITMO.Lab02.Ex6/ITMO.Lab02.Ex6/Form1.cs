using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITMO.Lab02.Ex6
{
    public partial class Form1 : Form
    {
        public string Author
        {
            get { return textBox1.Text; }
            set { textBox1.Text = value; }
        }
        public string Title
        {
 
            get
            {
                if (this.tabControl1.SelectedIndex == 0)
                    return textBox2.Text;
                else
                    return textBox4.Text;
            }
            set 
            {
                if (this.tabControl1.SelectedIndex == 0)
                    textBox2.Text = value; 
                else
                    textBox4.Text = value;
            }
        
        }
        public string PublishHouse
        {
            get { return textBox3.Text; }
            set { textBox3.Text = value; }
        }
        public int Page
        {
            get { return (int)numericUpDown1.Value; }
            set { numericUpDown1.Value = value; }
        }
        public int Year
        {
            get
            {
                if (this.tabControl1.SelectedIndex == 0)
                    return (int)numericUpDown2.Value;
                else
                    return (int)numericUpDown7.Value;
            }
            set 
            {
                if (this.tabControl1.SelectedIndex == 0)
                    numericUpDown2.Value = value;
                else
                    numericUpDown7.Value = value;
            }
        }
        public int InvNumber
        {
            get 
            {
                if (this.tabControl1.SelectedIndex == 0)
                    return (int)numericUpDown3.Value;
                else
                    return (int)numericUpDown8.Value;
            }
            set 
            {
                if (this.tabControl1.SelectedIndex == 0)
                    numericUpDown3.Value = value;
                else
                    numericUpDown8.Value = value;
            }
        }
        public bool Existence
        {
            get 
            {
                if (this.tabControl1.SelectedIndex == 0)
                    return checkBox1.Checked;
                else
                    return checkBox5.Checked;
            }
            set 
            {
                if (this.tabControl1.SelectedIndex == 0)
                    checkBox1.Checked = value;
                else
                    checkBox5.Checked = value;
            }
        }
        public bool SortInvNumber
        {
            get { return checkBox3.Checked; }
            set { checkBox3.Checked = value; }
        }
        public bool ReturnTime
        {
            get { return checkBox2.Checked; }
            set { checkBox2.Checked = value; }
        }
        public int PeriodUse
        {
            get { return (int)numericUpDown4.Value; }
            set { numericUpDown4.Value = value; }
        }
        //public string Mtitle
        //{
        //    get { return textBox4.Text; }
        //    set { textBox4.Text = value; }
        //}
        public int Number
        {
            get { return (int)numericUpDown5.Value; }
            set { numericUpDown5.Value = value; }
        }
        public string Volume
        {
            get { return textBox5.Text; }
            set { textBox5.Text = value; }
        }
        //public int Myear
        //{
        //    get { return (int)numericUpDown7.Value; }
        //    set { numericUpDown7.Value = value; }
        //}
        //public int MinvNumber
        //{
        //    get { return (int)numericUpDown8.Value; }
        //    set { numericUpDown8.Value = value; }
        //}
        //public bool MExistence
        //{
        //    get { return checkBox5.Checked; }
        //    set { checkBox5.Checked = value; }
        //}
        public bool Subs
        {
            get { return checkBox4.Checked; }
            set { checkBox4.Checked = value; }
        }
        
        List<Item> its = new List<Item>();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Book b = new Book(Author, Title, PublishHouse, Page, Year, InvNumber, Existence);
            if (ReturnTime)
                b.ReturnSrok();
            b.PriceBook(PeriodUse);
            its.Add(b);

            Author = Title = PublishHouse = "";
            Page = 5;
            InvNumber = 1;
            PeriodUse = 0;
            Year = 1915;
            Existence = false; 
            ReturnTime = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (SortInvNumber)
                its.Sort();

            StringBuilder sb = new StringBuilder();
            foreach (Item item in its)
            {
                sb.Append("\n" + item.ToString());
            }
            richTextBox1.Text = sb.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Magazine m = new Magazine(Volume, Number, Title, Year, InvNumber, Existence);
            if (Subs)
                m.Subs();
            if (Existence)
                m.Return();
            its.Add(m);
            Volume = Title = "";
            Number = 1;
            Year = 1990;
            InvNumber = 0;
            Existence = Subs = false;
        }
    }
}
