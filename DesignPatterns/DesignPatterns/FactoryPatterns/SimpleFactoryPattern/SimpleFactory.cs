namespace DesignPatterns.FactoryPatterns.SimpleFactoryPattern
{
    public class SimpleFactory
    {
        //We abstracted away object creation from the client code that uses these objects.
        public Duck CreateDuck(Senario senario)
        {
            Duck duck = null;
            if (senario == Senario.Picnic)
            {
                duck = new Mallard();
            }
            else if (senario == Senario.Hunting)
            {
                duck = new DecoyDuck();
            }
            else if (senario == Senario.TakingBath)
            {
                duck = new RubberDuck();
            }

            return duck;
        }

    }
}
