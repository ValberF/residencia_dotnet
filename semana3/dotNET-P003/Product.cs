namespace Semana3.dotnetP003
{
    public class Product
    {
        public Product(string name, int amount, double price)
        {
            Code = ++productID;
            Name = name;
            Amount = amount;
            Price = price;
        }
        private static int productID { get; set; } = 0;
        public int Code { get; }
        public string Name { get; private set; }
        public int Amount { get; set; }
        public double Price { get; private set; }
    }
}
