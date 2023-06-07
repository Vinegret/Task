// 1.Задайте двумерный массив
// 2.размером m*n
// 3.каждый элемент массива выводится по формуле: A[m,n] = m + n

// m = 3, n = 4

//      0   1   2   3
// 0    0   1   2   3 
// 1    1   2   3   4
// 2    2   3   4   5


int[,] CreateMatrixRndInt(int rows, int columns)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = i + j ;
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

int[,] array2D = CreateMatrixRndInt(3, 4);
PrintMatrix(array2D);
