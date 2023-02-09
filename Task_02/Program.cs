/* Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей 
суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка*/

 int[,] GetArray(int row, int col, int minValue, int maxValue)
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

void PrintArray(int[,] inArray)
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

int SumLine(int[,] array, int i)
{
    int sumLine = array[i,0];
    for (int j = 1; j < array.GetLength(1); j++)
    {
        sumLine += array[i,j];
    }
    return sumLine;
}

void NumLineMinSum(int[,] array)
{
    int minSumLine = 0;
    int sumLine = SumLine(array, 0);
    for (int i = 1; i < array.GetLength(0); i++)
    {
        int tempSumLine = SumLine(array, i);
        if (sumLine > tempSumLine)
        {
            sumLine = tempSumLine;
            minSumLine = i;
        }
    }
Console.Write($"Строка с наименьшей суммой элементов -> {minSumLine+1}");
}

void Main()
{
    Console.Clear();
    Console.WriteLine("Введите количество строк: ");
    int row = int.Parse(Console.ReadLine()!);
    Console.WriteLine("Введите количество столбцов: ");
    int col = int.Parse(Console.ReadLine()!);
    
    int[,] array = GetArray(row, col, 1, 20);
    PrintArray(array);
    int sumLine = SumLine(array, 0);
    NumLineMinSum(array);
}
Main();
