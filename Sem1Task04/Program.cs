// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
Console.WriteLine("Введите три числа: ");
// Cчитывание данных с консоли
string? num1Line = Console.ReadLine();
string? num2Line = Console.ReadLine();
string? num3Line = Console.ReadLine();
// Проверяем, чтобы введеннные данные не были null
if (num1Line != null && num2Line != null && num3Line != null)
{
    // Парсим введенное число (преобразуем в тип int)
    int num1 = int.Parse(num1Line);
    int num2 = int.Parse(num2Line);
    int num3 = int.Parse(num3Line);
    // Сравниваем числа между собой
    if (num1 > num2 && num1 > num3)
    {
        // Выводим данные в консоли
        Console.Write("Максимальное число - ");
        Console.WriteLine(num1);
    }
    if (num2 > num1 && num2 > num3)
    {
        Console.Write("Максимальное число - ");
        Console.WriteLine(num2);
    }
    if (num3 > num1 && num3 > num2)
    {
        Console.Write("Максимальное число - ");
        Console.WriteLine(num3);
    }

}