using Microsoft.EntityFrameworkCore;

namespace purpura_inventory.Infrastructure.Persistence;

public class InventoryContext : DbContext
{
    public InventoryContext(DbContextOptions<InventoryContext> options) : base(options)
    {
        
    }
}