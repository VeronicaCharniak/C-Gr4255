﻿// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
Console.WriteLine("Введите любое чило: ");
// Запрос на ввод данных от пользователя (string)
string num = Console.ReadLine();
// преобразование строки с числом ("123") в массив отдельных цифер (['1', '2', '3'])
char[] arr = num.ToCharArray();
// Проверка длины массива
if(arr.Length >= 3)
{
    // Вывод третьего элемента массива
    Console.WriteLine(arr[2]);
}
else
{
   Console.WriteLine("Такой цифры нет"); 
}