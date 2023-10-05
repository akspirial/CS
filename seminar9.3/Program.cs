using System;

class Prog
{
    static void Main(string[] args)
    {
        Console.Write("Введите значение m: ");
        int m = int.Parse(Console.ReadLine());
        Console.Write("Введите значение n: ");
        int n = int.Parse(Console.ReadLine());
        int result = Akkerman(m, n);
        Console.WriteLine("Значение функции Аккермана для m={0} и n={1} равно {2}", m, n, result);

        Console.ReadKey();
    }

    static int Akkerman(int m, int n)
    {
        if (m == 0)
        {
            return n + 1;
        }
        else if (n == 0)
        {
            return Akkerman(m - 1, 1);
        }
        else
        {
            return Akkerman(m - 1, Akkerman(m, n - 1));
        }
    }
}