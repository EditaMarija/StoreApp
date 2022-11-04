namespace StoreApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            
            var functions = new StoreSetup();
            var myStore = functions.CreateShop();

        }
    }
}