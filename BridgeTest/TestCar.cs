using Bridge;
using System.Diagnostics.CodeAnalysis;

namespace BridgeTest
{
    [TestClass]
    [ExcludeFromCodeCoverage]
    public class TestCar
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        [DataRow("1234567890")]
        public void TestLengthOfLicensePlateProperty(string licensePlate)
        {
            // Arrange
            Car car = new Car(licensePlate);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void TestNullLicensePlateProperty()
        {
            // Arrange
            Car car = new Car(null);
        }

        //[TestMethod]
        //public void TestDateProperty()
        //{
        //    // Arrange
        //    Car car = new Car();

        //}

        [TestMethod]
        [DataRow("1234567")]
        public void TestConstructor(string licensePlate)
        {
            // Arrange
            Car car = new Car(licensePlate);

            // Assert
            Assert.IsNotNull(car);
        }

        [TestMethod]
        [DataRow("1234567", false)]
        public void TestPrice(string licensePlate, bool brobizz)
        {
            // Arrange
            Car car = new Car(licensePlate, brobizz);

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
        [DataRow("1234567")]
        public void TestVehicleType(string licensePlate)
        {
            // Arrange
            Car car = new Car(licensePlate);

            // Act
            string vehicleType = "Car";

            // Assert
            Assert.AreEqual(vehicleType, car.VehicleType());
        }
    }
}
