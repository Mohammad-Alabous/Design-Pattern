namespace ME.DesignPattern.Main.AbstractFactory
{
    public class LinuxAlertNotification : IAlertNotification
    {
        public void Show(string message)
        {
            Console.WriteLine($"[Linux OS] {message}");
        }
    }
}
