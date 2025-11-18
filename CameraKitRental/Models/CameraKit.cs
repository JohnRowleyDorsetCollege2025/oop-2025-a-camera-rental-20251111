using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CameraKitRental.Models;

public interface IRentable
{
    bool Book();    
    void ReturnItem();  
    void Display();
    bool isBooked();

    double CheckRate();
    void ChangeRate(double newRate);
}



public abstract class RentalItem
{
    // Base class for rental items
    public string Brand { get; set; } = string.Empty;
    public string Model { get; set; } = string.Empty;
    public double DailyRate { get; set; } = 0.0;

    public bool Booked { get; protected set; } = false;


    protected RentalItem(string brand, string model, double dailyRate)
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

    public abstract void Display();
}   
public class CameraKit : RentalItem, IRentable
{
  
    public string AssetTag { get; set; } = string.Empty;    

    public string KitType { get; set; } = string.Empty;

    public CameraKit(string brand, string model, string assetTag, string kitType, double dailyRate) : base(brand, model, dailyRate)
    {


        if (string.IsNullOrWhiteSpace(assetTag) || string.IsNullOrWhiteSpace(kitType))
        {
            Console.WriteLine("Invalid parameters provided.");
            throw new ArgumentException("assetTag and kitType cannot be empty");

        }




        AssetTag = assetTag;
        KitType = kitType;

    }
    public override void Display()
    {
        //Console.WriteLine("CameraKit Display method called.");
        Console.WriteLine(new string('*', 40));
        Console.WriteLine($"Brand: {Brand}, Model: {Model}, Asset Tag: {AssetTag}, KitType: {KitType},Daily Rate: {DailyRate}, Booked: {Booked}");
        Console.WriteLine(new string('*', 40));
    }

    public bool Book()
    {
        if (!Booked)
        {
            Booked = true;
            Console.WriteLine($"CameraKit {Brand} {Model} has been booked.");
            return true;
        }
        else
        {
            Console.WriteLine($"CameraKit {Brand} {Model} is already booked.");
            return false;
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

    public double CheckRate() => DailyRate; 

    public void ChangeRate(double newRate)
    {
        if (newRate > 0)
        {
            DailyRate = newRate;
            Console.WriteLine($"CameraKit {Brand} {Model} rate changed to {DailyRate}.");
        }
        else
        {
            Console.WriteLine("Invalid rate. Rate must be greater than zero.");
        }
    }


}



