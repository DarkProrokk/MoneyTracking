namespace DataLayer.Entity;
using System.ComponentModel.DataAnnotations.Schema;

public class Item
{
    public int ItemId { get; set; }

    public string Name { get; set; }
    
    public decimal Price { get; set; }
    
    public decimal? PossiblePrice { get; set; }

    public bool Usefull { get; set; }
    
    public bool? PossibleUsefull { get; set; }
    
    public string? Description { get; set; }
    
    public DateTime Date { get; set; }
    // Relationships
    public ICollection<Tag> Tags {get; set; }
    
    [ForeignKey("User")]
    public string UserId { get; set; }

    public User User { get; set; } = null!;
}