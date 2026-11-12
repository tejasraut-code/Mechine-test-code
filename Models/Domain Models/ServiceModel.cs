using System.ComponentModel.DataAnnotations;

namespace Mechine_Test_Code.Models.Domain_Models
{
    public class ServiceModel
    {
        [Key]
        public int ServiceId { get; set; }
        public int CategoryId { get; set; }
        public string ServiceName { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public decimal Price { get; set; } 
        public string? Image { get; set; }
        public string? DurationNote { get; set; }
        public int EstimatedDurationMinutes { get; set; }
        public bool RequiredSiteVisit { get; set; }


        public CategoryModel? Category { get; set; }
    }
}
