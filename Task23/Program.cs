// Напишите программу, которая 
// 1. принимает на вход число(N) и 
// 2. выдает таблицу 
// 3. кубов чисел 
// 4. от 1 до N

Console.Write("Введите число -> ");
int number = Convert.ToInt32(Console.ReadLine());

Square (number);

void Square (int num)
{
    int count = 1;
    while ( count <= num )
    {
        Console.WriteLine($"{count,4}  {count*count*count,10}");
        count++;
    }
}