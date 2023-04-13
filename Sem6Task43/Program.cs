// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
//y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

//Метод, выполняющий чтение данных с консоли
int ReadData(string msg)
{
    Console.Write(msg);
    int res = int.Parse(Console.ReadLine() ?? "0");
    return res;
}

int CrossPointX(int k1, int b1, int k2, int b2)
{
        int x = (b2 - b1) / (k1 - k2);
        return x;
}

int CrossPointY(int k1, int b1, int k2, int b2)
{
        int y = k1 * ((b2 - b1) / (k1 - k2)) + b1;
        return y;
}

int k1Value = ReadData("Введите значение k1: ");
int b1Value = ReadData("Введите значение b1: ");
int k2Value = ReadData("Введите значение k2: ");
int b2Value = ReadData("Введите значение b2: ");

if((k1Value - k2Value) == 0)
{
    Console.Write("Разница k1 и k2 равняется нулю. А на ноль делить нельзя. Введите другие значения.");
}
if(k1Value == k2Value && b1Value == b2Value)
{
    Console.Write("Прямые совпадают");
}
if(k1Value == k2Value && b1Value != b2Value)
{
    Console.Write("Прямые параллельны");
}
else
{
int xValue = CrossPointX(k1Value, b1Value, k2Value, b2Value);
int yValue = CrossPointY(k1Value, b1Value, k2Value, b2Value);
Console.WriteLine("Заданные прямые пересекаются в точке с координатами: x (" + xValue + ") и y (" + yValue + ")");
}


