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
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void TestNullLicensePlateProperty()
        {
            // Arrange
            Vehicle vehicle = new Vehicle(null);
        }

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
            Assert.AreEqual(price, vehicle.Price());
        }

        [TestMethod]
        [DataRow("1234567", true)]
        public void TestBrobizz(string licensePlate, bool brobizz)
        {
            // Arrange
            Vehicle vehicle = new Vehicle(licensePlate, brobizz);

            // Act
            double price = 90;

            // Assert
            Assert.AreEqual(price, vehicle.Price());
        }

        [TestMethod]
        public void TestVehicleType()
        {
            // Arrange
            Vehicle vehicle = new Vehicle();

            // Act
            string vehicleType = "Vehicle";

            // Assert
            Assert.AreEqual(vehicleType, vehicle.VehicleType());
        }
    }
}
