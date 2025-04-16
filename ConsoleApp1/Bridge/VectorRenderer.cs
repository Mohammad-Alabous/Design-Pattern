namespace ME.DesignPattern.Main.Bridge
{
    public class VectorRenderer : IRenderer
    {
        public void Render(string shapeType)
        {
            Console.WriteLine($"{nameof(VectorRenderer)}: {shapeType}");
        }
    }
}
