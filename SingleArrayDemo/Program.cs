using ProductSize;
 
 class Program
{
    public static void Main(String[ ]args)
    {
        Product[] products = new Product[5]
        {
            new Product(101, "Mouse", 500),
            new Product(102, "Keyboard", 800),
            new Product(103, "Monitor", 7000),
            new Product(104, "Laptop", 55000),
            new Product(105, "Pen Drive", 700)
        };
    
        for (int i = 0;i<products.Length;i++)
        {
            Console.WriteLine($"protuctdetail :{products[i].Id}, {products[i].Name}, {products[i].Price}");
        }
    

    
    }
}
