using SkiBooking.Entities;

namespace SkiBooking.Interface
{
    public interface ILiftTicketService
    {

        IEnumerable<LiftTicketType> GetLiftTicketTypes();
    }
}
