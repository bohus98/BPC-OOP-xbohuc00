using System;
using System.Collections.Generic;
using System.Linq;

namespace cv08
{
    // Class representing temperature data for a specific year
    public class YearTemperature
    {
        // List to store monthly temperature data
        private List<double> monthTemperature;

        // Properties
        public List<double> MonthTemperature
        {
            get { return monthTemperature; }
            private set { monthTemperature = value; }
        }
        public int Year { get; set; }
        public double MaxTemperature { get; private set; }
        public double MinTemperature { get; private set; }
        public double AverageTemperature { get; private set; }

        // Constructor
        public YearTemperature(int year, List<double> monthTemperature = null)
        {
            // Initialize monthTemperature list
            this.MonthTemperature = monthTemperature ?? new List<double>();

            // Set year
            Year = year;

            // Calculate min, max, and average temperatures
            SetMinMaxAverage();
        }

        // Adjust temperature data by a calibration value
        public void Calibration(double calibrationValue)
        {
            for (int i = 0; i < monthTemperature.Count; i++)
            {
                monthTemperature[i] += calibrationValue;
            }

            // Recalculate min, max, and average temperatures after calibration
            SetMinMaxAverage();
        }

        // Calculate average temperature
        private void ComputeAverageTemperature()
        {
            double sumOfTemperature = monthTemperature.Sum();
            AverageTemperature = sumOfTemperature / monthTemperature.Count;
        }

        // Set min, max, and average temperatures
        private void SetMinMaxAverage()
        {
            if (monthTemperature.Count > 0)
            {
                MinTemperature = monthTemperature.Min();
                MaxTemperature = monthTemperature.Max();
                ComputeAverageTemperature();
            }
            else
            {
                // If no temperature data available, set min, max, and average to 0
                MinTemperature = MaxTemperature = AverageTemperature = 0;
            }
        }

        // Override ToString method to represent object as string
        public override string ToString()
        {
            return $"Year {Year}: {string.Join(" ", monthTemperature.Select(r => $"{r:N1}"))}";
        }
    }
}
