namespace ConsoleApp
{
    public class Employee : User
    {
        public string? EmployeeId { get; set; }
        public string? Position { get; set; }
        public string? Department { get; set; }
        public string? Email { get; set; }
        public string? Password { get; set; } // Adding Password to Employee for Authentication

        public override void ShowDashboard()
        {
            Console.Clear();
            Console.WriteLine("Employee Dashboard");
            Console.WriteLine("-------------------");
            Console.WriteLine("1. View Profile");
            Console.WriteLine("2. View Assigned Tasks");
            Console.WriteLine("3. Logout");
            Console.Write("Please select an option: ");
            string? option = Console.ReadLine();

            switch (option)
            {
                case "1":
                    ShowEmployeeProfile();
                    break;
                case "2":
                    ShowAssignedTasks();
                    break;
                case "3":
                    Console.WriteLine("Logging out...");
                    break;
                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    ShowDashboard();
                    break;
            }
        }

        private void ShowEmployeeProfile()
        {
            Console.Clear();
            Console.WriteLine("Employee Profile");
            Console.WriteLine("-----------------");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Position: {Position}");
            Console.WriteLine($"Department: {Department}");
            Console.WriteLine($"Email: {Email}");
            Console.WriteLine("Press 1 > Go Back");
            string? option = Console.ReadLine();

            switch (option)
            {
                case "1":
                ShowDashboard();
                break;
                default:
                Console.WriteLine("Invalid option. Please try again.");
                ShowEmployeeProfile();
                break;
            }
        }

        private void ShowAssignedTasks()
        {
            Console.Clear();
            Console.WriteLine("Assigned Tasks");
            Console.WriteLine("--------------");
            Console.WriteLine("1. Collect Requirements");
            Console.WriteLine("2. Console application");
            Console.WriteLine("3. Attend team meeting");
            Console.WriteLine("Press 1 > Go Back");
            string? option = Console.ReadLine();

            switch (option)
            {
                case "1":
                ShowDashboard();
                break;
                default:
                Console.WriteLine("Invalid option. Please try again.");
                ShowAssignedTasks();
                break;
            }
        }
    }
}
