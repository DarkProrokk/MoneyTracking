using System.Security.Claims;
using Microsoft.AspNetCore.Http;
using ServiceLayer.UserService.Interfaces;

namespace ServiceLayer.UserService;

public class UserService(IHttpContextAccessor httpContext): IUserService
{
    private readonly IHttpContextAccessor _httpcontext = httpContext;
    
    public string GetUserId()
    {
        return _httpcontext.HttpContext.User?.FindFirst(ClaimTypes.NameIdentifier)?.Value;
    }

}