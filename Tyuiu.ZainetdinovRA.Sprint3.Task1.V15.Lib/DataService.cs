﻿using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.ZainetdinovRA.Sprint3.Task1.V15.Lib
{
    public class DataService : ISprint3Task1V15
    {
        public double GetMultiplySeries(int value, int startValue, int stopValue)
        {
            double sumSeries = 1;
            int i = startValue;
            while (i <= stopValue)
            {
                sumSeries *= ((Math.Pow(value, 2) * i) + 1);
                i++;
            }
            return sumSeries;
        }
    }
}
