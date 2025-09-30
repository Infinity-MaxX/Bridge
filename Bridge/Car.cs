using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    public class Car : Vehicle
    {
        #region Instances

        #endregion

        #region Properties

        #endregion

        #region Constructor
        /// <summary>
        /// Creates an object of class Car, with LicensePlate and Date as properties
        /// </summary>
        // default constructor
        public Car() : base() { }

        // parameterised constructor
        public Car(string licensePlate, bool brobizz = false) : base(licensePlate, brobizz = false) { }
        #endregion

        #region Methods
        /// <summary>
        /// Returns the price of the Car. Can be overriden.
        /// </summary>
        /// <returns></returns>
        public override double Price(double defaultPrice = 230)
        {
            if (Brobizz == true) { return defaultPrice * 0.9; }
            else { return defaultPrice; }
        }
        /// <summary>
        /// Returns the vehicle type. Can be overriden.
        /// </summary>
        /// <returns></returns>
        public override string VehicleType()
        {
            return "Car";
        }
        #endregion
    }
}
