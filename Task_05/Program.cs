/* Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07*/

int[,] FillArray(int[,] array)
{
    int temp = 1;
    int i = 0;
    int j = 0;
    while (temp <= array.GetLength(0) * array.GetLength(1))
    {
        array[i, j] = temp;
        temp++;
        if (i <= j + 1 && i + j < array.GetLength(1) - 1)
        j++;
        else if (i < j && i + j >= array.GetLength(0) - 1)
        i++;
        else if (i >= j && i + j > array.GetLength(1) - 1)
        j--;
        else
        i--;
    }
    return array;

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

void Main()
{
    Console.Clear();
    int row = 6;
    int col = 6;
    int[,] array = new int[row, col];

    Console.WriteLine("Массив заполненный спирально: ");
    PrintArray(FillArray(array));
}
Main();