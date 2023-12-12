public static class Controller
{
    public static Coffee brewCoffee(int beverageChoice, int sugarChoice) 
    {
        Coffee coffee = new Cappuccino();
        coffee.adjustSugar(sugarChoice);
        return coffee;
    }

    public static void updateServer(Coffee orderedDrink)
    {

    }
} 