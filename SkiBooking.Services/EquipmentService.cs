using SkiBooking.Entities;
using SkiBooking.Interface;

namespace SkiBooking.Services
{
    public class EquipmentService : IEquipmentService
    {
        public IEnumerable<EquipmentType> GetEquipmentTypes()
        {
            //call to DAL
            return TestData.GetEquipmentTypes();
        }

        public EquipmentType GetEquipmentType(int id)
        {
            //call to DAL
            return TestData.GetEquipmentType(id);
        }
    }

}
