using Bridge;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreBaeltTicketLibrary
{
    public class Repository : IRepository
    {
        #region Instances
        List<Vehicle> _ticketRepository;
        #endregion

        #region Properties
        public int Count { get { return _ticketRepository.Count(); } }
        #endregion

        #region Constructor
        public Repository()
        {
            _ticketRepository = new List<Vehicle>();
        }
        #endregion

        #region Methods
        public void AddCarTicket(StoreBaeltCar car)
        {
            StoreBaeltCar carTicket = new StoreBaeltCar(car.LicensePlate, car.Brobizz);
            _ticketRepository.Add(carTicket);
        }
        public void AddMCTicket(MC mc)
        {
            MC mcTicket = new MC(mc.LicensePlate, mc.Brobizz);
            _ticketRepository.Add(mcTicket);
        }
        public List<Vehicle> GetAll()
        {
            return _ticketRepository;
        }
        public StoreBaeltCar GetCar(string licensePlate)
        {
            foreach (StoreBaeltCar car in _ticketRepository)
            {
                if (car.LicensePlate == licensePlate) { return car; }
            }
            return null;
        }
        public MC GetMC(string licensePlate)
        {
            foreach (MC mc in _ticketRepository)
            {
                if (mc.LicensePlate == licensePlate) { return mc; }
            }
            return null;
        }
        #endregion
    }
}
