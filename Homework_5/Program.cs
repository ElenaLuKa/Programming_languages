// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, 
// которая покажет количество чётных чисел в массиве.

/*
int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];
    
    for(int i = 0; i < size; i++)
        array[i] = new Random().Next(minValue, maxValue + 1);

    return array;
}

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

int CountEvenElements(int[] array)
{
    int count = 0;
    
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] % 2 == 0)
            count++;
    }
    return count;
}

Console.Write("input a number of elements: ");
int lenght = Convert.ToInt32(Console.ReadLine());

int min = 100;
int max = 999;

int[] myArray = CreateRandomArray(lenght, min, max);
ShowArray(myArray);

int Count = CountEvenElements(myArray);
Console.WriteLine("Count of even elements is " + Count);
*/

// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// (отсчет начинается с 0)
/*
int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];
    
    for(int i = 0; i < size; i++)
        array[i] = new Random().Next(minValue, maxValue + 1);

    return array;
}

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

int NotEvenPosition (int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 != 0)
            sum += array[i];
    }
    return sum;
}

Console.Write("input a number of elements: ");
int lenght = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max pissible value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(lenght, min, max);
ShowArray(myArray);

int sum = NotEvenPosition(myArray);
Console.WriteLine("Sum of elements in not even position is " + sum);
*/

//Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

/*
double[] CreateRandomArray(int size, int minValue, int maxValue)
{
    double[] array = new double[size];
    double[] array2 = new double[size];
    double[] sumArray = new double[size];

    for(int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(minValue, maxValue);
        array2[i] = Math.Round(new Random().NextDouble(), 2);
        sumArray[i] = array[i] + array2[i];
    }
    return sumArray;
}

void ShowArray(double[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

double differenceMaxMin(int size, double[] sumArray)
{
    int imin = 0;
    int imax = size-1;
    for(int i = 1; i < size; i++)
    {
        if(sumArray[i] < sumArray[imin])
            imin = i;
        else
        {
            if(sumArray[i] > sumArray[imax])
               imax = i;         
        }
    }
    double result = sumArray[imax] - sumArray[imin];
    return result;     
}

Console.Write("input a number of elements: ");
int lenght = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max pissible value: ");
int max = Convert.ToInt32(Console.ReadLine());

double[] myArray = CreateRandomArray(lenght, min, max);
ShowArray(myArray);

double difference = differenceMaxMin(lenght, myArray);
Console.WriteLine("The difference between the maximum and minimum values is " + difference);
*/

// при отрицательных значениях минимального числа разница становится больше максимального, так как минус на минус дает плюс. 
// Вроде все кажется логичным в линейном плане, но не уверенна правильно ли в данном случае.
