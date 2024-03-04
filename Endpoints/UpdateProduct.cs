using System.Runtime.CompilerServices;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.EntityFrameworkCore;
using static System.Net.WebRequestMethods;

public class UpdadeProduct{

  public static string Route => "/";

  public static string[] Methods => new string[] {Http.Put.ToString()};
  public static Delegate Handler => HandlerAction;

  
    
    public  static IResult HandlerAction(Product productUpdate, AppDbContext db) {
    var productOld = db.Products.Find(productUpdate.Id);
    
    if (productOld is not null) {

      if (productOld.Name != productUpdate.Name || productOld.Price != productUpdate.Price ) {
          
          db.Products.Update(productOld);
          productOld.Name = productUpdate.Name;
          productOld.Price = productUpdate.Price;
          db.SaveChanges();

          return Results.Ok(productOld);
          } 


    }
    
    
    return Results.NotFound("Product Not Found");
    
      
  }
}
