using Microsoft.EntityFrameworkCore;
using Store.API.Models;

namespace Store.API.Context;

public class ItemContext : DbContext
{
    public ItemContext(DbContextOptions<ItemContext> options) : base(options){}

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Item>(entity =>
        {
            entity.HasKey(e => e.Id);
            entity.Property(e => e.Name);
            entity.Property(e => e.Price);
        });

        
    }
}