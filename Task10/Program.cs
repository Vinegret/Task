// Напишите программу, которая 
// 1. выводит случайное 
// 2. трехзначное число и 
// 3. удаляет вторую цифру этого числа.

int number = new Random().Next(100,1000);
Console.WriteLine($"Случайное число из промежутка 100 - 999 -> {number}");

int RemoveSecondDigit(int num)
{
    int FirstDigit = num / 100;
    int LastDigit = num % 10;
    return FirstDigit * 10 + LastDigit;
}
int result = RemoveSecondDigit(number);
Console.WriteLine($"{number} -> {result}");