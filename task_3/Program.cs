/* Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3. */

// Получение чисел от пользователей
string[] GetNumberOfUser(string messenge)
{
    Console.Write(messenge);
    char[] separators = new char[] { ' ', ',', '.', '*' };
    string[] splitArray = Console.ReadLine()!.Split(separators, StringSplitOptions.RemoveEmptyEntries);
    return splitArray;
}
//инцилизация массива
int[] GetArray(string[] splitArray, string error)
{
    int[] arrayOfNumbers = new int[splitArray.Length];
    int result = 0;
    for (int i = 0; i < splitArray.Length; i++)
    {
        if (int.TryParse(splitArray[i], out result))
            arrayOfNumbers[i] = result;

        else Console.WriteLine(error);
    }

    return arrayOfNumbers;
}

//заполенние массива рандомом
int[,] InsilizationArray(int[] arrayOfNumber, int[] rangeNumbers)
{
    int[,] matrix = new int[arrayOfNumber[0], arrayOfNumber[1]];
    Random rnd = new Random();
    for (int i = 0; i < arrayOfNumber[0]; i++)
    {
        for (int j = 0; j < arrayOfNumber[1]; j++)
        {
            matrix[i, j] = rnd.Next(rangeNumbers[0], rangeNumbers[1] + 1);
        }
    }

    return matrix;
}

//Печать двухмерного массива
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine(" ");
    }
}
//Средннее значение каждого столбца
double[] MeanColumns(int[,] matrix)
{
    double[] meanColumns = new double[matrix.GetLength(1)];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            meanColumns[j] += matrix[i, j];
        }
    }
    for (int i = 0; i < meanColumns.Length; i++)
    {
        meanColumns[i] /= matrix.GetLength(0);
    }
    return meanColumns;
}

//Печать одномерного массива
void PrintDoubleArray(double[] doubleArray, string messenge)
{
    Console.Write(messenge);
    for (int i = 0; i < doubleArray.Length; i++)
    {
        Console.Write($"{doubleArray[i]:N1} ");
    }
}
int[,] matrix = InsilizationArray(GetArray(GetNumberOfUser("Введите размер масива "), "Введите число "),
GetArray(GetNumberOfUser("Введите диапозон чиел для массива "), "Введите число "));
PrintArray(matrix);
PrintDoubleArray(MeanColumns(matrix), "Среднее значение столбцов -> ");

