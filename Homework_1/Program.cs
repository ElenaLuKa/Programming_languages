// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
/*
Console.Write("Input a ferst number: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a second number: ");
int num2 = Convert.ToInt32(Console.ReadLine());

if(num1 > num2)
{
    Console.Write("max = " + num1 + " and min = " + num2);
}
else
{
    Console.Write("max = " + num2 + " and min = " + num1);
}

*/

//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
/*
Console.WriteLine("Input a ferst number: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input a second number: ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input third number: ");
int num3 = Convert.ToInt32(Console.ReadLine());

if(num1 > num2)
{
    if(num1 > num3)
    {
        Console.WriteLine("max = " + num1);
    }
    else
    {
        Console.WriteLine("max = " + num3);
    } 
}    
else
{
    if(num2 > num3)
    {
        Console.WriteLine("max = " + num2);
    }
    else
    {
        Console.WriteLine("max = " + num3);
    }
}

*/

//Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
/*
Console.Write("Input integer number: ");
int n = Convert.ToInt32(Console.ReadLine());

if(n % 2 == 0)
{
    Console.Write("YES!");
}
else 
{
    Console.Write("NO!");
}

*/

//Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
/*
Console.Write("Input an integer number: ");
int n = Convert.ToInt32(Console.ReadLine());

int current = 2;
while (current <=n)
{
    if(current % 2 == 0)
    {
        Console.Write(current +" ");
    }
    current++;
}
*/
/*

int MaxNum(int num)
{
    int des = num / 10;
    int ed = num % 10;
    int maxnum;

    if(des > ed)
    {
        maxnum = des;
    }
    else
    {
        maxnum = ed;
    }
    return maxnum;
}

int randNum = new Random().Next(10, 99);
int newnum = MaxNum(randNum);

Console.WriteLine($"New vertion a number {randNum} is {newnum}");
*/
