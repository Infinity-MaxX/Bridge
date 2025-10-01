using OresundTicketLibrary;
namespace BridgeTest;

[TestClass]
public class TestOresundMC
{
    [TestMethod]
    [ExpectedException(typeof(ArgumentException))]
    [DataRow("1234567890")]
    public void TestLengthOfLicensePlateProperty(string licensePlate)
    {
        // Arrange
        OresundMC mc = new OresundMC(licensePlate);
    }

    [TestMethod]
    [ExpectedException(typeof(ArgumentNullException))]
    public void TestNullLicensePlateProperty()
    {
        // Arrange
        OresundMC mc = new OresundMC(null);
    }

    //[TestMethod]
    //public void TestDateProperty()
    //{
    //    // Arrange
    //    MC mc = new MC();

    //}

    [TestMethod]
    [DataRow("1234567")]
    public void TestConstructor(string licensePlate)
    {
        // Arrange
        OresundMC mc = new OresundMC(licensePlate);

        // Assert
        Assert.IsNotNull(mc);
    }

    [TestMethod]
    [DataRow("1234567", false)]
    public void TestPrice(string licensePlate, bool brobizz)
    {
        // Arrange
        OresundMC mc = new OresundMC(licensePlate, brobizz);

        // Act
        int price = 235;

        // Assert
        Assert.AreEqual(price, mc.Price());
    }

    [TestMethod]
    [DataRow("1234567", true)]
    public void TestBrobizz(string licensePlate, bool brobizz)
    {
        // Arrange
        OresundMC mc = new OresundMC(licensePlate, brobizz);

        // Act
        double price = 92;

        // Assert
        Assert.AreEqual(price, mc.Price());
    }

    [TestMethod]
    [DataRow("1234567")]
    public void TestVehicleType(string licensePlate)
    {
        // Arrange
        OresundMC mc = new OresundMC(licensePlate);

        // Act
        string vehicleType = "Oresund MC";

        // Assert
        Assert.AreEqual(vehicleType, mc.VehicleType());
    }
}
