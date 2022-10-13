// Урок 8. Как не нужно писать код. Часть 2
// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2


int[,] CreateTwiceArray()
{
    Console.Write("Введите количество строк больше 0: ");
    int line = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите количество столбцов больше 0: ");
    int colum = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine();

    if (line > 0 && colum > 0)
    {
        Console.WriteLine($"Создан массив размером {line} x {colum} ");
        return new int[line, colum];

    }
    Console.WriteLine($"Создан массив размером - {0} x {0} ");
    return new int[0, 0];
}


int[,] FillArray(int[,] array, int minValue = 0, int maxValue = 10)
{
    maxValue++;


    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(minValue, maxValue);
        }
    }
    return array;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int k = 0; k < array.GetLength(1); k++)
        {
            Console.Write(array[i, k] + "\t");
        }
        Console.WriteLine();
    }
}



//==================================================================================================================
// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

int[,] SortArrayLines(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = j; k < array.GetLength(1); k++)
            {
                int tm = array[i, j];
                if (array[i, j] < array[i, k])
                {
                    tm = array[i, j];
                    array[i, j] = array[i, k];
                    array[i, k] = tm;
                }
            }
        }
    }

    return array;

}
// int[,] array = CreateTwiceArray();           // Проверка задания. Сортировка массивов.
// PrintArray(FillArray(array));
// SortArrayLines(array);
// Console.WriteLine();
// PrintArray(array);

//==================================================================================================================

void minValueinLineofArray(int[,] array)
{

    int[] findLineArray = new int[array.GetLength(0)];
    int sumLine = 0;

    for (int i = 0; i < array.GetLength(0); i++)
    {
        sumLine = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sumLine += array[i, j];
        }

        findLineArray[i] = sumLine;


    }
    int result = 0;
    int num = findLineArray[0];
    for (int i = 0; i < findLineArray.Length; i++)
    {

        if (findLineArray[i] < num)
        {
            num = findLineArray[i];
            result = i;
        }
    }


    Console.WriteLine($"Первая минимальная сумма на строке {result + 1}, с суммой элементов {findLineArray[result]}");
}

// int[,] test = CreateTwiceArray();              // Проверка задания. Нумерация строк result +1   - отчет начинается не с 0, а с 1 для удобства.
// Console.WriteLine();                             
// FillArray(test);
// minValueinLineofArray(test);
// PrintArray(test);



//==================================================================================================================
// Задача 58: Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:

int[,] SpiralArray()
{
    int[,] spiralArray = new int[4, 4];
    int line = spiralArray.GetLength(0);
    int colum = spiralArray.GetLength(1);
    int coutn = 1;
    for (int i = 0; i < spiralArray.Length / 2; i++)
    {
        for (int j = i; j < colum - i; j++)
        {
            spiralArray[i, j] = coutn++;
        }
        for (int k = i + 1; k < line - i; k++)
        {
            spiralArray[k, colum - 1 - i] = coutn++;
        }
        for (int f = colum - i - 2; f > i; f--)
        {

            spiralArray[line - 1 - i, f] = coutn++;
        }
        for (int t = line - i - 1; t > i; t--)
        {
            spiralArray[t, i] = coutn++;
        }
    }
    return spiralArray;
}

PrintArray(SpiralArray());                       // Проверка задания. Спиральный массив.





