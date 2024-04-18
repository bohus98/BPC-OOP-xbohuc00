namespace CV11.EFCore
{
    public class Zapis
    {
        public int ZapisId { get; set; }
        public int StudentId { get; set; }
        public int PredmetId { get; set; }
        public Student Student { get; set; }
        public Predmet Predmet { get; set; }
    }
}
