// Необходимо написать задачу, которая принимает на вход число(А) и выдает сумму чисел от 1 до А.
/*
int GetSum(int num)
{
    int sum = 0;

    for(int current = 1; current <= num; current++)
    // способ записи привыносе рабочей переменной за цикл
    // int sum = 0;
    // int current = 1;
    // for(; current <= num; current++)

    {
        sum = sum + current; 
    }
    return sum;
}

Console.WriteLine("Intut a number: ");
int Number = Convert.ToInt32(Console.ReadLine());
int Sum = GetSum(Number);
Console.WriteLine($"Sum of numbers from 1 to {1} is {Sum}");

*/


// Необходимо написать программу, которая принимает на вход число и выдает количество цифр в числе.

/*
int Quantum(int num)
{
    int Quant = 0;
    for(int N = num; N > 0; N = N / 10)
    {
        Quant++;
    }
    return Quant;
}

Console.WriteLine("Intut a number: ");
int N = Convert.ToInt32(Console.ReadLine());
int Quant = Quantum(N);
Console.WriteLine($"Quantum of numbers {N} is {Quant}");
*/

// Необходимо написать программу, которая принимает на вход число N и выдает произведение чисел от 1 до N.

/*
int Factorial(int N)
{
    int Product = 1;
    for(int current = 1; current <= N; current++)
    {
        Product = Product * current;
    }
    return Product;
}

Console.WriteLine("Intut a number N: ");
int Num = Convert.ToInt32(Console.ReadLine());
int Product = Factorial(Num);
Console.WriteLine($"Product of numbers fron 1 to {Num} is {Product}");

*/

// Массивы статистические. С неизменяемым объемом данных.

// Метод, генерирующий одномерный массив, заполняя его случайными числами

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
        // Console.Write(array[i] + " "); //или
        Console.WriteLine($"{i + 1} element is {array[i]}");
    }
}

Console.Write("input a number of elements: ");
int lenght = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input a max pissible value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(lenght, min, max);
ShowArray(myArray);