
using Microsoft.EntityFrameworkCore;
using static System.Net.WebRequestMethods;

public class GetProductByName {

  public static string Route => "{productName}";

  public static string[] Methods => new string[] {Http.Get.ToString()};

  public static Delegate Handler => HandlerAction;


  public static IResult HandlerAction(string productName, AppDbContext db) {

    var product = db.Products
    .Where(n => n.Name == productName).ToList();

    if (product is  not null)
    {
      return Results.Ok(product);
    } else {

      return Results.NotFound($"Not found any {productName}");

    }

  }



}