using System.Collections.Generic;

namespace CV05
{
    // Trieda reprezentujúca autorádio
    public class Autoradio
    {
        // Privátny zoznam pre predvolby autorádia
        private Dictionary<int, double> predvolby = new Dictionary<int, double>();

        // Vlastnosti
        public double NaladenyKmitocet { get; private set; }
        public bool RadioZapnuto { get; private set; }

         public Autoradio()
        {
            RadioZapnuto = true; // Nastaviť radio na predvolene zapnuté
        }

        // Metóda na zapnutie autorádia
        public void ZapniRadio()
        {
            RadioZapnuto = true;
        }

        // Metóda na vypnutie autorádia
        public void VypniRadio()
        {
            RadioZapnuto = false;
        }

        // Metóda pre nastavenie predvolby
        public void NastavPredvolbu(int cislo, double kmitocet)
        {
            predvolby[cislo] = kmitocet;
        }

        // Metóda pre prípade, že používateľ sa pokúsil nastaviť frekvenciu na uloženú predvolbu
        public void PreladNaPredvolbu(int cislo)
        {
            if (predvolby.ContainsKey(cislo))
                NaladenyKmitocet = predvolby[cislo];
            else
                throw new KeyNotFoundException("Predvolba nebola nájdená.");
        }
    }
}
