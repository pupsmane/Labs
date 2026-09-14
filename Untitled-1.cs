using System;

class Program
{
    static void Main()
    {
Console.WriteLine("Введите сторону A"); // По данным сторонам прямоугольника вычислить его периметр, площадь и длину диагонали.
double a = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите сторону B"); 
double b = Convert.ToDouble(Console.ReadLine());
double P = 2*(a+b);
double S = a*b;
double d = Math.Sqrt(Math.Pow(a,2)+Math.Pow(b,2));
Console.WriteLine($"Периметр {P}, Площадь {S}, Диагональ {d}.");
    }
}