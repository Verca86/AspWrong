using Microsoft.AspNetCore.Mvc;

namespace AspWrong.Controllers
{
    public class UsersController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
