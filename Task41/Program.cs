// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3
Console.WriteLine("Введите размер массива");
int size = Convert.ToInt32(Console.ReadLine()); 

int[] CreateArray (int sizeM)
{
    int[] arr = new int[size];

    for (int i = 0; i < arr.Length; i++)
    {
        Console.WriteLine($"Введите {i} элемент ");
        arr[i] = Convert.ToInt32(Console.ReadLine());
    }
    return arr;
}
    
void PrintArray (int[] arr, string sep)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}{sep} ");
        else Console.Write($"{arr[i]}");
    }
    
}

int NumPositive (int[] arr)
{
    int num = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i]>0) num++;
    }
    return num;
}

int[] array = CreateArray(size);
Console.Write("[");
PrintArray(array, ",");
Console.Write("] -> ");

int numPositive = NumPositive(array);
Console.Write($"Чисел в массиве больше 0 = {numPositive}");


