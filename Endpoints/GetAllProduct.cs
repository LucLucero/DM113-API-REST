using Microsoft.AspNetCore.Http.HttpResults;
using static System.Net.WebRequestMethods;

public class GetAllProduct{

  public static string Route => "/";

  public static string[] Methods => new string[] {Http.Get.ToString()};
  public static Delegate Handler => HandlerAction;

  
    
    public static IResult HandlerAction(AppDbContext db) {
    var products = db.Products.ToList();

    if (products != null && products.Count > 0) {
      return Results.Ok(products);
    } else {
      return Results.NotFound("Empty List, No Products was registered");
    }
  }
}

