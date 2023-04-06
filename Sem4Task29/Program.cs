// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// Метод получения данных от пользователя и преобразование строки в число
int ReadData(string message)
{
    Console.WriteLine(message);
    int res = int.Parse(Console.ReadLine() ?? "0");
    return res;
}

// Метод, выводящий полученный массив в консоли в виду [num1, num2, ..., num.Length-1]
void Print1DArr(int[] arr)
{
     Console.Write("[");
     for (int i = 0; i < arr.Length -1; i++)
     {
          Console.Write(arr[i] + ",");
     }  
     Console.WriteLine(arr[arr.Length-1] + "]");              
}

// Метод, генерирующий массив
int[] Gen1DArr(int len, int top, int bot)
{
    int[] res = new int[len];
    for(int i = 0; i < len; i++)
    {
        res[i] = new Random().Next(bot, top+1);
    }
    return res;
}

int lenArr = ReadData("Введите длину массива: ");
int topArr = ReadData("Введите верхнюю границу массива: ");
int botArr = ReadData("Введите нижнюю границу массива: ");
int[] arr = Gen1DArr(lenArr, topArr, botArr);
Print1DArr(arr);
