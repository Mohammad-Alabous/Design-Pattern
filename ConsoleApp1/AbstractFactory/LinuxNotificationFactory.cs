namespace ME.DesignPattern.Main.AbstractFactory
{
    public class LinuxNotificationFactory : INotificationFactory
    {
        public IAlertNotification CreateAlertNotification()
        {
            return new LinuxAlertNotification();
        }

        public IToastNotification CreateToastNotification()
        {
            return new LinuxToastNotification();
        }
    }
}
