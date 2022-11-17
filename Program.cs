// Задайте значение N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от N до 1. 
// Выполнить с помощью рекурсии.
void PrintNumbersDesc(int number)
{
    if (number == 1)
    {
        Console.Write(1);
        return;
    }
    else
    {
        Console.Write(number + " ");
        PrintNumbersDesc(number - 1);
    }
}

Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());
PrintNumbersDesc(number);

// Задайте значение N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от N до 1. 
// Выполнить с помощью рекурсии.

int CalcSumNumbers(int from, int end)
{
    if (from == end)
        return from;
    else
        return CalcSumNumbers(from + 1, end) + from;
}
Console.WriteLine();
Console.WriteLine("sum = " + CalcSumNumbers(1, 15));

// Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n. С помощью рекурсии!!!
int AccermanFunc(int m, int n)
{
    if (m > 0 && n > 0)
        return AccermanFunc(m - 1, AccermanFunc(m, n - 1));
    if (m > 0 && n == 0)
        return AccermanFunc(m - 1, 1);
    if (m == 0)
        return n + 1;
    return 0;
}
Console.WriteLine(AccermanFunc(3, 2));