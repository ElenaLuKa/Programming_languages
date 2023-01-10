// Рекурсия - вызов метода внутри метода
// Параллели с циклом:
// - повторение определенных действий;
// - существует не свободно, определяется конкретным условием;
// - есть какое-то содержимое на каждом этапе рекурсии, которое будет выполнятьсяю
// От циклов отличается большим объемом выделяемой памяти. 


// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.
/*
void ShowNums(int num)
{
    
    if(num > 1) 
        ShowNums(num - 1);  // когда вы вызываете метод, его аргумент должен чем то отличаться от аргумента, 
    Console.Write(num + " "); // который был отправлен в текущий метод
}

Console.Write("Input a number: ");
int n = Convert.ToInt32(Console.ReadLine());
ShowNums(n);
*/

// Задайте значение M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
/*
void GetNums(int num1, int num2)
{
    Console.WriteLine(num1 + " "); 
    if (num1 > num2) GetNums(num1 - 1, num2);
    if (num1 < num2) GetNums(num1 + 1, num2);
}

Console.Write("Input a fierst number: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a double number: ");
int num2 = Convert.ToInt32(Console.ReadLine());
GetNums(num1, num2);
*/

// Напишите программу, которая на вход принимает два числа A и B, и возводит число A в целую степень.
/*
double Num(int A, int B)
{
    if(B > 0) return Num(A, B - 1) * A;
    if(B < 0) return Num(A, B + 1) / A;
    return 1;
}

Console.Write("Input a fierst number: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a double number: ");
int num2 = Convert.ToInt32(Console.ReadLine());
double res = Num(num1, num2);
Console.Write(res);

*/
