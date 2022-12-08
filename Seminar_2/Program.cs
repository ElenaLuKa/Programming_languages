// Задача 1. Необходимо написать программу, которая выводит случайное число из отрезка от 10 до 99 и показывает наибольшую цифру числа
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

// Задача 2. Необходимо написать программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому.
/*
bool Aliquot(int num1, int num2)
{
        if(num2 % num1 == 0)
    {
        return true;
    }
    else
    {
        return false;
    }
}


Console.WriteLine("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());

bool F = Aliquot(num1, num2);
Console.WriteLine(F);

*/

// Задача 3. Необходимо написать программу, которая будет принимать на вход число и проверять кратно ли оно одновременно A и B
/*
bool Aliquot(int num1, int num2, int num3)
{
    if(num1 % num2 == 0 && num1 % num3 == 0)
    {
        return true;
    }
    else
    {
        return false;
    }
}

Console.WriteLine("Введите проверяемое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите первый делитель: ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второй делитель: ");
int num3 = Convert.ToInt32(Console.ReadLine());
bool F = Aliquot(num1, num2, num3);

Console.WriteLine(F);
*/