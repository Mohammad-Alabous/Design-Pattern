namespace ME.DesignPattern.Main.AbstractFactory
{
    public class MacOSToastNotification : IToastNotification
    {
        public void Show(string message)
        {
            Console.WriteLine($"[Mac OS] {message}");
        }
    }
}
