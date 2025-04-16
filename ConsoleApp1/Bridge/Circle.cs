namespace ME.DesignPattern.Main.Bridge
{
    public class Circle : Shape
    {
        public Circle(IRenderer renderer) : base(renderer)
        {
        }

        public override void Draw()
        {
            shapRenderer.Render("Circle");
        }
    }
}
