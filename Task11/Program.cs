// Напишите программу, которая 
// 1. на вход будет принимать два числа и 
// 3. выводить, является ли первое число кратным второму. 
// 4. Если первое число не кратно второму, то 
// 5. программа выволит остаток от деления.

// Console.Write("Первое число -> ");
// int number1 = Convert.ToInt32(Console.ReadLine());

// Console.Write("Второе число -> ");
// int number2 = Convert.ToInt32(Console.ReadLine());

// int remainder = number1 % number2;

// if (remainder== 0)
// {
//     Console.WriteLine($"{number1} кратно {number2}");
// }
// else 
// {
//     Console.WriteLine($"{number1} не кратно {number2}, остаток равен {remainder}");
// }

Console.Write("Первое число -> ");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Второе число -> ");
int number2 = Convert.ToInt32(Console.ReadLine());

int remainder = Remainder(number1, number2);
string result = remainder != 0 ? $"{number1} не кратно {number2}, остаток равен {remainder}" : $"{number1} кратно {number2}";
Console.WriteLine(result);

int Remainder(int num1, int num2)
{
    return num1 % num2;
}