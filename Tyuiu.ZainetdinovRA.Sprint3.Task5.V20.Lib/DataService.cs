using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.ZainetdinovRA.Sprint3.Task5.V20.Lib
{
    public class DataService : ISprint3Task5V20
    {
        public double GetSumSumSeries(int x, int startValue1, int startValue2, int stopValue1, int stopValue2)
        {
            double sumSumSeries = 0;
            for (int i = startValue1; i <= stopValue1; i++)
            {
                for (int j = startValue2; j <= stopValue2; j++)
                {
                    sumSumSeries += Math.Pow(x / Math.Sin(x), j);
                }
            }
            return Math.Round(sumSumSeries, 3);
        }
    }
}
