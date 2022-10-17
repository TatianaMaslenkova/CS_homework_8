// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с 
// наименьшей суммой элементов. Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой 
// элементов: 1 строка (нумерация строк начинается с 1)

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
    PrintRowSums(RowSum(array));
    Console.WriteLine();
    Console.Write($"Наименьшая сумма в строке {FindMinRowSum(RowSum(array)) + 1} ");
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

int[] RowSum(int[,] array) // метод в консоль не вывожу:он нужен для использовния в двух след.методах
{
    int index = 0;
    int[] result = new int[array.GetLength(0)];

    for (int i = 0; i < array.GetLength(0); i++)
    {
        int sum = 0;

        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum += array[i, j];
        }
        result[index] = sum;
        index++;
    }
    return result;
}

void PrintRowSums(int[] RowSum)
{
    for (int k = 0; k < RowSum.Length; k++)
    {
        Console.Write(RowSum[k] + " ");
    }
    Console.WriteLine();
}

int FindMinRowSum(int[] RowSum)
{
    int min = RowSum[0];
    int count = 0;
    for (int l = 0; l < RowSum.Length; l++)
    {
        if (min >= RowSum[l])
        {
            min = RowSum[l];
            count = l;
        }
    }
    return count;
}