// Напишите программу, которая 
// 1. на вход принимает 
// 2. пятизначное число и 
// 3. проверяет является ли оно палиндромом

Console.Write("Введите пятизначное число -> ");
int number = Convert.ToInt32(Console.ReadLine());

int palindrome = Palindrome (number);
string result = palindrome == 0 ? "Некорректный ввод" : $"Число {number} является палиндромом";
Console.WriteLine(result);

int Palindrome (int num)
{
    int num5 = num % 10;
    int num4 = num5 % 10;
    int num3 = num4 % 10;
    int num2 = num3 % 10;
    int num1 = num2 % 10;
    if (num5 == num1 && num4 == num2) return 1;
    return 0;
}