// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, 
// которая будет построчно выводить массив, добавляя индексы каждого элемента.

// Чтение данных из консоли
int ReadData(string line)
{
  Console.Write(line);
  int number = int.Parse(Console.ReadLine() ?? "0");
  return number;
}

// Метод повторов 
bool Test(int[] array, int elem, int n)
{
  for (int t = 0; t < n; t++)
    if (elem == array[t]) return true;
  return false;
}

// Вывод массива 
int[,,] Gen3DArray(int coordX, int coordY, int coordZ)
{
  int[,,] array3D = new int[coordX, coordY, coordZ];
  int[] temp = new int[coordX * coordY * coordZ];
  for (int i = 0; i < temp.Length; i++)
  {
    temp[i] = new Random().Next(10, 100);
    while (Test(temp, temp[i], i) == true)
      temp[i] = new Random().Next(10, 100);
  }
  int count = 0;
  for (int x = 0; x < array3D.GetLength(0); x++)
  {
    for (int y = 0; y < array3D.GetLength(1); y++)
    {
      for (int z = 0; z < array3D.GetLength(2); z++)
      {
        array3D[x, y, z] = temp[count];
        count++;
      }
    }
  }
  return array3D;
}

// Печать трехмеронго  массива по строкам
void Print3DArray(int[,,] array3D)
{
  for (int i = 0; i < array3D.GetLength(0); i++)
  {
    for (int j = 0; j < array3D.GetLength(1); j++)
    {
      for (int k = 0; k < array3D.GetLength(2); k++)
      {
        Console.WriteLine($"{array3D[i, j, k]} ({i},{j},{k})");
      }
      
    }
    Console.WriteLine();
  }
}


int x = ReadData("Величина массива по A: ");
int y = ReadData("Величина массива по B: ");
int z = ReadData("Величина массива по C: ");
int[,,] matrix = Gen3DArray(x, y, z);
Print3DArray(matrix);
