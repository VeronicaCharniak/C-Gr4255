// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

//Метод, выполняющий чтение данных с консоли
int ReadData(string msg)
{
    Console.Write(msg);
    int res = int.Parse(Console.ReadLine() ?? "0");
    return res;
}

//Метод, подсчитывающий количество положительных чисел
int PositiveCounter (int num)
{
    int count = 0;
    while(num > 0)
    {
        int value = ReadData("Введите число: ");
        if(value > 0) count++;
        num = num - 1;
    }
    return count;
}

int number = ReadData("Сколько чисел вы хотите ввести: ");
int result = PositiveCounter(number);
Console.WriteLine("Количество введенных вами положительных чисел составило: " + result);
