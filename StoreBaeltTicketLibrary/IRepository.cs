using Bridge;

namespace StoreBaeltTicketLibrary
{
    public interface IRepository
    {
        int Count { get; }

        void AddCarTicket(StoreBaeltCar car);
        void AddMCTicket(MC mc);
        List<Vehicle> GetAll();
        StoreBaeltCar GetCar(string licensePlate);
        MC GetMC(string licensePlate);
    }
}