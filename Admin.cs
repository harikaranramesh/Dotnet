namespace ConsoleApp
{
    public class Admin : User
    {
        private EmployeeManager _employeeManager;

        public Admin(EmployeeManager employeeManager)
        {
            _employeeManager = employeeManager;
        }

        public override void ShowDashboard()
        {
            Console.Clear();
            Console.WriteLine("Admin Dashboard");
            Console.WriteLine("----------------");
            Console.WriteLine("1. View Employee List");
            Console.WriteLine("2. Add New Employee");
            Console.WriteLine("3. Logout");
            Console.Write("Please select an option: ");
            string? option = Console.ReadLine();

            switch (option)
            {
                case "1":
                    ViewEmployeeList();
                    break;
                case "2":
                    AddNewEmployee();
                    break;
                case "3":
                    Console.WriteLine("Logging out...");
                    break;
                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }
        }

        private void ViewEmployeeList()
        {
            Console.Clear();
            Console.WriteLine("Employee List");
            Console.WriteLine("-------------");
            foreach (var employee in _employeeManager.GetEmployees())
            {
                Console.WriteLine($"ID: {employee.EmployeeId}, Name: {employee.Name}, Position: {employee.Position}");
            }
            Console.WriteLine("Press any key to go back.");
            Console.ReadKey();
        }

        private void AddNewEmployee()
        {
            Console.Clear();
            Console.WriteLine("Add New Employee");
            Console.WriteLine("-----------------");

            Console.Write("Employee ID: ");
            string? empId = Console.ReadLine();
            Console.Write("Name: ");
            string? name = Console.ReadLine();
            Console.Write("Position: ");
            string? position = Console.ReadLine();
            Console.Write("Department: ");
            string? department = Console.ReadLine();
            Console.Write("Email: ");
            string? email = Console.ReadLine();
            Console.Write("Password: ");
            string? password = Console.ReadLine();

            var newEmployee = new Employee
            {
                UserId = empId,
                Name = name,
                Position = position,
                Department = department,
                Email = email,
                Password = password
            };

            _employeeManager.AddEmployee(newEmployee);
            Console.WriteLine("Employee added successfully!");
            ShowDashboard();
        }
    }
}
