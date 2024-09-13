namespace Factory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Factory guitarFactory = new GuitarFactory();
            Instrument guitar = guitarFactory.createInstrument();
            Factory bassFactory = new BassFactory();
            Instrument bass = bassFactory.createInstrument();
            Factory drumsFactory = new DrumsFactory();
            Instrument drums = drumsFactory.createInstrument();

            guitar.PlaySound();
            bass.PlaySound();
            drums.PlaySound();
        }
    }
}
