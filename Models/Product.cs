public class Product {

  public int Id {get; set;}
  public string Name {get; set;}
  public double Price {get; set;}


    public Product() {
        // Construtor sem parâmetros, necessário para o Entity Framework Core
    }

    public Product(int i, string n, double p){

    this.Id = i;
    this.Name = n;
    this.Price = p;


  }

}