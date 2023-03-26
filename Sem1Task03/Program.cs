// Вывести день недели по заданному номеру
Console.WriteLine("Введите день недели: ");
string? dayLine =Console.ReadLine();
if(dayLine != null)
{
    string[] dayWeek = new string[7];
    dayWeek[0] = "понедельник";
    dayWeek[1] = "вторник";
    dayWeek[2] = "среда";
    dayWeek[3] = "четверг";
    dayWeek[4] = "пятница";
    dayWeek[5] = "суббота";
    dayWeek[6] = "воскресенье";
    int day = int.Parse(dayLine);
    Console.WriteLine(dayWeek[day-1]);
}