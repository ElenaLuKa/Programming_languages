// Задача 1. Найти большее из 9.
/*
int a1 = 15;
int b1 = 39;
int c1 = 17;
int a2 = 45;
int b2 = 14569;
int c2 = 1;
int a3 = 156;
int b3 = 2000;
int c3 = 59;

int max = a1;
if (b1 > max) max = b1;
if (c1 > max) max = c1;

if (a2 > max) max = a2;
if (b2 > max) max = b2;
if (c2 > max) max = c2;

if (a3 > max) max = a3;
if (b3 > max) max = b3;
if (c3 > max) max = c3;

Console.WriteLine(max);

*/

// Решение задачи методом 
/*
int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if(arg2 > result) result = arg2;
    if(arg3 > result) result = arg3;
    return result;
}

int a1 = 15;
int b1 = 39;
int c1 = 17;
int a2 = 45;
int b2 = 14;
int c2 = 1;
int a3 = 156;
int b3 = 2;
int c3 = 59;

// int max1 = Max(a1, b1, c1);
// int max2 = Max(a2, b2, c2);
// int max3 = Max(a3, b3, c3);
// int max = Max(max1, max2, max3);
// or

int max = Max(Max(a1, b1, c1), Max(a2, b2, c2), Max(a3, b3, c3));

Console.WriteLine(max);

*/

// Решение задачи Массивом
/*
int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if(arg2 > result) result = arg2;
    if(arg3 > result) result = arg3;
    return result;
}

//              0   1   2   3   4    5   6  7  8  
int[] array = {15, 17, 23, 48, 159, 231, 2, 4, 9};
array[0] = 15;

int max = Max(Max(array[0], array[1], array[2]), Max(array[3], array[4], array[5]), Max(array[6], array[7], array[8]));

Console.WriteLine(max);

*/

// Решение задачи массивом с n элементом: Имеется одномерный массив array из n элементов, требуется найти элемент массива, равный find
/*
//              0   1   2   3   4    5    6  7  8  9
int[] array = {15, 17, 23, 48, 159, 231, 23, 2, 4, 9};

int n = array.Length;
int find = 23;

int index = 0;

while (index < n)
{
    if(array[index] == find)
    {
        Console.WriteLine(index);
        break; //команда используется для того, что бы на первом найденом значении остановиться. В противном случае она покажет все искомые значения
    }
    //index = index + 1;   
}

*/ 
// Метод
/*

void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    
    while (index < length)
    {
        collection[index] = new Random().Next(1, 10);
        index++;
    }
}

void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}

int[] array = new int[10]; //new int - команда, которая переводитсяЖ создай новый массив (по умолчанию заполняется нулями)

FillArray(array);
PrintArray(array);

*/

// Метод

/*

void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    
    while (index < length)
    {
        collection[index] = new Random().Next(1, 10);
        index++;
    }
}

void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}

int IndexOf(int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int position = -1;
    while (index < count)
    {
        if(collection[index] == find)
        {
            position = index;
        }
        index++;
    }
    return position;
}

int[] array = new int[10]; //new int - команда, которая переводитсяЖ создай новый массив (по умолчанию заполняется нулями)

FillArray(array);
PrintArray(array);
Console.WriteLine();
int pos = IndexOf(array, 5);
Console.WriteLine(pos);
*/
