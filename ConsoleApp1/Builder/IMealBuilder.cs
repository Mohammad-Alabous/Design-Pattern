namespace ME.DesignPattern.Main.Builder
{
    public interface IMealBuilder
    {
        IMealBuilder BuildMainCourse();
        IMealBuilder BuildSide();
        IMealBuilder BuildDrink();
        IMealBuilder BuildDessert();
        Meal GetMeal();
    }
}
