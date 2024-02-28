using System;

class Program
{
    static void Main()
    {
        // Арифметические операции
        int a = 10;
        int b = 5;

        int sum = a + b;
        int difference = a - b;
        int product = a * b;
        int quotient = a / b;
        int remainder = a % b;

        Console.WriteLine("Сложеие: " + sum);
        Console.WriteLine("Вычитание: " + difference);
        Console.WriteLine("Умноение: " + product);
        Console.WriteLine("деление: " + quotient);
        Console.WriteLine("остаток: " + remainder);

        // Логические операции
        bool isTrue = true;
        bool isFalse = false;

        bool andResult = isTrue && isFalse;
        bool orResult = isTrue || isFalse;
        bool notResult = !isTrue;

        Console.WriteLine("И" + andResult);
        Console.WriteLine("Или" + orResult);
        Console.WriteLine("НЕ" + notResult);

        // Операции сравнения
        int x = 10;
        int y = 20;

        bool isEqual = x == y;
        bool isNotEqual = x != y;
        bool isGreater = x > y;
        bool isLess = x < y;
        bool isGreaterOrEqual = x >= y;
        bool isLessOrEqual = x <= y;

        Console.WriteLine("равенство " + isEqual);
        Console.WriteLine("не равенство " + isNotEqual);
        Console.WriteLine("больше" + isGreater);
        Console.WriteLine("меньше" + isLess);
        Console.WriteLine("больше или равно" + isGreaterOrEqual);
        Console.WriteLine("меньше или равно" + isLessOrEqual);
    }
}