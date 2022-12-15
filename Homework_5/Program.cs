
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

void ShowArray2(double[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}
// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, 
// которая покажет количество чётных чисел в массиве.

/*
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

double[] CreateFracArray(int size)
{
    double[] array2 = new double[size];

    for(int i = 0; i < size; i++)
        array2[i] = Math.Round(new Random().NextDouble(), 2);
        
    return array2;
}

double[] SumArray(int size, int[] array, double[] array2)
{   double[] sum = 0;
    for(int i = 0; i < size; i++)
       sum[i] = array[i] + array2[i];
        
    return array2;
} 

Console.Write("input a number of elements: ");
int lenght = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max pissible value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(lenght, min, max);
ShowArray(myArray);

double[] myArray2 = CreateFracArray(lenght);
ShowArray2(myArray2);
