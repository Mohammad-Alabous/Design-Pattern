namespace ME.DesignPattern.Main.Bridge
{
    public class RasterRenderer : IRenderer
    {
        public void Render(string shapeType)
        {
            Console.WriteLine($"{nameof(RasterRenderer)}: {shapeType}");
        }
    }
}
