
using System.Security.Claims;
using DataLayer.Context;
using Microsoft.AspNetCore.Mvc;
using ServiceLayer.DAL.Repositories;
using ServiceLayer.UserService;
using DataLayer.Entity;
using ServiceLayer.ItemsService.QueryObjects;
using ServiceLayer.UserService.Interfaces;

namespace MoneyTracking.Controllers;

public class ItemsController(ItemsRepository itemsRepository, TrackingContext db, UserRepository userRepository, IUserService userService): Controller
{
   public IActionResult Index()
   {
      var items = db.Items.MapItemToDto();
      return View();
   }

   public IActionResult CreateItem()
   {
      return View();
   }
}