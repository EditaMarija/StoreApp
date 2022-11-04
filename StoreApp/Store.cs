
namespace StoreApp
{
    internal class Store
    {
        public string StoreName { get; set; }

        public string StoreType { get; set; }
        public List<Employee> Employees { get; set; }

        public List<Item> ItemsList { get; set; }

        public Store(string name, string storeType)
        {
            StoreName = name;
            StoreType = storeType;
            Employees = new List<Employee>();
            ItemsList = new List<Item>();

        }

    }
}