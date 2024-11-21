namespace ConsoleApp
{
    public abstract class User
    {
        public string? UserId { get; set; }
        public string? Name { get; set; }

        // Abstract method to display dashboard
        public abstract void ShowDashboard();
    }
}
