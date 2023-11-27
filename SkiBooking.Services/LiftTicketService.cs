using SkiBooking.Entities;
using SkiBooking.Interface;

namespace SkiBooking.Services
{
    public class LiftTicketService : ILiftTicketService
    {
        public IEnumerable<LiftTicketType> GetLiftTicketTypes()
        {
            //call to DAL
            return TestData.GetLiftTicketTypes();
        }

        public LiftTicketType GetLiftTicketServiceType(int id)
        {
            //call to DAL
            return TestData.GetLiftTicketType(id);
        }
    }

}
