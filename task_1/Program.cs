/* Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

m = 3, n = 4.

0,5 7 -2 -0,2

1 -3,3 8 -9,9

8 7,8 -7,1 9 */

//Получение от пользователя числа
int GetNumbersOfUser(string messenge)
{
    Console.Write(messenge);
    int result = 0;
    while (true)
    {
        if (int.TryParse(Console.ReadLine(), out result)) break;
        else Console.WriteLine("Введите число для продолжения");
    }

    return result;
}

//инцилизация массива рандомом
double[,] InsilizationArray(int rows, int columns)
{
    double[,] matrix = new double[rows, columns];
    Random rnd = new Random();
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            matrix[i, j] = rnd.NextDouble();
        }
    }

    return matrix;
}

//Печать массива
void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]:F2} ");
        }
        Console.WriteLine("");
    }
}

PrintArray(InsilizationArray(GetNumbersOfUser("Введите количество строк-> "), GetNumbersOfUser("Введите количество столбцов->  ")));