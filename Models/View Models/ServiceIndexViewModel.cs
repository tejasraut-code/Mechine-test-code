using Microsoft.AspNetCore.Mvc.Rendering;

namespace Mechine_Test_Code.Models.View_Models
{
    public class ServiceIndexViewModel
    {
        public int? SelectedCategoryId { get; set; }

        public List<SelectListItem> CategoryOption { get; set; } = new List<SelectListItem>();
        public List<ServiceViewModel> serviceViews { get; set; } = new List<ServiceViewModel>();
    }
}
