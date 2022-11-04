
namespace StoreApp
{
    internal class StoreSetup
    {
        public Store MyStore { get; set; }
      
        // neste: Bytte til en kunde som har empty shopping cart og skal handle i butikken

        public Store CreateShop()
        {
            Console.WriteLine("Welcome! Let's start to setup your new store!");

            // Name the store
            Console.WriteLine("Please enter a name of your new store:");
            string ChosenStoreName = Console.ReadLine();

            // Store Type
            Console.WriteLine("What type of store is it?");
            string StoreType = Console.ReadLine();

            MyStore = new Store(ChosenStoreName, StoreType);

            EmployeeSetup();

            return MyStore;
        }


        // ---------------------- Employees Setup -------------------------
        public void EmployeeSetup()
        {
            int employeeIndex = 0;
            string employeeName = "";
            string employeePosition = "";
            int employeeAge = 0;

            // Number of employees
            Console.WriteLine("How many employees work at your store?");
            int NumberOfEmployees = int.Parse(Console.ReadLine());

            //Add amount of employees to work at the store:
            while (employeeIndex < NumberOfEmployees)
            {

                //Name
                Console.WriteLine("What is the name of your new employee?");
                employeeName = Console.ReadLine();

                //Age
                Console.WriteLine($"Enter {employeeName}'s age:");
                employeeAge = int.Parse(Console.ReadLine());

                //Position
                Console.WriteLine($"What's {employeeName}'s position?");
                employeePosition = Console.ReadLine();
                //add employees to the list
                MyStore.Employees.Add(new Employee(employeeName, employeeAge, employeePosition));
                employeeIndex++;                

            }

            Console.Clear();
            GetEmployeeList(MyStore);
            var itemSetup = new ItemSetup();
            itemSetup.ProductSetup(MyStore);
        }
        // ---------------------------------------------------------------------------

        public void GetEmployeeList(Store MyStore)
        {
            Console.Clear();
            Console.WriteLine("\nYour new store " + MyStore.StoreName + " is of type " + MyStore.StoreType);
            Console.WriteLine("\nAll employees have been registered. Here is a list of them:");
            foreach (var employee in MyStore.Employees)
            {
                Console.WriteLine("\n" + employee.Name + " | " + employee.Age + " | " + employee.Position + "\n");
            }

        }

    }
}