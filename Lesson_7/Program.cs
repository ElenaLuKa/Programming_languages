// Найти сумму чисел от 0 до n.

int SumRec(int n)
{
    if (n == 0) return 0;
    else return n + SumRec(n-1);
}

Console.Write("Input a number: ");
int N = Convert.ToInt32(Console.ReadLine());

int Sum = SumRec(N);
Console.WriteLine(Sum);

