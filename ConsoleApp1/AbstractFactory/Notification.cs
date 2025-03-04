namespace ME.DesignPattern.Main.AbstractFactory
{
    public class Notification
    {
        private readonly IToastNotification _toastNotification;
        private readonly IAlertNotification _alertNotification;

        public Notification(INotificationFactory notificationFactory)
        {
            _toastNotification = notificationFactory.CreateToastNotification();
            _alertNotification = notificationFactory.CreateAlertNotification();
        }

        public void Show(string message)
        {
            _toastNotification.Show(message);
            _alertNotification.Show(message);
        }
    }
}
