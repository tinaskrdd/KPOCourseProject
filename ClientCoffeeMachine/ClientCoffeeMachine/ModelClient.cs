enum QuanititiesOfCoffee { 
espresso = 20,
capuccino = 15,
americano = 10 
}

enum QuantitiesOfWater
{
    espressoWater = 100,
    capuccinoWater = 300,
    americanoWater = 400
}
enum QuantitiesOfSugar
{
    sweet = 10,
    semiSweet = 5,
    sugarFree = 0
}

public abstract class Beverage
{
    abstract public int getCoffee();
    abstract public int getSugar();
    abstract public int getMilk();
    abstract public int getWater();

}

public class Coffee: Beverage
{
    // Properties 
    protected int water;
    protected int coffee;
    protected int milk;
    protected int sugar;

    public Coffee(int _w, int _c, int _m, int _s)
    {
        water = _w;
        coffee = _c;
        milk = _m;
        sugar = _s;
    }
    // Getters
    public override int getCoffee()
    {
        return coffee;
    }
    public override int getMilk()
    {
        return milk;
    }

    public override int getWater()
    {
        return water;
    }
    public override int getSugar()
    {
        return sugar;
    }

    // Methods
    public void adjustSugar(int _choice)
    {

        if (_choice == 1)
        {
            QuantitiesOfSugar sgr = QuantitiesOfSugar.sweet;
            sugar = (int)sgr;
        }
        else if (_choice == 2)
        {
            QuantitiesOfSugar sgr = QuantitiesOfSugar.semiSweet;
            sugar = (int)sgr;
        }
        else
        {
            QuantitiesOfSugar sgr = QuantitiesOfSugar.sugarFree;
            sugar = (int)sgr;
        }
    }
} 

public class Cappuccino: Coffee
{
    // Constructors 
    public Cappuccino() : base((int)QuantitiesOfWater.capuccinoWater, (int)QuanititiesOfCoffee.capuccino, 100,(int)QuantitiesOfSugar.sugarFree)
    {
    

    }
}

public class Espresso: Coffee
{
    // Constructors 
    public Espresso(): base((int)QuantitiesOfWater.espressoWater, (int)QuanititiesOfCoffee.espresso,0, (int)QuantitiesOfSugar.sugarFree)
    {

    }
}
public class Americano: Coffee {
    public Americano() : base((int)QuantitiesOfWater.americanoWater, (int)QuanititiesOfCoffee.americano, 0, (int)QuantitiesOfSugar.sugarFree) { 
    }
}