namespace ME.DesignPattern.Main.AbstractFactory
{
    public static class AbstractFactoryRun
    {
        public static void Run()
        {
            INotificationFactory factory = GetNotificationFactoryByOS();

            var notification = new Notification(factory);
            notification.Show("Test First Notification");
        }


        private static INotificationFactory GetNotificationFactoryByOS()
        {
            if (OperatingSystem.IsWindows())
            {
                return new WindowsNotificationFactory();
            }

            if (OperatingSystem.IsLinux())
            {
                return new LinuxNotificationFactory();
            }

            if (OperatingSystem.IsMacOS())
            {
                return new MacOSNotificationFactory();
            }

            throw new NotImplementedException();
        }
    }
}
