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
//==================================================================================================================
// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка


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

// PrintArray(SpiralArray());                       // Проверка задания. Спиральный массив.


//==================================================================================================================

//Задача 59: Из двумерного массива целых чисел удалить строку и столбец, на пересечении которых расположен наименьший элемент.



int[,] DeleteLineAndColum(int[,] array, int line, int colum)
{
    int[,] newArray;
    int lineCorrect = 0;
    int columCorrect = 0;
    newArray = new int[array.GetLength(0) - 1, array.GetLength(1) - 1];

    for (int i = 0; i < array.GetLength(0) - 1; i++)
    {
        columCorrect = 0;
        if (line == i) { lineCorrect++; }

        for (int j = 0; j < array.GetLength(1) - 1; j++)
        {
            if (colum == j) { columCorrect++; }
            newArray[i, j] = array[i + lineCorrect, j + columCorrect];
        }
    }
    return newArray;
}

// int[,] testArray = FillArray(CreateTwiceArray());                            // Проверка задания.
// PrintArray(testArray);
// int[,] testArray2 = DeleteLineAndColum(testArray, 0, 0);
// Console.WriteLine();
// PrintArray(testArray2);


// Задача 60 . Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)



int[,,] CreateTrippleArray()
{

    Console.Write("Введите размер Лисирв ");
    int a = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите количество Строк ");
    int b = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите количество столбцов ");
    int c = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine();
    int[,,] array = new int[a, b, c];

    return array;
}


bool CheckValues(int[,,] array, int value)
{
    bool b = false;

    int lists = array.GetLength(0);
    int lineIndex = array.GetLength(1);
    int columIndex = array.GetLength(2);
    for (int i = 0; i < lists; i++)
    {
        for (int j = 0; j < lineIndex; j++)
        {
            for (int k = 0; k < columIndex; k++)
            {
                if (array[i, j, k] == value)
                {
                    return b = true;
                }
            }
        }

    }
    return b;

}

int[,,] FillTripleArrayRandom(int[,,] array, int minValue = 10, int maxValue = 100)
{
    maxValue++;
    int coutn = 0;
    int lists = array.GetLength(0);
    int lineIndex = array.GetLength(0);
    int columIndex = array.GetLength(0);

    int[,,] arrayResult = new int[lists, lineIndex, columIndex];

    var random = new Random();
    for (int i = 0; i < lists; i++)
    {

        for (int j = 0; j < lineIndex; j++)
        {
            for (int c = 0; c < columIndex; c++)
            {
                coutn = 0;
                int value = random.Next(minValue, maxValue);

                while (CheckValues(arrayResult, value))
                {
                    value = random.Next(minValue, maxValue);

                }
                arrayResult[i, j, c] = value;
            }

        }
    }


    return arrayResult;
}



void pr(int[,,] array)                   
{
    int a = array.GetLength(0);
    int b = array.GetLength(1);
    int c = array.GetLength(2);

    for (int i = 0; i < a; i++)
    {
        for (int j = 0; j < b; j++)
        {
            for (int k = 0; k < c; k++)
            {
                Console.Write($"{array[i, j, k]}  +  ({i} {j} {k})");
            }
            Console.WriteLine();
        }
    }
}
// int[,,] abas = CreateTrippleArray();         // проверка задания. 
// abas = FillTripleArrayRandom(abas);          //ВНИМАНИЕ - если задать Обьем массива больше чем чисел которые может сгенерировать Рандом то будет вечный поиск числа.(зацикливание)
// pr(abas);


//==================================================================================================================
// Задача 61: Показать треугольник Паскаля. *Сделать вывод в виде равнобедренного треугольника.

// Не понимаю какой алгоритм его вычесления.


// //Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

// int [,] matrix1 ={{2,4},{3,2}};
// int [,] matrix2 = {{3,4},{3,3}};

// int[,] MultiplicationMatrix(int [,] matrix, int [,] matrix2){
//     int [,] resultMatrix = new int[matrix.GetLength(0),matrix2.GetLength(1)];
//         int line = matrix.GetLength(0);
//         int col = matrix2.GetLength(1);
//     for(int i = 0; i < line;i++)
//     {
//                 for (int j = 0; j < col; j++)
//                 {
//                     for (int k = 0; k < col; k++)
//                     {
//                         resultMatrix[i,j] += matrix[i,k] * matrix2[k,j];
//                     }
//                 }
//     }


//     return resultMatrix;
// }

// PrintArray(MultiplicationMatrix(matrix1,matrix2));