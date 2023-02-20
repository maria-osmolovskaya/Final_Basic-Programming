/* Задача 3*) Дано натуральное число. Напечатать сумму максимальной и минимальной цифры
Например:

12345 ==> б
1000 ==> 1
8790 ===> 9
7 ===> 14
2222 ===> 4
*/

int GetNumber(string message)
{
    bool isCorrect = false;
    int result = 0;

    while (!isCorrect)
    {
        Console.WriteLine(message);

        if (int.TryParse(Console.ReadLine(), out result))
        {
            isCorrect = true;
        }
        else
        {
            Console.WriteLine("Ввели не число. Введите число.");
        }
    }

    return result;
}

void PrintDigitsSum(int number)

{
    int max = number % 10;
    int min = number % 10;
    while (number > 0)
    {
        int digit = number % 10;
        if (digit > max)
        {
            max = digit;
        }
        if (digit < min)
        {
            min = digit;
        }
        number = number / 10;
    }
    Console.WriteLine($"{max + min}");
}

int number = Math.Abs(GetNumber("Введите число"));
PrintDigitsSum(number);