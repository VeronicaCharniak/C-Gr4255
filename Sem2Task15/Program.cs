// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
Console.WriteLine("Введити цифру от 1 до 7: ");
// Запрос на ввод данных с одновременным парсингом string в int и проверкой на null
int day = int.Parse(Console.ReadLine()??"0");
// День недели меньше 1 ИЛИ больше 7?
if(day < 1 || day > 7)
{
    Console.WriteLine("Это не день недели, нужно было ввести цифру от 1 до 7");
}
else
{
    if(day >= 1 && day <= 5)
    {
        Console.WriteLine("Рабочий день");
    }
    else
    {
        Console.WriteLine("Выходной день");
    }
}

// второй способ при помощи словаря
Dictionary<int, string> daysOfWeek = new Dictionary<int, string>();
daysOfWeek.Add(1, "Будний день");
daysOfWeek.Add(2, "Будний день");
daysOfWeek.Add(3, "Будний день");
daysOfWeek.Add(4, "Будний день");
daysOfWeek.Add(5, "Будний день");
daysOfWeek.Add(6, "Выходной день");
daysOfWeek.Add(7, "Будний день");

Console.Write("Введите день недели (1-7): ");
int dday = int.Parse(Console.ReadLine() ?? "0");
if(daysOfWeek.ContainsKey(dday))
{
    Console.WriteLine(daysOfWeek[dday]);
}
else
{
    Console.WriteLine("Это не день недели");
}