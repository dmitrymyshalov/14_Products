namespace Products
{
    public enum ProductCategories
    {
        Food,
        Appliances
    }

    public class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public string Picture { get; set; }
        public ProductCategories Category { get; set; }
    }
}