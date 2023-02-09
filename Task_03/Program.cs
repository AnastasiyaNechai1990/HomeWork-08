/*Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18*/

 int[,] GetArrayA(int row, int col, int minValue, int maxValue)
{
    int[,] result = new int[row, col];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue+1);
        }    
    }
    return result;
}

 int[,] GetArrayB(int row, int col, int minValue, int maxValue)
{
    int[,] result = new int[row, col];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue+1);
        }    
    }
    return result;
}

void PrintArrayA(int[,] inArray)
{
    Console.WriteLine();
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i,j]}\t ");
        }
        Console.WriteLine();
    } 
}

void PrintArrayB(int[,] inArray)
{
    Console.WriteLine();
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i,j]}\t ");
        }
        Console.WriteLine();
    } 
}


int[,] ProductOfMatrix (int[,] arrayA, int[,] arrayB)
{
    if (arrayA.GetLength(1) != arrayB.GetLength(0))
    {
        throw new Exception("Умножение не возможно! Размер матрица А не равен размеру матрице В");
    }
    

    int[,] arrayC = new int[arrayA.GetLength(0), arrayB.GetLength(1)];
    for (int i = 0; i < arrayA.GetLength(0); i++)
    {
        for (int j = 0; j < arrayB.GetLength(1); j++)
        {
            arrayC[i,j] = 0;
            for (int k = 0; k < arrayA.GetLength(1); k++)
            {
                arrayC[i,j] += arrayA[i, k] * arrayB[k, j];
            }
        }
    }
    return arrayC;

}


void Main(string[] args)
{
    Console.Clear();
    Console.Write("Введите кол-во строк для матрицы A: ");
    int rowA = int.Parse(Console.ReadLine()!);
    Console.Write("Введите кол-во столбцов для матрицы A: ");
    int colA = int.Parse(Console.ReadLine()!);
    int[,] arrayA = GetArrayA(rowA, colA, 1, 20);

    Console.Clear();
    Console.Write("Введите кол-во строк для матрицы B: ");
    int rowB = int.Parse(Console.ReadLine()!);
    Console.Write("Введите кол-во столбцов для матрицы B: ");
    int colB = int.Parse(Console.ReadLine()!);
    int[,] arrayB = GetArrayB(rowB, colB, 1, 20);

    Console.Write("Матрица А: ");
    PrintArrayA(arrayA);
    Console.WriteLine();

    Console.Write("Матрица B: ");
    PrintArrayB(arrayB);
    Console.WriteLine();

    int[,] result = ProductOfMatrix(arrayA, arrayB);
    Console.Write("Произведение матриц: ");
    PrintArrayA(result);

}
Main(args);

