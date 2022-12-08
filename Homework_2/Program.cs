// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
/*

int Duo(int num)
{
    if(num > 100 && num < 999)
    {
        int duonum = num / 10 % 10;
        return duonum;
    }
    else
    {
        return -1;
    }
}

Console.WriteLine("Enter the number: ");
int num = Convert.ToInt32(Console.ReadLine());
int secondNum = Duo(num);

Console.WriteLine($"Second Number version a Number {num} is {secondNum}");

*/

// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

/*
int ThirdNum(int num)
{
    if(num > 99)
    {
        while(num > 1000) 
        {
            num = num / 10;
        }
        int ThirdNum = num % 10;
        return ThirdNum;
    }
    else
    {
        return -1;
    }    
} 

Console.WriteLine("Enter the number: ");
int num = Convert.ToInt32(Console.ReadLine());
int newNum = ThirdNum(num);

Console.WriteLine($"Third Number version f Number {num} is {newNum}");

*/

//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

/*
bool Day(int count)
{
    
    if(count == 6) return true;
    if(count == 7) return true;
    else 
    return false;
}

// int countDay = new Random().Next(1, 8);

Console.WriteLine("enter а number from 1 to 7: ");
int countDay = Convert.ToInt32(Console.ReadLine());

bool reply  = Day(countDay);

// Console.WriteLine(countDay); - при рандомном способе
Console.WriteLine(reply);

*/

