namespace ME.DesignPattern.Main.AbstractFactory
{
    internal class WindowsAlertNotification : IAlertNotification
    {
        public void Show(string message)
        {
            Console.WriteLine($"[Windows OS] {message}");
        }
    }
}
