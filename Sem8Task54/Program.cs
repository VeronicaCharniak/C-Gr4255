//Задайте двумерный массив. Напишите программу, 
//которая упорядочит по убыванию элементы каждой строки двумерного массива.

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

//метод сортировки пузырьком
void BubbleSort(int[] arr)
{
    for(int i = 0; i < arr.Length; i++)
    {
        for (int j = 0; j < arr.Length-1-i; j++)
        {
            if(arr[j] < arr[j+1])
            {
                int buf = arr[j];
                arr[j] = arr[j+1];
                arr[j+1] = buf;
            }
        }
    }
}

//Метод, сортирующий массив построчно
void SortingRaws(int[,] arr)
{
    int[] buffer = new int[arr.GetLength(1)];
     for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            buffer[j] = arr[i, j];
        }
        BubbleSort(buffer);
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = buffer[j];
        }
    }
}

int testRaws = ReadData("Введите количество строк в генерируемом массиве: ");
int testColumns = ReadData("Введите количество столбцов в генерируемом массиве: "); 
int[,] testArray = Gen2DArray(testRaws, testColumns, 10, 99);
Print2DArray(testArray);
SortingRaws(testArray);
Console.WriteLine();
Print2DArray(testArray);