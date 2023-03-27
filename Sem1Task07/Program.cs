// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа.
Console.WriteLine("Введите трехзначное число: ");
string? numLine = Console.ReadLine();
if(numLine != null)
{
    int num = int.Parse(numLine);
    int res = num % 10;
    Console.WriteLine(res);
}