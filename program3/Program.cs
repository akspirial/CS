﻿//Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
//4 -> да
//-3 -> нет
//7 -> нет

Console.WriteLine("Введите число а: ");
	int a = int.Parse(Console.ReadLine());
	if (a % 2 == 0)
	{ 
		Console.Write("Это число четное ");
		Console.WriteLine(a);
		
	}
	else if (a % 2 != 0)
	{
         Console.Write("Это число не четное");
		 
	
	}