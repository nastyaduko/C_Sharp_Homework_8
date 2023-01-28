// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию 
// элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2


int[,] array54 = GetArray(4, 4, 0, 20);
PrintArray(array54);
System.Console.WriteLine();
int[,] sortedArray54 = Sorting(array54);
PrintArray(sortedArray54);

//-----------Methods-------------

int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] array = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return array;
}

void PrintArray(int[,] collection)
{
    for (int i = 0; i < collection.GetLength(0); i++)
    {
        for (int j = 0; j < collection.GetLength(1); j++)
        { Console.Write($"{collection[i, j]} "); }
        Console.WriteLine();
    }
}

int[,] Sorting(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(1) - 1; k++)
            {
                int temp = 0;
                if (array[i, k] < array[i, k + 1])
                {
                    temp = array[i, k + 1];
                    array[i, k + 1] = array[i, k];
                    array[i, k] = temp;
                }
            }
        }
    }
    return array;
}


// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет 
// находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
System.Console.WriteLine();
int[,] array = GetArray56(3, 4, 0, 10);
PrintArray56(array);
System.Console.WriteLine();
int[] sum = GetSum(array);
System.Console.WriteLine($"[{String.Join(",", sum)}]");
System.Console.WriteLine();
int number = FindIndex(sum);
System.Console.WriteLine($"{number+1} строка");

//-----------Methods-------------

int[,] GetArray56(int m, int n, int minValue, int maxValue)
{
    int[,] array = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return array;
}

void PrintArray56(int[,] collection)
{
    for (int i = 0; i < collection.GetLength(0); i++)
    {
        for (int j = 0; j < collection.GetLength(1); j++)
        { Console.Write($"{collection[i, j]} "); }
        Console.WriteLine();
    }
}

int[] GetSum(int[,] array)
{
    int summ = 0;
    int[] sum = new int[array.GetLength(0)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            summ = summ + array[i, j];
        }
        sum[i] = summ;
        summ = 0;
    }
    return sum;
}

int FindIndex (int[] col)
{   
    int index = 0;
    int min = col[0];
    for(int i = 1; i < col.Length; i++)
    {
        if(min > col[i])
        {
            min = col[i];
            index = i;
        }
    }   
  return index;  
}

// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18


int[,] firstArray = { { 2, 4 }, { 3, 2 } };
int[,] secondArray = { { 3, 4 }, { 3, 3 } };

int[,] result = ResultMatrix(firstArray, secondArray);

System.Console.WriteLine();
PrintArray58(firstArray);
System.Console.WriteLine();
PrintArray58(secondArray);
System.Console.WriteLine();
PrintArray(result);

//-----------Methods-------------

void PrintArray58(int[,] collection)
{
    for (int i = 0; i < collection.GetLength(0); i++)
    {
        for (int j = 0; j < collection.GetLength(1); j++)
        { Console.Write($"{collection[i, j]} "); }
        Console.WriteLine();
    }
}


int[,] ResultMatrix(int[,] arrayA, int[,] arrayB)
{
    int[,] arrayC = new int[arrayA.GetLength(0), arrayB.GetLength(1)];
    int sum = 0;
    for (int i = 0; i < arrayA.GetLength(0); i++)
    {
        for (int j = 0; j < arrayB.GetLength(1); j++)
        {
            for (int k = 0; k < arrayB.GetLength(0); k++)
            {
                sum += arrayA[i, k] * arrayB[k, j];
                arrayC[i, j] = sum;
            }
            sum = 0;
        }
    }
    return arrayC;
}


// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

int m = 2;
int n = 2;
int p = 2;
int minValue = 10;
int maxValue = 100;
System.Console.WriteLine();
int[] collection = FillArray(m, n, p, minValue, maxValue);
Console.WriteLine($"[{String.Join(",", collection)}]");
int[,,] matrix60 = OneToThreeDimension(collection);
System.Console.WriteLine();
PrintArray60(matrix60);


// --------------Methods------------

int[] FillArray(int m, int n, int p, int minValue, int maxValue) // Заполняем массив случайными числами с проверкой на их неповторяемость
{
    int[] array = new int[m * n * p];
    for (int i = 0; i < m * n * p; i++)
    {
        int x = new Random().Next(minValue, maxValue + 1);
        if (Check(x, array))
        {
            i--;
        }
        else array[i] = x;
    }
    return array;
}

bool Check(int y, int[] array) // Проверка на неповторяемость
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == y) return true;
    }
    return false;
}

int[,,] OneToThreeDimension(int[] array) // Переносим данные из одномерного массива в трехмерный
{
    int[,,] arr = new int[m, n, p];
    int z = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            for (int k = 0; k < arr.GetLength(2); k++)
            {
                arr[i, j, k] = array[z];
                z++;
            }
        }
    }
    return arr;
}

void PrintArray60(int[,,] collection)

{
    for (int i = 0; i < collection.GetLength(0); i++)
    {
        for (int j = 0; j < collection.GetLength(1); j++)
        {
            for (int k = 0; k < collection.GetLength(2); k++)
            {
                Console.Write(collection[i, j, k] + "" + (i,j,k) + " ");
            }
            Console.WriteLine();
        }
    }
}


// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07


int[,] newMas = new int[4, 4];
FillArray62(newMas);
PrintArray62(newMas);

// ----------------


void FillArray62(int[,] newArray)
{
    int i = 0; int j = 0; int k = 0;
    newArray[0, 0] = 1;

    while (k + 1 < 3)
    { k++; i++; newArray[j, k] = i + 1; }

    k++; i++; newArray[j, k] = i + 1;

    while (j + 1 < 3)
    { j++; i++; newArray[j, k] = i + 1; }

    j++; i++; newArray[j, k] = i + 1;

    while (k > 1)
    { k--; i++; newArray[j, k] = i + 1; }

    k--; i++; newArray[j, k] = i + 1;

    while (j > 2)
    { j--; i++; newArray[j, k] = i + 1; }

    j--; i++; newArray[j, k] = i + 1;

    while (k < 2)
    { k++; i++; newArray[j, k] = i + 1; }

    while (j + 1 < 3)
    { j++; i++; newArray[j, k] = i + 1; }

    k--; i++; newArray[j, k] = i + 1;
}


void PrintArray62(int[,] collection)
{
    for (int i = 0; i < collection.GetLength(0); i++)
    {
        for (int j = 0; j < collection.GetLength(1); j++)
        { Console.Write($"{collection[i, j]} "); }
        Console.WriteLine();
    }
}

