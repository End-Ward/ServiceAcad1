using Microsoft.AspNetCore.Mvc;

public class StudentDashboardController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}
