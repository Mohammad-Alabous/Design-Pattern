namespace ME.DesignPattern.Main.Builder
{
    public class KidsMealBuilder : IMealBuilder
    {
        private Meal _meal = new Meal();

        public IMealBuilder BuildDessert()
        {
            _meal.Dessert = "Ice Cream";
            return this;
        }

        public IMealBuilder BuildDrink()
        {
            _meal.Drink = "Apple Juice";
            return this;
        }
        public IMealBuilder BuildMainCourse()
        {
            _meal.MainCourse = "Chicken Nuggets";
            return this;
        }

        public IMealBuilder BuildSide()
        {
            _meal.Side = "Fries";
            return this;
        }
        
        public Meal GetMeal()
        {
            return _meal;
        }
    }
}
