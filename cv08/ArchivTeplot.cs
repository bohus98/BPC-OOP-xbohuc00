using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace cv08
{
    // Class for managing temperature data for multiple years
    public class TemperatureArchive
    {
        // Dictionary to store temperature data for each year
        private SortedDictionary<int, YearTemperature> _archive = new SortedDictionary<int, YearTemperature>();

        // Directory paths and file names for input and output
        private const string MainDirectory = "D:\\BPC-OOP\\221536\\cv08";
        private const string InputFile = "inputTemperature.txt";
        private const string OutputFile = "outputTemperature.txt";

        // Add temperature data for a year to the archive
        public void AddToArchive(YearTemperature yearTemperature)
        {
            _archive.Add(yearTemperature.Year, yearTemperature);
        }

        // Load temperature data from file
        public void Load()
        {
            try
            {
                string path = Path.Combine(MainDirectory, InputFile);
                using (StreamReader sr = new StreamReader(path))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        List<double> temperature = new List<double>();
                        line = line.Replace(" ", "");
                        string[] splitter = line.Split(new char[] { ':', ';' });
                        for (int i = 1; i < splitter.Length; i++)
                        {
                            temperature.Add(Convert.ToDouble(splitter[i]));
                        }
                        _archive.Add(Convert.ToInt32(splitter[0]), new YearTemperature(Convert.ToInt32(splitter[0]), temperature));
                    }
                }
            }
            catch (Exception e)
            {
                throw new Exception($"Error loading data: {e.Message}");
            }
        }

        // Save temperature data to file
        public void Save()
        {
            try
            {
                string path = Path.Combine(MainDirectory, OutputFile);
                using (StreamWriter sw = new StreamWriter(path))
                {
                    foreach (YearTemperature s in _archive.Values)
                    {
                        sw.WriteLine($"{s.Year}: {string.Join("; ", s.MonthTemperature.Select(r => $"{r:N1}"))}");
                    }
                }
            }
            catch (Exception e)
            {
                throw new Exception($"Error saving data: {e.Message}");
            }
        }

        // Find temperature data for a specific year
        public YearTemperature FindYearTemperature(int year)
        {
            return _archive.TryGetValue(year, out YearTemperature value) ? value : null;
        }

        // Calibrate all temperature data by a given value
        public void Calibration(double calibrationValue)
        {
            foreach (YearTemperature s in _archive.Values)
            {
                s.Calibration(calibrationValue);
            }
        }

        // Calculate and return the average temperature for each year
        public string AverageYearTemperature()
        {
            StringBuilder ret = new StringBuilder();
            foreach (var s in _archive.Values)
            {
                ret.AppendLine($"{s.Year}:    {s.AverageTemperature:N1}");
            }
            return ret.ToString();
        }

        // Calculate and return the average monthly temperature across all years
        public string AverageMonthlyTemperature()
        {
            StringBuilder ret = new StringBuilder();
            List<double> averageMonthTemperature = new List<double>();
            for (int i = 0; i < _archive.FirstOrDefault().Value.MonthTemperature.Count(); i++)
            {
                double monthAverage = 0;
                int counter = 0;
                foreach (var s in _archive.Values)
                {
                    monthAverage += s.MonthTemperature[i];
                    counter++;
                }
                averageMonthTemperature.Add(monthAverage / counter);
            }
            ret.AppendLine($"Average: {string.Join(" ", averageMonthTemperature.Select(r => $"{r:N1}"))}");
            return ret.ToString();
        }

        // Print temperature data for all years
        public string PrintTemperature()
        {
            StringBuilder ret = new StringBuilder();
            foreach (var s in _archive.Values)
            {
                ret.AppendLine($"{s}");
            }
            return ret.ToString();
        }
    }
}
