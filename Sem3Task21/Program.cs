// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

//Чтение данных консоли
int ReadData(string message)
{
    Console.WriteLine(message);
    int res = int.Parse(Console.ReadLine() ?? "0");
    return res;
}

//Метод находит расстояние между точками в 3D пространстве
double CalcLen3D(int x1, int y1, int z1, int x2, int y2, int z2)
{
    //квадрат гипотенузы равен сумме квадратов катетов (плюс квадрат z)
    return Math.Sqrt(Math.Pow((x1 - x2), 2) + (y1 - y2) * (y1 - y2) + Math.Pow((z1 - z2), 2));
}

int x1 = ReadData("Введите координату x точки A: ");
int y1 = ReadData("Введите координату y точки A: ");
int z1 = ReadData("Введите координату z точки A: ");
int x2 = ReadData("Введите координату x точки B: ");
int y2 = ReadData("Введите координату y точки B: ");
int z2 = ReadData("Введите координату z точки B: ");

//Вывод результата
Console.WriteLine("Расстояние между точками A и B: " + CalcLen3D(x1, y1, z1, x2, y2, z2));
