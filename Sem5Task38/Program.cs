// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементом массива.

//Метод, выполняющий чтение данных с консоли
int ReadData(string msg)
{
    Console.Write(msg);
    int res = int.Parse(Console.ReadLine() ?? "0");
    return res;
}

//Метод, генерирующий массив вещественных чисел
double[] Gen1DArray(int len, int bot, int top)
{
    double[] res = new double[len];
    Random number = new Random();
    for(int i = 0; i < len; i++)
    {
        res[i] = number.Next(bot, top) + number.NextDouble(); // генерация вещественных чисел от нижней до верхней границы
        //res[i]= number.NextDouble(); - если генерировать вещественные числа от 0 до 1
    }
    return res;
}

//Метод печати одномерного массива
void Print1DArray(double[] arr)
{
    Console.Write("[");
    for(int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i] + ",");
    }
    Console.WriteLine(arr[arr.Length - 1] + "]");
}

double DiffMaxMin(double[] arr)
{
    double diff = 0;
    double min = arr[0];
    double max = arr[0];
    for(int i = 0; i < arr.Length; i++)
    {
        if(arr[i] < min)
        {
            min = arr[i];
        }
        if(arr[i] > max) max = arr[i];
    }
    diff = max - min;
    return diff;
}

int lenArr = ReadData("Введите длину массива: ");
int bottom = ReadData("Введите нижнюю границу массива: ");
int top = ReadData("Введите верхнюю границу массива: ");
double[] arr = Gen1DArray(lenArr, bottom, top);
//double[] arr = Gen1DArray(lenArr, 0, 1); - для генерации массива от 0 до 1
Console.WriteLine("Искомый массив: ");
Print1DArray(arr);
Console.Write("Разница между максимальным и минимальным элементами массива: ");
Console.WriteLine(DiffMaxMin(arr));