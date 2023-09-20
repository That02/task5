// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива

using System;

class Program
{
    static void Main(string[] args)
    {
        
        double[] numbers = { 2.5, 4.7, 1.3, 9.2, 5.0 };

       
        double min = numbers[0];
        double max = numbers[0];

        
        for (int i = 1; i < numbers.Length; i++)
        {
            if (numbers[i] < min)
                min = numbers[i];

            if (numbers[i] > max)
                max = numbers[i];
        }
        double difference = max - min;

        Console.WriteLine("Разница между максимальным и минимальным элементами массива: " + difference);
    }
}
