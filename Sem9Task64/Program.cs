//Задайте значение N. Напишите программу, которая выведет 
//все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

// Чтение данных из консоли
int ReadData(string line)
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}

//метод генерации чисело от 1 до N методом рекурсии
void From1ToN(int i, int n)
{   
    if (i <= n)
    {
        Console.Write(i + " ");
        From1ToN(i + 1, n);
    }
    else
    {
        return;
    }
}

int numN = ReadData("Введите число N: ");
Console.Write("Числа от 1 до N: ");
From1ToN(1, numN);