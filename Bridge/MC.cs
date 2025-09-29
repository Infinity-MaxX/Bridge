using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public MC() { }
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
