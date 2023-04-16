// Задайте двумерный массив размером m×n, заполненный случайными целыми числами.

int ReadData(string line)
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}

// Метод, генерирующий массив
int[,] Gen2DArray(int countRow, int countColumn, int minValue, int maxValue)
{
    int[,] arr = new int[countRow, countColumn];
    for (int i = 0; i < countRow; i++)
    {
        for (int j = 0; j < countColumn; j++)
        {
            arr[i,j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return arr;
}

void Priny2DArray(int[,] arr)
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
            Console.Write(arr[i,j]+" ");
            Console.ResetColor(); // сбрасывание цвета
        }
        Console.WriteLine();
    }
}

int row = ReadData("Введите количество строк: ");
int col = ReadData("Введите количество столбцов: ");
int[,] arr2D = Gen2DArray(row,col,10,99);
Priny2DArray(arr2D);