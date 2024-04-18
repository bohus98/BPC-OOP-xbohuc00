
using System;
using System.Collections.Generic;

namespace CV11.EFCore
{
    public class Student
    {
        public int StudentId { get; set; }
        public string Jmeno { get; set; }
        public string Prijmeni { get; set; }
        public DateTime DatumNarozeni { get; set; }
        public ICollection<Zapis> Zapisy { get; set; }
    }
}
