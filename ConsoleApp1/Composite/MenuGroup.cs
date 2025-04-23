namespace ME.DesignPattern.Main.Composite
{
    public class MenuGroup : IMenuComponent
    {
        private readonly List<IMenuComponent> _menuItems = new();
        private readonly string _name;
        public MenuGroup(string name)
        {
            _name = name;
        }

        public void Add(IMenuComponent menuItem) => _menuItems.Add(menuItem);
        public void Remove(IMenuComponent menuItem) => _menuItems.Remove(menuItem);

        public void Display(int indent = 0)
        {
            Console.WriteLine($"{new string(' ', indent)}> {_name}");
            foreach (var menuItem in _menuItems)
            {
                menuItem.Display(indent + 4);
            }
        }
    }
}
