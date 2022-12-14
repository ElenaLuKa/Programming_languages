// Тема: Двумерные массивы

// Задача: Необходимо задать двумерный массив размером mxn, заполненный натуральными целыми числами
/*
int[,] CreateRandom2dArray() // от количества запятых зависит какой массив будет создаваться, двумерный, трехмерный и т.д. 
{
    Console.WriteLine("Input a number of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Input a number of columns: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Input a min possible value: ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Input a max possible value: ");
    int maxValue = Convert.ToInt32(Console.ReadLine());

    int[,] array = new int[rows, columns];
    for(int i = 0; i < rows; i++)
        for(int j = 0; j < columns; j++)
            array[i,j] = new Random().Next(minValue, maxValue + 1);
    return array;
}

void Show2dArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i,j] + "\t"); //"\t" - используется для табуляции массива. 
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,] myArray = CreateRandom2dArray();
Show2dArray(myArray);
*/

// Задача: Задайте двумерный массив размера m на n, каждый элемент массива находится по формуле Aij = i+j. 
//Выведите полученный массив на экран. 
/*
 int[,] Create2dArray(int rows, int columns)
{
 
    int[,] array = new int[rows, columns];
    for(int i = 0; i < rows; i++)
        for(int j = 0; j < columns; j++)
            array[i,j] = i + j;
    return array;
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

int[,] myArray = Create2dArray(rows, columns);
Show2dArray(myArray);
*/

// Задайте двумерный массив. Найдите элементы у которых оба индекса четные, и замените эти элементы на их квадраты
/*
int[,] Create2dArray()
{
    Console.WriteLine("Input a number of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Input a number of columns: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Input a min possible value: ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Input a max possible value: ");
    int maxValue = Convert.ToInt32(Console.ReadLine());

    int[,] array = new int[rows, columns];
    for(int i = 0; i < rows; i++)
        for(int j = 0; j < columns; j++)
            array[i,j] = new Random().Next(minValue, maxValue + 1);
    return array;
}

void Create2dCorrectArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i+=2)
        for(int j = 0; j < array.GetLength(1); j+=2)
            array[i,j] *= array[i,j];
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

int[,] myArray = Create2dArray();
Show2dArray(myArray);
Create2dCorrectArray(myArray);
Show2dArray(myArray);
*/

// Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (с индексами(0,0);(1,1) и т.д.)
/*
int[,] CreateRandom2dArray()
{
    Console.WriteLine("Input a number of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Input a number of columns: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Input a min possible value: ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Input a max possible value: ");
    int maxValue = Convert.ToInt32(Console.ReadLine());

    int[,] array = new int[rows, columns];
    for(int i = 0; i < rows; i++)
        for(int j = 0; j < columns; j++)
            array[i,j] = new Random().Next(minValue, maxValue + 1);
    return array;
}

int Dioganal(int[,] array)
{
    int summ = 0;
    for(int i = 0; i < array.GetLength(0) && i < array.GetLength(1); i++)
        summ += array[i,i];
    return summ;    
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

int[,] myArray = CreateRandom2dArray();
Show2dArray(myArray);
int summ = Dioganal(myArray);
Console.WriteLine(summ);

*/
