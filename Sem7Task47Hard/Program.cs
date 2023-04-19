//метод генерации массива
double[,] Gen2Darray(int countRow, int countColum, int minValue, int maxValue)
{
    double[,] arr = new double[countRow, countColum];
    for (int i = 0; i < countRow; i++)
    {
        for (int j = 0; j < countColum; j++)
        {
            arr[i, j] = new Random().Next(minValue, maxValue + 1) + new Random().NextDouble();
        }
    }
    return arr;
}

//метод печати двумерного массива
void Print2DArray(double[,] arr)
{
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
            char[] numbers = arr[i,j].ToString().ToCharArray();
            for(int k =0;k<numbers.Length;k++)
            {
            Console.ForegroundColor = col[new Random().Next(0, 16)];
            Console.Write(numbers[k]);
            Console.ResetColor();
            }
            Console.Write(" ");
        }
        Console.WriteLine();
    }
}

double[,] matr = Gen2Darray(5,3,0,100);
Print2DArray(matr);
