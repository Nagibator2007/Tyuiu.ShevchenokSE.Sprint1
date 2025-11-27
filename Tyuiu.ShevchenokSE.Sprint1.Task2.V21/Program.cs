using Tyuiu.ShevchenokSE.Sprint1.Task2.V21.Lib;
namespace Tyuiu.ShevchenokSE.Sprint1.Task2.V21
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
            Console.WriteLine("* Известны длины стороны прямоугольника.Вычислить площадь*");
            Console.WriteLine("**********************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                       *");
            Console.WriteLine("**********************************************************");
            int x;
            Console.WriteLine("Введите значение первой стороны:*");
            x = Convert.ToInt32(Console.ReadLine());
            int y;
            Console.WriteLine("Введите значение второй стороны");
            y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("**********************************************************");
            Console.WriteLine("* Результат:                                             *");
            Console.WriteLine("**********************************************************");
            Console.WriteLine("Площадь прямоугольника равна:" + ds.CalculateRectangleSquare(x, y));
            Console.ReadLine();
        }
    }
}
