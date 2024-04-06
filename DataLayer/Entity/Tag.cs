namespace DataLayer.Entity;

public class Tag
{
    public int TagId { get; set; }
    
    public string Name { get; set; }
    
    public ICollection<Item> Items { get; set; }
}