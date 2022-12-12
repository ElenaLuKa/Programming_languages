// dooble Math.Round(a,b) - производит округление числа, например 0,12347859 становится 0,1245 (а = 0,12347859б и и = 0,1234)

// double Math.Pow(a,b)  - возведение а в степень b 
// double Math.Sqrt(a) - извлечение корня из a

// Напишите программу, которая принимает на вход координаты точки (X и Y), при чем X b Y не равны нулю и выдает номер четверти
// плоскости, в которой находится эта точка
/*
int FindQuandrant(double x, double y)
{
    if(x > 0 && y > 0) return 1;
    if(x < 0 && y > 0) return 2;
    if(x < 0 && y < 0) return 3;
    if(x > 0 && y < 0) return 4;
    return 0;
}

Console.Write("Input the first coordinate: x = ");
double xA = Convert.ToDouble(Console.ReadLine());
Console.Write("Input the first coordinate: y = ");
double yA = Convert.ToDouble(Console.ReadLine());

int quadNum = FindQuandrant(xA, yA);
if(quadNum == 0) Console.WriteLine("The point is on the coordinate axis");
else Console.WriteLine($"The point A({xA},{yA}) is on the {quadNum} quadrant.");

*/

// Напишите программу, которая по заданному номеру четверти показывает диапазон возможных координат точек в этой четверти (x и y).

/*
void Coordinate(int quadNum)
{
    if(quadNum == 1) 
    Console.WriteLine("A(x>0, y>0)");
   
    if(quadNum == 2) 
    Console.WriteLine("A(x<0, y>0)");
    
    if(quadNum == 3) 
    Console.WriteLine("A(x<0, y<0)");
    
    if(quadNum == 4) 
    Console.WriteLine("A(x>0, y<0)");
    
    if(quadNum < 1 || quadNum > 4)
    Console.WriteLine("Incorrect quarter");
}

Console.WriteLine("Input quarter: ");
int quadNum = Convert.ToInt32(Console.ReadLine());
Coordinate(quadNum);

*/

// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.
/*
double FindDistance(double xa, double ya, double xb, double yb)
{
    double Distance = Math.Sqrt(Math.Pow((xa - xb),2) + Math.Pow((ya - yb),2));
    return Distance;
}

Console.Write("Input the point xa: ");
double xA = Convert.ToInt32(Console.ReadLine());
Console.Write("Input the point ya; ");
double yA = Convert.ToInt32(Console.ReadLine());
Console.Write("Input the point xb: ");
double xB = Convert.ToInt32(Console.ReadLine());
Console.Write("Input the point yb; ");
double yB = Convert.ToInt32(Console.ReadLine());

double Dist = Math.Round(FindDistance(xA, yA, xB, yB),3); 
Console.WriteLine($"Distance = {Dist}");

*/
// Напишите программу, которая принимает на вход число (N) и выдает ряд квадратов чисел от 1 до N.

/*
void RowSquares(int N)
{
    int result = 1;
    while(result <= N)
    {
        Console.Write(Math.Pow(result,2) + " ");
        result++;
    }
}
Console.WriteLine("Input N: ");
int N = Convert.ToInt32(Console.ReadLine());
RowSquares(N);

*/
