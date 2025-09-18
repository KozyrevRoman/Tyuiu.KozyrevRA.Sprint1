using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.KozyrevRA.Sprint1.Task3.V18.Lib;
namespace Tyuiu.KozyrevRA.Sprint1.Task3.V18
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #1 | Выполнил: Козырев Р. А. | СМАРТБ-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Операторы составного присваивания                                 *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #18                                                             *");
            Console.WriteLine("* Выполнил: Козырев Роман Артёмович | СМАРТБ-25-1                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные, *");
            Console.WriteLine("* выполняет указанные расчёты и печатает результат на экране.             *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("* Расчеты:                                                                *");
            Console.WriteLine("* Написать программу, которая вычисляет, сколько квадратов со стороной C  *");
            Console.WriteLine("* можно разместить внутри прямоугольника с размерами A x B без наложений. *");
            Console.WriteLine("* Ответ округлите до 3 знаков после запятой.                              *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            double a;
            Console.WriteLine("Введите значение A:");
            a = Convert.ToInt32(Console.ReadLine());
            double b;
            Console.WriteLine("Введите значение B:");
            b = Convert.ToInt32(Console.ReadLine());
            double c;
            Console.WriteLine("Введите значение C:");
            c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Результат:                                                              *"); 
            Console.WriteLine("***************************************************************************");
            Console.WriteLine(ds.HowManySquares(a,b,c)+" квадратов со стороной "+c+ " можно разместить   *");
            Console.WriteLine("* внутри прямоугольника с размерами " + a+"*"+b+" без наложения           *");
            Console.WriteLine("***************************************************************************");

            Console.ReadKey();
        }
    }
}