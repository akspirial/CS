using System;

class Prog
{
    static void Main()
    {
        int[,] array = new int[,]
        {
            {1, 4, 7, 2},
            {5, 9, 2, 3},
            {8, 4, 2, 4}
        };
        
        int rows = array.GetLength(0);
        int cols = array.GetLength(1);
        for (int row = 0; row < rows; row++)
        {
            for (int col = 0; col < cols - 1; col++)
            {
                for (int j = col + 1; j < cols; j++)
                {
                    if (array[row, j] > array[row, col])
                    {
                        int temp = array[row, col];
                        array[row, col] = array[row, j];
                        array[row, j] = temp;
                    }
                }
            }
        }
        for (int row = 0; row < rows; row++)
        {
            for (int col = 0; col < cols; col++)
            {
                Console.Write(array[row, col] + " ");
            }
            Console.WriteLine();
        }
    }
}