// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
/*
int Exponent(int A, int B)
{
    int mult = A;

    for (int currB = B; currB > 1; currB = currB - 1)
    {
        mult = mult * A; 
    }
    return mult;
}

Console.WriteLine("Enter the Number A: ");
int numA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the Number B: ");
int numB = Convert.ToInt32(Console.ReadLine());
int mult = Exponent(numA, numB);
Console.WriteLine(mult);
*/

// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
/*
int Sum(int num)
{
    int n = num;
    int sum = 0;
        
    while(n > 0)
        {
        int current = n % 10;
        sum = sum + current;
        n = n / 10;
        }
        return sum;       
}

Console.WriteLine("Enter the Number: ");
int Number = Convert.ToInt32(Console.ReadLine());
int SumCurrent = Sum(Number);
Console.WriteLine(SumCurrent);
*/

// Задача 29: Напишите программу, которая задаёт массив из n элементов и выводит их на экран.
/*
int[] CreateArray(int size)
{
    int[] array = new int[size];

    for(int i = 0; i < size; i++)
    {
        Console.WriteLine("Input the elements array: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
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

Console.Write("Enter a number of elements in the array: ");
int size = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateArray(size);
ShowArray(myArray);
*/