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
        /// Creates an object of class Car, with 
        /// LicensePlate, Date and Brobizz as properties
        /// </summary>
        // parameterised constructor
        public Car(string licensePlate, bool brobizz = false) : base(licensePlate, brobizz)
        {
            _price = 230;
        }
        #endregion

        #region Methods
        /// <summary>
        /// Returns the type of vehicle as type "Car".
        /// </summary>
        /// <returns></returns>
        public override string VehicleType()
        {
            return "Car";
        }
        #endregion
    }
}
