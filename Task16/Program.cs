// Напишите программу, которая 
// 1. принимает на вход два числа и 
// 2. проверяет, является ли одно число квадратом второго числа

Console.WriteLine("Введите первое целое число ");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе целое число ");
int number2 = Convert.ToInt32(Console.ReadLine());

bool result = Square(number1, number2);
Console.WriteLine(result ? "ДА" : "НЕТ");

bool Square(int num1, int num2)
{
    return num1 * num1 == num2 || num2 * num2 == num1;
}