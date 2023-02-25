//Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа строго в промежутке от M до N.
/*
void ShowNumbers(int m, int n)
{
    Console.Write(m + " ");
    if (m < n) ShowNumbers(m + 1, n);
}

Console.Write("Input number M: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number N: ");
int N = Convert.ToInt32(Console.ReadLine());
//выводимые числа должны быть натуральными, поэтому далее идут проверки
if (N > 0) 
{
    if (M <= N)
    {
        if (M >= 1) ShowNumbers(M, N);
        else
        {
            M = 1;//М приравниваем к единице, поскольку выводимые числа должны быть натуральными
            ShowNumbers(M, N);
        }
    }
    else Console.Write("The number M must be less than or equal to the number N");
}
else Console.Write("The number N must be natural!");
*/

//Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
//M = 1; N = 15 -> 120
//M = 4; N = 8. -> 30
/*
int SumNumbers(int m, int n)
{
    if (m <= n) return m + SumNumbers(m + 1, n);
    else return 0;
}

Console.Write("Input number M: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number N: ");
int N = Convert.ToInt32(Console.ReadLine());
//слагаемые числа должны быть натуральными, поэтому далее идут проверки
if (N > 0)
{
    if (M <= N)
    {
        if (M >= 1)
        {
            int sum = SumNumbers(M, N);
            Console.Write($"The sum of natural elements in the range from {M} to {N} is {sum}");
        }
        else
        {
            M = 1;//М приравниваем к единице, поскольку слагаемые числа должны быть натуральными
            int sum = SumNumbers(M, N);
            Console.Write($"The sum of natural elements in the range from M to {N} is {sum}");
        }
    }
    else Console.Write("The number M must be less than or equal to the number N");
}
else Console.Write("The number N must be natural!");
*/

//Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
//m = 2, n = 3 -> A(m,n) = 9
//m = 3, n = 2 -> A(m,n) = 29

int AckermanFunction (int m, int n)
{
    if (m == 0) return n + 1;
    else
    {
        if(m != 0 && n == 0) return AckermanFunction(m - 1, 1);
        else return AckermanFunction (m - 1, AckermanFunction(m, n - 1));
    }
}

Console.Write("Input non-negative number M: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.Write("Input non-negative number N: ");
int N = Convert.ToInt32(Console.ReadLine());

if (M >= 0 && N >= 0)
{
    int result = AckermanFunction(M, N);
    Console.Write($"The ackerman function for numbers {M} and {N} is {result}");
}
else Console.Write("The numbers M and N must be non-negative!");
