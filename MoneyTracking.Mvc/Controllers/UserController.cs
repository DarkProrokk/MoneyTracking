using DataLayer.Entity;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace MoneyTracking.Controllers;

public class UserController(UserManager<User> _userManager): Controller
{
    public IActionResult Index()
    {
        List<User> users = _userManager.Users.ToList();
        return View();
    }
}