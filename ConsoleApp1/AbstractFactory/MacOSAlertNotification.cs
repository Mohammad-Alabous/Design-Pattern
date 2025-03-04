namespace ME.DesignPattern.Main.AbstractFactory
{
    public class MacOSAlertNotification : IAlertNotification
    {
        public void Show(string message)
        {
            Console.WriteLine($"[Mac OS] {message}");
        }
    }
}
