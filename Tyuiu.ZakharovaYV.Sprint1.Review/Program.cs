using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.ZakharovaYV.Sprint1.Review.V.Lib;

namespace Tyuiu.ZakharovaYV.Sprint1.Review
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт#1 |Выполнила: Захарова Ю.В. |ПКТб-23-2";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт# 1                                                               *");
            Console.WriteLine("* Тема: Итоговое решение по спринту                                       *");
            Console.WriteLine("* Задание # Review                                                        *");
            Console.WriteLine("* Вариант # 28                                                            *");
            Console.WriteLine("* Выполнила: Захарова Юлиана Владимировна | ПКТб-23-2                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая вычисляет математическое выражение          *");
            Console.WriteLine("* по исходным значениям данных,вводимых пользователем.                    *");
            Console.WriteLine(" Ответ округлите до 3 знаков после запятой.                               *");
            Console.WriteLine("*     z =((sinx + cosy)/(cosx -siny)) * tg(x * y)                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            double x, y;

            Console.WriteLine("Введите значение Х :");
            x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение Y :");
            y = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine(ds.Calculate(x, y));
            Console.ReadKey();
        }
    }
}
