using System;

class Prog
{
    static void Main()
    {
        int[,,] array = new int[2, 3, 4]
        {
            {
                {66, 27, 3, 4},
                {25, 90, 7, 8},
                {9, 10, 11, 12}
            },
            {
                {34, 26, 15, 16},
                {41, 55, 19, 20},
                {21, 22, 23, 24}
            }
        };

        int dim1 = array.GetLength(0);
        int dim2 = array.GetLength(1);
        int dim3 = array.GetLength(2);

        for (int i = 0; i < dim1; i++)
        {
            for (int j = 0; j < dim2; j++)
            {
                for (int k = 0; k < dim3; k++)
                {
                    Console.WriteLine($"[{i}][{j}][{k}] = {array[i, j, k]}");
                }
            }
        }
    }
}