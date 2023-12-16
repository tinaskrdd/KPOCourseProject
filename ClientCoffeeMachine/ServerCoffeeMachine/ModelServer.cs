public class Storage
{
    private static Storage instance;
    private static readonly object lockObject = new object();

    public int remainingCoffee { get; set; }
    public int remainingWater { get; set; }
    public int remainingSugar { get; set; }
    public int remainingMilk { get; set; }
    // Private constructor
    private Storage()
    {
        // Initialize properties here if needed
        remainingCoffee = 5000;
        remainingWater = 1000;
        remainingSugar = 1000;
        remainingMilk = 2000;
    }

    // Method to get the singleton instance
    public static Storage GetInstance()
    {
        if (instance == null)
        {
            lock (lockObject)
            {
                if (instance == null)
                {
                    instance = new Storage();
                }
            }
        }
        return instance;
    }

//    singleton.Property1 = "Updated Value";
//singleton.Property2 = 42;

}

