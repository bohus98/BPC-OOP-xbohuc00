using System;

namespace CV11.EFCore
{
    public class Hodnoceni
    {
        public int HodnoceniId { get; set; }
        public int StudentId { get; set; }
        public int PredmetId { get; set; }
        public string Zkratka { get; set; }
        public DateTime DatumHodnoceni { get; set; }
        public int HodnoceniBody { get; set; }
        public Student Student { get; set; }
        public Predmet Predmet { get; set; }
    }
}
