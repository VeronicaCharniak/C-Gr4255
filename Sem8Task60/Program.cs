// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
//Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

//Метод, выполняющий чтение данных с консоли
int ReadData(string msg)
{
    Console.Write(msg);
    int res = int.Parse(Console.ReadLine() ?? "0");
    return res;
}

//Метод печати 3D массива
void Print3DArray (int[,,] arr3D)
{
  for(int i=0; i < arr3D.GetLength(0); i++)
  {
    for(int j=0; j < arr3D.GetLength(1); j++)
    {
      Console.Write($"X({i}) Y({j}) ");
      for(int k=0; k < arr3D.GetLength(2); k++)
      {
        Console.Write( $"Z({k})={arr3D[i,j,k]} ");
      }
      Console.WriteLine();
    }
  }
}

//метод генерации 3D массива
void Gen3DArray(int[,,] arr3D)
{
  int[] temp = new int[arr3D.GetLength(0) * arr3D.GetLength(1) * arr3D.GetLength(2)];
  int  number = 0;
  for (int i = 0; i < temp.GetLength(0); i++)
  {
    temp[i] = new Random().Next(10, 100);
    number = temp[i];
    if (i >= 1)
    {
      for (int j = 0; j < i; j++)
      {
        while (temp[i] == temp[j])
        {
          temp[i] = new Random().Next(10, 100);
          j = 0;
          number = temp[i];
        }
          number = temp[i];
      }
    }
  }
  int count = 0; 
  for (int x = 0; x < arr3D.GetLength(0); x++)
  {
    for (int y = 0; y < arr3D.GetLength(1); y++)
    {
      for (int z = 0; z < arr3D.GetLength(2); z++)
      {
        arr3D[x, y, z] = temp[count];
        count++;
      }
    }
  }
}

int x = ReadData("Введите значение x для 3D массива: ");
int y = ReadData("Введите значение y для 3D массива: ");
int z = ReadData("Введите значение z для 3D массива: ");
Console.WriteLine();
int[,,] array3D = new int[x, y, z];
Gen3DArray(array3D);
Print3DArray(array3D);
