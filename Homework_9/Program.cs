// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1.
/*
void ShowNums(int num)
{
    Console.Write(num + " "); 
    if(num > 1) 
        ShowNums(num - 1);
}

Console.Write("Input a number: ");
int n = Convert.ToInt32(Console.ReadLine());
ShowNums(n);
*/

// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
/*
int SumNumsRec(int num1, int num2)
{
    if (num1 == num2) return num1;
    else 
        if(num1 > num2) return num1 + SumNumsRec(num1 - 1, num2);
        else return num2 + SumNumsRec(num1, num2 - 1);
}

Console.Write("Input a fierst number: ");
int Num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a second number: ");
int Num2 = Convert.ToInt32(Console.ReadLine());

int Sum = SumNumsRec(Num1, Num2);
Console.WriteLine($"The sum of elements from {Num1} to {Num2} is: {Sum}");
*/

// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
/*
int AckermanRecursionn(int m, int n)
{
if (m == 0) return n + 1;
else if (n == 0 && m > 0) return AckermanRecursionn(m - 1, 1);
        else return AckermanRecursionn(m - 1, AckermanRecursionn(m, n - 1));
}

Console.Write("Input a fierst number M: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a second number N: ");
int N = Convert.ToInt32(Console.ReadLine());

int Sum = AckermanRecursionn(M, N);
Console.WriteLine($"The result of calculating the Ackermann function for numbers {M} and {N} is: {Sum}");
*/

