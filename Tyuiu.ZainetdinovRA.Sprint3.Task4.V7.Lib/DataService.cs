using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.ZainetdinovRA.Sprint3.Task4.V7.Lib
{
    public class DataService : ISprint3Task4V7
    {
        public double Calculate(int startValue, int stopValue)
        {
            double y = 1;
            for (double x = startValue; x <= stopValue; x++)
            {
                if (x == 0)
                {
                    break;
                }
                y *= (x / Math.Cos(x)) + 1.5;
            }
            return Math.Round(y, 3);
        }
       
    }
}
