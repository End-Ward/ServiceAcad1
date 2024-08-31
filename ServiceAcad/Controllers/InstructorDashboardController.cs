using Microsoft.AspNetCore.Mvc;

public class InstructorDashboardController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
    public IActionResult Analytics()
    {
        return View();
    }
    public IActionResult CreateCourse()
    {
        return View();
    }

    public IActionResult ManageStudents()
    {
        return View();
    }
}
