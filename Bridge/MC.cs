using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Bridge
{
    public class MC : Vehicle
    {
        #region Instances

        #endregion

        #region Properties
        
        #endregion

        #region Constructor
        /// <summary>
        /// Creates an object of class MC, with LicensePlate and Date as properties
        /// </summary>
        // default constructor
        public MC() : base() { }

        // paramterised constructor
        public MC(string licensePlate, bool brobizz) : base(licensePlate, brobizz = false) { }
        #endregion

        #region Methods
        /// <summary>
        /// Returns the price of the MC.
        /// </summary>
        /// <returns></returns>
        public override double Price(double defaultPrice = 120)
        {
            return defaultPrice;
        }
        /// <summary>
        /// Returns the vehicle type.
        /// </summary>
        /// <returns></returns>
        public override string VehicleType()
        {
            return "MC";
        }
        #endregion
    }
}
