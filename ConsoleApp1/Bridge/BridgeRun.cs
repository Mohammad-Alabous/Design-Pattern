namespace ME.DesignPattern.Main.Bridge
{
    public static class BridgeRun
    {
        public static void Run()
        {
            IRenderer vectorRenderer = new VectorRenderer();
            Shape circle = new Circle(vectorRenderer);
            circle.Draw();

            IRenderer rasterRenderer = new RasterRenderer();
            Shape square = new Square(rasterRenderer);
            square.Draw();
        }
    }
}
