// Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа. 
// Первый способ
System.Random numSintezator = new System.Random();
int rndNum = numSintezator.Next(100, 1000);
Console.WriteLine(rndNum);
int res = (rndNum/100)*10 + rndNum%10;
Console.WriteLine(res);

//Второй способ
int rndNum = new System.Random().Next(100, 1000);
Console.WriteLine((rndNum/100)*10 + rndNum%10);

//Третий способ
int num = new Random().Next(100,1000);
Console.WriteLine(num );
int firstNum = num/100;
int lastNum = num%10;
int newNum = firstNum*10+lastNum;
Console.WriteLine(newNum );

//Четвертый способ
System.Random numSintezator = new System.Random();
char[] digits = numSintezator.Next(100, 1000).ToString().ToCharArray();
Console.WriteLine(digits);
char[] res = {digits[0], digits[2]};
Console.WriteLine(res);
