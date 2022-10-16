// Задача 64 : Задайте значения N, М. Напишите программу, которая выведет все натуральные числа в промежутке от N до M. Выполнить с помощью рекурсии.

// N = 5, M = 2 -> "5, 4, 3, 2,"
// N = 8, M = 4 -> "8, 7, 6, 5, 4"


void PrintNaturalValuesFromRange(int start, int end = 0)
{

    if (start == end)
    {
        Console.Write(start + " ");
        return;
    }
    Console.Write(start + " ");
    PrintNaturalValuesFromRange(start - 1, end);

}

// printNaturalValuesFromRange(8,4);                             //Проверка задания.
// PrintNaturalValuesFromRange(5,2);

//==================================================================================================================

// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

void PrintSummOfNaturalValuesFromRange(int start, int end, int result = 0)
{


    result += start;
    if (start >= end)
    {
        Console.WriteLine(result);
        return;
    }

    PrintSummOfNaturalValuesFromRange(start + 1, end, result);

}
// PrintSummOfNaturalValuesFromRange(1,15);
// PrintSummOfNaturalValuesFromRange(4,8);

//==================================================================================================================

// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int AkkermanFunction(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (m > 0 && n == 0)
    {
        return AkkermanFunction(m - 1, 1);
    }
    else
    {
        return AkkermanFunction(m - 1, AkkermanFunction(m, n - 1));
    }

}



//Console.WriteLine(AkkermanFunction(3, 2));                  //Проверка задания.