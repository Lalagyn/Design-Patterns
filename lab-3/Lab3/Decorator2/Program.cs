using System;
using static System.Net.Mime.MediaTypeNames;
using System.Threading;
using Decorator2;

namespace Decorator2
{


    class Program
    {
        static void Main(string[] args)
        {
            Hero warrior = new Warrior();
            Hero mage = new Mage();
            Hero palladin = new Palladin();

            Console.WriteLine($"{warrior.GetDescription()} - Сила: {warrior.GetPower()}");
            Console.WriteLine($"{mage.GetDescription()} - Сила: {mage.GetPower()}");
            Console.WriteLine($"{palladin.GetDescription()} - Сила: {palladin.GetPower()}");

            warrior = new Armor(warrior);
            warrior = new Weapon(warrior);
            mage = new Artifact(mage);
            mage = new Weapon(mage);
            palladin = new Armor(palladin);
            palladin = new Artifact(palladin);

            Console.WriteLine($"{warrior.GetDescription()} - Сила: {warrior.GetPower()}");
            Console.WriteLine($"{mage.GetDescription()} - Сила: {mage.GetPower()}");
            Console.WriteLine($"{palladin.GetDescription()} - Сила: {palladin.GetPower()}");
        }
    }

}