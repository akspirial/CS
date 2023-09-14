//Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
//5 -> 2, 4
//8 -> 2, 4, 6, 8

Console.WriteLine("Введите число а: ");
		int N = int.Parse(Console.ReadLine());
		int b = 1;
		while (b < N)
		{  
			if ( b % 2 == 0)
			{
			Console.WriteLine(b);
			}
		b ++;
		}