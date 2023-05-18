// Задача 28: Напишите программу, которая
// 1. принимает на вход число N и 
// 2. выдаёт произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120

Console.WriteLine("Введите целое положительное число");
int number = Convert.ToInt32(Console.ReadLine());

int numbers = Num(number);
Console.WriteLine($"Произведение чисел от 1 до {number} = {numbers}");

int Num (int num)
{
    int fact = 1;
    for (int i = 1; i <= num; i++)
    {
       fact = fact * i;
    }
    return fact;
}