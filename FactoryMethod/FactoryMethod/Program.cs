namespace FactoryMethod;

public class Program
{
    public static void Main(String[]args)
    {
        BeefResturent beefResturent = new BeefResturent();
        beefResturent.OrderBurger();

        VeggiResturent veggiResturent = new VeggiResturent();
        veggiResturent.OrderBurger();

        ChickenBurger chickenBurger = new ChickenBurger();
        chickenBurger.OrderBurger();
    }
}
