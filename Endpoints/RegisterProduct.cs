using static System.Net.WebRequestMethods;

public class RegisterProduct {

  public static string Route => "/";
  public static string[] Methods => new string[] {Http.Post.ToString()};
  public static Delegate Handler => HandlerAction;

  private static IResult HandlerAction(ProductTO p, AppDbContext db){

    db.Products.Add(new Product(p.id,p.Name, p.Price));
    db.SaveChanges();

    return Results.Ok();
  
  }

}