// Задача 50. 
// 1.Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// 2. и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4


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

int NumELem(int[,] matr, int numRows, int numColumns)
{
    int elem = matr[numRows - 1 ,numColumns - 1 ];
    return elem;
}

void PrintElem(int numRows, int rows, int numColumns, int columns, int result)
{
    if (numRows < rows && numRows>0 && numColumns < columns && numColumns > 0)
    {
        Console.WriteLine($"Элемент находящийся на {numRows} строке и {numColumns} столбце имеет значение {result}");
    }
    else
    {
        Console.WriteLine("Элемент который вы выбрали находится за пределами двумерного массива");
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

Console.WriteLine("Введите номер строки");
int NumRows = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите номер столбца");
int NumColumns = Convert.ToInt32(Console.ReadLine());

int[,] createMatrix = CreateMatrix(Rows, Columns, Min, Max);
Console.WriteLine($"Матрица размером {Rows} * {Columns}:");
PrintMatrix(createMatrix);

int Result = NumELem(createMatrix, NumRows , NumColumns);
PrintElem(NumRows, Rows, NumColumns, Columns, Result);







