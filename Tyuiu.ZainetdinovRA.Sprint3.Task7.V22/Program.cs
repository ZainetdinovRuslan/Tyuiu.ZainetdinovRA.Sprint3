using System.Text;
using Tyuiu.ZainetdinovRA.Sprint3.Task7.V22.Lib;
namespace Tyuiu.ZainetdinovRA.Sprint3.Task7.V22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.OutputEncoding = Encoding.UTF8;
            Console.Title = "Спринт #3 | Выполнил: Zainetdinov R. A. | ИИПБ-24-2";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Добавление к решению итоговых проектов по спринту                 *");
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #22                                                             *");
            Console.WriteLine("* Выполнил: Зайнетдинов Руслан Александрович | ИИПБ-24-2                  *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Напишите программу, которая вывод таблицу значений функции:             *");
            Console.WriteLine("* F(x)= sin(x) + cos(2x) / 2 - 1.5x                                       *");
            Console.WriteLine("* (произвести табулирование) f(x) на заданном диапазоне [-5;5]            *");
            Console.WriteLine("* с шагом 1. Произвести провеку деления на ноль. При делении на ноль      *");
            Console.WriteLine("* вернуть значение 0. Значение округлить до 2 знаков после запятой.       *");
            Console.WriteLine("* Значения занести в массив.                                              *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int startValue = -5;
            int stopValue = 5;
            int range = Math.Abs(startValue - stopValue) + 1;
            double[] result = ds.GetMassFunction(startValue, stopValue);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ                                                               *");
            Console.WriteLine("***************************************************************************");

            for (int i = 0; i < range; i++)
            {
                Console.WriteLine($"{startValue} = {result[i]}");
                startValue++;
            }
        }
    }
}
