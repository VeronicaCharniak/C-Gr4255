// Задайте значения M и N. 
//Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// Чтение данных из консоли
int ReadData(string line)
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}

//метод подсчета суммы чисел от m до n рекурсией
int SumFromMToN(int m, int n)
{
    if(m>=n)
    {
        return n;
    }
    else
    {
        return m + SumFromMToN(m+1, n);
    }
}

int numM = ReadData("Введите число M: ");
int numN = ReadData("Введите число N: ");
Console.Write("Сумма чисел от M до N составляет: ");
int testSum = SumFromMToN((numM>numN)?numN:numM,(numM>numN)?numM:numN);
Console.WriteLine(testSum);