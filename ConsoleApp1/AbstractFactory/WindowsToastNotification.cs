namespace ME.DesignPattern.Main.AbstractFactory
{
    public class WindowsToastNotification : IToastNotification
    {
        public void Show(string message)
        {
            Console.WriteLine($"[Windows OS] {message}");
        }
    }
}
