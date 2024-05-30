using System;
using System.Collections.Generic;

namespace Prototype
{
    public class Virus : ICloneable
    {
        public double Weight { get; set; }
        public int Age { get; set; }
        public string Name { get; set; }
        public string Species { get; set; }
        public List<Virus> Children { get; set; }

        public Virus(double weight, int age, string name, string species)
        {
            Weight = weight;
            Age = age;
            Name = name;
            Species = species;
            Children = new List<Virus>();
        }

        public void AddChild(Virus child)
        {
            Children.Add(child);
        }

        public object Clone()
        {
            Virus clone = (Virus)this.MemberwiseClone();
            clone.Children = new List<Virus>();
            foreach (Virus child in Children)
            {
                clone.Children.Add((Virus)child.Clone());
            }
            return clone;
        }

        public void Display(int depth = 0)
        {
            Console.WriteLine(new string('-', depth) + $"Ім'я: {Name}, Вид: {Species}, Вік: {Age}, Вага: {Weight}");
            foreach (Virus child in Children)
            {
                child.Display(depth + 1);
            }
        }
    }
}