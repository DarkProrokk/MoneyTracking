using DataLayer.Entity;
namespace ServiceLayer.DAL.Interfaces;


public interface IItemsRepository: IBaseRepository<Item>
{
    IEnumerable<Item> GetAllItems();
}