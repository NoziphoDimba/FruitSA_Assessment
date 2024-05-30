using Microsoft.AspNetCore.Mvc;

namespace ProductManagementAPP.Controllers
{
    public class CategoriesViewController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
