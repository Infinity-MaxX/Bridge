using Bridge;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OresundTicketLibrary
{
    public class OresundMC : Vehicle
    {
        #region Instances
        #endregion

        #region Properties
        #endregion

        #region Constructor
        public OresundMC(string licensePlate, bool brobizz = false) : base(licensePlate, brobizz)
        {
            _price = 235;
        }
        #endregion

        #region Methods
        public override double Price()
        {
            if (Brobizz == true) { _price = 92; return _price; }
            else { return _price; }
        }
        public override string VehicleType()
        {
            return "Oresund MC";
        }
        #endregion
    }
}
