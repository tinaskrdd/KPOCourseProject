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
}