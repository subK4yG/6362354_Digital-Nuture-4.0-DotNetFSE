using System;
namespace FinancialForecasting
{
    class Program
    {
        static double PredictFutureValue(double current, double rate, int years)
        {
            if (years == 0)
                return current;
            return PredictFutureValue(current * (1 + rate), rate, years - 1);
        }
        static void Main()
        {
            double presentValue = 10000;
            double growthRate = 0.10;
            int years = 5;
            double futureValue = PredictFutureValue(presentValue, growthRate, years);
            Console.WriteLine("Future Value after " + years + " years: Rs." + futureValue);
        }
    }
}
