namespace Factory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Factory factory1;
            Factory factory2;
            Factory factory3;

            factory1 = new GuitarFactory();
            factory2 = new BassFactory();
            factory3 = new DrumsFactory();

            factory1.createInstrument().PlaySound();
            factory2.createInstrument().PlaySound();
            factory3.createInstrument().PlaySound();
        }
    }
}
