// Напишите программу, которая 
// 1. принимает на вход трёхзначное число и 
// 2. на выходе показывает вторую цифру этого числа.

Console.WriteLine("Введите целое трехзначное число");
int number = Convert.ToInt32(Console.ReadLine());

int result = SecondDigit(number);
Console.WriteLine($"Вторая цифра числа {number} -> {result}");

int SecondDigit(int num)
{
    return num % 100 / 10;
}