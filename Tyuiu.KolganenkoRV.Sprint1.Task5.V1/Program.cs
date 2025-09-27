using Tyuiu.KolganenkoRV.Sprint1.Task5.V1.Lib;

namespace Tyuiu.KolganenkoRV.Sprint1.Task5.V1
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #1 | Выполнила : Колганенко Р. В. | ИБКСб-25-1";
            //Длина строки 75 символов
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Базовые навыки работы в C#                                        *");
            Console.WriteLine("* Задание #5                                                              *");
            Console.WriteLine("* Вариант #1                                                              *");
            Console.WriteLine("* Выполнил: Колганенко Ринат Витальевич | ИБКСб-25-1                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Найти расстояние между двумя точками с заданными координатами (x, y).   *");
            Console.WriteLine("* Ответ привести к целому с помощью класса Convert.                       *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            double x1;
            double y1;
            double x2;
            double y2;

            Console.WriteLine("Введите координату x1:");
            x1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите переменную y1:");
            y1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите координату x2:");
            x2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите переменную y2:");
            y2 = double.Parse(Console.ReadLine());


            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");


            Console.WriteLine(" Расстояние между точками равно = " + ds.DistanceBetweenDots(x1, y1, x2, y2));
            Console.ReadLine();
        }
    }
}