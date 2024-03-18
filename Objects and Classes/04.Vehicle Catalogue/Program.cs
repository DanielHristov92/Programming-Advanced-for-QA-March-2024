using System;
using System.Collections.Generic;
using System.Linq;

public class Vehicle
{
    public string Brand { get; set; }
    public string Model { get; set; }
}

public class Car : Vehicle
{
    public int HorsePower { get; set; }

    public override string ToString()
    {
        return $"{Brand}: {Model} - {HorsePower}hp";
    }
}

public class Truck : Vehicle
{
    public int Weight { get; set; }

    public override string ToString()
    {
        return $"{Brand}: {Model} - {Weight}kg";
    }
}

public class Catalog
{
    public List<Car> Cars { get; set; }
    public List<Truck> Trucks { get; set; }

    public Catalog()
    {
        Cars = new List<Car>();
        Trucks = new List<Truck>();
    }

    public void AddVehicle(string type, string brand, string model, int horsePowerOrWeight)
    {
        if (type == "Car")
        {
            Cars.Add(new Car { Brand = brand, Model = model, HorsePower = horsePowerOrWeight });
        }
        else if (type == "Truck")
        {
            Trucks.Add(new Truck { Brand = brand, Model = model, Weight = horsePowerOrWeight });
        }
    }

    public void PrintCatalog()
    {
        Console.WriteLine("Cars:");
        foreach (var car in Cars.OrderBy(c => c.Brand))
        {
            Console.WriteLine(car);
        }

        Console.WriteLine("Trucks:");
        foreach (var truck in Trucks.OrderBy(t => t.Brand))
        {
            Console.WriteLine(truck);
        }
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Catalog catalog = new Catalog();

        string input;
        while ((input = Console.ReadLine()) != "end")
        {
            string[] vehicleData = input.Split('/');
            string type = vehicleData[0];
            string brand = vehicleData[1];
            string model = vehicleData[2];
            int horsePowerOrWeight = int.Parse(vehicleData[3]);

            catalog.AddVehicle(type, brand, model, horsePowerOrWeight);
        }

        catalog.PrintCatalog();
    }
}