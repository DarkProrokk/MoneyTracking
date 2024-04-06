using System.ComponentModel.DataAnnotations;
using DataLayer.Entity;
using ServiceLayer.DAL.Interfaces;
using DataLayer.Context;
using Microsoft.Extensions.Logging;

namespace ServiceLayer.DAL.Repositories;

public class ItemsRepository : IItemsRepository
{
    private TrackingContext context;

    public ItemsRepository(TrackingContext context)
    {
        this.context = context;
    }

    public IEnumerable<Item> GetAllItems() => context.Items;
    public Item? Get(int id)
    {
        return context.Items.Find(id);
    }

    public void Insert(Item item)
    {
        context.Items.Add(item);
    }

    public void Update(Item item)
    {
        context.Items.Update(item);
    }

    public void Delete(int id)
    {
        Item? item = Get(id);
        if (item != null)
        { 
            context.Items.Remove(Get(id));
        }
    }
    
    public void Save()
    {
        try
        {
            context.SaveChanges();
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
    
    
    
    
    
    
    
    
    private bool disposed = false;

    protected virtual void Dispose(bool disposing)
    {
        if (!this.disposed)
        {
            if (disposing)
            {
                context.Dispose();
            }
        }
        this.disposed = true;
    }

    public void Dispose()
    {
        Dispose(true);
        GC.SuppressFinalize(this);
    }
}