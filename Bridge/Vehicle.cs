using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    public class Vehicle
    {
        #region Instances

        #endregion

        #region Properties
        public string LicensePlate { get; set; }
        public DateTime Date { get; set; }
        #endregion

        #region Constructor
        /// <summary>
        /// Creates an object of class Vehicle, with LicensePlate and Date as properties
        /// </summary>
        public Vehicle() { }
        #endregion

        #region Methods
        public virtual double Price()
        {
            return 100;
        }
        public virtual string VehicleType()
        {
            return "Car";
        }
        #endregion
    }
}
