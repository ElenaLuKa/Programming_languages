// Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. 
// В случае, если это невозможно, программа должна вывести сообщение для пользователя.
/*
int[,] Create2dArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] array = new int[rows, columns];
    for(int i = 0; i < rows; i++)
        for(int j = 0; j < columns; j++)
            array[i,j] = new Random().Next(minValue, maxValue + 1);
    return array;
}

void RewerseArray(int[,] array)
{
    if(array.GetLength(0) == array.GetLength(1))
        for(int i = 0; i < array.GetLength(0) - 1; i++)
            for(int j = i + 1; j < array.GetLength(1); j++)
            {
                int temp = array[i,j];
                array[i,j] = array[j,i];
                array[j,i] = temp;
            }
    else Console.WriteLine("Reverse in impossible!");
    
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

int[,] myArray = Create2dArray(rows, columns, minValue, maxValue);
Show2dArray(myArray);
RewerseArray(myArray);
Show2dArray(myArray);
*/

// Задайте двумерный массив. Напишите программу, которая поменяет местами две строки, которые задаст пользователь
/*
int[,] Create2dArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] array = new int[rows, columns];
    for(int i = 0; i < rows; i++)
        for(int j = 0; j < columns; j++)
            array[i,j] = new Random().Next(minValue, maxValue + 1);
    return array;
}

void SwitchRows (int[,] array, int row1, int row2)
{
    if(row1 != row2 && row1 < array.GetLength(0) && row2 < array.GetLength(0))
        for(int j = 0; j < array.GetLength(1); j++)
        {
            int temp = array[row1,j];
            array[row1,j] = array[row2,j];
            array[row2, j] = temp;
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

int[,] myArray = Create2dArray(rows, columns, minValue, maxValue);
Show2dArray(myArray);

Console.WriteLine("Input a number of row1: ");
int row1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input a number of row2: ");
int row2 = Convert.ToInt32(Console.ReadLine());

SwitchRows (myArray, row1, row2);
Show2dArray(myArray);
*/

// Из двумерного массива целых чисел удалить строку и столбец, на пересечении которых расположен наименьший элемент

int[,] Create2dArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] array = new int[rows, columns];
    for(int i = 0; i < rows; i++)
        for(int j = 0; j < columns; j++)
            array[i,j] = new Random().Next(minValue, maxValue + 1);
    return array;
}

int[,] NewArray(int[,] array)
{
    int imin = 0;
    int jmin = 0;
    for(int i = 0; i < array.GetLength(0); i++)
        for(int j = 0; j < array.GetLength(1); j++)
            if(array[i,j] < array[imin,jmin])
            {
                imin = i;
                jmin = j;
            }
    int[,] newArray = new int[array.GetLength(0) - 1, array.GetLength(1) - 1];
    for(int i = 0, x = 0; i < array.GetLength(0); i++, x++)
        if(i == imin)
            x = x - 1;
        else 
            for(int j = 0, y = 0; j < array.GetLength(1); j++, y++)
                if(j == jmin)
                    y = y - 1;
                else
                newArray[x,y] = array[i,j];    
                
    return newArray;        
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

int[,] myArray = Create2dArray(rows, columns, minValue, maxValue);
Show2dArray(myArray);
int[,] NewMyArray = NewArray(myArray);
Show2dArray(NewMyArray);
