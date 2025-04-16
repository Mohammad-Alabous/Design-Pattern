namespace ME.DesignPattern.Main.Bridge
{
    public abstract class Shape
    {
        protected readonly IRenderer shapRenderer;
        public Shape(IRenderer renderer) 
        {
            shapRenderer = renderer;
        }

        public abstract void Draw();
    }
}
