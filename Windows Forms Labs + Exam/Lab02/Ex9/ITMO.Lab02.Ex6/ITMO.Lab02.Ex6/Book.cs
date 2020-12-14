using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ITMO.Lab02.Ex6
{
    class Book : Item
    {
        private string author { get; set; }
        private string title { get; set; }
        private string publisher { get; set; }
        private int pages { get; set; }
        private int year { get; set; }
        private double cost { get; set; }
        private static double price = 9;
     
        private bool returnSrok;
        public Book(string Author, string Title, string Publisher, int Pages, int Year, long InvNumber, bool Taken) : base(InvNumber, Taken)
        {
            author = Author;
            title = Title;
            publisher = Publisher;
            pages = Pages;
            year = Year;
        }
        public Book() { }
        static Book()
        {
            price = 10;
        }
        public static void SetPrice(double price)
        {
            Book.price = price;
        }
        public void PriceBook(int s)
        {
            if (this.returnSrok == true)
                this.cost = s * price;
            else this.cost = s * (price + price * 0.13); ;
        }
        public void ReturnSrok()
        {
            returnSrok = true;
        }
        public override void Return()
        {
            if (returnSrok == true)
                taken = true;
            else
                taken = false;
        }
        public override string ToString()
        {
            if (this.IsAvailable())
                return "\nКнига:\nАвтор: " + author + "\nНазвание: " + title + "\nИздательство: " + publisher +
                "\nГод издания: " + year + ".,\n" + pages + " стр. \nСтоимость аренды: " + Book.price + " p.\n" + base.ToString()
                + "\nИтого за чтение: " + cost + " p.";
            else
                return "\nКнига:\nАвтор: " + author + "\nНазвание: " + title + "\nИздательство: " + publisher +
            "\nГод издания: " + year + ".,\n" + pages + " стр. \nСтоимость аренды: " + Book.price + " p.\n" + base.ToString();

        }
    }
}













