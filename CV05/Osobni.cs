namespace CV05
{
    // Trieda reprezentujúca osobné auto
    public class Osobni : Auto
    {
        // Vlastnosť pre počet prepravovaných osôb
        public int PrepravovaneOsoby { get; private set; }

        // Konštruktor
        public Osobni(double velikostNadrze, TypPaliva palivo, int maxOsob) : base(velikostNadrze, palivo, maxOsob, 0)
        {
            PrepravovaneOsoby = 0;
        }

        // Metóda ToString
        public override string ToString()
        {
            return base.ToString() + $", Počet prepravovaných osôb: {PrepravovaneOsoby}";
        }
    }
}
