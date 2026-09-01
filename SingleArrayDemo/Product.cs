using System.ComponentModel.DataAnnotations;

namespace ProductSize ;
public class Product
{
    public int Id{get; set;}
    public String Name{get; set;}
    public double Price{get; set;}

    public Product(int id,string name,double price)
    {
        Id = id;
        Name = name;
        Price = price;
    }

}
        