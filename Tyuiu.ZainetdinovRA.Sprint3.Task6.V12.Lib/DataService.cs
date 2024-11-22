using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.ZainetdinovRA.Sprint3.Task6.V12.Lib
{
    public class DataService : ISprint3Task6V12
    {
        public int GetSumTheDivisors(int startValue, int stopValue)
        {
            int count = 0;
            for (int number = startValue; number <= stopValue; number++)
            {
                for (int divisor = 1; divisor <= number; divisor++)
                {
                    if (number % divisor == 0)
                    {
                        count += divisor;
                    }
                }
            }
            return count;
        }
    }
}
