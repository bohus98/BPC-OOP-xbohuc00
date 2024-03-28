using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace cv08
{
    class Program
    {
        static void Main(string[] args)
        {
            
            CultureInfo.CurrentCulture = new CultureInfo("cs-CZ");
            Console.WriteLine("Archive logic");
            TemperatureArchive t = new TemperatureArchive();
            t.Load();
            Console.WriteLine(t.PrintTemperature());
            Console.WriteLine(t.AverageMonthlyTemperature());
            t.Calibration(-0.1);
            Console.WriteLine("After calibration");
            Console.WriteLine(t.PrintTemperature());
            Console.WriteLine(t.findYearTemperature(2019));
            Console.WriteLine(t.AverageYearTemperature());
            Console.WriteLine(t.AverageMonthlyTemperature());
            t.Save();
            Console.WriteLine();
            Console.ReadLine();


        }
    }
}