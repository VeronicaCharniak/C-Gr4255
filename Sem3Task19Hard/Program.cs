// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// Метод, получающий данные от пользователя
string ReadData(string message)
{
    Console.WriteLine(message);
    string? num5Line = Console.ReadLine();
    // Превращение в 4-значное число
    string num4Line = String.Empty;
    for (int i = 0; i < num5Line.Length; i++)
    {
        if (i != 2) num4Line = num4Line + $"{num5Line[i]}";
    }
    return num4Line;
}

// Метод, определяющий, является ли число палиндромом
bool PalindromeTest(string numLine)
{
    bool res = false;
    // словарь 4-значных палиндромов
    Dictionary<int, string> palindromes = new Dictionary<int, string>();

    palindromes.Add(1, "1001");
    palindromes.Add(2, "1111");
    palindromes.Add(3, "1221");
    palindromes.Add(4, "1331");
    palindromes.Add(5, "1441");
    palindromes.Add(6, "1551");
    palindromes.Add(7, "1661");
    palindromes.Add(8, "1771");
    palindromes.Add(9, "1881");
    palindromes.Add(10, "1991");
    palindromes.Add(11, "2002");
    palindromes.Add(12, "2112");
    palindromes.Add(13, "2222");
    palindromes.Add(14, "2332");
    palindromes.Add(15, "2442");
    palindromes.Add(16, "2552");
    palindromes.Add(17, "2662");
    palindromes.Add(18, "2772");
    palindromes.Add(19, "2882");
    palindromes.Add(20, "2992");
    palindromes.Add(21, "3003");
    palindromes.Add(22, "3113");
    palindromes.Add(23, "3223");
    palindromes.Add(24, "3333");
    palindromes.Add(25, "3443");
    palindromes.Add(26, "3553");
    palindromes.Add(27, "3663");
    palindromes.Add(28, "3773");
    palindromes.Add(29, "3883");
    palindromes.Add(30, "3993");
    palindromes.Add(31, "4004");
    palindromes.Add(32, "4114");
    palindromes.Add(33, "4224");
    palindromes.Add(34, "4334");
    palindromes.Add(35, "4444");
    palindromes.Add(36, "4554");
    palindromes.Add(37, "4664");
    palindromes.Add(38, "4774");
    palindromes.Add(39, "4884");
    palindromes.Add(40, "4994");
    palindromes.Add(41, "5005");
    palindromes.Add(42, "5115");
    palindromes.Add(43, "5225");
    palindromes.Add(44, "5335");
    palindromes.Add(45, "5445");
    palindromes.Add(46, "5555");
    palindromes.Add(47, "5665");
    palindromes.Add(48, "5775");
    palindromes.Add(49, "5885");
    palindromes.Add(50, "5995");
    palindromes.Add(51, "6006");
    palindromes.Add(52, "6116");
    palindromes.Add(53, "6226");
    palindromes.Add(54, "6336");
    palindromes.Add(55, "6446");
    palindromes.Add(56, "6556");
    palindromes.Add(57, "6666");
    palindromes.Add(58, "6776");
    palindromes.Add(59, "6886");
    palindromes.Add(60, "6996");
    palindromes.Add(61, "7007");
    palindromes.Add(62, "7117");
    palindromes.Add(63, "7227");
    palindromes.Add(64, "7337");
    palindromes.Add(65, "7447");
    palindromes.Add(66, "7557");
    palindromes.Add(67, "7667");
    palindromes.Add(68, "7777");
    palindromes.Add(69, "7887");
    palindromes.Add(70, "7997");
    palindromes.Add(71, "8008");
    palindromes.Add(72, "8118");
    palindromes.Add(73, "8228");
    palindromes.Add(74, "8338");
    palindromes.Add(75, "8448");
    palindromes.Add(76, "8558");
    palindromes.Add(77, "8668");
    palindromes.Add(78, "8778");
    palindromes.Add(79, "8888");
    palindromes.Add(80, "8998");
    palindromes.Add(81, "9009");
    palindromes.Add(82, "9119");
    palindromes.Add(83, "9229");
    palindromes.Add(84, "9339");
    palindromes.Add(85, "9449");
    palindromes.Add(86, "9559");
    palindromes.Add(87, "9669");
    palindromes.Add(88, "9779");
    palindromes.Add(89, "9889");
    palindromes.Add(90, "9999");


    if (palindromes.ContainsValue(numLine))
    {
        res = true;
    }
    return res;
}


string test = ReadData("Введите чило N: ");
//проверка на null и длину числа
if(test != null && test.Length == 4)
{
    Console.WriteLine(PalindromeTest(test));
}
else
{
    Console.WriteLine("Нужно ввести пятизначное число");
}