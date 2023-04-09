// Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях.

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

int SumOfUnevenInd(int[] arr)
{
    int sum = 0;
    for(int i = 1; i < arr.Length; i = i+2)
    {
        if(i % 2 != 0)
        {
            sum += arr[i];
        }
    }
    return sum;
}

int lenArr = ReadData("Введите длину массива: ");
int bottom = ReadData("Введите нижнюю границу массива: ");
int top = ReadData("Введите верхнюю границу массива: ");
int[] arr = Gen1DArray(lenArr, bottom, top);
Console.WriteLine("Искомый массив: ");
Print1DArray(arr);
Console.Write("Сумма элементов на нечетных позициях: ");
Console.WriteLine(SumOfUnevenInd(arr));
