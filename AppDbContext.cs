using Microsoft.EntityFrameworkCore;

public class AppDbContext : DbContext
{   
    public DbSet<Product> Products {get; set;}
    
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        base.OnConfiguring(optionsBuilder);
        optionsBuilder.UseSqlServer(
            "Server=DESKTOP-VM87J8V;"
            + "User id=dm113;"
            + "Password=dm113;"
            + "Database=ProductDB;"
            + "Trusted_Connection=True;"
            + "encrypt=false");
    }
}