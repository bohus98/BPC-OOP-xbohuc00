using System;
using System.Globalization;

namespace cv08
{
    class Program
    {
        static void Main(string[] args)
        {
            // Uncomment the line below to set the current culture to Czech
            // CultureInfo.CurrentCulture = new CultureInfo("cs-CZ");

            Console.WriteLine("Temperature Archive");
            TemperatureArchive temperatureArchive = new TemperatureArchive();

            // Load temperature data from file
            temperatureArchive.Load();

            // Print loaded temperature data
            Console.WriteLine("Loaded Temperature Data:");
            Console.WriteLine(temperatureArchive.PrintTemperature());

            // Print average monthly temperature
            Console.WriteLine("Average Monthly Temperature:");
            Console.WriteLine(temperatureArchive.AverageMonthlyTemperature());

            // Calibrate temperature data
            temperatureArchive.Calibration(-0.1);
            Console.WriteLine("After Calibration:");
            Console.WriteLine(temperatureArchive.PrintTemperature());

            // Find temperature data for a specific year
            Console.WriteLine("Temperature Data for Year 2019:");
            Console.WriteLine(temperatureArchive.FindYearTemperature(2019));

            // Print average temperature for each year
            Console.WriteLine("Average Temperature for Each Year:");
            Console.WriteLine(temperatureArchive.AverageYearTemperature());

            // Print average monthly temperature again
            Console.WriteLine("Average Monthly Temperature:");
            Console.WriteLine(temperatureArchive.AverageMonthlyTemperature());

            // Save temperature data to file
            temperatureArchive.Save();

            Console.ReadLine();
        }
    }
}
