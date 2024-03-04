public class ProductsEndPoints {

  public RouteGroupBuilder builder;

  public ProductsEndPoints (RouteGroupBuilder b){

    builder = b;
    SetupEndpoints();


  }


  void SetupEndpoints (){

    builder.MapMethods(RegisterProduct.Route, RegisterProduct.Methods, RegisterProduct.Handler);
    builder.MapMethods(GetAllProduct.Route, GetAllProduct.Methods, GetAllProduct.Handler);
    builder.MapMethods(GetProductByName.Route, GetProductByName.Methods, GetProductByName.Handler);
    builder.MapMethods(UpdadeProduct.Route, UpdadeProduct.Methods, UpdadeProduct.Handler);
    builder.MapMethods(DeleteAllProducts.Route, DeleteAllProducts.Methods, DeleteAllProducts.Handler);
  

  }

}