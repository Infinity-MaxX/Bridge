using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    public abstract class Vehicle
    {
        #region Instances
        private DateTime _date;
        protected double _price;
        #endregion

        #region Properties
        public string LicensePlate { get; private set; }
        public DateTime Date { get { return _date; } }
        public bool Brobizz { get; set; }
        #endregion

        #region Constructor
        /// <summary>
        /// Creates an object of class Vehicle, with 
        /// LicensePlate, Date and Brobizz as properties.
        /// </summary>
        // parameterised constructors
        public Vehicle(string licensePlate, bool brobizz = false)
        {
            _date = DateTime.Now;   // set the current date and time
            _price = 100;           // default value for a ticket
            Brobizz = brobizz;
            if (licensePlate == null)
            { throw new ArgumentNullException("License Plate cannot be null."); }
            else
            {
                if (licensePlate.Length <= 7) { LicensePlate = licensePlate; }
                else { throw new ArgumentException("License Plate cannot be more than 7 characters long."); }
            }
        }
        #endregion

        #region Methods
        /// <summary>
        /// Returns the price of the ticket. The function will also check
        /// if the vehicle has Brobizz, and return the discount price if true.
        /// </summary>
        /// <returns></returns>
        public virtual double Price()
        {
            if (Brobizz == true) { return _price * 0.9; }
            else { return _price; }
        }
        /// <summary>
        /// Returns the type of vehicle.
        /// </summary>
        /// <returns></returns>
        public abstract string VehicleType();
        #endregion
    }
}
