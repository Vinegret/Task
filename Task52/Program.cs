// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int[,] CreateMatrix(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j], 7}");
        }
        Console.WriteLine();
    }
}

void Arif (int m, int n, int[,] matr)
{
    int row=1;
    int column=1;
    for (int b = 0; b < n; b++)
    {
        double sum = 0;
        double average = 0;
        for (int a = 0; a < m; a++)
        {
            sum = sum + matr[a, b];
            average = sum / m;
        }
        Console.WriteLine($"Среднее арифметическое в {column} столбце = {average,2} ");
        column++ ;
    }
}

Console.WriteLine("Введите количество строк");
int Rows = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите количество столбцов");
int Columns = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите минимальное значение");
int Min = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите максимальное значение");
int Max = Convert.ToInt32(Console.ReadLine());

int[,]createMatrix = CreateMatrix(Rows, Columns, Min, Max);
Console.WriteLine("Двумерная матрица: ");
PrintMatrix(createMatrix);

Arif(Rows,Columns,createMatrix);




