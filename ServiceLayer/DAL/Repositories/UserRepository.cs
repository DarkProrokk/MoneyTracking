using System.Security.Claims;
using DataLayer.Entity;
using ServiceLayer.DAL.Interfaces;
using DataLayer.Context;
using ServiceLayer.UserService;


namespace ServiceLayer.DAL.Repositories;

public class UserRepository(TrackingContext context): IUserRepository
{
    public User? GetActiveUser(string id)
    {
        //string? username = new CurrentUser().GetActiveUserName();
        User? user = context.Users.FirstOrDefault(x => x.Id == id);
        return user;
    }
}