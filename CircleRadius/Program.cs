﻿using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите длину стороны квадрата (a): ");
        double a = double.Parse(Console.ReadLine());

        Console.Write("Введите число секторов в r3: ");
        double b = double.Parse(Console.ReadLine());

        Console.Write("Введите радиус окружности r3: ");
        double r3 = double.Parse(Console.ReadLine());

        Console.Write("Введите число секторов в r2: ");
        double c = double.Parse(Console.ReadLine());

        Console.Write("Введите радиус окружности r2: ");
        double r2 = double.Parse(Console.ReadLine());

        Console.Write("Введите число секторов в r1: ");
        double d = double.Parse(Console.ReadLine());

        Console.Write("Введите радиус окружности r1: ");
        double r1 = double.Parse(Console.ReadLine());


        // Вычисляем площадь квадрата
        double squareArea = a * a;

        // Вычисляем площадь большой вписанной окружности
        double circleArea = Math.PI * r3 * r3; // 78.5

        // Вычисляем площадь большого сектора
        double firstSectorArea = circleArea / 8.0;


        // Вычисляем площадь среднего сектора r2
        double secondSectorArea = (Math.PI * r2 * r2) / 8.0; // 3.5

        //Вычисляем площадь большого сектора r3
        double firstSSectorArea = firstSectorArea - secondSectorArea;

        //Вычисление площади маленького сектора  r1
        double lastSectorArea  = (Math.PI * r1 * r1) / 8.0; // 0.39

        // Вычисляем площадь закрешенной фигуры за окружностью
        double shadedArea = ((squareArea - circleArea) / 2 + (squareArea - circleArea) / 4); // (squareArea - circleArea) / 2 - четрые закрашенных мини сектора из 8, а (squareArea - circleArea) / 4 - два закрашенных сектора из 8

        
        // Вычисляем площадь секторов в r3
        double SectorAreaR3 = firstSSectorArea * b;

        // Вычисляем площадь секторов в r2
        double SectorAreaR2 = secondSectorArea * c;

        // Вычисляем площадь секторов в r1
        double SectorAreaR1 = lastSectorArea * d;

        //Вычисляем сумму площадей секторов r1,r2,r3
        double sumSectorArea = SectorAreaR1 + SectorAreaR2 + SectorAreaR3;

        //Площадь всей закрашенной фигуры
        double allSumFigure = shadedArea + sumSectorArea;
        // Вычисляем площадь первого радиуса
        Console.WriteLine("Площадь заштрихованной фигуры: " + shadedArea);

        //Вывод площади одного из секторов
        Console.WriteLine("Площадь одного из восьми секторов: " + firstSectorArea);

        //Вывод площади секторов, которые указаны в задаче
        Console.WriteLine("Площадь секторов: " + sumSectorArea);

        //Вывод суммы всей площади фигуры
        Console.WriteLine("Площадь всей закрашенной фигуры: " + allSumFigure);

        //Вывод r3
        Console.WriteLine("r3: " + firstSSectorArea);

        //Вывод r2
        Console.WriteLine("r2: " + secondSectorArea);

        //Вывод r1
        Console.WriteLine("r1: " + lastSectorArea);

    }
}
