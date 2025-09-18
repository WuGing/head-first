public abstract class Duck 
{
#nullable disable
    public IFlyBehavior flyBehavior { get; set; }
    public IQuackBehavior quackBehavior { get; set; }
#nullable enable

    public Duck() { }

    public void PerformQuack() 
    {
        quackBehavior.Quack();
    }

    public void PerformFly() 
    {
        flyBehavior.Fly();
    }

    public void Swim() 
    {
        Console.WriteLine("All ducks float, even decoys!");
    }

    public void SetFlyBehavior(IFlyBehavior fb) 
    {
        flyBehavior = fb;
    }

    public void SetQuackBehavior(IQuackBehavior qb) 
    {
        quackBehavior = qb;
    }

    public abstract void Display();
}