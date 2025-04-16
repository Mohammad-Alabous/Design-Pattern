namespace ME.DesignPattern.Main.Adapter
{
    public class LoggerAdapter : ILogger
    {
        ThirdPartyLogger thirdPartyLogger = new ThirdPartyLogger();
        public void Log(string message)
        {
            thirdPartyLogger.WriteLog(message);
        }
    }
}
