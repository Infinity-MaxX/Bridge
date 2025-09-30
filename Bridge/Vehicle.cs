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
        private DateTime _date;
        #endregion

        #region Properties
        public string LicensePlate { get; private set; }
        public DateTime Date { get { return _date; } }
        #endregion

        #region Constructor
        /// <summary>
        /// Creates an object of class Vehicle, with LicensePlate and Date as properties
        /// </summary>
        // default constructor
        public Vehicle() { }

        // parameterised constructor
        public Vehicle(string licensePlate)
        {
            if (licensePlate != null && licensePlate.Length == 7){ LicensePlate = licensePlate; }
            else { throw new ArgumentException("License Plate cannot be null or more than 7 characters long."); }
            _date = DateTime.Now;
        }
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
