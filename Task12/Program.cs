// Напишите программу, которая 
// 1. принимает на вход число и 
// 2. проверяет, кратно ли оно одновременно 7 и 23


Console.WriteLine("Введите целое число ");
int number = Convert.ToInt32(Console.ReadLine());

bool result = Multiplisity(number);
Console.WriteLine(result ? "ДА" : "НЕТ");

bool Multiplisity(int num)
{
    return num % 7 == 0 && num % 23 == 0;
}