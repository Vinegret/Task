﻿// Напишите программу, которая 
// 1. на вход принимает число и 
// 2. выдает его квадрат (число умноженное само на себя).
// Например:
// 4 -> 16
// -3 -> 9
// -7 -> 49

Console.WriteLine("Введите целое число");
int number = Convert.ToInt32(Console.ReadLine());
// - 2 147 483 648 ... 2 147 483 648
int square = number * number;
Console.WriteLine($"Квадрат числа {number} = {square}");