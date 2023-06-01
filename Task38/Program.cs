// Задача 38: Задайте массив вещественных чисел.
//  Найдите разницу между максимальным и минимальным элементов массива.
// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2

int[] CreateArray(int size, int min, int max)
{
    int [] arr = new int[size];
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

float minElem (float[] arr)
{
    float min = arr[0];
    for (int i = 1; i < arr.Length; i++)
    {
        if( min < arr[i]) ;
        else min = arr[i];
    }
    return min ;
}

float maxElem (float[] arr)
{
    float max = arr[0];
    for (int i = 1; i < arr.Length; i++)
    {
        if( max > arr[i]) ;
        else max = arr[i];
    }
    return max ;
}

float diff (float minEl, float maxEl)
{
    float difference = maxEl - minEl;
    return difference;
}


int[] array = CreateArray(10, 0, 99);
Console.Write("[");
PrintArray(array, ",");
Console.Write("] -> ");

float MinElem = minElem(array);
float MaxElem = maxElem(array);
Console.WriteLine($"Минимальный элемент в массиве = {MinElem}");
Console.WriteLine($"Максимальный элемент в массиве = {MaxElem}");

float Diff = diff(MinElem, MaxElem);
Console.WriteLine($"Разница максимального и минимального элемента в массиве = {Diff}");