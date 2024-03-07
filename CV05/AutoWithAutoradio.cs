namespace CV05
{
    // Trieda rozšírená o autorádio
    public class AutoWithAutoradio : Auto
    {
        // Vlastnosť pre autorádio
        public Autoradio Radio { get; } = new Autoradio();

        // Konštruktor
        public AutoWithAutoradio(double velikostNadrze, TypPaliva palivo, int maxOsob, double maxNaklad) : base(velikostNadrze, palivo, maxOsob, maxNaklad)
        {
        }
    }
}
