using System.ComponentModel.DataAnnotations;

namespace Mechine_Test_Code.Models.View_Models
{
    public class CategoryViewModel
    {
        public int CategoryId { get; set; }
        [Required]
        public string CategoryName { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string Image { get; set; } = string.Empty;
    }
}
