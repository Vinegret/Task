// 1. Задайте двумерный массив. 
// 2. Найдите сумму элементов находящихся на главной диагонали

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
            Console.Write($"{matrix[i, j], 5}");
        }
        Console.WriteLine();
    }
}

int SumElementsOnDiagonal(int[,] matr)
{
    int sum = 0;
    int j = 0;
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        if (i==j) 
        {
            sum = sum + matr[i,j];
            j++;
        }
    }
   return sum;
}

Console.WriteLine("Введите количество строк");
int Rows = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите количество столбцов");
int Columns = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите минимальное значение");
int Min = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите максимальное значение");
int Max = Convert.ToInt32(Console.ReadLine());

int[,] matrix = CreateMatrix(Rows,Columns,Min,Max);
PrintMatrix(matrix);
int sum = SumElementsOnDiagonal(matrix);
Console.Write($"Сумма элементов по диагонали равна -> {sum}");
