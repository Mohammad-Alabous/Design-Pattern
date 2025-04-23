namespace ME.DesignPattern.Main.Composite
{
    public class MenuItem : IMenuComponent
    {
        private readonly string _name;
        private readonly string _description;

        public MenuItem(string itemName, string description)
        {
            _name = itemName;
            _description = description;
        }

        public void Display(int indent = 0)
        {
            Console.WriteLine($"{new string(' ', indent)}- {_name}");
            if (!string.IsNullOrEmpty(_description))
            {
                Console.WriteLine($"{new string(' ', indent + 2)}- {_description}");
            }
        }
    }
}
