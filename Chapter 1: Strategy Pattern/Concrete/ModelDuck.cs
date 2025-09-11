public class ModelDuck : Duck
{
    public ModelDuck()
    {
        flyBehavior = new FlyNoWay();
        quackBehavior = new RealQuack();
    }

    public override void Display()
    {
        Console.WriteLine("I'm a model duck");
    }
}