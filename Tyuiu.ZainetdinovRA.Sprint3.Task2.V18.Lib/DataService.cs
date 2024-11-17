using System.Runtime.Intrinsics.Arm;
using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.ZainetdinovRA.Sprint3.Task2.V18.Lib
{
    public class DataService : ISprint3Task2V18
    {
        public double GetMultiplySeries(int value, int startValue, int stopValue)
        {
            double sumSeries = 1;
            double i = startValue;
            do
            {                
                sumSeries *= Math.Cos(value) + Math.Pow(i / 8, 3);
                i++;
            }
            while (i <= stopValue);
            return Math.Round(sumSeries, 3);
        }
    }
}
