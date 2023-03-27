// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
Console.WriteLine("Введите число");
// Cчитывание данных с консоли
string? numLine = Console.ReadLine();
// Проверяем, чтобы введеннные данные не были null
if (numLine != null)
{
    // Парсим введенное число (преобразуем в тип int)
    int num = int.Parse(numLine);

    int resOfDiv = num % 2;

    if(resOfDiv == 0)
    {
        Console.WriteLine("Введенное вами число - четное");
    }
    else
        Console.WriteLine("Введенное вами число - нечетное");
}