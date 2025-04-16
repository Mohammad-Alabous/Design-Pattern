namespace ME.DesignPattern.Main.Adapter
{
    public class ThirdPartyLogger
    {
        public void WriteLog(string message)
        {
            Console.WriteLine(message);
        }
    }
}
