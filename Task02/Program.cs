// Напишите программу, которая на вход принимает два числа и выдает, какое число большее, а какое меньшее

Console.WriteLine("Введите первое целое число");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе целое число");
int num2 = Convert.ToInt32(Console.ReadLine());
if (num1 < num2)
{
    Console.WriteLine($"Первое число {num1} меньше второго числа {num2}");
}
else
{
    Console.WriteLine($"Первое число {num1} больше второго числа {num2}");
}