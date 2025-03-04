namespace ME.DesignPattern.Main.AbstractFactory
{
    public class MacOSNotificationFactory : INotificationFactory
    {
        public IAlertNotification CreateAlertNotification()
        {
            return new MacOSAlertNotification();
        }

        public IToastNotification CreateToastNotification()
        {
            return new MacOSToastNotification();
        }
    }
}
