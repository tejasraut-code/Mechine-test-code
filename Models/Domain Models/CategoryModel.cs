using System.ComponentModel.DataAnnotations;

namespace Mechine_Test_Code.Models.Domain_Models
{
    public class CategoryModel
    {
        [Key]
        public int CategoryId { get; set; }
        [Required]
        public string CategoryName { get; set; } = string.Empty;

        public string Description { get; set; } = string.Empty;
        public string Image { get; set; } = string.Empty;

        public List<ServiceModel> services { get; set; } = new List<ServiceModel>();
    }
}
