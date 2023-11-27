namespace SkiBooking.Api.Dto
{
    public class SkiPackageSummaryDto
    {
        public int Id { get; set; }
        public string? PackageType { get; set; }

        public double? PackagePrice { get; set; }
    }
}