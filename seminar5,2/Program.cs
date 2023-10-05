using System;

class Programm
{
    static void Main()
    {
        Console.WriteLine("Введите числа, разделенные пробелами:");
        string input = Console.ReadLine();

        string[] numbersString = input.Split(' '); 
        int[] numbers = new int[numbersString.Length];

        for (int i = 0; i < numbersString.Length; i++)
        {
            numbers[i] = int.Parse(numbersString[i]); 
        }

        int sum = 0;
        for (int i = 1; i < numbers.Length; i += 2)
        {
            sum += numbers[i];
        }

        Console.WriteLine("Сумма элементов на нечетных индексах: " + sum);
    }
}