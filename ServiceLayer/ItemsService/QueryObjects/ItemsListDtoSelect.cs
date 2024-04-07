using System.Diagnostics.Eventing.Reader;
using System.Linq;
using DataLayer.Entity;
using ServiceLayer.UserService.Interfaces;

namespace ServiceLayer.ItemsService.QueryObjects;

public static class ItemsListDtoSelect
{
    public static IQueryable<ItemsListDto> MapItemToDto(this IQueryable<Item> items, IUserService userService)
    {
        return items.Select(item => new ItemsListDto
        {
            ItemId = item.ItemId,
            Name = item.Name,
            Price = item.Price,
            PossiblePrice = item.PossiblePrice,
            PossibleUseful = item.PossibleUsefull,
            PriceDelta = item.PossiblePrice == null
                ? 0
                : (item.PossiblePrice - item.Price),
            Usefull = item.Usefull,
            Description = item.Description,
            Date = item.Date,
            Tags = item.Tags,
            User = item.User.Id
        }).Where(item => item.User == userService.GetUserId());
    }
}