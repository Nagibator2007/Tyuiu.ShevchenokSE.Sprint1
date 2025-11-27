using Tyuiu.ShevchenokSE.Sprint1.Task7.V2.Lib;
namespace Tyuiu.ShevchenokSE.Sprint1.Task7.V2
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #1 | Выполнил: Шевченок С.Е. | СМАРТб-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Создание итоговых проектов по спринту                             *");
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #25                                                             *");
            Console.WriteLine("* Выполнил: Шевченок Сергей Евгеньевич | СМАРТб-25-1                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая вычисляет математическое выражение          *");
            Console.WriteLine("* по исходным значениям данных, вводимых пользователем.                   *");
            Console.WriteLine("* Ответ округлите до 3 знаков после запятой.                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*      sin x + cos y                                                      *");
            Console.WriteLine("* z = --------------- tg xy                                               *");
            Console.WriteLine("*      cos x - sin y                                                      *");
            Console.WriteLine("***************************************************************************");
            double x, y, z;
            Console.WriteLine("Введите значение переменной x: ");
            x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение переменной y: ");
            y = Convert.ToDouble(Console.ReadLine());
            z = ((Math.Sin(x) + Math.Cos(y)) / (Math.Cos(x) - Math.Sin(y))) * Math.Tan(x * y);
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ 1:                                                            *");
            Console.WriteLine("Значение выражения равно: " + Math.Round(z, 3));
            Console.WriteLine("***************************************************************************");
            Console.WriteLine(ds.Calculate(x, y));
            Console.ReadKey();
        }
    }
}