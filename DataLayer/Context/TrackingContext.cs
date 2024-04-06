using DataLayer.Entity;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
namespace DataLayer.Context;

public class TrackingContext(DbContextOptions<TrackingContext> options): DbContext(options)
{
    public DbSet<Item?> Items { get; set; }
    
    public DbSet<Tag> Tags { get; set; }

    public DbSet<User?> Users { get; set; }
    
    public DbSet<IdentityUserClaim<string>> UserClaims { get; set; }
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Item>()
            .HasOne(i => i.User)
            .WithMany(u => u.Items)
            .HasForeignKey(i => i.UserId)
            .OnDelete(DeleteBehavior.Cascade);
        
        modelBuilder.Entity<IdentityUserClaim<string>>().ToTable("UserClaims");
    }  
    
}