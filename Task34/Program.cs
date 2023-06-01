// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
//  Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int[] CreateArray(int size, int min, int max)
{
    int[] arr = new int[size];
    Random rnd = new Random();

    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(min, max + 1);
    }
    return arr;
}

void PrintArray(int[] arr, string sep)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}{sep} ");
        else Console.Write($"{arr[i]}");
    }
}

int numEven (int[] arr)
{
    int even = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        int num = arr[i]%2;
        if (num == 0 ) even ++;
    }
    return even;
}

int[] array = CreateArray(10, 100, 999);
Console.Write("[");
PrintArray(array, ",");
Console.Write("] -> ");

int NumEven = numEven(array);
Console.WriteLine($"Количество четных чисел в массиве равно {NumEven}");