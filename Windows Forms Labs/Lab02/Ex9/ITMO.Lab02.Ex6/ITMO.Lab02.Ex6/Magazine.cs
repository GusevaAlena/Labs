using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ITMO.Lab02.Ex6
{
    class Magazine : Item, IPubs
    {
        private string volume { get; set; }  // Название тома
        private int number { get; set; }  // номер
        private string title { get; set; }  // Название выпуска
        private int year { get; set; }    // дата выпуска
       
        public Magazine(string Volume, int Number, string Title, int Year, long InvNumber, bool Taken)
            : base(InvNumber, Taken)
        {
            volume = Volume;
            number = Number;
            title = Title;
            year = Year;
        }
        public Magazine() { }
        public override void Return()    // Возврат
        {
            taken = true;
        }
        public bool IfSubs { get; set; }
        public void Subs()
        {
            IfSubs = true;
        }
        public override string ToString()
        {
            if (IfSubs)
                return "\nЖурнал:\nНазвание: " + title + "\nТом: " + volume +
                "\nНомер: " + number + "\nГод выпуска: " + year + "\nПодписка оформлена" + "\n" + base.ToString();
            else
                return "\nЖурнал:\nНазвание: " + title + "\nТом: " + volume +
                "\nНомер: " + number + "\nГод выпуска: " + year + "\nПодписка не оформлена" + "\n" + base.ToString();
        }

    }
}




