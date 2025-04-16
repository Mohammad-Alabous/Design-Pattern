namespace ME.DesignPattern.Main.Adapter
{
    public static class AdapterRun
    {
        public static void Run()
        {
            LoggerAdapter loggerAdapter = new LoggerAdapter();

            loggerAdapter.Log("Message From LoggerAdapter!");
        }
    }
}
