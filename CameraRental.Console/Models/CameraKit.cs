using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CameraRental.Models;

public class RentalItem
{


}

public class CameraKit : RentalItem
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
        if (string.IsNullOrWhiteSpace(brand))
        {
            throw new ArgumentException("Brand cannot be null or empty.", nameof(brand));
        }

        if (string.IsNullOrWhiteSpace(model))
        {
            throw new ArgumentException("Model cannot be null or empty.", nameof(model));
        }

        Brand = brand;
        Model = model;
        DailyRate = dailyRate;
    }

    public void Display()
    {
        Console.WriteLine("CameraKit Display Called");
        Console.WriteLine(new string('*', 40));
        Console.WriteLine($"Brand: {Brand}, Model: {Model}, Daily Rate: {DailyRate}, Booked: {Booked}");

    }

    public void Book()
    {
        if (Booked)
        {
            Console.WriteLine("CameraKit is already booked.");
        }
        else
        {
            Booked = true;
            Console.WriteLine("CameraKit has been booked.");
        }
    }

    public void ReturnItem()
    {
        if (Booked)
        {
            Booked = false;
            Console.WriteLine("CameraKit has been returned.");
        }
        else
        {

            Console.WriteLine("CameraKit has not been booked.");
        }
    }

    public bool isBooked() => Booked;
}
