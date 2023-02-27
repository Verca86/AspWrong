using Microsoft.AspNetCore.Mvc;

namespace AspBlog.Controllers
{
    public class UsersController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
