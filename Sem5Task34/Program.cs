// Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.

//Метод, выполняющий чтение данных с консоли
int ReadData(string msg)
{
    Console.Write(msg);
    int res = int.Parse(Console.ReadLine() ?? "0");
    return res;
}

//Метод, генерирующий массив
int[] Gen1DArray(int len, int bot, int top)
{
    int[] res = new int[len];
    for(int i = 0; i < len; i++)
    {
        res[i]= new Random().Next(bot, top+1);
    }
    return res;
}

//Метод печати одномерного массива
void Print1DArray(int[] arr)
{
    Console.Write("[");
    for(int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i] + ",");
    }
    Console.WriteLine(arr[arr.Length - 1] + "]");
}

//метод, подсчитывающий количество четных чисел в массиве
int EvenCounter(int[] arr)
{
    int counter = 0;
    for(int i = 0; i < arr.Length; i++)
    {
        if(arr[i] % 2 == 0)
        {
            counter ++;
        }
    }
    return counter;
}

int lenArr = ReadData("Введите длину массива: ");
int[] arr = Gen1DArray(lenArr,100,999);
Console.WriteLine("Искомый массив: ");
Print1DArray(arr);
Console.Write("Количество четных чисел в нем: ");
Console.WriteLine(EvenCounter(arr));

