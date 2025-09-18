using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.KozyrevRA.Sprint1.Task4.V8.Lib;
namespace Tyuiu.KozyrevRA.Sprint1.Task4.V8
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #1 | Выполнил: Козырев Р. А. | СМАРТБ-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Class Math                                                        *");
            Console.WriteLine("* Задание #4                                                              *");
            Console.WriteLine("* Вариант #8                                                              *");
            Console.WriteLine("* Выполнил: Козырев Роман Артёмович | СМАРТБ-25-1                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные, *");
            Console.WriteLine("* вычисляет результат по формуле и печатает его на экране.                *");
            Console.WriteLine("* Ответ округлите до 3 знаков после запятой.                              *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("* Формула:                                                                *");
            Console.WriteLine("*   _______                                                               *");
            Console.WriteLine("* _/|x - y| + 3x                                                          *");
            Console.WriteLine("* --------------                                                          *");
            Console.WriteLine("*    3 + |x|                                                              *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            double x;
            Console.WriteLine("Введите значение X:");
            x = Convert.ToInt32(Console.ReadLine());
            double y;
            Console.WriteLine("Введите значение Y:");
            y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Результат:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*   _______                                                               *");
            Console.WriteLine("* _/|x - y| + 3x                                                          *");
            Console.WriteLine("* -------------- = " + ds.Calculate(x,y)+"                                *");
            Console.WriteLine("*    3 + |x|                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.ReadKey();
        }
    }
}