using System.ComponentModel.DataAnnotations;

namespace ServiceLayer.ItemsService.QueryObjects;

public enum ItemsFilterBy
{
    [Display(Name = "All")] NoFilter = 0,
    [Display(Name = "По цене..")] ByPrice,
    [Display(Name = "По тегам...")] ByTags,
    [Display(Name = "По полезности... ")] ByUseFul
}

public static class ItemListDtoFilter
{
    public static IQueryable<ItemsListDto> FilterItemsBy(
        this IQueryable<ItemsListDto> items,
        ItemsFilterBy filterBy,
        string filterValue)
    {
        if (string.IsNullOrEmpty(filterValue))
            return items;
        switch (filterBy)
        {
            case ItemsFilterBy.NoFilter:
                return items;
            case ItemsFilterBy.ByPrice:
                return items;
            case ItemsFilterBy.ByTags:
                return items;
            case ItemsFilterBy.ByUseFul:
                return items;
            default:
                throw new ArgumentOutOfRangeException(
                    nameof(filterBy), filterBy, null);
        }
    }
}