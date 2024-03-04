using System.Data.Common;

namespace WebAppDb;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);
        builder.Services.AddDbContext<AppDbContext>();
        builder.Services.AddAuthorization();
        builder.Services.AddEndpointsApiExplorer();

        var app = builder.Build();
        var routeGroup = app.MapGroup("products");
        new ProductsEndPoints(routeGroup);
        
        app.Run();
    }
}
