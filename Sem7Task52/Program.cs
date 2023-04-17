// Задайте двумерный массив из целых чисел. 
//Найдите среднее арифметическое элементов в каждом столбце.

//Метод, выполняющий чтение данных с консоли
int ReadData(string msg)
{
    Console.Write(msg);
    int res = int.Parse(Console.ReadLine() ?? "0");
    return res;
}

// Метод, генерирующий двумерный массив
int[,] Gen2DArray(int rows, int columns, int bottom, int top)
{
    int[,] arr = new int[rows, columns];
    for(int i = 0; i < rows; i++)
    {
        for(int j = 0; j < columns; j++)
        {
            arr[i,j] = new Random().Next(bottom, top + 1);
        }
    }
    return arr;
}

// метод печати двумерного массива
void Print2DArray(int[,] arr)
{
    // раскрашивание массива
    ConsoleColor[] col = new ConsoleColor[]{ConsoleColor.Black,ConsoleColor.Blue,ConsoleColor.Cyan,
                                        ConsoleColor.DarkBlue,ConsoleColor.DarkCyan,ConsoleColor.DarkGray,
                                        ConsoleColor.DarkGreen,ConsoleColor.DarkMagenta,ConsoleColor.DarkRed,
                                        ConsoleColor.DarkYellow,ConsoleColor.Gray,ConsoleColor.Green,
                                        ConsoleColor.Magenta,ConsoleColor.Red,ConsoleColor.White,
                                        ConsoleColor.Yellow};

    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.ForegroundColor = col[new Random().Next(0,16)]; //задание цвета шрифту
            Console.Write(arr[i,j]+" "); // печать в 1 строку
            Console.ResetColor(); // сбрасывание цвета
        }
        Console.WriteLine(); // переход на новую строку по окончании цикла по столбцам (j)
    }
}

double[] ColumnMean(int[,] arr)
{
    double[] mean = new double[arr.GetLength(1)];
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            mean[j] += arr[i,j];
        }
        mean[j] = mean[j] / arr.GetLength(0);
    }
    return mean;
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

int arrRows = ReadData("Введите количество строк в двумерном массиве: ");
int arrColumns = ReadData("Введите количество столбцов в двумерном массиве: ");
int[,] testArr2D = Gen2DArray(arrRows, arrColumns, 10, 99);
Print2DArray(testArr2D);
double[] arrOfMeans = ColumnMean(testArr2D);
Print1DArray(arrOfMeans);
