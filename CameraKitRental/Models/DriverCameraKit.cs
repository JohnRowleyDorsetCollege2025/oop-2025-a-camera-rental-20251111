using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CameraKitRental.Models
{
    internal static class DriverCameraKit
    {
        public static void Run()
        {
            CameraKit cameraKit = new CameraKit("Canon","Model1",230.33);
            
            cameraKit.Display();

            cameraKit.Book();   

            cameraKit.Display();    

            cameraKit.Display();

            cameraKit.Book();

            cameraKit.ReturnItem(); 

            cameraKit.Display();

            try
            {
                CameraKit cameraItem = new CameraKit("", "", 255.33);
                cameraItem.Display();
            }
            catch(ArgumentException ex)
            {
                Console.WriteLine($"Error creating CameraKit: {ex.Message}");
            }
            finally
            {
                Console.WriteLine("DriverCameraKit Run method completed.");
            }
        }
    }
}
