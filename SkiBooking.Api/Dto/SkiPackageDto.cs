namespace SkiBooking.Api.Dto
{
    public class SkiPackageDto
    {
        public int Id { get; set; }
        public string? PackageType { get; set; }

        public double? PackagePrice { get; set; }
        public string? Details { get; set; }
    }
}
