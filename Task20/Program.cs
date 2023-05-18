// Напишите программу, которая 
// 1. принимает на вход 
// 2. координаты 2ух точек и 
// 3. находит расстояние между ними 
// 4. в 2D пространстве 

Console.WriteLine("Введите координаты точки 1 -> ");
Console.Write("Координата X первой точки: ");
int x1Coordinate = Convert.ToInt32(Console.ReadLine());
Console.Write("Координата Y первой точки: ");
int y1Coordinate = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты точки 2 -> ");
Console.Write("Координата X второй точки: ");
int x2Coordinate = Convert.ToInt32(Console.ReadLine());
Console.Write("Координата Y второй точки: ");
int y2Coordinate = Convert.ToInt32(Console.ReadLine());


int distanse = Distanse(x1Coordinate, y1Coordinate, x2Coordinate, y2Coordinate);
Console.WriteLine($"Расстояние от точки 1 до точки 2 = {distanse} ");

int Distanse (int x1, int y1, int x2, int y2)
{
    difference1 = (x2 - x1)*(x2 - x1);
    difference2 = (y2 - y1)*(y2 - y1);
    num = difference1 + difference2;
    double square = Math.Sqrt(num);
    return square;
}
