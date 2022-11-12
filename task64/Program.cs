

// Задача 64: Задайте значение N. Напишите программу,
// которая выведет все чётные числа в промежутке от N до 1. 
// Выполнить с помощью рекурсии.

// N = 5 -> "4, 2"
// N = 8 -> "8, 6, 4, 2,"

Console.Write("Введите число: ");
int namber = int.Parse(Console.ReadLine()!);


int result = NewNamber(namber);

int NewNamber(int namber)
{
    if (namber < 1) return namber;

    if (namber % 2 != 0) return NewNamber(namber - 1);

    Console.Write($"{namber} ");
    return NewNamber(namber - 1);

}
