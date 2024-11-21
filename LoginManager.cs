namespace ConsoleApp
{
    public class LoginManager
    {
        private EmployeeManager _employeeManager;

        public LoginManager(EmployeeManager employeeManager)
        {
            _employeeManager = employeeManager;
        }

        public User? Login()
        {
            Console.Clear();
            Console.WriteLine("Login System");
            Console.WriteLine("------------");

            int maxAttempts = 3;
            int attempts = 0;

            while (attempts < maxAttempts)
            {
                Console.Write("Employee ID: ");
                string? userId = Console.ReadLine();
                 if (string.IsNullOrWhiteSpace(userId))
                {
                    Console.WriteLine("Employee ID cannot be empty or null. Please try again.");
                    attempts++;
                    continue;
                }

                Console.Write("Password: ");
                string? password = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(password))
                {
                    Console.WriteLine("Password cannot be empty or null. Please try again.");
                    attempts++;
                    continue;
                }

                // Authenticate Employee
                Employee? employee = _employeeManager.GetEmployees().Find(e => e.EmployeeId == userId);
                if (employee != null && employee.Password == password)
                {
                    return employee; // Return the Employee object if credentials are valid
                }

                // Authenticate Admin
                if (userId == "Admin123" && password == "password123")
                {
                    return new Admin(_employeeManager) { UserId = userId, Name = "Admin" };
                }

                // Invalid login attempt
                attempts++;
                Console.WriteLine($"Incorrect login. Attempt {attempts} of {maxAttempts}.");
                if (attempts < maxAttempts)
                {
                    Console.WriteLine("Please try again.");
                }
                else
                {
                    Console.WriteLine("Maximum attempts reached.");
                }
            }

            return null; 
        }
    }
}
