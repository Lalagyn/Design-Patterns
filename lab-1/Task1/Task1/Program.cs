using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using Task1;

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.Unicode;
        Console.InputEncoding = Encoding.Unicode;

        // Тестування класу Money
        Money money = new Money(10, 99);
        money.Display();  // Виведе: $10.99
        money.SetAmount(20, 50);
        money.Display();  // Виведе: $20.50
        money.Add(5, 75);
        money.Display();  // Виведе: $26.25

        // Тестування класу Product
        Product product = new Product("Шоколадка", 50.0);
        Console.WriteLine($"{product.Name}: {product.Price} грн");  // Виведе: Шоколадка: 50 грн
        product.ReducePrice(10.0);
        Console.WriteLine($"{product.Name}: {product.Price} грн");  // Виведе: Шоколадка: 40 грн

        // Тестування класу Warehouse
        Warehouse warehouse = new Warehouse();
        warehouse.AddProduct(new WarehouseItem("Книга", "шт", 150.0, 10));
        warehouse.AddProduct(new WarehouseItem("Олівець", "шт", 5.0, 100));
        warehouse.DisplayInventory();

        // Тестування класу Reporting
        Reporting reporting = new Reporting();
        reporting.RegisterIncomingProduct("Книга", "шт", 150.0, 10);
        reporting.RegisterIncomingProduct("Олівець", "шт", 5.0, 100);
        reporting.ShipProduct("Олівець", 20);
        reporting.GenerateInventoryReport();
    }
}