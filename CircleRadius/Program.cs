using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите длину стороны квадрата (a): ");
        double a = double.Parse(Console.ReadLine());

        Console.Write("Введите число секторов в r3: ");
        double b = double.Parse(Console.ReadLine());

        Console.Write("Введите число секторов в r2: ");
        double c = double.Parse(Console.ReadLine());

        Console.Write("Введите число секторов в r1: ");
        double d = double.Parse(Console.ReadLine());



        // Вычисляем радиус вписанной окружности
        double r = a / 2.0;

        // Вычисляем площадь квадрата
        double squareArea = a * a;

        // Вычисляем площадь вписанной окружности
        double circleArea = Math.PI * r * r;

        // Вычисляем площадь закрешенной фигуры за окружностью
        double shadedArea = ((squareArea - circleArea) / 2 + (squareArea - circleArea) / 4); // (squareArea - circleArea) / 2 - четрые закрашенных мини сектора из 8, а (squareArea - circleArea) / 4 - два закрашенных сектора из 8

        // Вычисляем площадь одного сектора
        double sectorArea = circleArea / 8.0;

        // Вычисляем площадь секторов в r3
        double SectorAreaR3 = sectorArea * b;

        // Вычисляем площадь секторов в r2
        double SectorAreaR2 = sectorArea * c;

        // Вычисляем площадь секторов в r1
        double SectorAreaR1 = sectorArea * d;

        //Вычисляем сумму площадей секторов r1,r2,r3
        double sumSectorArea = SectorAreaR1 + SectorAreaR2 + SectorAreaR3;

        //Площадь всей закрашенной фигуры
        double allSumFigure = shadedArea + sumSectorArea;
        // Вычисляем площадь первого радиуса
        Console.WriteLine("Площадь заштрихованной фигуры: " + shadedArea);

        //Вывод площади одного из секторов
        Console.WriteLine("Площадь одного из восьми секторов: " + sectorArea);

        //Вывод площади секторов, которые указаны в задаче
        Console.WriteLine("Площадь секторов: " + sumSectorArea);

        //Вывод суммы всей площади фигуры
        Console.WriteLine("Площадь всей закрашенной фигуры: " + allSumFigure);

        Console.WriteLine("Оранжевая часть " + (squareArea - circleArea) / 8);
    }
}
