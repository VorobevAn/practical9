
// Задача 68: Напишите программу вычисления 
// функции Аккермана с помощью рекурсии.
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

Console.Write("Введите начальное число M:");
int numberM = int.Parse(Console.ReadLine()!);

Console.Write("Введите начальное число N:");
int numberN = int.Parse(Console.ReadLine()!);

Console.WriteLine($"Результат:{Function(numberM, numberN)}");

int Function(int numberM, int numberN)  //Метод вычисления функции Аккермана
{
    if (numberM == 0) return numberN + 1;
    if (numberM != 0 && numberN == 0) return Function(numberM - 1, 1);
    if (numberM > 0 && numberN > 0) return Function(numberM - 1, Function(numberM, numberN - 1));
    return Function(numberM, numberN);
}