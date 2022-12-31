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
        Console.Write(array[i] + " "); //или
        // Console.WriteLine($"{i + 1} element is {array[i]}");
    }
    Console.WriteLine();
}

//Напишите программу, которая перевернет одномерный массив (последний элемент будет на первом месте, а первый на последнем и т.д.)

void ReverseArray(int[] array)
{
    for(int i = 0, j = array.Length - 1; i < j; i++, j--)
    {
        int temp = array[i];
        array[i] = array[j];
        array[j] = temp;
    }
}

Console.Write("Input a number of elements: ");
int lenght = Convert.ToInt32(Console.ReadLine());

Console.Write("Input a min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());

Console.Write("Input a max pissible value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(lenght, min, max);
ShowArray(myArray);

//ReverseArray(myArray);
//ShowArray(myArray);
*/

//Задача 1. Необходимо написать программу, которая принимает на вход три числа, и проверяет, 
//может ли существовать треугольник со сторонами такой длинны.

/*
bool Triangle(int a, int b, int c)
{
   return a + b > c && a + c > b && b + c > a; // работает, как и запись ниже
   /*
    if(a + b > c && a + c > b && b + c > a)
        return true;
    return false;
     
}

Console.Write("Input A: ");
int A = Convert.ToInt32(Console.ReadLine());

Console.Write("Input B: ");
int B = Convert.ToInt32(Console.ReadLine());

Console.Write("Input C: ");
int C = Convert.ToInt32(Console.ReadLine());

bool result = Triangle(A, B, C);
if(result)
    Console.WriteLine("Triangle существует");
else 
    Console.WriteLine("Triangle не существует");
*/

//Задача 2. Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: а и b
/*
int[] Fibonachi(int a, int b, int n)
{
    int[] array = new int[n];
    array[0] = a;
    array[1] = b;

    for(int i = 2; i < n; i++)
    {
        array[i] = array[i-1] + array[i-2];
    }
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

Console.Write("Input N: ");
int Length = Convert.ToInt32(Console.ReadLine());

Console.Write("Input A: ");
int A = Convert.ToInt32(Console.ReadLine());

Console.Write("Input B: ");
int B = Convert.ToInt32(Console.ReadLine());

int[] result = Fibonachi(A, B, Length);
ShowArray(result);
*/

//Задача 3. Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования. 
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
        Console.Write(array[i] + " "); //или
        // Console.WriteLine($"{i + 1} element is {array[i]}");
    }
    Console.WriteLine();
}

int[] ArrayCopy(int[] array)
{
    int[] arrayCopy = new int [array.Length];

    for(int i = 0; i < array.Length; i++)
    {
        arrayCopy[i] = array[i];
    }
    return arrayCopy;
}

Console.Write("Input a number of elements: ");
int lenght = Convert.ToInt32(Console.ReadLine());

Console.Write("Input a min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());

Console.Write("Input a max pissible value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(lenght, min, max);
ShowArray(myArray);
int[] DoubleArray = ArrayCopy(myArray);
//myArray[0] +=10; проверка 
//ShowArray(myArray);
ShowArray(DoubleArray);
*/

