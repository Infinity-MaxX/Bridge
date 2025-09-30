using Bridge;
using System.Diagnostics.CodeAnalysis;

namespace BridgeTest
{
    [TestClass]
    [ExcludeFromCodeCoverage]
    public class TestVehicle
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        [DataRow("1234567890")]
        public void TestLengthOfLicensePlateProperty(string licensePlate)
        {
            // Arrange
            Vehicle vehicle = new Vehicle(licensePlate);

            // Assert
        }

        //[TestMethod]
        //[ExpectedException(typeof(ArgumentNullException))]
        //public void TestNullLicensePlateProperty()
        //{
        //    // Arrange
        //    Vehicle vehicle = new Vehicle();

        //    // Assert
        //}

        //[TestMethod]
        //public void TestDateProperty()
        //{
        //    // Arrange
        //    Vehicle vehicle = new Vehicle();

        //}

        [TestMethod]
        public void TestConstructor()
        {
            // Arrange
            Vehicle vehicle = new Vehicle();

            // Assert
            Assert.IsNotNull(vehicle);
        }

        [TestMethod]
        public void TestPrice()
        {
            // Arrange
            Vehicle vehicle = new Vehicle();

            // Act
            int price = 100;

            // Assert
            Assert.AreEqual(vehicle.Price(), price);
        }

        [TestMethod]
        public void TestVehicleType()
        {
            // Arrange
            Vehicle vehicle = new Vehicle();

            // Act
            string vehicleType = "Car";

            // Assert
            Assert.AreEqual(vehicle.VehicleType(), vehicleType);
        }
    }
}
