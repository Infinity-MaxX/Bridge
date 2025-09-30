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
        #endregion

        #region Methods
        /// <summary>
        /// Returns the price of the MC. Can be overriden.
        /// </summary>
        /// <returns></returns>
        public override double Price()
        {
            return 120;
        }
        /// <summary>
        /// Returns the vehicle type. Can be overriden.
        /// </summary>
        /// <returns></returns>
        public override string VehicleType()
        {
            return "MC";
        }
        #endregion
    }
}
