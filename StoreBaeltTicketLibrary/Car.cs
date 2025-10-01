using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bridge;

namespace StoreBaeltTicketLibrary
{
    public class Car
    {
        public Car() { }
        /// <summary>
        /// Returns the price of the ticket. This function will also check if
        /// the car is crossing on weekends, and if the car has Brobizz. Should 
        /// either or both yield true, this function will return a discounted 
        /// price, otherwise return the standard ticket price.
        /// </summary>
        /// <returns></returns>
        public override double Price()
        {
            DayOfWeek today = DateTime.Now.DayOfWeek;
            if (today == DayOfWeek.Sunday || today == DayOfWeek.Saturday)
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
    }
}
