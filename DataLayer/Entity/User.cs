using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;
namespace DataLayer.Entity;

public class User: IdentityUser
{
    public List<Item> Items { get; set; }
}