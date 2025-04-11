namespace ME.DesignPattern.Main.Builder
{
    public class Meal
    {
        public string MainCourse { get; set; }
        public string Side { get; set; }
        public string Drink { get; set; }
        public string Dessert { get; set; }

        public void Show()
        {
            Console.WriteLine($"Main Course: {MainCourse}");
            Console.WriteLine($"Side: {Side}");
            Console.WriteLine($"Drink: {Drink}");
            Console.WriteLine($"Dessert: {Dessert}");
        }
    }
}
