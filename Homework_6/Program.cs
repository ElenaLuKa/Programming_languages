// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
/*
void EvenCount(int M)
{
    int count = 0;
    Console.Write("Input the current: ");
    for(int num = 0; num < M; num++)
    {
        int current = Convert.ToInt32(Console.ReadLine());
        if(current > 0)
           count++;
    }
    Console.WriteLine($"The numbers positive elements is: {count}");
}

Console.Write("Enter the given numbers of elements: ");
int M = Convert.ToInt32(Console.ReadLine());
EvenCount(M);
*/

//Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
//заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
/*
void IntersectionPoint(double k1, double k2, double b1, double b2)
{
    double x = (b2 - b1) / (k1 - k2); 
    double y = k2 * (b2 - b1) / (k1 - k2) + b2;
    if(k1 / k2 == b1 / b2)
        Console.WriteLine("The equation has many points of intersection, the lines coincide.");
    else 
        if(k1 == k2)
            Console.WriteLine("No points of intersection of lines.");
        else
            Console.WriteLine($"Point of intersection of lines with coordinates: ({Math.Round(x, 2)}, {Math.Round(y, 2)})");
    
}

Console.WriteLine("Input the element equation K1; ");
double k1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input the element equation K2; ");
double k2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input the element equation B1; ");
double b1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input the element equation B2; ");
double b2 = Convert.ToInt32(Console.ReadLine());

IntersectionPoint(k1, k2, b1, b2);
*/