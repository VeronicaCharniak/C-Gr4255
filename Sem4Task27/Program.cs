// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// Метод получения данных от пользователя и преобразование строки в число
int ReadData(string message)
{
    Console.WriteLine(message);
    int res = int.Parse(Console.ReadLine() ?? "0");
    return res;
}

// Метод, выводящий результат
void PrintResult(string message, int res)
{
     Console.WriteLine(message+res);
}

// Метод, подсчитывающий сумму цифр в числе
int CountDigitSum(int number)
{
    int result = 0;
    while(number>0)
    {
      result=result + (number % 10);
      number = number / 10;              
    }
    return result ;
}

int myNumber = ReadData("Введите ваше число: ");
int sum = CountDigitSum(myNumber);
PrintResult("Сумма цифр в введенном вами числе составляет: ", (int) sum);