// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
Console.WriteLine("Введите 2 числа: ");
// Cчитывание данных с консоли
string? num1Line = Console.ReadLine();
string? num2Line = Console.ReadLine();
// Проверяем, чтобы введеннные данные не были null
if(num1Line != null && num2Line != null)
{
    // Парсим введенное число (преобразуем в тип int)
    int num1 = int.Parse(num1Line);
    int num2 = int.Parse(num2Line);
    // Сравниваем 2 числа
    if(num1 > num2)
    {
        // Выводим данные в консоли
        Console.Write("Большее число - ");
        Console.WriteLine(num1);
        Console.Write("Меньшее число - ");
        Console.WriteLine(num2);
    }
    else
    {
        Console.Write("Большее число - ");
        Console.WriteLine(num2);
        Console.Write("Меньшее число - ");
        Console.WriteLine(num1);
    }
}