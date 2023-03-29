//Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. Если второе число некратно первому, то программа выводит остаток от деления. 

//вариант 1
//Просим ввести два числа
Console.Write("Введите первое число: ");
int num1 = int.Parse(Console.ReadLine()??"0");
Console.Write("Введите второе число: ");
int num2 = int.Parse(Console.ReadLine()??"0");

if(num2%num1 == 0)
{
    Console.WriteLine("Второе число кратно первому");
}
else
{
    Console.WriteLine("Второе число не кратно первому, остаток: " + num2%num1);
}

// //вариант 2 с bool!!
Console.Write("Введите первое число: ");
int num1 = int.Parse(Console.ReadLine()??"0");
Console.Write("Введите второе число: ");
int num2 = int.Parse(Console.ReadLine()??"0");

bool res = (num2%num1 == 0);
if (res)
{
     Console.WriteLine("Второе число кратно первому");
}
else
{
    Console.WriteLine("Второе число не кратно первому, остаток: " + num2%num1);
}
