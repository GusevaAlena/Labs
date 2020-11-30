using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ITMO.Lab02.Ex6
{
    abstract class Item : IComparable
    {
        protected long invNumber { get; set; } // инвентарный номер
        protected bool taken { get; set; }   // взят ли объект на руки
        public bool IsAvailable() //наличие в библиотеке
        {
            if (taken == true)
                return true;
            else
                return false;
        }
        public long GetInvNumber()
        {
            return invNumber;
        }
        private void Take()
        {
            taken = false;
        }
        abstract public void Return();    // операция "вернуть"

        public Item(long InvNumber, bool Taken)
        {
            invNumber = InvNumber;
            taken = Taken;
        }

        public Item()
        {
            this.taken = true;
        }
        public void TakeItem()
        {
            if (this.IsAvailable())
                this.Take();
        }
        public override string ToString()
        {
            if (taken)
                return "Состояние единицы хранения: \nИнвентарный номер: " + invNumber + ". В наличии";
            else
                return "Состояние единицы хранения: \nИнвентарный номер: " + invNumber + ". Нет в наличии";
        }
        int IComparable.CompareTo(object obj)
        {
            Item it = (Item)obj;
            if (this.invNumber == it.invNumber) return 0;
            else if (this.invNumber > it.invNumber) return 1;
            else return -1;
        }
    }
}














