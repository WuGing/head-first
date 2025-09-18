public class MallardDuck : Duck
{
    public MallardDuck()
    {
        flyBehavior = new FlyWithWings();
        quackBehavior = new RealQuack();
    }

    public override void Display()
    {
        Console.WriteLine("I'm a real Mallard duck");
    }
}