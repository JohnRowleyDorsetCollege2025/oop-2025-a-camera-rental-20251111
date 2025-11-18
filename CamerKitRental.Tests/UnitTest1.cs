using CameraKitRental.Models;

namespace CamerKitRental.Tests
{
    public class UnitTest1
    {

        private CameraKit CreateDefaultCameraKit(bool booked = false)
        {
            return new CameraKit("Canon", "Model1", "Camera1", "MirrorLess", 230.33);


        }
        [Fact]
        public void Constructor_Properties_Are_Set_Correctly()
        {
            var cameraKit = CreateDefaultCameraKit();

            Assert.Equal("Canon", cameraKit.Brand);
            Assert.Equal("Model1", cameraKit.Model);

        }


        [Fact]
        public void Constructor_Empty_Brand_ThrowsArgumentException()
        {
           Assert.Throws<ArgumentException>(() => new CameraKit("", "Model1", "Camera1", "MirrorLess", 230.33));
        }

        [Fact]
        public void Constructor_Empty_Model_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new CameraKit("xxxxx", "", "Camera1", "MirrorLess", 230.33));
        }
        [Fact]
        public void Constructor_Empty_KitType_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new CameraKit("xxxxx", "xxxxx", "Camera1", "", 230.33));
        }

        [Fact]
        public void Constructor_Empty_AssetType_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new CameraKit("xxxxx", "xxxxx", "", "Camera1", 230.33));
        }



    }
}