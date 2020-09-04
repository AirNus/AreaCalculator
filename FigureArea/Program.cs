using System;

namespace FigureArea
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Выберите фигуру, площадь которой вы хотите расчитать:");
            Console.WriteLine("1 - Круг\n 2 - Квадрат\n 3 - Треугольник\n 4 - Произвольная\n");
            int FigureChoice = Convert.ToInt32(Console.ReadLine());
            switch(FigureChoice)
            {
                case 1: break;
                case 2: break;
                case 3: break;
                case 4: break;
            }
        }
    }
}
