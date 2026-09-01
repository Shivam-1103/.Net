namespace MultiDArray;

public class Product
{
    public int Id { get; set; }
    public string Name { get; set; }
    public double Price { get; set; }

    // Constructor
    public Product(int id, string name, double price)
    {
        Id = id;
        Name = name;
        Price = price;
    }

    public override string ToString()
    {
        return $"Id:{Id}, Name: {Name}, Price : {Price}";
    }
};



class Program
{
    public static void Main(String[] args)
    {
        Product[,] products = new Product[3,3]
        {
            {
                new Product(101, "Mouse", 500),
                new Product(102, "Keyboard", 800),
                new Product(103, "Monitor", 7000)
            },

            {
                new Product(104, "Laptop", 55000),
                new Product(105, "Pen Drive", 700),
                new Product(106, "Webcam", 1500),

            },
            {
                new Product(108, "USB Cable", 300),
                new Product(109, "Charger", 1200),
                new Product(107, "Speaker", 2000)
            }
        };
        foreach (Product product in products)
        {
            Console.WriteLine(product);
        }

    }
}

