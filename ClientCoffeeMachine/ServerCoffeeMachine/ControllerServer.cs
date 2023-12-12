public static class Controller
{
    public static void  updateQuantities(int cof, int water, int sugar, int milk)
    {
        Storage strorageSingleTon = Storage.GetInstance();
        int updatedCoffee = strorageSingleTon.remainingCoffee - cof;
        strorageSingleTon.remainingCoffee = updatedCoffee;
        int updatedWater = strorageSingleTon.remainingWater - water;
        strorageSingleTon.remainingWater = updatedWater;
        int updatedSugar = strorageSingleTon.remainingSugar - sugar;
        strorageSingleTon.remainingSugar = updatedSugar;
        int updatedMilk = strorageSingleTon.remainingMilk - milk;
        strorageSingleTon.remainingMilk = updatedMilk;
    }

    public static void replenishWater(int quantity)
    {
        Storage strorageSingleTon = Storage.GetInstance();
        int updatedWater = strorageSingleTon.remainingWater + quantity;
        strorageSingleTon.remainingWater = updatedWater;
    }

    public static void replenishCoffee(int quantity)
    {
        Storage strorageSingleTon = Storage.GetInstance();
        int updatedCoffee = strorageSingleTon.remainingCoffee + quantity;
        strorageSingleTon.remainingCoffee = updatedCoffee;
    }

    public static void replenishSugar(int quantity)
    {
        Storage strorageSingleTon = Storage.GetInstance();
        int updatedSugar = strorageSingleTon.remainingSugar + quantity;
        strorageSingleTon.remainingSugar = updatedSugar;
    }

    public static void replenishMilk(int quantity)
    {
        Storage strorageSingleTon = Storage.GetInstance();
        int updatedMilk = strorageSingleTon.remainingMilk + quantity;
        strorageSingleTon.remainingMilk = updatedMilk;
    }
}