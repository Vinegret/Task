// Напишите программу, которая 
// 1. по заданному номеру четверти, 
// 2. показывает диапазон возможных координат точек в этой четверти

Console.Write("Введите номер четверти -> ");
string imput = Console.ReadLine();

string range = Range (imput);
Console.WriteLine(range == null ? "Некорректный ввод" : $"Номер четверти соответствует диапазону -> {range}");

string Range (string num)
{
    if (num == "1" || num == "один" ) return "x > 0, y > 0";
    if (num == "2" || num == "два") return "x < 0, y > 0";
    if (num == "3" || num == "три") return "x < 0, y < 0";
    if (num == "4" || num == "четыре") return "x > 0, y < 0";
    return null;
}