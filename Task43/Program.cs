// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
int Size = 2;

int[] Line1(int size)
{
    int[] arr1 = new int[size];
    Console.WriteLine($"Введите значение b1 = ");
    arr1[0] = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine($"Введите значение k1 = ");
    arr1[1] = Convert.ToInt32(Console.ReadLine());
    return arr1;
}

int[] Line2(int size)
{
    int[] arr2 = new int[size];
    Console.WriteLine($"Введите значение b2 = ");
    arr2[0] = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine($"Введите значение k2 = ");
    arr2[1] = Convert.ToInt32(Console.ReadLine());
    return arr2;
}

int[] Coordinate(int[] Arr1, int[] Arr2, int size)
{
    int[] LineCoord = new int[size];
    int coefK = Arr1[1] - Arr2[1];
    int coefB = Arr1[0] - Arr2[0];
    int x = -(coefB / coefK);
    int y = Arr2[1] * x + Arr2[0];
    return new int[2] { x, y };
}

void PrintArray(int[] LineCoord)
{
    Console.Write($"{LineCoord[0]}, ");
    Console.Write($"{LineCoord[1]}");
}

int[] array1 = Line1(Size);
int[] array2 = Line2(Size);
int[] coordinate = Coordinate(array1, array2, Size);

Console.Write("[");
PrintArray(coordinate);
Console.Write("]");