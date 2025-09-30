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
        public bool Brobizz { get; set; }
        #endregion

        #region Constructor
        /// <summary>
        /// Creates an object of class Vehicle, with LicensePlate and Date as properties
        /// </summary>
        // default constructor
        public Vehicle() { }

        // parameterised constructors
        public Vehicle(string licensePlate, bool brobizz = false)
        {
            _date = DateTime.Now;
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
        public virtual double Price(double defaultPrice = 100)
        {
            if (Brobizz == true) { return defaultPrice * 0.9; }
            else { return defaultPrice; }
        }
        public virtual string VehicleType()
        {
            return "Vehicle";
        }
        public virtual double BrobizzDiscount()
        {
            if (Brobizz == true) { return (Price() * 0.9); }
            else { return Price(); }
        }
        #endregion
    }
}
