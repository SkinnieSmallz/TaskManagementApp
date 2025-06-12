using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace TaskManagement.Web.Controllers
{
    [Authorize] // ensures only logged in users can access
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
