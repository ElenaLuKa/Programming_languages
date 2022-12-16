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
   
    for(int i = 0; i < size; i++)
    {
        array[i] = Math.Round(new Random().Next(minValue, maxValue) + new Random().NextDouble(), 2);
    }
    return array;
}

void ShowArray(double[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

double differenceMaxMin(int size, double[] array)
{
    int imin = 0;
    int imax = size-1;
    for(int i = 1; i < size; i++)
    {
        if(array[i] < array[imin])
            imin = i;
        else
        {
            if(array[i] > array[imax])
               imax = i;         
        }
    }
    double result = array[imax] - array[imin];
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