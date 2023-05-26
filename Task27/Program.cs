// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12


Console.WriteLine("Введите целое число");
int number = Convert.ToInt32(Console.ReadLine());

int SumNumbers(int num)
{
    int result = 0;
    while (num > 0)
    {
        int i = num % 10;
        num = num / 10;
        result = result + i;
    }
    return result;
}

int sumNumbers = SumNumbers(number);
Console.WriteLine($"Сумма цифр в числе {number} = {sumNumbers}");