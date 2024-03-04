public class DeleteAllProducts {
    public static string Route => "/";
    public static string[] Methods => new string[] { "DELETE" };
    public static Delegate Handler => new Func<AppDbContext, IResult>(HandlerAction);

    private static IResult HandlerAction(AppDbContext db) {
        try {            
            db.Products.RemoveRange(db.Products);
            db.SaveChanges();
            return Results.NoContent();

        } catch (Exception e) {            
            return Results.NotFound(e);
        }
    }
}
