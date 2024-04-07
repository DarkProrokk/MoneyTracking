using MoneyTracking.Models;
using DataLayer.Context;
using DataLayer.Entity;
using Microsoft.AspNetCore.Mvc;
using ServiceLayer.DAL.Repositories;
using ServiceLayer.ItemsService.QueryObjects;
using ServiceLayer.UserService.Interfaces;

namespace MoneyTracking.Controllers;

public class ItemsController(ItemsRepository itemsRepository, TrackingContext db, UserRepository userRepository, IUserService userService): Controller
{
   [HttpGet]
   public IActionResult CreateItem()
   {
      
      var viewModel = new CreateItemViewModel
      {
         Item = new Item
         {
            UserId = userService.GetUserId()
         },
         Tags = db.Tags
      };
      
      return View(viewModel);
   }

   public IActionResult Index()
   {
      
      return View(db.Items.MapItemToDto(userService));
   }

   public IActionResult Create(CreateItemViewModel model)
   {
      return Redirect($"Home/Index/");
   }
}