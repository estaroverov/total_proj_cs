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