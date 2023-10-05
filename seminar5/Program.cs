using System;

class Programm
{
    static void Main()
    {
        Random random = new Random();

        int size = 10;

        int[] array = new int[size];
        for (int i = 0; i < size; i++)
        {
            array[i] = random.Next(100, 1000);
        }

        int count = 0;
        for (int i = 0; i < size; i++)
        {
            if (array[i] % 2 == 0)
            {
                count++;
            }
        }
        Console.WriteLine($"Количество четных чисел в массиве: {count}");
    }
}