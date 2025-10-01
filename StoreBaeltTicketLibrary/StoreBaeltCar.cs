using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bridge;

namespace StoreBaeltTicketLibrary
{
    public class StoreBaeltCar : Vehicle
    {
        #region Instances
        #endregion

        #region Properties
        public DayOfWeek Day { get; set; }
        #endregion

        #region Constructors
        public StoreBaeltCar(string licensePlate, bool brobizz = false)
            : base(licensePlate, brobizz)
        {
            Day = DateTime.Now.DayOfWeek;
            _price = 230;
        }
        /// <summary>
        /// A constructor where the day of the week is provided at initialisation.
        /// THIS CONSTRUCTOR IS USED EXLUSIVELY FOR TESTING PURPOSES.
        /// </summary>
        /// <param name="licensePlate"></param>
        /// <param name="day"></param>
        /// <param name="brobizz"></param>
        public StoreBaeltCar(string licensePlate, DayOfWeek day, bool brobizz = false)
            : base(licensePlate, brobizz)
        {
            Day = day;
            _price = 230;
        }

        #endregion

        #region Methods
        /// <summary>
        /// Returns the price of the ticket. This function will also check if
        /// the car is crossing on weekends, and if the car has Brobizz. Should 
        /// either or both yield true, this function will return a discounted 
        /// price, otherwise return the standard ticket price.
        /// </summary>
        /// <returns></returns>
        public override double Price()
        {
            if (Day == DayOfWeek.Sunday || Day == DayOfWeek.Saturday)
            {
                if (Brobizz == true) { return _price * 0.85 * 0.9; }
                else { return _price * 0.85; }
            }
            else
            {
                if (Brobizz == true) { return _price * 0.9; }
                else { return _price; }
            }
        }
        /// <summary>
        /// Returns the type of vehicle as type "StoreBaeltCar".
        /// </summary>
        /// <returns></returns>
        public override string VehicleType()
        {
            return "Car";
        }
        #endregion
    }
}