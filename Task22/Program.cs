// Напишите программу, которая 
// 1. принимает на вход число(N) и 
// 2. выдает таблицу 
// 3. квадратов чисел 
// 4. от 1 до N

Console.WriteLine("Введите число ->");
int number = Convert.ToInt32(Console.ReadLine());

Square (number);

void Square (int num)
{
    int count = 1;
    while ( count <= num )
    {
        Console.WriteLine($"{count,3}  {count*count,5}");
        count++;
    }
}