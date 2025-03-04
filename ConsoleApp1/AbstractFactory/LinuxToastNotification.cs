namespace ME.DesignPattern.Main.AbstractFactory
{
    public class LinuxToastNotification : IToastNotification
    {
        public void Show(string message)
        {
            Console.WriteLine($"[Linux OS] {message}");
        }
    }
}
