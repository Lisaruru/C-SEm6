//Напишите программу, которая найдёт точку пересечения двух прямых,
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 
//задаются пользователем.

using System;

namespace exs43
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Console.WriteLine("Введите значение b1: ");
            double b1=Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение b2: ");
            double b2=Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение k1: ");
            double k1=Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение k2: ");
            double k2=Convert.ToDouble(Console.ReadLine());
            
            double dotX0=(b2-b1)/(k1-k2);
            double dotY0=k1*dotX0+b1;
            
            Console.WriteLine($"Точка пересечения двух прямых:= {dotX0}; {dotY0} ");
        }
    }
}
