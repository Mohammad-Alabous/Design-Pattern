namespace ME.DesignPattern.Main.Bridge
{
    public class Square : Shape
    {
        public Square(IRenderer renderer) : base(renderer)
        {
        }

        public override void Draw()
        {
            shapRenderer.Render("Square");
        }
    }
}
