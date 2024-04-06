using System.Diagnostics.Eventing.Reader;
using System.Linq;
using DataLayer.Entity;

namespace ServiceLayer.ItemsService.QueryObjects;

public static class ItemsListDtoSelect
{
    public static IQueryable<ItemsListDto> MapItemToDto(this IQueryable<Item> items)
    {
        return items.Select(item => new ItemsListDto
        {
            ItemId = item.ItemId,
            Name = item.Name,
            Price = item.Price,
            PossiblePrice = item.PossiblePrice,
            PriceDelta = item.PossiblePrice == null
                ? 0
                : (item.Price - item.PossiblePrice),
            Usefull = item.Usefull,
            Description = item.Description,
            Date = item.Date,
            Tags = item.Tags
        });
    }
}