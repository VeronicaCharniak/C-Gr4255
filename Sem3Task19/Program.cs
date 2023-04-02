// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// Метод получения данных от пользователя
int ReadData(string message)
{
    Console.WriteLine(message);
    int res = int.Parse(Console.ReadLine() ?? "0");
    return res;
}

// Метод, проверяющий, является ли число палиндромом
bool PalindromeTest(int num)
{
    bool res = false;
    int n1 = num / 10000;
    int n5 = num % 10;
    int n2 = (num / 1000) % 10;
    int n4 = (num / 10) % 10;
    if (n1 == n5 && n2 == n4)
    {
        res = true;
    }
    return res;
}

int numN = ReadData("Введите чило N: ");
// Проверка на пятизначность
if((numN / 10000) >= 1)
{
    Console.WriteLine("Вы ввели число " + numN);
    Console.WriteLine("Является ли оно палиндромом?");
    Console.WriteLine(PalindromeTest(numN));
}
else
{
    Console.WriteLine("Нужно было ввести пятизначное число");
}