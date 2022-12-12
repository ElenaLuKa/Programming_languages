// Задача 19. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
/*
bool Palindrome(int num)
{
    int n = num;
    int rew = 0;
        
    while(n > 0)
        {
        int r = n % 10;
        rew = rew * 10 + r;
        n = n / 10;
        }
    if(num == rew)
    {
       return true;       
    }
    else
    {
        return false;
    }
}
   

Console.WriteLine("Enter the number: ");
int Number = Convert.ToInt32(Console.ReadLine());
bool reply = Palindrome(Number);
Console.WriteLine(reply);
*/

// Задача 21. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
/*
double FindDistance(double xa, double ya, double xb, double yb, double za, double zb)
{
    double Distance = Math.Sqrt(Math.Pow((xa - xb),2) + Math.Pow((ya - yb),2) + Math.Pow((za - zb),2));
    return Distance;
}

Console.Write("Input the point xa: ");
double xA = Convert.ToInt32(Console.ReadLine());
Console.Write("Input the point ya; ");
double yA = Convert.ToInt32(Console.ReadLine());
Console.Write("Input the point za: ");
double zA = Convert.ToInt32(Console.ReadLine());
Console.Write("Input the point xb ");
double xB = Convert.ToInt32(Console.ReadLine());
Console.Write("Input the point yb; ");
double yB = Convert.ToInt32(Console.ReadLine());
Console.Write("Input the point zb: ");
double zB = Convert.ToInt32(Console.ReadLine());

double Dist = Math.Round(FindDistance(xA, yA, xB, yB, zA, zB),3); 
Console.WriteLine($"Distance = {Dist}");
*/

// Задача 21. Рандомный поиск координат

/*
double FindDistance(double xa, double ya, double xb, double yb, double za, double zb)
{
    double Distance = Math.Sqrt(Math.Pow((xa - xb),2) + Math.Pow((ya - yb),2) + Math.Pow((za - zb),2));
    return Distance;
}

double xA = new Random().Next(-125,125); // можно и не указывать диапазон, но будет очень много цифр
double yA = new Random().Next(-125,125);
double zA = new Random().Next(-125,125);
Console.WriteLine($"A({xA},{yA},{zA})");
double xB = new Random().Next(-125,125);
double yB = new Random().Next(-125,125);
double zB = new Random().Next(-125,125);
Console.WriteLine($"B({xB},{yB},{zB})");

double Dist = Math.Round(FindDistance(xA, yA, xB, yB, zA, zB),3); 
Console.WriteLine($"Distance = {Dist}");

*/

// Задача 23. Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

/*
void RowCubes(int N)
{
    int result = 1;
    while(result <= N)
    {
        Console.Write(Math.Pow(result,3) + " ");
        result++;
    }
}
Console.WriteLine("Input N: ");
int N = Convert.ToInt32(Console.ReadLine());
RowCubes(N);

*/

