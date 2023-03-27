// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
Console.WriteLine("Введите число");
// Cчитывание данных с консоли
string? numNLine = Console.ReadLine();
// Проверяем, чтобы введеннные данные не были null
if(numNLine != null)
{
    // Парсим введенное число (преобразуем в тип int)
    int numN = int.Parse(numNLine);
    // Стартовая переменная
    int startNum = 2;

    // Создаем пустую строку результата
    string res = string.Empty;

    // Запускаем цикл
    while(startNum <= numN)
    {
        // Проверяем условие кратности двум
        if(startNum % 2 == 0)
        // Записываем в строку результата
        res = res + startNum + " ";
        // Увеличиваем переменную на 1
        startNum = startNum + 1;
    }
     // Выводим данные
    Console.WriteLine(res);

}