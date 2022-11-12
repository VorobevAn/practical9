

// Задача 66: Задайте значения M и N. Напишите программу,
// которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Write("Введите число: ");
int namber1 = int.Parse(Console.ReadLine()!);
Console.Write("Введите число: ");
int namber2 = int.Parse(Console.ReadLine()!);
int amount = 0;
int meaning = Amount(namber1, namber2);
Console.WriteLine(meaning);

int Amount(int m, int n)
{
    if (m > n) return amount;
    amount = amount + m;

    return Amount(m + 1, n);
}