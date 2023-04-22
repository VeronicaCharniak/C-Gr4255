// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:

//Console.Clear();

//Метод ввода 
int ReadData(string msg)
{
    Console.Write(msg);
    int res = int.Parse(Console.ReadLine() ?? "0");
    return res;
}

//Метод генерации массива
int[,] Gen2DSpiralArray(int countRow, int countColumn, int but, int top)
{
    {
        
        int res = 1;
        int[,] arr = new int[but, top];
        //Заполняем периметр массива по часовой стрелке.
        for (int j = 0; j < top; j++)
        {
            arr[0, j] = res;
            res++;
        }
        for (int i = 1; i < but; i++)
        {
            arr[i, top - 1] = res;
            res++;
        }
        for (int j = top - 2; j >= 0; j--)
        {
            arr[but - 1, j] = res;
            res++;
        }
        for (int i = but - 2; i > 0; i--)
        {
            arr[i, 0] = res;
            res++;
        }
        //продолжение заполнения массива
        //тк выше мы заполнели его только по 1
        //во всех направлениях
        int m = 1;
        int n = 1;

        while (res < but * top)
        {
            //Движемся вправо.
            while (arr[m, n + 1] == 0)
            {
                arr[m, n] = res;
                res++;
                n++;
            }

            //Движемся вниз.
            while (arr[m + 1, n] == 0)
            {
                arr[m, n] = res;
                res++;
                m++;
            }

            //Движемся влево.
            while (arr[m, n - 1] == 0)
            {
                arr[m, n] = res;
                res++;
                n--;
            }

            //Движемся вверх.
            while (arr[m - 1, n] == 0)
            {
                arr[m, n] = res;
                res++;
                m--;
            }
        }

        // Убираем незаполненную ячейку в центре при помощи следующего цикла.
        for (int i = 0; i < but; i++)
        {
            for (int j = 0; j < top; j++)
            {
                if (arr[i, j] == 0)
                {
                    arr[i, j] = res;
                }
            }
        }

        return arr;
    }
}

// //Метод печати 2мерного массива 
// void Print2DSpiralarray(int[,] arr)
// {
//     //Выводим массив в консоль.
//     for (int i = 0; i < arr.GetLength(0); i++)
//     {
//         for (int j = 0; j < arr.GetLength(1); j++)
//         {
//             //Сравнение для более красивого вывода в консоль
//             //крассиво только для 10            
//             if (arr[i, j] < 10)
//             {   
//                 Console.Write(arr[i, j] + "  ");
//             }
//             else
//             {
//                 Console.Write(arr[i, j] + " ");
//             }
//         }
//         Console.WriteLine();
//     }
// }

// //Игорь Трибелустов
// int[,] GenSpiralArray(int size)
// {
//     int[,] nums = new int[size, size];

//     int num = 1;
//     int i = 0;
//     int x = 0;

//     while (num <= size * size)
//     {
//         nums[i, x] = num;
//         if (i <= x + 1 && i + x < size - 1)
//             ++x;
//         else if (i < x && i + x >= size - 1)
//             ++i;
//         else if (i >= x && i + x > size - 1)
//             --x;
//         else
//             --i;
//         ++num;
//     }
//     return nums;
// }

// //Мария Волгунцова
// int[,] SpiralArray(int countRow, int countColumn)
// {
//     int[,] array = new int[countRow, countColumn];
//     int value = 1;
//     int x = 0, y = 0, dx = 0, dy = 1;

//     for (int i = 0; i < countRow * countColumn; i++)
//     {
//         array[x, y] = value++;
//         if (x + dx < 0 || x + dx >= countRow || y + dy < 0 || y + dy >= countColumn || array[x + dx, y + dy] != 0)
//         {
//             int temp = dx;
//             dx = dy;
//             dy = -temp;
//         }
//         x += dx;
//         y += dy;
//     }
//     return array;
// }

// int[,] ChatGPT(int n)
// {
//     int[,] matrix = new int[n, n];

//     int num = 1;
//     int row = 0;
//     int col = 0;
//     while (num <= n * n)
//     {
//         // заполнение верхней строки
//         for (int i = col; i < n - col; i++)
//         {
//             matrix[row, i] = num;
//             num++;
//         }
//         // заполнение правого столбца
//         for (int i = row + 1; i < n - row; i++)
//         {
//             matrix[i, n - col - 1] = num;
//             num++;
//         }
//         // заполнение нижней строки
//         for (int i = n - col - 2; i >= col; i--)
//         {
//             matrix[n - row - 1, i] = num;
//             num++;
//         }
//         // заполнение левого столбца
//         for (int i = n - row - 2; i > row; i--)
//         {
//             matrix[i, col] = num;
//             num++;
//         }
//         // переход к следующему кругу спирали
//         row++;
//         col++;
//     }
//     return matrix;


// }




int[,] FillSpiral(int[,] matrix, int startNumber = 1, int count = 1)
{
    for (int j = -1 + count; j < matrix.GetLength(1) + 1 - count; j++)
    {
        matrix[-1 + count, j] = startNumber++;
    }
    for (int i = count; i < matrix.GetLength(0) + 1 - count; i++)
    {
        matrix[i, matrix.GetLength(1) - count] = startNumber++;
    }
    for (int j = matrix.GetLength(1) - 1 - count; j > -1 + count; j--)
    {
        matrix[matrix.GetLength(0) - count, j] = startNumber++;
    }
    for (int i = matrix.GetLength(0) - count; i > -1 + count; i--)
    {
        matrix[i, -1 + count] = startNumber++;
    }
    if (startNumber <= matrix.GetLength(0) * matrix.GetLength(1))
    {
        FillSpiral(matrix, startNumber, ++count);
    }
    return matrix;
}



// DateTime d1 = DateTime.Now;
// Gen2DSpiralArray(10000,10000,10000,10000);
// Console.WriteLine("Решение Ивана" + (DateTime.Now - d1));

// DateTime d2 = DateTime.Now;
// GenSpiralArray(10000);
// Console.WriteLine("Решение Игорь" + (DateTime.Now - d2));

// DateTime d3 = DateTime.Now;
// SpiralArray(10000,10000);
// Console.WriteLine("Решение Мария" + (DateTime.Now - d3));

// DateTime d4 = DateTime.Now;
// Gen2DSpiralArray(10000,10000,10000,10000);
// Console.WriteLine("Решение ChatGPT" + (DateTime.Now - d4));

int[,] InitMatrix(int rows, int columns)
{ return new int[rows, columns]; }

 int m = ReadData("Введите количество строк: ");
 int n = ReadData("Введите количество столбцов: ");

 int[,] NewMatrix = InitMatrix(m, n);

//   DateTime d1 = DateTime.Now;
//   Gen2DSpiralArray(m,n,m,n);
//   Console.WriteLine("Решение Ивана" + (DateTime.Now - d1));

 DateTime d2 = DateTime.Now;
FillSpiral(NewMatrix);
 Console.WriteLine("Решение Рекурсия" + (DateTime.Now - d2));

//  int[,] arr = FillSpiral(NewMatrix);
//  Print2DSpiralarray(arr);