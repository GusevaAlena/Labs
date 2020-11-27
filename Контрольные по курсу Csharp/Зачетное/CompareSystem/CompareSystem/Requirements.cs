using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompareSystem
{
    class Requirements
    {
        private string nameoftest { get; }
        private string markofsteel { get; }
        private double temperature { get; }
        private double requirement { get; }
        private string nameofcharacteristic { get; }
        public Requirements(string MarkOfsteel,string NameOfTest, string NameOfCharacteristic, double Temperature, double Requirement)
        {
            markofsteel = MarkOfsteel;
            nameoftest = NameOfTest;
            nameofcharacteristic = NameOfCharacteristic;
            temperature = Temperature;
            requirement = Requirement;
        }
        public string ShowRequirements ()
        {
            string Require = "\nМарка стали: " + markofsteel + "\nНазвание испытания: " + nameoftest + "\nХарактеристика материала: " + nameofcharacteristic + "\nТемпература испытания: " + temperature + "\nТребуемое значение характеристики: " + requirement;
            return Require;
        }
    }
}
