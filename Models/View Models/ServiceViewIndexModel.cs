using Microsoft.AspNetCore.Mvc.Rendering;

namespace Mechine_Test_Code.Models.View_Models
{
    public class ServiceViewIndexModel
    {
        public int? SelectedCategoryId { get; set; }
        public string CategoryName { get; set; } = string.Empty;
        public string SearchServiceName { get; set; } = string.Empty;

        public List<SelectListItem> CategoryOption { get; set; } = new List<SelectListItem>();
        public List<ServiceViewModel> Services { get; set; } = new List<ServiceViewModel>();
    }
}
