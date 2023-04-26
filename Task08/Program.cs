// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.WriteLine("Введите целое положительное число");
int num1 = Convert.ToInt32(Console.ReadLine());
int num2 = 2;
while (num2 <= num1)
{
    Console.Write($" {num2} ,");
    num2 = num2 + 2;
}
