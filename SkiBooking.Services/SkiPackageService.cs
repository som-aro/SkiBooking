using SkiBooking.Entities;
using SkiBooking.Interface;

namespace SkiBooking.Services
{
    public class SkiPackageService : ISkiPackageService
    {
        public void AddNewPackage(SkiPackage skiPackage)
        {
            throw new NotImplementedException();
        }

        public void DeletePackage(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<SkiPackage> GetAllPackages()
        {
            //call to DAL
            return TestData.GetSkiPackages();
        }

        public SkiPackage GetPackage(int id)
        {
            //call to DAL
            return TestData.GetSkiPackage(id);
        }
    }

}
