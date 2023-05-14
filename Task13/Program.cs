// Напишите программу, которая 
// 1. выводит третью цифру заданного числа 
// 2. или сообщает, что третьей цифры нет.

Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());

int Digit = ThirdDigit(number);
string result = Digit < 1000 ? $"Третья цифра числа {number} -> {ThirdDigit} " : $"Число {number} не имеет третьей цифры";
Console.WriteLine(result);

int ThirdDigit (int num)
{
   while (num >= 1000) 
   {
    num = num / 10;
   }
   return num % 10;
}
