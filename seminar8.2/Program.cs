using System;

class Prog
{
    static void Main()
    {
        int[,] array = new int[,]
        {
            {1, 4, 7, 2},
            {5, 9, 2, 3},
            {8, 4, 2, 4},
            {5, 2, 6, 7}
        };

        int rows = array.GetLength(0);
        int cols = array.GetLength(1);

        int minSumRow = 0;  // номер строки с меньшей суммой
        int minSum = int.MaxValue;  
        for (int row = 0; row < rows; row++)
        {
            int sum = 0; 
            for (int col = 0; col < cols; col++)
            {
                sum += array[row, col];
            }
            if (sum < minSum)
            {
                minSum = sum;
                minSumRow = row;
            }
        }

        Console.WriteLine("Строка с наименьшей суммой элементов: ");

        // Выводим строкy с наименьшей суммой
        for (int col = 0; col < cols; col++)
        {
            Console.Write(array[minSumRow, col] + " ");
        }

        Console.WriteLine();
    }
}