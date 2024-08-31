using Microsoft.AspNetCore.Mvc;

namespace ServiceAcad.Controllers
{
    public class HomeController : Controller
    {
        // Action method for the homepage
        public IActionResult Index()
        {
            return View();
        }

        // Action method for a Programs page
        public IActionResult ListPrograms()
        {
            return View();
        }

        // Action method for a Contact Us page
        public IActionResult Contact()
        {
            return View();
        }

        // Action method for FAQs page
        public IActionResult FAQs()
        {
            return View();
        }

        // Error handling action
        public IActionResult Error()
        {
            return View();
        }
    }
}
