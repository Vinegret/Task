﻿// Напишите программу, которя принимает на вход трехзначное число и на выходе показывает последнюю цифру этого числа

Console.WriteLine("Введите целое трехзначное число");
int num = Convert.ToInt32(Console.ReadLine());
int LastNum = num % 10;
Console.WriteLine($"Последняя цифра числа {num} - {LastNum}");
