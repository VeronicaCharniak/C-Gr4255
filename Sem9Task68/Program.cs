// Напишите программу вычисления функции Аккермана с помощью рекурсии. 
//Даны два неотрицательных числа m и n.

// Чтение данных из консоли
uint ReadData(string line)
{
    Console.Write(line);
    uint number = uint.Parse(Console.ReadLine() ?? "0");
    return number;
}

//Фукнция Аккермана
uint AckermannF(uint n, uint m)
{
  if (n == 0)
    {
        return m + 1;
    }
  else
    {
        if ((n != 0) && (m == 0))
        {
        return AckermannF(n - 1, 1);
        }
        else
        {
            return AckermannF(n - 1, AckermannF(n, m - 1));
        }
    }
}

uint numM = ReadData("Введите неотрицательное число M: ");
uint numN = ReadData("Введите неотрицательное число N: ");
uint result = AckermannF(numN, numM);
Console.WriteLine(result);