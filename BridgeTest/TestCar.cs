using Bridge;
using System.Diagnostics.CodeAnalysis;

namespace BridgeTest
{
    [TestClass]
    [ExcludeFromCodeCoverage]
    public class TestCar
    {
        [TestMethod]
        public void TestConstructor()
        {
            // Arrange
            Car car = new Car();

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
            Assert.AreEqual(price, car.Price());
        }

        [TestMethod]
        [DataRow("1234567", true)]
        public void TestBrobizz(string licensePlate, bool brobizz)
        {
            // Arrange
            Car car = new Car(licensePlate, brobizz);

            // Act
            double price = 207;

            // Assert
            Assert.AreEqual(price, car.Price());
        }

        [TestMethod]
        public void TestVehicleType()
        {
            // Arrange
            Car car = new Car();

            // Act
            string vehicleType = "Car";

            // Assert
            Assert.AreEqual(vehicleType, car.VehicleType());
        }
    }
}
