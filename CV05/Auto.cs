using System;

namespace CV05
{
    // Základná trieda reprezentujúca auto
    public class Auto
    {
        // Vnorený výčtový typ reprezentujúci typ paliva
        public enum TypPaliva { Benzin, Nafta }

        // Vlastnosti
        protected double VelikostNadrze { get; private set; }
        protected double StavNadrze { get; set; }
        protected TypPaliva Palivo { get; private set; }
        protected int MaxOsob { get; }
        protected double MaxNaklad { get; }

        // Metóda pre kontrolu nastavenia vlastností PrepravovanyNaklad a PrepravovaneOsoby
        protected void KontrolaPrepravy(double hodnota, double maxHodnota)
        {
            if (hodnota > maxHodnota)
                throw new ArgumentOutOfRangeException($"Hodnota prekračuje maximálnu povolenú hodnotu {maxHodnota}.");
        }

        // Metóda na natankovanie
        public void Natankuj(TypPaliva typ, double mnozstvi)
        {
            if (typ != Palivo)
                throw new ArgumentException("Nesprávny typ paliva.");

            if (StavNadrze + mnozstvi > VelikostNadrze)
                throw new OverflowException("Pretečenie nádrže.");

            StavNadrze += mnozstvi;
        }

        // Konštruktor
        public Auto(double velikostNadrze, TypPaliva palivo, int maxOsob, double maxNaklad)
        {
            VelikostNadrze = velikostNadrze;
            Palivo = palivo;
            MaxOsob = maxOsob;
            MaxNaklad = maxNaklad;
            StavNadrze = 0;
        }

        // Metóda ToString
        public override string ToString()
        {
            return $"Stav nádrže: {StavNadrze}, Typ paliva: {Palivo}, Maximálny počet osôb: {MaxOsob}, Maximálny náklad: {MaxNaklad}";
        }
    }
}
