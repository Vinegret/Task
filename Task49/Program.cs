// 1. Задайте двумерный массив. 
// 2. Найдите элементы, у которых оба индекса четные и 
// 3. замените эти элементы на их квадраты.



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
            Console.Write($"{matrix[i,j], 5}");
        }  
        Console.WriteLine();
    }
}

int[,] SquareElem(int[,] Matrix)
{
    for (int i = 0; i < Matrix.GetLength(0); i+=2)
    {
        for (int j = 0; j < Matrix.GetLength(1); j+=2)
        {
            Matrix[i, j ] *= Matrix[i, j];
        }
    }
    return Matrix;
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
Console.WriteLine(" Двумерный массив : ");
PrintMatrix(matrix);
SquareElem(matrix);
Console.WriteLine(" Двумерный массив с квадратами :");
PrintMatrix(matrix);


