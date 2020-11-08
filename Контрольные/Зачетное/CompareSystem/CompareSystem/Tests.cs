using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompareSystem
{
    class Tests
    {
        private string nameoftest { get; set; }
        private string markofsteel { get; set; }
        private double temperature { get; set; }
        private double result { get; set; }
        private string nameofcharacteristic { get; set; }

        public Tests(string MarkOfsteel, string NameOfTest, string NameOfCharacteristic, double Temperature, double Result)
        {
            markofsteel = MarkOfsteel;
            result = Result;
            nameoftest= NameOfTest;
            nameofcharacteristic = NameOfCharacteristic;
            temperature = Temperature;
        }
        public string ShowResults ()
        {
            string TestResult = "\nМарка стали: " + markofsteel + "\nНаименование испытания: "+ nameoftest + "\nПолученная характеристика: " + nameofcharacteristic +"\nТемпература испытаний: "+temperature+ "\nСреднее значение по результатам испытаний 3 образцов: " + result;
            return TestResult;
        }
        

    }
}
