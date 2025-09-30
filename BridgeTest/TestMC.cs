using Bridge;
using System.Diagnostics.CodeAnalysis;

namespace BridgeTest
{
    [TestClass]
    [ExcludeFromCodeCoverage]
    public class TestMC
    {
        [TestMethod]
        public void TestConstructor()
        {
            // Arrange
            MC mc = new MC();

            // Assert
            Assert.IsNotNull(mc);
        }

        [TestMethod]
        public void TestPrice()
        {
            // Arrange
            MC mc = new MC();

            // Act
            int price = 120;

            // Assert
            Assert.AreEqual(price, mc.Price());
        }

        [TestMethod]
        public void TestVehicleType()
        {
            // Arrange
            MC mc = new MC();

            // Act
            string vehicleType = "MC";

            // Assert
            Assert.AreEqual(vehicleType, mc.VehicleType());
        }
    }
}
