using System;

namespace IdealWeightCalculator
{
    class Program
    {
        static void Main(string[] args)
        {

            WeightCalculator weightCalculator = new WeightCalculator
            {
                Hight = 180,
                Sex = 'm'

            };

            double weight = weightCalculator.GetIdealBodyWeight();

            Console.WriteLine($" The Ideal Body Weight is: {weight}");
            Console.ReadKey();
        }
    }
}
