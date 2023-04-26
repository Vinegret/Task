// Напишите программу, которая на вход принимает два числа и проверяет, является ли первое квадратом второго.

Console.WriteLine("Введите первое целое число");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе целое число");
int number2 = Convert.ToInt32(Console.ReadLine());
if (number1 * number1 == number2)
{
    Console.WriteLine($"Да, число {number2} является квадратом числа {number1}");
}
else
{
    Console.WriteLine($"Нет, число {number2} не является квадратом числа {number1}");
}