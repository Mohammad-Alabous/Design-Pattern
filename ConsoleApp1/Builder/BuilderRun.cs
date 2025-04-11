namespace ME.DesignPattern.Main.Builder
{
    public static class BuilderRun
    {
        public static void Run()
        {
            Meal kidsMeal = new KidsMealBuilder()
                .BuildDessert()
                .BuildDrink()
                .BuildSide()
                .BuildMainCourse()
                .GetMeal();

            kidsMeal.Show();
        }
    }
}
