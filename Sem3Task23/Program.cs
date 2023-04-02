﻿// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

//Чтение данных консоли
int ReadData(string message)
{
    Console.WriteLine(message);
    int res = int.Parse(Console.ReadLine() ?? "0");
    return res;
}

// метод, выводящий строку таблицы
string LineGenerator(int num, int pow)
{
    string res = ""; //string res = String.Empty;
    for (int i = 1; i <= num; i++)
    {
        res += Math.Pow(i, pow) + " ";
    }
    return res;
}

int numN = ReadData("Введите чило N: ");
Console.WriteLine(LineGenerator(numN,1));
Console.WriteLine(LineGenerator(numN,3));
