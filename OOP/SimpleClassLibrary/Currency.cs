using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleClassLibrary
{
    public class Currency // валюта
    {
        // змінні
        public string Name { set; get; } // назва валюти
        public double ExRate { set; get; } // кількість гривень та копійок, що дають за одну одиницю валюти

        // конструктори
        public Currency() { }
        public Currency(Currency previousCurrency)
        {
            Name = previousCurrency.Name;
            ExRate = previousCurrency.ExRate;
        }
        public Currency(string name, double exRate)
        {
            this.Name = name;
            this.ExRate = exRate;
        }
    }
}
