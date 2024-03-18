using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Item
{
    public string Name { get; set; }
    public double Price { get; set; }
}

public class Box
{
    public string SerialNumber { get; set; }
    public Item Item { get; set; }
    public int ItemQuantity { get; set; }
    public double BoxPrice => ItemQuantity * Item.Price;
}

public class Program
{
    public static void Main()
    {
        List<Box> boxes = new List<Box>();

        string input;
        while ((input = Console.ReadLine()) != "end")
        {
            string[] data = input.Split();
            string serialNumber = data[0];
            string itemName = data[1];
            int itemQuantity = int.Parse(data[2]);
            double itemPrice = double.Parse(data[3]);

            Item item = new Item { Name = itemName, Price = itemPrice };
            Box box = new Box { SerialNumber = serialNumber, Item = item, ItemQuantity = itemQuantity };
            boxes.Add(box);
        }

        foreach (Box box in boxes.OrderByDescending(b => b.BoxPrice))
        {
            Console.WriteLine($"{box.SerialNumber}");
            Console.WriteLine($"-- {box.Item.Name} - ${box.Item.Price:F2}: {box.ItemQuantity}");
            Console.WriteLine($"-- ${box.BoxPrice:F2}");
        }
    }
}