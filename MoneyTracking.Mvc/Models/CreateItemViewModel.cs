using DataLayer.Entity;
namespace MoneyTracking.Models;


public class CreateItemViewModel
{
    public Item Item { get; set; }
    public IEnumerable<Tag> Tags { get; set; }
}
