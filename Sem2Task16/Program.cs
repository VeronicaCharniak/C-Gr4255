// Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого. 
// Способ 1 - при помощи метода

int n1 = int.Parse(Console.ReadLine()??"0");
int n2 = int.Parse(Console.ReadLine()??"0");

void SqrtTest(int a, int b)
{
if (a == b*b)
    Console.WriteLine(a + " квадрат " + b);
else
    Console.WriteLine(a + " не квадрат " + b);
}

//Второй способ
int n1 = int.Parse(Console.ReadLine()??"0");
int n2 = int.Parse(Console.ReadLine()??"0");

if ((n1==n2*n2)||(n2==n1*n1))
{
    Console.WriteLine("является");
}

else
{
    Console.WriteLine("не является");
}