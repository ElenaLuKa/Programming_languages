// Найти сумму чисел от 0 до n.
/*
int SumRec(int n)
{
    if (n == 0) return 0;
    else return n + SumRec(n - 1);
}

Console.Write("Input a number: ");
int N = Convert.ToInt32(Console.ReadLine());

int Sum = SumRec(N);
Console.WriteLine(Sum);
*/

// Факториал числа n.
/*
int FactorialRec(int n)
{
    if (n == 0) return 1;
    else return n * FactorialRec(n - 1);
}

Console.Write("Input a number: ");
int N = Convert.ToInt32(Console.ReadLine());

int Factorial = FactorialRec(N);
Console.WriteLine(Factorial);
*/

// Вычислить a в степени n.
/*
int PoverRec(int a, int n)
{
    if (n == 0) return 1;
    else return PoverRec(a, n - 1) * a;
}

Console.Write("Input a number: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a number: ");
int n = Convert.ToInt32(Console.ReadLine());

int Pover = PoverRec(a, n);
Console.WriteLine(Pover);
*/