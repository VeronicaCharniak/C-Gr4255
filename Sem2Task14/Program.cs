// Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23. 
// Первый способ, с проверкой на null и парсингом в одной строке
Console.WriteLine("Введите первое число");
int num1 = int.Parse(Console.ReadLine()??"0");
bool res = ((num1%7 == 0) &&(num1%23 == 0));
if (res)
{
  Console.WriteLine("кратно");
}
else
{
  Console.WriteLine("не кратно");
}

// Второй способ
Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine()??"0");

bool res = ((num%7 == 0)&&(num%23==0));
if (res)
{
     Console.WriteLine("Число кратно 7 и 23");
}
else
{
    Console.WriteLine("Число некратно 7 и 23, остаток от 7: " + num%7 + ", остаток от 23: " + num%23);
}

// Способ 3
int num = int.Parse(Console.ReadLine()??"0");
bool test1 = (num%7 == 0);
bool test2 = (num%23 == 0);
if (test1 && test2)
{
   Console.WriteLine("кратно  оно одновременно 7 и 23.");
}
else 
{
   Console.WriteLine("не кратно  оно одновременно 7 и 23.");
}

