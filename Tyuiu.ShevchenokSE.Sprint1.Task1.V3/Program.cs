using Tyuiu.ShevchenokSE.Sprint1.Task1.V3.Lib;
namespace Tyuiu.ShevchenokSE.Sprint1.Task1.V3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #1| Выполнил: Шевченок С.Е.| СМАРТб-25-1";
            Console.WriteLine("**********************************************************");
            Console.WriteLine("* Спринт #1                                              *");
            Console.WriteLine("* Тема: Организация ввода вывода в консольных приложениях*");
            Console.WriteLine("* Задание #1                                             *");
            Console.WriteLine("* Вариант #3                                             *");
            Console.WriteLine("* Выполнил: Шевченок С.Е.| СМАРТб-25-1                   *");
            Console.WriteLine("**********************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                               *");
            Console.WriteLine("* Написать программу, которая запрашивает у пользователя *");
            Console.WriteLine("* исходные данные, вычисяет результат по формуле         *");
            Console.WriteLine("* (x-y)/(x+3)+3 и печатает его на экране.                *");
            Console.WriteLine("*                                                        *");
            Console.WriteLine("**********************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                       *");
            Console.WriteLine("**********************************************************");
            double x, y, a;
            Console.WriteLine("Введите значение X:*");
            x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение Y");
            y = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("**********************************************************");
            Console.WriteLine("* Результат:                                             *");
            Console.WriteLine("**********************************************************");
            Console.WriteLine(ds.Calculate(x, y));
            Console.ReadLine();
        }
    }
}