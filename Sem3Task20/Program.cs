// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между
// ними в 2D пространстве.

//Чтение данных консоли
int ReadData(string message)
{
    Console.WriteLine(message);
    int res = int.Parse(Console.ReadLine() ?? "0");
    return res;
}

//Метод находит расстояние между точками на плоскости
double CalcLen2D(int x1, int y1, int x2, int y2)
{
    return Math.Sqrt(Math.Pow((x1 - x2), 2) + (y1 - y2) * (y1 - y2));
}

int x1 = ReadData("Введите координату x точки A: ");
int y1 = ReadData("Введите координату y точки A: ");
int x2 = ReadData("Введите координату x точки B: ");
int y2 = ReadData("Введите координату y точки B: ");

Console.WriteLine("Расстояние между точками A и B: " + CalcLen2D(x1, y1, x2, y2));

// Второй способ
// using System;

// class Program
// {
//     static void Main(string[] args)
//     {
//         // Запрос координат первой точки
//         Console.WriteLine("Введите координаты первой точки:");
//         Console.Write("X1: ");
//         double x1 = double.Parse(Console.ReadLine());
//         Console.Write("Y1: ");
//         double y1 = double.Parse(Console.ReadLine());

//         // Запрос координат второй точки
//         Console.WriteLine("Введите координаты второй точки:");
//         Console.Write("X2: ");
//         double x2 = double.Parse(Console.ReadLine());
//         Console.Write("Y2: ");
//         double y2 = double.Parse(Console.ReadLine());

//         // Вычисление расстояния между двумя точками
//         double distance = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));

//         // Вывод результата
//         Console.WriteLine("Расстояние между двумя точками: {0}", distance);
//     }
// }
