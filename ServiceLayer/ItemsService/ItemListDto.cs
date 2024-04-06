using DataLayer.Entity;
namespace ServiceLayer.ItemsService;

public class ItemsListDto
{
    public int ItemId { get; set; }
    
    public string Name { get; set; }
    
    public decimal Price { get; set; }
    
    public decimal? PossiblePrice { get; set; }
    
    public decimal? PriceDelta { get; set; }
    
    public bool Usefull { get; set; }
    
    public string? Description { get; set; }
    
    public DateTime Date { get; set; }
    
    public ICollection<Tag>? Tags { get; set; }
}