using System;

public class ShapeCalculator
{
    // Метод для вычисления площади круга по радиусу
    public double CalculateCircleArea(double radius)
    {
        return Math.PI * radius * radius;
    }

    // Метод для вычисления площади треугольника по трем сторонам (по формуле Герона)
    public double CalculateTriangleArea(double sideA, double sideB, double sideC)
    {
        double p = (sideA + sideB + sideC) / 2; // полупериметр треугольника
        return Math.Sqrt(p * (p - sideA) * (p - sideB) * (p - sideC));
    }

    // Метод для проверки, является ли треугольник прямоугольным
    public bool IsRightTriangle(double sideA, double sideB, double sideC)
    {
        // Проверяем теорему Пифагора
        double[] sides = { sideA, sideB, sideC };
        Array.Sort(sides);
        return sides[0] * sides[0] + sides[1] * sides[1] == sides[2] * sides[2];
    }
}

public class Shape
{
    // Метод для вычисления площади фигуры без знания типа фигуры в compile-time
    public static double CalculateArea(dynamic shape, params double[] args)
    {
        return shape.CalculateArea(args);
    }
}