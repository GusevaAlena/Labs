using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookSort
{
    class Book: IComparable
    {
        private string author;
        private string title;
        private int year;
        private int pages;
        public void SetBook(String author, String title, int year, int pages)
        {
            this.author = author;
            this.title = title;
            this.year = year;
            this.pages = pages;
        }
        public void Show()
        {
            Console.WriteLine("\nКнига: \nАвтор: {0}\nНазвание: {1}\nГод издания: {2}\nКоличество страниц:{3}\n", author, title, year, pages);
        }
        int IComparable.CompareTo(object obj)
        {
            Book it = (Book)obj;
            if (this.year == it.year) return 0;
            else if (this.year > it.year) return 1;
            else return -1;
        }
    }
}
