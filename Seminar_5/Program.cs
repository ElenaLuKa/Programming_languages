// некоторые методы могут использоваться из раза в раз

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
        Console.Write(array[i] + " "); //или
        // Console.WriteLine($"{i + 1} element is {array[i]}");
    }
    Console.WriteLine();
}

// Задача 1. Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. 
// Найдите сумму отрицательных элементов массива.

/*
int GetSumOfNegatives(int[]array)
{
    int sum = 0;
    
    for(int i = 0; i < array.Length; i++)
        if(array[i] <0)
            sum += array[i];  // sum = sum + array[i];

    return sum;
}
*/

// Задача 2. Напишите программу замены элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.

/*
int[] Reverse (int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] *= -1;
    return array;
}
*/

// Задача 3. Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
/*
bool FindNumber (int[] array, int N)
{
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] == N)
            return true; 
    }
    return false;
}
*/
// Задача 4. Задайте массив из m случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [a,b].
/*
int FindFragment (int[] array, int a, int b)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] >= a && array[i] <= b)
            count++;
    }
    return count;
}
*/

// вывод результатов. основное тело программы

// общий для всех задач лекции
Console.Write("input a number of elements: ");
int lenght = Convert.ToInt32(Console.ReadLine());

Console.Write("Input a min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());

Console.Write("Input a max pissible value: ");
int max = Convert.ToInt32(Console.ReadLine());

// Для задачи 3.
/*
Console.Write("Input find number N = ");
int N = Convert.ToInt32(Console.ReadLine());
*/

// Для задачи 4.
/*
Console.Write("Input a min psible value on diapasone A: ");
int A = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max psible value on diapasone B: ");
int B = Convert.ToInt32(Console.ReadLine());
*/

int[] myArray = CreateRandomArray(lenght, min, max);
ShowArray(myArray);

// Для задачи 1.
/*
int result = GetSumOfNegatives(myArray);
ShowArray(newArray);
Console.WriteLine("Sum of negative elements is " + result);
*/

// Для задачи 2.
/*
int[] newArray = Reverse(myArray);
ShowArray(newArray);
*/

// Для задачи 3.
/*
bool result = FindNumber (myArray, N);
Console.Write($"The find number N - {result}");
*/

// Для задачи 4.
/*
int result = FindFragment(myArray, A, B);
Console.Write($"Number of elements on diapasone from {A} to {B} is {result}");
*/