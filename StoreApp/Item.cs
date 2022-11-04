
namespace StoreApp
{
    internal class Item
    {
        public string ProductName { get; set; }
        public string ProductType { get; set; }
        public int ProductPrice { get; set; }
        public int ProductCount { get; set; }

        public Item(string productName, string productType, int productPrice, int productCount)
        {
            ProductName = productName;
            ProductType = productType;
            ProductPrice = productPrice;
            ProductCount = productCount;
        }
    }
}