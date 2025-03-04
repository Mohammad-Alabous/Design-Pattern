namespace ME.DesignPattern.Main.AbstractFactory
{
    public class WindowsNotificationFactory : INotificationFactory
    {
        public IAlertNotification CreateAlertNotification()
        {
            return new WindowsAlertNotification();
        }

        public IToastNotification CreateToastNotification()
        {
            return new WindowsToastNotification();
        }
    }
}
