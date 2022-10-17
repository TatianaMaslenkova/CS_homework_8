// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки 
// двумерного массива. Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

Console.Clear();

Console.Write("Введите количество строк: ");
int m = int.Parse(Console.ReadLine()!);

Console.Write("Введите количество столбцов: ");
int n = int.Parse(Console.ReadLine()!);

if (m <= 0 || n <= 0)
{
    Console.WriteLine("Введите положительные значения!");
}
else
{
    int[,] array = new int[m, n];
    
    FillArray(array);
    PrintArray(array);
    Console.WriteLine();
    PrintArray(SortElementsInRows(array));
}

void FillArray(int[,] array)
{
    Random generator = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = generator.Next(1, 10);
        }
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

int[,] SortElementsInRows(int[,] array)
{
    for (int k = 0; k < array.GetLength(0); k++)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 1; j < array.GetLength(1); j++)
            {

                {
                    if (array[k, j] > array[k, j - 1])
                    {
                        int temp = array[k, j];
                        array[k, j] = array[k, j - 1];
                        array[k, j - 1] = temp;
                    }
                }

            }

        }
    }
    return array;
}