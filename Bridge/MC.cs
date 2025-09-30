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
        /// Creates an object of class MC, with 
        /// LicensePlate, Date and Brobizz as properties.
        /// </summary>
        // paramterised constructor
        public MC(string licensePlate, bool brobizz = false) : base(licensePlate, brobizz)
        {
            _price = 120;
        }
        #endregion

        #region Methods
        /// <summary>
        /// Returns the type of vehicle as type "Motorcycle", shortened as "MC".
        /// </summary>
        /// <returns></returns>
        public override string VehicleType()
        {
            return "MC";
        }
        #endregion
    }
}
