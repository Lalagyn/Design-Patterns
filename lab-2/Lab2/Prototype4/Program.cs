using System;
using System.Collections.Generic;
using System.Text;

namespace Prototype
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            // Створення вірусів
            Virus parentVirus = new Virus(2.5, 5, "БатьківськийВірус", "ТипА");
            Virus childVirus1 = new Virus(1.2, 2, "ДитячийВірус1", "ТипБ");
            Virus childVirus2 = new Virus(1.1, 3, "ДитячийВірус2", "ТипВ");
            Virus grandChildVirus = new Virus(0.5, 1, "ОнукВірус", "ТипГ");

            // Додавання дітей
            childVirus1.AddChild(grandChildVirus);
            parentVirus.AddChild(childVirus1);
            parentVirus.AddChild(childVirus2);

            // Клонування вірусу-батька
            Virus clonedVirus = (Virus)parentVirus.Clone();

            // Відображення оригінального та клонованого вірусів
            Console.WriteLine("Оригінальна сім'я вірусів:");
            parentVirus.Display();

            Console.WriteLine("\nКлонована сім'я вірусів:");
            clonedVirus.Display();
        }
    }
}