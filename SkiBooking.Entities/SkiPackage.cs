namespace SkiBooking.Entities
{
    public class SkiPackage : BaseEntity
    {
        public string? PackageType { get; set; }

        public double? PackagePrice { get; set; }
        public string? Details { get; set; }
    }
}
