using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace ElectricityCalculator.ResistorOperations
{
    public class Resistor
    {
        public ResistorBands BandType { get; set; }
        public decimal Value { get; set; }
        public Colors Band1 { get; set; }
        public Colors Band2 { get; set; }
        public Colors Band3 { get; set; }
        public Colors Multiplier { get; set; }
        public Colors Tolerance { get; set; }
        public Colors TemperatureCoefficient { get; set; }
       

        public Resistor() {

           
        }

        public static double AddSeries(double[] values)
        {
            double resistorSumResult = 0;
            foreach (double value in values)
            {
                resistorSumResult += value;
            }
            return resistorSumResult;

        }

        public static double AddParallel(double[] values)
        {
            double resistorSumResult = 0;
            foreach (double value in values)
            {
                resistorSumResult += ( 1/value);
            }
            return resistorSumResult;

        }
        public string CalulateColorCode(Resistor resistor)
        {
            StringBuilder result = new StringBuilder();

            result.Append(Convert.ToInt16(resistor.Band1));
            result.Append(Convert.ToInt16(resistor.Band2));
            
            switch (resistor.BandType)
            {
                  
                case ResistorBands._3Band:
                    result.Append(CalculateMultiplierValue(resistor.Multiplier));
                    return result.ToString();
                    
                case ResistorBands._4Band:
                    result.Append(resistor.Band3);
                    result.Append(CalculateMultiplierValue(resistor.Multiplier));
                    return result.ToString(); 

                case ResistorBands._5Band:
                    result.Append(resistor.Band3);
                    result.Append(CalculateMultiplierValue(resistor.Multiplier));
                    result.Append(CalculateToleranceValue(resistor.Tolerance));
                    return result.ToString();
                   
                case ResistorBands._6Band:
                    result.Append(resistor.Band3);
                    result.Append(CalculateMultiplierValue(resistor.Multiplier));
                    result.Append(CalculateToleranceValue(resistor.Tolerance));
                    result.Append(CalculateTemperatureValue(resistor.TemperatureCoefficient));
 
                    return result.ToString();
                  
                default: return "Resistor Band not Set!";
                    
            }

         

        }

        string CalculateMultiplierValue(Colors multiplierColor)
        { 

            return "1".PadRight(Convert.ToInt32(multiplierColor) + 1, '0');
        }

        string CalculateToleranceValue(Colors toleranceColor)
        {
            return "";
        }

        string CalculateTemperatureValue(Colors temperatureColor)
        {
            return "";
        }
    }
}
