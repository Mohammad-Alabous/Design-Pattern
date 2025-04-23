namespace ME.DesignPattern.Main.Composite
{
    public static class CompositeRun
    {
        public static void Run()
        {
            var appetizersMenu = new MenuGroup("Appetizers");
            appetizersMenu.Add(new MenuItem("Crispy Calamari", "Tender calamari, lightly battered and fried to a golden crisp, served with a spicy marinara dipping sauce.\r\n"));
            appetizersMenu.Add(new MenuItem("Spinach & Artichoke Dip", "Creamy spinach and artichoke dip baked to perfection, served with warm pita bread.\r\n"));
            appetizersMenu.Add(new MenuItem("Mozzarella Sticks", "Classic mozzarella sticks, deep-fried and served with tangy marinara sauce. \r\n"));

            var entreesMenu = new MenuGroup("Entrees");
            entreesMenu.Add(new MenuItem("Grilled Salmon", "Fresh salmon fillet, grilled to perfection, served with roasted vegetables and lemon butter sauce.\r\n"));
            entreesMenu.Add(new MenuItem("Chicken Parmesan", "Breaded chicken breast, baked with marinara sauce and mozzarella cheese, served with spaghetti.\r\n"));
            entreesMenu.Add(new MenuItem("Ribeye Steak", "Juicy 12oz ribeye steak, grilled to your liking, served with mashed potatoes and asparagus. \r\n"));

            var dessertsMenu = new MenuGroup("Desserts");
            dessertsMenu.Add(new MenuItem("Chocolate Lava Cake", "Warm chocolate lava cake with a molten chocolate center, served with vanilla ice cream"));
            dessertsMenu.Add(new MenuItem("New York Cheesecake", "Classic New York-style cheesecake, baked to perfection, topped with fresh fruit."));
            dessertsMenu.Add(new MenuItem("Brownie Sundae", "Fluffy brownie sundae with fresh banana and ice cream."));

            var fullMenu = new MenuGroup("*** M&M's Restaurant ***");
            fullMenu.Add(appetizersMenu);
            fullMenu.Add(entreesMenu);
            fullMenu.Add(dessertsMenu);

            fullMenu.Display();
        }
    }
}
