
/* Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

пользователь вводит индексы 10, 10 - такого элемента нет.
пользователь вводите индексы 0, 2 - выводим элеменет 7 */

//Получение от пользователя числа
string[] GetNumbersOfUser(string messenge)
{
    Console.Write(messenge);
    char[] separators = new char[] { ' ', ',', '.' };
    string[] splitArray = Console.ReadLine()!.Split(separators, StringSplitOptions.RemoveEmptyEntries);
    return splitArray;
}

int[] GetArray(string[] splitArray, string error)
{
    int[] arrayOfNumbers = new int[splitArray.Length];
    int result = 0;
    for (int i = 0; i < splitArray.Length; i++)
    {
        if (int.TryParse(splitArray[i], out result))
        {
            arrayOfNumbers[i] = result;
        }
        else Console.WriteLine(error);
    }

    return arrayOfNumbers;
}

//инцилизация массива рандомом
int[,] InsilizationArray(int[] arrayOfNumber)
{
    int[,] matrix = new int[arrayOfNumber[0], arrayOfNumber[1]];
    Random rnd = new Random();
    for (int i = 0; i < arrayOfNumber[0]; i++)
    {
        for (int j = 0; j < arrayOfNumber[1]; j++)
        {
            matrix[i, j] = rnd.Next(0, 10);
        }
    }

    return matrix;
}

//Печать массива
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

//Вывод значения  по индексу 
void SearchOfIndex(int[,] array, int[] positionArray)
{
    bool result = false;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        if (i == positionArray[0])
            for (int j = 0; j < array.GetLength(1); j++)
            {
                if (j == positionArray[1])
                {
                    result = true;
                    break;
                }
            }
    }
    if (result)
        Console.Write($"По позиции ({positionArray[0]},{positionArray[1]}) найдено число {array[positionArray[0], positionArray[1]]}");
    else Console.Write($"По позиции ({positionArray[0]},{positionArray[1]}) такого элемента нет");
}

int[,] matrix = InsilizationArray(GetArray(GetNumbersOfUser("Введите количество столбцов и строк "), " Введите только числа для создания массива"));
PrintArray(matrix);
SearchOfIndex(matrix, GetArray(GetNumbersOfUser("Введите позицию для поиска "), "Введите только чила для поиска"));