
namespace StoreApp
{
    internal class ItemSetup
    {
        public Item ItemList { get; set; }

        public void ProductSetup(Store MyStore)
        {
            int productIndex = 0;
            string productName = "";
            string productType = "";
            int productPrice = 0;
            int productCount = 0;

            // Number of items
            Console.Clear();
            Console.WriteLine("How many different items are you selling at your store?");
            int NumberOfProducts = int.Parse(Console.ReadLine());

            //Add items to the store:
            while (productIndex < NumberOfProducts)
            {
                //Name
                Console.WriteLine("What is the name of your product?");
                productName = Console.ReadLine();

                //Price
                Console.WriteLine($"Enter {productName}'s price:");
                productPrice = int.Parse(Console.ReadLine());

                //Type
                Console.WriteLine($"What's the product's type?");
                productType = Console.ReadLine();

                //Count
                Console.WriteLine($"How many of {productName} in stock?");
                productCount = int.Parse(Console.ReadLine());

                //add items to the list
                MyStore.ItemsList.Add(new Item(productName, productType, productPrice, productCount));
                productIndex++;

                Console.Clear();

            }

            Console.WriteLine("List of all products: ");
         
            foreach (var product in MyStore.ItemsList)
            {              
                Console.WriteLine("\nProduct: " + product.ProductName + " | Type: " + product.ProductType + " | Price: " + product.ProductPrice + " | In stock: " + product.ProductCount);
                Console.WriteLine();

            }

         

        }


    }


}