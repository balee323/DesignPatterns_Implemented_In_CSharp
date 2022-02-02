namespace DesignPatterns.FactoryPatterns.SimpleFactoryPattern
{
    public enum Senario
    {
        Picnic,
        Hunting,
        TakingBath
    }

    public abstract class Duck
    {
        public abstract decimal Cost { get; }
    }

    public class Mallard : Duck
    {
        public override decimal Cost => 75.95m;
    }
    public class DecoyDuck : Duck
    {
        public override decimal Cost => 29.99m;
    }
    public class RubberDuck : Duck
    {
        public override decimal Cost => 2.99m;
    }

}
