// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц. Например, даны 2 матрицы:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// и
// 1 5 8 5
// 4 9 4 2
// 7 2 2 6
// 2 3 4 7
// Их произведение будет равно следующему массиву:
// 1 20 56 10
// 20 81 8 6
// 56 8 4 24
// 10 6 24 49

// Проверила на онлайн-калькуляторе, результат в примере неверный, поэтому перемножала матрицы по 
// формуле перемножения матриц из курса линейной алгебры.

Console.Clear();

Console.Write("Введите количество строк первой матрицы: ");
int m1 = int.Parse(Console.ReadLine()!);

Console.Write("Введите количество столбцов первой матрицы: ");
int n1 = int.Parse(Console.ReadLine()!);

Console.Write("Введите количество строк второй матрицы: ");
int m2 = int.Parse(Console.ReadLine()!);

Console.Write("Введите количество столбцов второй матрицы: ");
int n2 = int.Parse(Console.ReadLine()!);

if (m1 <= 0 || n1 <= 0 || m2 <= 0 || n2 <= 0)
{
    Console.WriteLine("Введите положительные значения!");
}
else if(n1 != m2 || m1 != n2)
{
    Console.WriteLine("Кол-во столбцов 1-й матрицы должно быть равно кол-ву строк 2-й матрицы!");
}
else
{
    int[,] matrix1 = new int[m1, n1];
    int[,] matrix2 = new int[m2, n2];
    
    FillArray(matrix1);
    PrintArray(matrix1);
    Console.WriteLine();
    FillArray(matrix2);
    PrintArray(matrix2);
    Console.WriteLine();
    PrintArray(MatrixProduct(matrix1, matrix2));
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

int[,] MatrixProduct(int[,] matrix1, int[,] matrix2)
{
    int[,] Matrix1and2Product = new int[matrix1.GetLength(0), matrix2.GetLength(1)];

    for (int i = 0; i < matrix1.GetLength(0); i++)
    {
        for (int j = 0; j < matrix2.GetLength(1); j++)
        {
            Matrix1and2Product[i, j] = 0;
            for(int k = 0; k < matrix1.GetLength(1); k++)
            {
                Matrix1and2Product[i, j] += matrix1[i, k] * matrix2[k, j];
            }
        }
    }
    return Matrix1and2Product;
}