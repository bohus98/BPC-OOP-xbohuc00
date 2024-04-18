using Microsoft.EntityFrameworkCore;
using System;

namespace CV11.EFCore
{
    public class VyukaContext : DbContext
    {
        public DbSet<Student> Studenti { get; set; }
        public DbSet<Predmet> Predmety { get; set; }
        public DbSet<Zapis> Zapisy { get; set; }
        public DbSet<Hodnoceni> Hodnoceni { get; set; }

        public IEnumerable<Student> StudentiPredmetu(int predmetId)
        {
            // Použití LINQ dotazu na entitní sadu Zapisy pro získání studentů zapsaných na daný předmět
            return Zapisy
                .Where(z => z.PredmetId == predmetId)
                .Select(z => z.Student);
        }

        // Metoda pro získání předmětů studenta
        public IEnumerable<Predmet> PredmetyStudenta(int studentId)
        {
            // Použití LINQ dotazu na entitní sadu Zapisy pro získání předmětů zapsaných daným studentem
            return Zapisy
                .Where(z => z.StudentId == studentId)
                .Select(z => z.Predmet);
        }
        public void TiskSeznamuPredmetuSPrumernouZnamkou()
        {
            // LINQ dotaz pro získání průměrných známek v jednotlivých předmětech
            var prumerneZnamky = Hodnoceni
                .GroupBy(h => h.Zkratka)
                .Select(g => new
                {
                    ZkratkaPredmetu = g.Key,
                    PrumernaZnamka = g.Average(h => h.HodnoceniBody)
                });

            // Výpis průměrných známek předmětů
            Console.WriteLine("Seznam předmětů s průměrnou známkou:");
            foreach (var prumernaZnamka in prumerneZnamky)
            {
                Console.WriteLine($"Předmět: {prumernaZnamka.ZkratkaPredmetu}, Průměrná známka: {prumernaZnamka.PrumernaZnamka}");
            }
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Nastavení připojení k databázi
            optionsBuilder.UseSqlServer(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\BPC-OOP\221536\CV11\CV11\VyukaDatabase.mdf;Integrated Security=True;Connect Timeout=30");
        }

        // Metoda pro vytvoření databáze, pokud neexistuje
        public void CreateDatabaseIfNotExists()
        {
            if (!Database.CanConnect())
            {
                Database.EnsureCreated();
                Console.WriteLine("Databáze byla vytvořena.");
            }
            else
            {
                Console.WriteLine("Databáze již existuje.");
            }
        }
    }
}
