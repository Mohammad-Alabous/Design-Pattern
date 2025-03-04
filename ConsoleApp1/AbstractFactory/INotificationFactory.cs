namespace ME.DesignPattern.Main.AbstractFactory
{
    public interface INotificationFactory
    {
        IToastNotification CreateToastNotification();
        IAlertNotification CreateAlertNotification();
    }
}
