using SkiBooking.Entities;
using System.ComponentModel;

namespace SkiBooking.Interface
{
    public interface ISkiPackageService
    {
        IEnumerable<SkiPackage> GetAllPackages();
        SkiPackage GetPackage(int id);
        void AddNewPackage(SkiPackage skiPackage);
        void DeletePackage(int id);

    }
}
