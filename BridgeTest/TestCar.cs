using Bridge;
using System.Diagnostics.CodeAnalysis;

namespace BridgeTest
{
    [TestClass]
    [ExcludeFromCodeCoverage]
    public class TestCar
    {
        [TestMethod]
        // [DataRow()]
        public void TestConstructor()
        {
            // Arrange
            var car = new Car();

            // Assert
            Assert.IsNotNull(car);
        }

        [TestMethod]
        public void TestPrice()
        {
            // Arrange
            Car car = new Car();

            // Act
            int price = 230;

            // Assert
            Assert.AreEqual(car.Price(), price);
        }

        [TestMethod]
        public void TestVehicleType()
        {
            // Arrange
            Car car = new Car();

            // Act
            string vehicleType = "Car";

            // Assert
            Assert.AreEqual(car.VehicleType(), vehicleType);
        }
    }
}
