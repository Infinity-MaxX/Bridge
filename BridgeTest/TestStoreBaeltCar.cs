using StoreBaeltTicketLibrary;
using System.Diagnostics.CodeAnalysis;

namespace BridgeTest;

[TestClass]
public class TestStoreBaeltCar
{
    [TestMethod]
    [ExpectedException(typeof(ArgumentException))]
    [DataRow("1234567890")]
    public void TestLengthOfLicensePlateProperty(string licensePlate)
    {
        // Arrange
        StoreBaeltCar car = new StoreBaeltCar(licensePlate);
    }

    [TestMethod]
    [ExpectedException(typeof(ArgumentNullException))]
    public void TestNullLicensePlateProperty()
    {
        // Arrange
        StoreBaeltCar car = new StoreBaeltCar(null);
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
        StoreBaeltCar car = new StoreBaeltCar(licensePlate);

        // Assert
        Assert.IsNotNull(car);
    }

    [TestMethod]
    [DataRow("1234567", DayOfWeek.Monday, false)]
    public void TestPrice(string licensePlate, DayOfWeek day, bool brobizz)
    {
        // Arrange
        StoreBaeltCar car = new StoreBaeltCar(licensePlate, day, brobizz);

        // Act
        int price = 230;

        // Assert
        Assert.AreEqual(price, car.Price());
    }

    [TestMethod]
    [DataRow("1234567", DayOfWeek.Monday, true)]
    public void TestBrobizz(string licensePlate, DayOfWeek day, bool brobizz)
    {
        // Arrange
        StoreBaeltCar car = new StoreBaeltCar(licensePlate, day, brobizz);

        // Act
        double price = 207;

        // Assert
        Assert.AreEqual(price, car.Price());
    }

    [TestMethod]
    [DataRow("1234567", DayOfWeek.Sunday, false)]
    public void TestWeekendDiscount(string licensePlate, DayOfWeek day, bool brobizz)
    {
        // Arrange
        StoreBaeltCar car = new StoreBaeltCar(licensePlate, day, brobizz);

        // Act
        double price = 195.5;

        // Assert
        Assert.AreEqual(price, car.Price(), 0.0001);
    }

    [TestMethod]
    [DataRow("1234567", DayOfWeek.Sunday, true)]
    public void TestWeekendAndBrobizzDiscount(string licensePlate, DayOfWeek day, bool brobizz)
    {
        // Arrange
        StoreBaeltCar car = new StoreBaeltCar(licensePlate, day, brobizz);

        // Act
        double price = 175.95;

        // Assert
        Assert.AreEqual(price, car.Price(), 0.0001);
    }

    [TestMethod]
    [DataRow("1234567")]
    public void TestVehicleType(string licensePlate)
    {
        // Arrange
        StoreBaeltCar car = new StoreBaeltCar(licensePlate);

        // Act
        string vehicleType = "StoreBaeltCar";

        // Assert
        Assert.AreEqual(vehicleType, car.VehicleType());
    }
}
