// Задача: найти квадрат введенного числа
// Cчитывание данных с консоли
string? inLine = Console.ReadLine();

// Проверяем, чтобы введеннные данные не были null
if (inLine != null)
{
    // Парсим введенное число (преобразуем в тип int)
    int inNumber = int.Parse(inLine);

    // Находим квадрат числа
    int outNumber = inNumber * inNumber;
    int outStrtPow = (int)Math.Pow(inNumber, 2);

    // Выводим данные в консоли
    Console.WriteLine(outNumber);
    Console.WriteLine(outStrtPow);
}