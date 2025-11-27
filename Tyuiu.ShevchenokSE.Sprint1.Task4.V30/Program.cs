using Tyuiu.ShevchenokSE.Sprint1.Task4.V30.Lib;
namespace Tyuiu.ShevchenokSE.Sprint1.Task4.V30
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #1 | Выполнил Шевченок С.Е. | СМАРТб-23-1 ";
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* Спринт #1                                                              *");
            Console.WriteLine("* Тема: Class Math                                                      *");
            Console.WriteLine("* Задание #4                                                             *");
            Console.WriteLine("* Вариант #30                                                            *");
            Console.WriteLine("* Выполнил: Шевченок Сергей Евгеньевич | СМАРТб-25-1                     *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                               *");
            Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные        *");
            Console.WriteLine("* данные, вычисляет результат по формуле и печатает его на экране.       *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                       *");
            Console.WriteLine("**************************************************************************");
            double x, y;
            Console.WriteLine("Введите значение X:");
            x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение Y:");
            y = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* РУЗУЛЬТАТ:                                                             *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("(x + y ^ 3) / e ^ 2 - y = " + ds.Calculate(x, y));
            Console.ReadLine();
        }
    }
}