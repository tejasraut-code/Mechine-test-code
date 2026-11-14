using System.Diagnostics;
using System.Threading.Tasks;
using Mechine_Test_Code.Data;
using Mechine_Test_Code.Models;
using Mechine_Test_Code.Models.Domain_Models;
using Mechine_Test_Code.Models.View_Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace Mechine_Test_Code.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private readonly AppDbContext _context;
        public HomeController(ILogger<HomeController> logger, AppDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> Index(int? SelectedCategoryId)
        {
            string CategoryName = "All Category";
            ServiceViewIndexModel serviceViewIndex = new ServiceViewIndexModel();
            if(SelectedCategoryId != null)
            {
                var category = await _context.Category.FindAsync(SelectedCategoryId);
                if(category == null)
                {
                    return NotFound();
                }
                serviceViewIndex.CategoryName = category.CategoryName;
            }

            serviceViewIndex.SelectedCategoryId = SelectedCategoryId;
            serviceViewIndex.CategoryOption = await _context.Category.Select(x => new SelectListItem
            {
                Text = x.CategoryName,
                Value = x.CategoryId.ToString()
            }).ToListAsync();

            List<ServiceModel>? servicesList = await _context.Services.Include(x => x.Category).Where( x=> SelectedCategoryId == null || x.CategoryId == SelectedCategoryId).ToListAsync();
            foreach (var item in servicesList)
            {
                ServiceViewModel serviceView = new ServiceViewModel();
                serviceView.ServiceName = item.ServiceName;
                serviceView.category.CategoryName = item.Category!.CategoryName;
                serviceView.CategoryId = item.Category.CategoryId;
                serviceView.Description = item.Description;
                serviceView.Price = item.Price;

                serviceViewIndex.Services.Add(serviceView);
            }
            
            return View(serviceViewIndex);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
