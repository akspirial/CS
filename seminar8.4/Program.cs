class Prog
{
    static void Main()
    {
        int n = 4;  
        int[,] array = new int[n, n];  

        int value = 01;  
        int rowStart = 0, rowEnd = n - 1;  
        int colStart = 0, colEnd = n - 1; 
        while (value <= n * n)
        {
            for (int i = colStart; i <= colEnd; i++)
            {
                array[rowStart, i] = value++;
            }
            rowStart++;
            for (int i = rowStart; i <= rowEnd; i++)
            {
                array[i, colEnd] = value++;
            }
            colEnd--;
            for (int i = colEnd; i >= colStart; i--)
            {
                array[rowEnd, i] = value++;
            }
            rowEnd--;
            for (int i = rowEnd; i >= rowStart; i--)
            {
                array[i, colStart] = value++;
            }
            colStart++;
        }
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write(array[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }
}