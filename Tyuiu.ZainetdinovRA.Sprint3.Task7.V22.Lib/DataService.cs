using System.ComponentModel.DataAnnotations;
using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.ZainetdinovRA.Sprint3.Task7.V22.Lib
{
    public class DataService : ISprint3Task7V22
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            int range = Math.Abs(startValue - stopValue) + 1;
            double[] arrValues = new double[range];
            
            for (int i = startValue; i <= stopValue; i++)
            {
                double denominator = Math.Cos(2 * i) / 2;
                double resultOfFunction;
                if (denominator == 0)
                {
                    resultOfFunction = 0;
                }
                else
                {
                    resultOfFunction = Math.Round(Math.Sin(i) + denominator - 1.5 * i, 2);
                }
                arrValues[i - startValue] = resultOfFunction;
            }
            return arrValues;
        }
    }
}
