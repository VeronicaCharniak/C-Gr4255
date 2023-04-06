// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// Метод чтения данных с консоли и преобразования в число int
int ReadData(string message)
{
    Console.WriteLine(message);
    int res = int.Parse(Console.ReadLine() ?? "0");
    return res;
}

// Метод, выводящий результат
void PrintResult(string msg, long res)
{
    Console.WriteLine(msg + res);
}

//метод с циклом, возводящий число А в степень В
long MyPow (int a, int b)
{
    long res = 1;
    while(b>0)
    {
        res = res * a;
        b = b - 1;
    }
    return res;
}

int num1 = ReadData("Введите число A: ");
int num2 = ReadData("Введите число B: ");
long numPow = MyPow(num1, num2);
PrintResult("Число A, возведенное в степень B равняется: ", numPow);
