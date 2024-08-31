using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

public class AccountController : Controller
{
    private readonly UserManager<ApplicationUser> _userManager;
    private readonly SignInManager<ApplicationUser> _signInManager;

    public AccountController(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager)
    {
        _userManager = userManager;
        _signInManager = signInManager;
    }

    // Registration View
    public IActionResult Register() => View();

    [HttpPost]
    public async Task<IActionResult> Register(RegisterViewModel model)
    {
        if (ModelState.IsValid)
        {
            var user = new ApplicationUser { UserName = model.Email, Email = model.Email, FullName = model.FullName, Role = model.Role };
            var result = await _userManager.CreateAsync(user, model.Password);

            if (result.Succeeded)
            {
                await _userManager.AddToRoleAsync(user, model.Role);
                await _signInManager.SignInAsync(user, isPersistent: false);

                TempData["SuccessMessage"] = "Registration successful!";
                return RedirectToAction("Dashboard", model.Role);
            }
            foreach (var error in result.Errors)
            {
                ModelState.AddModelError(string.Empty, error.Description);
            }
        }
        return View(model);
    }


    // Login View
    public IActionResult Login() => View();

    [HttpPost]
    public async Task<IActionResult> Login(LoginViewModel model)
    {
        if (ModelState.IsValid)
        {
            var result = await _signInManager.PasswordSignInAsync(model.Email, model.Password, model.RememberMe, false);

            if (result.Succeeded)
            {
                var user = await _userManager.FindByEmailAsync(model.Email);
                if (user != null)
                {
                    var roles = await _userManager.GetRolesAsync(user);
                    var role = roles.FirstOrDefault(); // Assuming a single role per user
                    return RedirectToAction("Dashboard", new { role = role });
                }
            }

            ModelState.AddModelError(string.Empty, "Invalid login attempt.");
        }
        return View(model);
    }

    public async Task<IActionResult> Logout()
    {
        await _signInManager.SignOutAsync();
        return RedirectToAction("Login");
    }

    // Role-based dashboard redirection
    public IActionResult Dashboard(string role)
    {
        switch (role)
        {
            case "Admin":
                return RedirectToAction("Index", "AdminDashboard");
            case "Instructor":
                return RedirectToAction("Index", "InstructorDashboard");
            case "Student":
                return RedirectToAction("Index", "StudentDashboard");
            default:
                return RedirectToAction("Index", "Home");
        }
    }
}
