namespace ME.DesignPattern.Main.Prototype
{
    public static class PrototypeRun
    {
        public static void Run()
        {
            Resume original = new Resume() 
            {
                Name = "Original 1",
                Email = "Original@test.com",
                Skills = new List<string>() { "Org 1", "Org 2" }
            };

            Resume copy = original.Clone();
            copy.Name = "Copy";
            copy.Email = "Copy@test.com";
            copy.Skills = new List<string>() { "Copy 1", "Copy 2" };

            original.Show();
            Console.WriteLine("-------------");
            copy.Show();
        }
    }
}
