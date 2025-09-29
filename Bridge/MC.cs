using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    public class MC
    {
        #region Instances

        #endregion

        #region Properties
        public string LicensePlate { get; set; }
        public DateTime Date { get; set; }
        #endregion

        #region Constructor
        /// <summary>
        /// Creates an object of class Car, with LicensePlate and Date as properties
        /// </summary>
        public MC() { }
        #endregion

        #region Methods
        /// <summary>
        /// Returns the price of the Car. The price is currently fixed at 230.
        /// </summary>
        /// <returns></returns>
        public double Price()
        {
            return 120;
        }
        /// <summary>
        /// Returns the vehicle type. The type is currently fixed as "Car".
        /// </summary>
        /// <returns></returns>
        public string VehicleType()
        {
            return "MC";
        }
        #endregion
    }
}
