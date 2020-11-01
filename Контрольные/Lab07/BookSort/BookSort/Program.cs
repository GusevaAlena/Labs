using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace BookSort
{
    class Program
    { 
        public static void ShowList(Book [] books)
        {
            for (int i = 0; i < books.Length; i++)
            {
                books[i].Show();
            }
        }
        static void Main(string[] args)
        {          
            Book b1 = new Book();         
            b1.SetBook("Пушкин А.С.", "Евгений Онегин", 2017, 384);           
            Book b2 = new Book();        
            b2.SetBook("Робин Шарма", "Монах, который продал свой феррари", 2019, 256);          
            Book b3 = new Book();
            b3.SetBook("Дэн Браун", "Инферно", 2018, 576);          
            Book b4 = new Book();          
            b4.SetBook("Достаевский Ф.М.", "Преступление и наказание", 1996, 544);           
            Book b5 = new Book();
            b5.SetBook("Носов Н.Н.", "Приключения Незнайки и его друзей", 2005, 184);
            Console.WriteLine("До сортировки: ");     
            Book[] AllBooks = { b1, b2, b3, b4, b5 };
            ShowList(AllBooks);
            Array.Sort(AllBooks);
            Console.WriteLine("После сортировки: ");
            ShowList(AllBooks);        
            Console.ReadLine();           
        }
    }
}
