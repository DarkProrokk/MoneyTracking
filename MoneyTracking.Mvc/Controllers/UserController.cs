using DataLayer.Context;
using DataLayer.Entity;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using ServiceLayer.UserService;

namespace MoneyTracking.Controllers;

public class UserController(UserService userService, TrackingContext context): Controller
{
    public IActionResult Index()
    {
        var id =  userService.GetUserId();
        var user = context.Users.FirstOrDefault(user => user.Id == id);
        return View();
    }
}