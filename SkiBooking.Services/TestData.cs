using SkiBooking.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkiBooking.Services
{
    internal class TestData
    {
        public static IEnumerable<SkiPackage> GetSkiPackages()
        {
            return new List<SkiPackage> { BuildSkiPackage(1,"Basic", 50.00),
                BuildSkiPackage(2,"Silver", 100.00),
                BuildSkiPackage(3, "Gold", 200.00),
                BuildSkiPackage(4, "Platinum", 300.00) };
        }
        public static SkiPackage GetSkiPackage(int id)
        {
            var all = GetSkiPackages();
            return all.Where(x => x.Id == id).FirstOrDefault();
        }

        public static SkiPackage BuildSkiPackage(int id, string packageType, double price)
        {
            return new SkiPackage
            {
                Details = $"{packageType} Loren ipsum",
                Id = id,
                PackagePrice = price,
                PackageType = packageType
            };
        }

        public static IEnumerable<EquipmentType> GetEquipmentTypes()
        {
            return new List<EquipmentType> { BuildEquipmentType(1,"Skis", 10.00),
                BuildEquipmentType(2, "Boots", 5.00),
                BuildEquipmentType(3, "Poles", 20.00) };
        }

        public static EquipmentType GetEquipmentType(int id)
        {
            var all = GetEquipmentTypes();
            return all.Where(x => x.Id == id).FirstOrDefault();
        }

        public static EquipmentType BuildEquipmentType(int id, string equipmentType, double price)
        {
            return new EquipmentType
            {
                EquipmentPrice = price,
                Id = id,
                Type = equipmentType
            };
        }
        public static IEnumerable<LiftTicketType> GetLiftTicketTypes()
        {
            return new List<LiftTicketType> { BuildLiftTicketType(1,"Child", 100.00),
                BuildLiftTicketType(2, "Concession", 200.00),
                BuildLiftTicketType(3, "Adult", 300.00) };
        }

        public static LiftTicketType GetLiftTicketType(int id)
        {
            var all = GetLiftTicketTypes();
            return all.Where(x => x.Id == id).FirstOrDefault();
        }

        public static LiftTicketType BuildLiftTicketType(int id, string type, double price)
        {
            return new LiftTicketType
            {
                Price = price,
                Id = id,
                Type = type
            };
        }
    }
}
