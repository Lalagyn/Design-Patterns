using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class Money
    {
        public int Dollars { get; private set; }
        public int Cents { get; private set; }

        public Money(int dollars, int cents)
        {
            Dollars = dollars;
            Cents = cents;
        }

        public void Display()
        {
            Console.WriteLine($"${Dollars}.{Cents:00}");
        }

        public void SetAmount(int dollars, int cents)
        {
            Dollars = dollars;
            Cents = cents;
        }

        public void Add(int dollars, int cents)
        {
            Dollars += dollars;
            Cents += cents;
            if (Cents >= 100)
            {
                Dollars += Cents / 100;
                Cents %= 100;
            }
        }
    }
}
    
