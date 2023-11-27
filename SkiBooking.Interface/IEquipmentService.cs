using SkiBooking.Entities;

namespace SkiBooking.Interface
{
    public interface IEquipmentService
    {
        IEnumerable<EquipmentType> GetEquipmentTypes();
    }
}
