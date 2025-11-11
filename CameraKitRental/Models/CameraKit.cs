using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CameraKitRental.Models;

public class CameraKit
{
    public string Brand { get; set; } = string.Empty;
    public string Model { get; set; } = string.Empty;
    public double DailyRate { get; set; } = 0.0;

    public bool Booked { get; protected set; } = false;
    public CameraKit()
    {
        Console.WriteLine("CameraKit instance created.");
    }
    public CameraKit(string brand, string model, double dailyRate)
    {
        if (string.IsNullOrWhiteSpace(brand) || string.IsNullOrWhiteSpace(model) || dailyRate <= 0)
        {
            Console.WriteLine("Invalid parameters provided.");
            throw new ArgumentException("Brand and Model cannot be empty, and Daily Rate must be greater than zero.");

        }



        Brand = brand;
        Model = model;
        DailyRate = dailyRate;
    }
    public void Display()
    {
        //Console.WriteLine("CameraKit Display method called.");
        Console.WriteLine(new string('*', 40));
        Console.WriteLine($"Brand: {Brand}, Model: {Model}, Daily Rate: {DailyRate}, Booked: {Booked}");
        Console.WriteLine(new string('*', 40));
    }

    public void Book()
    {
        if (!Booked)
        {
            Booked = true;
            Console.WriteLine($"CameraKit {Brand} {Model} has been booked.");
        }
        else
        {
            Console.WriteLine($"CameraKit {Brand} {Model} is already booked.");
        }

    }

    public void ReturnItem()
    {
        if (Booked)
        {
            Booked = false;
            Console.WriteLine($"CameraKit {Brand} {Model} has been returned.");
        }
        else
        {
            Console.WriteLine($"CameraKit {Brand} {Model} is not booked.");
        }

    }
    public bool isBooked() => Booked;

}
