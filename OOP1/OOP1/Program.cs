namespace OOP1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product[] products = new Product[3];
            products[0] = new Product(500, "Lenovo", "PS928719", "leptop");
            products[1] = new Product(950, "Creed", "AC828188", "Parfume");
            products[2] = new Product(37500, "Malibu XL", "XL2257911", "Car");
            foreach (Product p in products)
            {
                p.DisplayInfo();
            }
            CalculateTotal(products);
        }

        static void CalculateTotal(Product[] products)
        {
            decimal total = 0;
            foreach (Product product in products)
            {
                total += product.Price;
            }
            Console.WriteLine("Total price: " + total);

        }  
    }
    class Product
    {
        public decimal Price { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public string Category { get; set; }

        public Product()
        {

        }

        public Product(decimal price, string name)
        {
            Price = price;
            Name = name;
        }

        public Product(decimal price, string name, string code, string category)
        {
            Price = price;
            Name = name;
            Code = code;
            Category = category;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Price: {Price}, Name: {Name}, Code: {Code}, Category: {Category}");
        }

    }
}