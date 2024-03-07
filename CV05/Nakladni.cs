namespace CV05
{
    // Trieda reprezentujúca nákladné auto
    public class Nakladni : Auto
    {
        // Vlastnosť pre prepravovaný náklad
        public double PrepravovanyNaklad { get; private set; }

        // Konštruktor
        public Nakladni(double velikostNadrze, TypPaliva palivo, double maxNaklad) : base(velikostNadrze, palivo, 1, maxNaklad)
        {
            PrepravovanyNaklad = 0;
        }

        // Metóda ToString
        public override string ToString()
        {
            return base.ToString() + $", Prepravovaný náklad: {PrepravovanyNaklad}";
        }
    }
}
