using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CameraRental.Models
{
    public static class DriverCameraKit
    {
        public static void Run()
        {
            CameraKit cameraKit = new CameraKit("Canon","Model1",230.33);
            CameraKit cameraKit2 = new CameraKit("Nikon","Model0",250);

            cameraKit.Display();

            cameraKit.Book(); // not booked yet so ok to do

            cameraKit.Display();

            cameraKit.Book(); // already booked so should not be able to do

            cameraKit.ReturnItem();

            cameraKit.Display();

            Console.WriteLine($"Camera Kit is booked: {cameraKit.isBooked()}");
            Console.WriteLine($"Camera Kit is not booked: {!cameraKit.isBooked()}");

            if (!cameraKit.isBooked())
            {
                cameraKit.Book(); // now should be ok to do
            }

            if (cameraKit2.isBooked() == false)
            {
                cameraKit2.Book(); // now should be ok to do
            }
            // cameraKit.Booked = true; // directly setting the property not possible as it is protected
        }
    }
}
