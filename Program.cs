using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main()
        {
            EmployeeManager employeeManager = new EmployeeManager();
            employeeManager.AddEmployee(new Employee
            {
                EmployeeId = "EMP123",
                Name = "Harikaran",
                Position = "Trainee",
                Department = "TA",
                Email = "hari@gmail.com",
                Password = "password123"
            });

            
            LoginManager loginManager = new LoginManager(employeeManager);

            
            User? loggedInUser = loginManager.Login();

            
            if (loggedInUser != null)
            {
                loggedInUser.ShowDashboard();
            }
            else
            {
                Console.WriteLine("Login failed.");
            }

            Console.WriteLine("Login");
            Console.ReadKey();
        }
    }
}
