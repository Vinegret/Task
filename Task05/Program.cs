// Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числa в промежутке от -N до N

Console.WriteLine("Введите целое положительное число");
int num1 = Convert.ToInt32(Console.ReadLine());
int num2 = -num1;
while (num2 <= num1)
{
    Console.Write($" {num2} ,");
    num2 ++;
}
