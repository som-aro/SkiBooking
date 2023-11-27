using AutoMapper;
using SkiBooking.Api.Dto;
using SkiBooking.Entities;

namespace SkiBooking.Api.Helpers
{
    public class MappingProfiles: Profile
    {
        public MappingProfiles()
        {
            CreateMap<SkiPackage, SkiPackageDto>();
            CreateMap<SkiPackage, SkiPackageSummaryDto>();

            CreateMap<EquipmentType, EquipmentTypeDto>();

            CreateMap<LiftTicketType, LiftTicketTypeDto>();
        }
    }
}
