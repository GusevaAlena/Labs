using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace CodeFirst
{
    public class Reader
    {
        public int ReaderID { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public DateTime Birthday { get; set; }
        public string PhoneNum { get; set; }
        public string email { get; set; }
        public virtual List<Book> Books { get; set; }
        public Reader()
        {
            Books = new List<Book>();
        }
    }
    public class Book
    {
        public int BookID { get; set; }
        public string Author { get; set; }
        public string Title { get; set; }
        public int Year { get; set; }
        public int PagesNum { get; set; }
        public Reader Reader { get; set; }
    }
}
