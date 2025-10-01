using OresundTicketLibrary;

namespace BridgeTest;

[TestClass]
public class TestOresundCar
{
    [TestMethod]
    [ExpectedException(typeof(ArgumentException))]
    [DataRow("1234567890")]
    public void TestLengthOfLicensePlateProperty(string licensePlate)
    {
        // Arrange
        OresundCar car = new OresundCar(licensePlate);
    }

    [TestMethod]
    [ExpectedException(typeof(ArgumentNullException))]
    public void TestNullLicensePlateProperty()
    {
        // Arrange
        OresundCar car = new OresundCar(null);
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
        OresundCar car = new OresundCar(licensePlate);

        // Assert
        Assert.IsNotNull(car);
    }

    [TestMethod]
    [DataRow("1234567", false)]
    public void TestPrice(string licensePlate, bool brobizz)
    {
        // Arrange
        OresundCar car = new OresundCar(licensePlate, brobizz);

        // Act
        int price = 460;

        // Assert
        Assert.AreEqual(price, car.Price());
    }

    [TestMethod]
    [DataRow("1234567", true)]
    public void TestBrobizz(string licensePlate, bool brobizz)
    {
        // Arrange
        OresundCar car = new OresundCar(licensePlate, brobizz);

        // Act
        double price = 178;

        // Assert
        Assert.AreEqual(price, car.Price());
    }

    [TestMethod]
    [DataRow("1234567")]
    public void TestVehicleType(string licensePlate)
    {
        // Arrange
        OresundCar car = new OresundCar(licensePlate);

        // Act
        string vehicleType = "Oresund Car";

        // Assert
        Assert.AreEqual(vehicleType, car.VehicleType());
    }
}
