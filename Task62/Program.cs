// Напишите программу, которая заполнит спирально массив 4 на 4. Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

Console.Write("Ведите количество строк: ");
int m = int.Parse(Console.ReadLine()!);
Console.Write("Ведите количество столбцов: ");
int n = int.Parse(Console.ReadLine()!);

if (m <= 0 || n <= 0)
{
    Console.WriteLine("Введите положительные значения!");
}
else if (m != n)
{
    Console.Write("Количество строк и столбцов должны совпадать!");
}
else
{
    int[,] array = new int[m, n];
    FillSpiralArray(array);
    PrintArray(array);
}

void FillSpiralArray(int[,] array, int i = 0, int j = 0)
{
    int temp = 1;

    while (temp <= array.GetLength(0) * array.GetLength(1))
    {
        array[i, j] = temp;
        temp++;

        if (i < j && i + j >= array.GetLength(0) - 1)
            i++;
        else if (i <= j + 1 && i + j < array.GetLength(1) - 1)
            j++;

        else if (i >= j && i + j > array.GetLength(1) - 1)
            j--;
        else
            i--;
    }
}
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] < 10)
                Console.Write($"0{array[i, j]} ");
            else
                Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}