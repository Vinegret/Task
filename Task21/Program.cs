// Напишите программу, которая 
// 1. принимает на вход 
// 2. координаты 2ух точек и 
// 3. находит расстояние между ними 
// 4. в 3D пространстве 


Console.WriteLine("Введите координаты точки 1: ");
Console.Write("Координата X первой точки -> ");
int x1Coordinate = Convert.ToInt32(Console.ReadLine());
Console.Write("Координата Y первой точки -> ");
int y1Coordinate = Convert.ToInt32(Console.ReadLine());
Console.Write("Координата Z первой точки -> ");
int z1Coordinate = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты точки 2: ");
Console.Write("Координата X второй точки -> ");
int x2Coordinate = Convert.ToInt32(Console.ReadLine());
Console.Write("Координата Y второй точки -> ");
int y2Coordinate = Convert.ToInt32(Console.ReadLine());
Console.Write("Координата Z второй точки -> ");
int z2Coordinate = Convert.ToInt32(Console.ReadLine());


double distanse = Distanse(x1Coordinate, y1Coordinate, z1Coordinate, x2Coordinate, y2Coordinate, z2Coordinate);
Console.WriteLine($"Расстояние от точки 1 до точки 2 = {Math.Round(distanse, 2, MidpointRounding.ToZero)}");

double Distanse (int x1, int y1, int z1, int x2, int y2, int z2)
{
    int difference1 = (x2 - x1)*(x2 - x1);
    int difference2 = (y2 - y1)*(y2 - y1);
    int difference3 = (z2 - z1)*(z2 - z1);
    double hypo = Math.Sqrt(difference1 + difference2 + difference3);
    return hypo;
}
