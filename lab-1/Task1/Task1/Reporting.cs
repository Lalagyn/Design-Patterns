using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class Reporting
    {
        private List<WarehouseItem> inventory;

        public Reporting()
        {
            inventory = new List<WarehouseItem>();
        }

        public void RegisterIncomingProduct(string name, string unit, double pricePerUnit, int quantity)
        {
            WarehouseItem newItem = new WarehouseItem(name, unit, pricePerUnit, quantity);
            inventory.Add(newItem);
            Console.WriteLine($"Зареєстрований вхідний продукт: {quantity} {unit} з {name} за {pricePerUnit} за {unit}");
        }

        public void ShipProduct(string name, int quantity)
        {
            foreach (var item in inventory)
            {
                if (item.Name == name)
                {
                    if (item.Quantity >= quantity)
                    {
                        item.Quantity -= quantity;
                        Console.WriteLine($"Відправлено {quantity} одиниць {name}");
                        return;
                    }
                    else
                    {
                        Console.WriteLine($"Недостатня кількість {name} на складі");
                        return;
                    }
                }
            }
            Console.WriteLine($"Товар {name} не знайдено в асортименті");
        }

        public void GenerateInventoryReport()
        {
            Console.WriteLine("Звіт про інвентаризацію:");
            foreach (var item in inventory)
            {
                Console.WriteLine($"Продукт: {item.Name}, Одиниці: {item.Quantity}, Останній запас: {item.LastStocked}");
            }
        }
    }
}
