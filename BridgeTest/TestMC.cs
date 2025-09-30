using Bridge;
using System.Diagnostics.CodeAnalysis;

namespace BridgeTest
{
    [TestClass]
    [ExcludeFromCodeCoverage]
    public class TestMC
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        [DataRow("1234567890")]
        public void TestLengthOfLicensePlateProperty(string licensePlate)
        {
            // Arrange
            MC mc = new MC(licensePlate);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void TestNullLicensePlateProperty()
        {
            // Arrange
            MC car = new MC(null);
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
            MC mc = new MC(licensePlate);

            // Assert
            Assert.IsNotNull(mc);
        }

        [TestMethod]
        [DataRow("1234567", false)]
        public void TestPrice(string licensePlate, bool brobizz)
        {
            // Arrange
            MC mc = new MC(licensePlate, brobizz);

            // Act
            int price = 120;

            // Assert
            Assert.AreEqual(price, mc.Price());
        }

        [TestMethod]
        [DataRow("1234567", true)]
        public void TestBrobizz(string licensePlate, bool brobizz)
        {
            // Arrange
            MC mc = new MC(licensePlate, brobizz);

            // Act
            double price = 108;

            // Assert
            Assert.AreEqual(price, mc.Price());
        }

        [TestMethod]
        [DataRow("1234567")]
        public void TestVehicleType(string licensePlate)
        {
            // Arrange
            MC mc = new MC(licensePlate);

            // Act
            string vehicleType = "MC";

            // Assert
            Assert.AreEqual(vehicleType, mc.VehicleType());
        }
    }
}
