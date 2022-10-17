// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

Console.Clear();

Console.Write("Введите значение высоты массива: ");
int x = int.Parse(Console.ReadLine()!);

Console.Write("Введите значение ширины массива: ");
int y = int.Parse(Console.ReadLine()!);

Console.Write("Введите значение глубины массива: ");
int z = int.Parse(Console.ReadLine()!);

int[,,] array3D = new int[x, y, z];
string[] arraytostring = new string[array3D.GetLength(0) * array3D.GetLength(1) * array3D.GetLength(2)];

if (x <= 0 || y <= 0 || z <= 0)
{
    Console.WriteLine("Введите положительные значения!");
}
else
{
    FillArray(array3D);
    PrintArray(array3D);
}

void FillArray(int[,,] array3D)
{
    int index = 0;
    for (int i = 0; i < array3D.GetLength(0); i++)
    {
        for (int j = 0; j < array3D.GetLength(1); j++)
        {
            for (int k = 0; k < array3D.GetLength(2); k++)
            {
                array3D[i, j, k] = new Random().Next(10, 100);
                while (arraytostring.Contains(Convert.ToString(array3D[i, j, k])))
                {
                    array3D[i, j, k] = new Random().Next(10, 100);
                }
                arraytostring[index] = Convert.ToString(array3D[i, j, k]);
                index++;
            }
        }
    }
}

void PrintArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array3D.GetLength(0); k++)
            { Console.Write($"{array[i, j, k]}({i},{j},{k}) "); }
            Console.WriteLine();
        }

    }
}