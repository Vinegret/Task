// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.WriteLine("Введите число которое хотите возвести в степень");
int number = Convert.ToInt32(Console.ReadLine());


Console.WriteLine("Введите степень");
int degree = Convert.ToInt32(Console.ReadLine());

int total = Total(number, degree);
Console.WriteLine($"Число {number} возведенное в степень {degree} = {total}");

int Total(int num, int degr)
{
    int i = 1;
    int result = 1;
    while(i <= degr)
    {
        result = result * num;
        i++;
    }
    return result;
}
