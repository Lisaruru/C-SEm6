//Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
using System;

namespace exs41
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество чисел: ");
            int amount=Convert.ToInt32(Console.ReadLine());
           int[] arr=new int[amount];
           int posNum=0;
            for (int i=0; i<amount; i++)
            {
                 Console.WriteLine("Введите число: ");
                 arr[i] = Convert.ToInt32(Console.ReadLine());
                 if (arr[i]> 0)
                 {
                    posNum=posNum+1;
                 }
                 
            }
            Console.WriteLine("Введенный массив: ");
            for (int i=0; i<arr.Length; i++)
            {
                Console.Write($"{arr[i]} " );
            }
            Console.WriteLine();
            Console.WriteLine($"Количество чисел больше нуля= {posNum} ");



        
             
            
        }
    }
}
