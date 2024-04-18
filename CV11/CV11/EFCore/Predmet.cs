
using System.Collections.Generic;

namespace CV11.EFCore
{
    public class Predmet
    {
        public int PredmetId { get; set; }
        public string NazevPredmetu { get; set; }
        public string Zkratka { get; set; }
        public ICollection<Zapis> Zapisy { get; set; }
        public ICollection<Hodnoceni> Hodnoceni { get; set; }
    }
}
