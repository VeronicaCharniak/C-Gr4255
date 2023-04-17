// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
//и возвращает значение этого элемента или же указание, что такого элемента нет.

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

void SearchingElement (int[,] arr, int row, int column)
{
    if(row >= arr.GetLength(0) || column >= arr.GetLength(1))
    {
        Console.WriteLine("Элемента с заданной индексацией в текущем массиве нет");
    }
    else
    {
        Console.WriteLine("Заданной вами индексации соответствует элемент массива со значением: " + arr[row, column]);
    }
}

int arrRows = ReadData("Введите количество строк в двумерном массиве: ");
int arrColumns = ReadData("Введите количество столбцов в двумерном массиве: ");
int[,] testArr2D = Gen2DArray(arrRows, arrColumns, 10, 99);
Print2DArray(testArr2D);
int searchRow = ReadData("Введите значение строки, элемент в которой хотите найти:");
int searchColumn = ReadData("Введите значение столбца, элемент в котором хотите найти: ");
SearchingElement(testArr2D, searchRow, searchColumn);