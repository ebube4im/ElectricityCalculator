

namespace ElectricityCalulatorApp
{
    using ElectricityCalculator.ResistorOperations;
    internal class Program
    {
        static void Main(string[] args)

        {
            Resistor resistor = new Resistor() { Band1 = Colors.Red, Band2 = Colors.Green, Band3 = Colors.Red, BandType = ResistorBands._3Band, Multiplier = Colors.Green};

            string result =   resistor.CalulateColorCode(resistor);
            double[] values = { 2, 3.5, 4, 5.6 };
            Console.WriteLine(Resistor.AddParallel(values).ToString()); ;
            Console.WriteLine(result);
        }
    }
}