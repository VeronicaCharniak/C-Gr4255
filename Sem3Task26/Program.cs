// Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.

Console.Clear();
int ReadData(string message)
{
    Console.WriteLine(message);
    int res = int.Parse(Console.ReadLine() ?? "0");
    return res;
}
void PrintResult(string message, long res)
{
     Console.WriteLine(message+res);
}

int CountDigit(int number)
{
    int result = 0;
    while(number>0)
    {
      result=result +1;
      number = number/10;              
    }
    return result ;
}

int numberA = ReadData("put number a: ");
int res1 = CountDigit (numberA );
PrintResult ("count:",(int)res1);