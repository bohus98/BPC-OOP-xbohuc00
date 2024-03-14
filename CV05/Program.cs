using System;

namespace CV05
{
    class Program
    {
        static void Main(string[] args)
        {
            
                // Demonštrácia použitia tried
                var osobniAuto = new Osobni(50, Auto.TypPaliva.Benzin, 5);
                Console.WriteLine("Osobné auto:");
                Console.WriteLine(osobniAuto);
                Console.WriteLine();

                var nakladniAuto = new Nakladni(100, Auto.TypPaliva.Nafta, 200);
                Console.WriteLine("Nákladné auto:");
                Console.WriteLine(nakladniAuto);
                Console.WriteLine();

                var autoWithRadio = new AutoWithAutoradio(60, Auto.TypPaliva.Benzin, 4, 200);
                Console.WriteLine("Auto s autorádiom pred zapnutím:");
                Console.WriteLine(autoWithRadio);
                autoWithRadio.Radio.NastavPredvolbu(1, 98.5);
                autoWithRadio.Radio.NastavPredvolbu(2, 102.3);
                autoWithRadio.Radio.PreladNaPredvolbu(1);
                
                Console.WriteLine($"Naladený kmitočet: {autoWithRadio.Radio.NaladenyKmitocet}, Radio zapnuté: {autoWithRadio.Radio.RadioZapnuto}");
                Console.WriteLine();

            try
            {
                

                Console.WriteLine("Zapínanie autorádia:");
                autoWithRadio.Radio.ZapniRadio();
                Console.WriteLine($"Radio zapnuté: {autoWithRadio.Radio.RadioZapnuto}");
                Console.WriteLine();

                Console.WriteLine("Vypínanie autorádia:");
                autoWithRadio.Radio.VypniRadio();
                Console.WriteLine($"Radio zapnuté: {autoWithRadio.Radio.RadioZapnuto}");
                Console.WriteLine();

            }
            catch (Exception ex)
            {
                Console.WriteLine($"Chyba: {ex.Message}");
            }

            
                  
            try
            {
                Console.WriteLine("Pokus o natankovanie nesprávneho paliva:");
                autoWithRadio.Natankuj(Auto.TypPaliva.Nafta, 10); // Pokus o natankovanie iného paliva ako je nastavené
                
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Chyba: {ex.Message}");
                Console.WriteLine();
            }

            try
            {
                Console.WriteLine("Pokus o natankovanie do plnej nádrže:");
                osobniAuto.Natankuj(Auto.TypPaliva.Benzin, 150); // Pokus o natankovanie do plnej nádrže
                
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Chyba: {ex.Message}");
                Console.WriteLine();
            }
            
            try
            {
                Console.WriteLine("Kontrola nakladu:");
                nakladniAuto.KontrolaPrepravy(1000, Nakladni.MaxNaklad);
                
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Chyba: {ex.Message}");
                Console.WriteLine();
            }

            try
            {
                Console.WriteLine("Kontrola pasazierov:");
                osobniAuto.KontrolaPrepravy(6, Auto.MaxOsob);
                
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Chyba: {ex.Message}");
                Console.WriteLine();
            }

            try
            {
                Console.WriteLine("Kontrola radia:");
                autoWithRadio.Radio.PreladNaPredvolbu(5);
                Console.WriteLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Chyba: {ex.Message}");
                Console.WriteLine();
            }




        }
    }
}
