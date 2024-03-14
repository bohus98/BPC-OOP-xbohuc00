using System;

namespace CV06
{
    class Program
    {
        static void Main(string[] args)
        {
            GrObjekt[] grafickeObjekty = new GrObjekt[]
            {
                new Kruh(2.5),
                new Obdelnik(3, 4),
                new Trojuhelnik(5, 7),
                new Valec(2, 5),
                new Koule(3),
                new Jehlan(4, 6),
                new PravouhlyKvadr(2, 3, 4)
            };

            double celkovaPlocha = 0;
            double celkovyPovrch = 0;
            double celkovyObjem = 0;

            foreach (var objekt in grafickeObjekty)
            {
                objekt.Kresli();

                if (objekt is IObjekt2D)
                {
                    celkovaPlocha += ((IObjekt2D)objekt).SpoctiPlochu();
                }

                if (objekt is IObjekt3D)
                {
                    celkovyPovrch += ((IObjekt3D)objekt).SpoctiPovrch();
                    celkovyObjem += ((IObjekt3D)objekt).SpoctiObjem();
                }
            }

            Console.WriteLine($"Celkova plocha: {celkovaPlocha}");
            Console.WriteLine($"Celkovy povrch: {celkovyPovrch}");
            Console.WriteLine($"Celkovy objem: {celkovyObjem}");
        }
    }
}
