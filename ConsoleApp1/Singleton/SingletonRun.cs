namespace ME_Singleton
{
    public static class RunSingleton {
        public static void Run() {
            var settings = SettingsManager.Instance;
            settings.Set("Theme", "Dark");
            settings.Set("Language", "English");

            Console.WriteLine($"Theme: {settings.Get("Theme")}");
            Console.WriteLine($"Language: {settings.Get("Language")}");

            // Another reference should return the same instance
            var settings2 = SettingsManager.Instance;
            settings2.Set("FontSize", "14px");

            Console.WriteLine($"Font Size: {settings.Get("FontSize")}");
        }
    }
}