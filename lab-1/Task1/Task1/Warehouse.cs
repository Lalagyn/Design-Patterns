using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class WarehouseItem
    {
        public string Name { get; set; }
        public string Unit { get; set; }
        public double PricePerUnit { get; set; }
        public int Quantity { get; set; }
        public DateTime LastStocked { get; set; }

        public WarehouseItem(string name, string unit, double pricePerUnit, int quantity)
        {
            Name = name;
            Unit = unit;
            PricePerUnit = pricePerUnit;
            Quantity = quantity;
            LastStocked = DateTime.Now;
        }
    }

    public class Warehouse
    {
        private List<WarehouseItem> items;

        public Warehouse()
        {
            items = new List<WarehouseItem>();
        }

        public void AddProduct(WarehouseItem item)
        {
            items.Add(item);
            Console.WriteLine($"Продукт {item.Name} доданий до складу.");
        }

        public void DisplayInventory()
        {
            Console.WriteLine("Інвентаризація складу:");
            foreach (var item in items)
            {
                Console.WriteLine($"Продукт: {item.Name}, Одиниці: {item.Quantity}, Останній запас: {item.LastStocked}");
            }
        }
    }
}
