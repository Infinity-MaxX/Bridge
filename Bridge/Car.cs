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
        public Car() { }
        #endregion

        #region Methods
        /// <summary>
        /// Returns the price of the Car. Can be overriden.
        /// </summary>
        /// <returns></returns>
        public override double Price()
        {
            return 230;
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
