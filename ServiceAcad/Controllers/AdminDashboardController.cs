using Microsoft.AspNetCore.Mvc;

public class AdminDashboardController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
    public IActionResult Management()
    {
        return View();
    }

    public IActionResult ContentLibrary()
    {
        return View();
    }

    public IActionResult Permissions()
    {
        return View();
    }

    public IActionResult Analytics()
    {
        return View();
    }
}

