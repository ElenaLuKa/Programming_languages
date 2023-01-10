// Задача 54: Задайте двумерный массив. 
// Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
/*
int[,] CreateRandome2DArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] array = new int[rows, columns];
    for(int i = 0; i < rows; i++)
        for(int j = 0; j < columns; j++)
            array[i,j] = new Random().Next(minValue, maxValue + 1);
    return array;
}

void SortArrayRows(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            for (int k = 0; k < array.GetLength(1) - 1; k++)
                if (array[i, k] < array[i, k + 1])
                    {
                        int temp = array[i, k + 1];
                        array[i, k + 1] = array[i, k];
                        array[i, k] = temp;
                    }
}

void Show2dArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i,j] + "\t");
        Console.WriteLine();
    }
    Console.WriteLine();
}

Console.WriteLine("Input a number of rows: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input a number of columns: ");
int columns = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input a min possible value: ");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input a max possible value: ");
int maxValue = Convert.ToInt32(Console.ReadLine());

int[,] Myarray = CreateRandome2DArray(rows, columns, minValue, maxValue);
Show2dArray(Myarray);
SortArrayRows(Myarray);
Show2dArray(Myarray);
*/

// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.
/*
int[,] CreateRandome2DArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] array = new int[rows, columns];
    for(int i = 0; i < rows; i++)
        for(int j = 0; j < columns; j++)
            array[i,j] = new Random().Next(minValue, maxValue + 1);
    return array;
}

int[] SumArray(int[,] array)
{
    int[] newSumArray = new int[array.GetLength(1)]; 

    for(int j = 0; j < array.GetLength(1); j++)
    {
        int sum = 0;
        for(int i = 0; i < array.GetLength(0); i++)
            sum += array[i,j];
        newSumArray[j] = sum;
    }
    return newSumArray;
}

int minNumberRows(int[] array)
{
    int iminRows = 0;
    for(int i = 1; i < array.GetLength(0); i++)
        if(array[i] < array[iminRows]) iminRows = i;
    return iminRows; 
}

void ShowArray(int[] array)
{
    for(int k = 0; k < array.Length; k++)
        Console.WriteLine(array[k] + "\t");
    Console.WriteLine();
}
void Show2dArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i,j] + "\t");
        Console.WriteLine();
    }
    Console.WriteLine();
}

Console.WriteLine("Input a number of rows: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input a number of columns: ");
int columns = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input a min possible value: ");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input a max possible value: ");
int maxValue = Convert.ToInt32(Console.ReadLine());

int[,] Myarray = CreateRandome2DArray(rows, columns, minValue, maxValue);
Show2dArray(Myarray);
int[] NewMyArray = SumArray(Myarray);
ShowArray(NewMyArray);
int iminRows = minNumberRows(NewMyArray);
Console.WriteLine($"The row {iminRows + 1} with the smallest sum of elements.");
*/

// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Чтобы матрицу можно было умножить на матрицу нужно, чтобы число столбцов матрицы 1 равнялось числу строк матрицы 2.
/*
int[,] CreateRandome2DArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] array = new int[rows, columns];
    for(int i = 0; i < rows; i++)
        for(int j = 0; j < columns; j++)
            array[i,j] = new Random().Next(minValue, maxValue + 1);
    return array;
}

int[,] MultiplyArray(int[,] firstArray, int[,] secondArray)
{
    int[,] resultArray = new int[firstArray.GetLength(0), secondArray.GetLength(1)];
    
    for(int i = 0; i < resultArray.GetLength(0); i++)
        for(int j = 0; j < resultArray.GetLength(1); j++)
            for(int k = 0; k < firstArray.GetLength(1); k++)
                resultArray[i, j] += firstArray[i, k] * secondArray[k, j];
    return resultArray;
}

void Show2dArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i,j] + "\t");
        Console.WriteLine();
    }
    Console.WriteLine();
}

Console.WriteLine("Input a number of rows for first matrix: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input a number of columns for first matrix and rows for second matrix: ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input a number of columns for second matrix: ");
int num3 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input a min possible value: ");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input a max possible value: ");
int maxValue = Convert.ToInt32(Console.ReadLine());

int[,] firstArray = CreateRandome2DArray(num1, num2, minValue, maxValue);
int[,] secondArray = CreateRandome2DArray(num2, num3, minValue, maxValue);
Console.WriteLine("First array: ");
Show2dArray(firstArray); 
Console.WriteLine("Second array: ");
Show2dArray(secondArray);
Console.WriteLine("Multiplication of the First and Second array: ");
int[,] ResultArray = MultiplyArray(firstArray, secondArray);
Show2dArray(ResultArray);
*/

// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
/*
int[,,] CreateRandome3DArray(int rows, int columns, int count)
{
    int[,,] array = new int[rows, columns, count];
    for(int i = 0; i < rows; i++)
        for(int j = 0; j < columns; j++)
            for(int k = 0; k < count; k++)
                array[i,j,k] = new Random().Next(10, 99 + 1);
    return array;
}

// Сдаюсь. Списывать не хочу, а сама не додумалась, так что только половина :(
void Show3dArray(int[,,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        Console.WriteLine();   
        for(int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write("");
            for(int k = 0; k < array.GetLength(2); k++)
                Console.Write($"{array[i,j,k],1}({i},{j},{k}) \t");
            Console.WriteLine();
        }
    }       
}

Console.WriteLine("Input a number of rows: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input a number of columns: ");
int columns = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input a number of count: ");
int count = Convert.ToInt32(Console.ReadLine());

int[,,] Myarray = CreateRandome3DArray(rows, columns, count);
Show3dArray(Myarray);
*/

// Задача 62. Напишите программу, которая заполнит спирально массив.
/*
int[,] FillSpiralArray(int n)
{
    int i = 0;
    int j = 0;
    int[,] array = new int[n, n]; 

    for (int temp = 1; temp <= array.GetLength(0) * array.GetLength(1); temp++)
    { 
        array[i, j] = temp;
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

void Show2dArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            if(array[i,j] / 10 <= 0)
                Console.Write($"0{array[i,j]} ");
            else Console.Write($"{array[i,j]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

Console.WriteLine("Input a number of rows and columns: ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] Myarray = FillSpiralArray(n);
Show2dArray(Myarray);
*/