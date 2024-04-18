using CV11.EFCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CV11
{
    class Program
    {
        static void Main(string[] args)
        {

            using (var context = new VyukaContext())
            {
                context.Database.Migrate();
                context.CreateDatabaseIfNotExists();
                // Metoda pro naplnění databáze vzorovými daty
                SeedDatabase(context);

                
             
                // Vzorové použití metody StudentiPredmetu pro získání studentů předmětu
                int predmetId = 1; // ID požadovaného předmětu
                IEnumerable<Student> studentiPredmetu = context.StudentiPredmetu(predmetId);

                Console.WriteLine($"Studenti předmětu s ID {predmetId}:");
                foreach (var student in studentiPredmetu)
                {
                    Console.WriteLine($"{student.Jmeno} {student.Prijmeni}");
                }

                // Vzorové použití metody PredmetyStudenta pro získání předmětů studenta
                int studentId = 1; // ID požadovaného studenta
                IEnumerable<Predmet> predmetyStudenta = context.PredmetyStudenta(studentId);

                Console.WriteLine($"\nPředměty studenta s ID {studentId}:");
                foreach (var predmet in predmetyStudenta)
                {
                    Console.WriteLine($"{predmet.NazevPredmetu}");
                }
                // Výpis průměrných známek předmětů
                context.TiskSeznamuPredmetuSPrumernouZnamkou();
            }
        }

        // Metoda pro naplnění databáze vzorovými daty
        static void SeedDatabase(VyukaContext context)
        {
            if (!context.Predmety.Any())
            {
                var predmety = new List<Predmet>
                {
                    new Predmet { NazevPredmetu = "Matematika", Zkratka = "MAT" },
                    new Predmet { NazevPredmetu = "Český jazyk a literatura", Zkratka = "CJL" },
                    new Predmet { NazevPredmetu = "Informatika", Zkratka = "INF" }
                };
                context.Predmety.AddRange(predmety);
                context.SaveChanges();
            }

            if (!context.Studenti.Any())
            {
                var studenti = new List<Student>
                {
                    new Student { Jmeno = "Jan", Prijmeni = "Novák", DatumNarozeni = new DateTime(2000, 1, 15) },
                    new Student { Jmeno = "Eva", Prijmeni = "Nováková", DatumNarozeni = new DateTime(2001, 3, 20) },
                    new Student { Jmeno = "Petr", Prijmeni = "Svoboda", DatumNarozeni = new DateTime(2000, 5, 10) },
                    new Student { Jmeno = "Marie", Prijmeni = "Svobodová", DatumNarozeni = new DateTime(2001, 7, 25) }
                };
                context.Studenti.AddRange(studenti);
                context.SaveChanges();
            }

            if (!context.Zapisy.Any())
            {
                var zapisy = new List<Zapis>
                {
                    new Zapis { StudentId = 1, PredmetId = 1 },
                    new Zapis { StudentId = 1, PredmetId = 2 },
                    new Zapis { StudentId = 2, PredmetId = 1 },
                    new Zapis { StudentId = 3, PredmetId = 3 },
                    new Zapis { StudentId = 4, PredmetId = 2 },
                    new Zapis { StudentId = 4, PredmetId = 3 }
                };
                context.Zapisy.AddRange(zapisy);
                context.SaveChanges();
            }

            if (!context.Hodnoceni.Any())
            {
                var hodnoceni = new List<Hodnoceni>
                {
                    new Hodnoceni { StudentId = 1, PredmetId = 1, DatumHodnoceni = new DateTime(2023, 5, 20), HodnoceniBody = 85 },
                    new Hodnoceni { StudentId = 1, PredmetId = 2, DatumHodnoceni = new DateTime(2023, 6, 10), HodnoceniBody = 90 },
                    new Hodnoceni { StudentId = 2, PredmetId = 1, DatumHodnoceni = new DateTime(2023, 5, 20), HodnoceniBody = 88 },
                    new Hodnoceni { StudentId = 3, PredmetId = 3, DatumHodnoceni = new DateTime(2023, 6, 15), HodnoceniBody = 92 },
                    new Hodnoceni { StudentId = 4, PredmetId = 2, DatumHodnoceni = new DateTime(2023, 6, 10), HodnoceniBody = 87 },
                    new Hodnoceni { StudentId = 4, PredmetId = 3, DatumHodnoceni = new DateTime(2023, 6, 15), HodnoceniBody = 85 }
                };
                context.Hodnoceni.AddRange(hodnoceni);
                context.SaveChanges();
            }
        }
    }
}

