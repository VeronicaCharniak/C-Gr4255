// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

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

//метод перемножения матриц
int[,] MatrixMultiplication(int[,] arrA, int[,] arrB)
{
    if(arrA.GetLength(1) != arrB.GetLength(0))
 {
    // генерация исключения (проверка на возможность выполнения произведения матриц)
     throw new Exception("Перемножение матриц невозможно: количество столбцов матрицы А не равно количеству строк матрицы В");
 }
    int[,] arrC = new int[arrA.GetLength(0), arrB.GetLength(1)];
    for (int i = 0; i < arrA.GetLength(0); i++)
    {
        for (int j = 0; j < arrB.GetLength(1); j++)
        {
            arrC[i,j] = 0;
            for (int k = 0; k < arrA.GetLength(1); k++)
            {
                arrC[i,j] = arrA[i,k] * arrB[k,j];
            }
        }
    }
    return arrC;
}

// генерация и печать массива А
int rawsA = ReadData("Введите количество строк в генерируемом массиве A: ");
int columnsA = ReadData("Введите количество столбцов в генерируемом массиве A: "); 
int[,] arrayA = Gen2DArray(rawsA, columnsA, 10, 99);
Print2DArray(arrayA);
Console.WriteLine();

// генерация и печать массива B
int rawsB = ReadData("Введите количество строк в генерируемом массиве B: ");
int columnsB = ReadData("Введите количество столбцов в генерируемом массиве B: "); 
int[,] arrayB = Gen2DArray(rawsB, columnsB, 10, 99);
Print2DArray(arrayB);
Console.WriteLine();

Console.WriteLine("Матрица, получаемая при перемножении А и В: ");
int[,] arrayC = MatrixMultiplication(arrayA, arrayB);
Print2DArray(arrayC);

