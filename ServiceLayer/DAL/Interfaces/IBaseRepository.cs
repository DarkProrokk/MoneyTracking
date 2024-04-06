using DataLayer.Context;
namespace ServiceLayer.DAL.Interfaces;

public interface IBaseRepository<TEntity>: IDisposable where TEntity: class
{
    TEntity? Get(int id);
    void Insert(TEntity entity);
    void Update(TEntity entity);
    void Delete(int id);
    void Save();
}