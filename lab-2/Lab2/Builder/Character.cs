using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class Character
    {
        public double Height { get; set; }
        public string BodyType { get; set; }
        public string HairColor { get; set; }
        public string EyeColor { get; set; }
        public string Clothing { get; set; }
        public List<string> Inventory { get; set; }

        public Character()
        {
            Inventory = new List<string>();
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Зріст: {Height}");
            Console.WriteLine($"Статура: {BodyType}");
            Console.WriteLine($"Колір волосся: {HairColor}");
            Console.WriteLine($"Колір очей: {EyeColor}");
            Console.WriteLine($"Одяг: {Clothing}");
            Console.WriteLine("Інвентар: " + string.Join(", ", Inventory));
        }
    }
}

