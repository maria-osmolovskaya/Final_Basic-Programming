/*Задача 4*) Дан массив. Найти два максимальных элемента с разными номерами индексов

[5,4,2,1,3] ===> 5 4
[1,2,3,5,5] ===> 5 5
[1,1,1,1,1,1,1,1,1] ===> 1 1
[9, 10,1,2,3,4,5] ===> 10 9
*/

int GetNumber(string message)
{
    int result;

    while (true)
    {
        Console.WriteLine(message);
        if (int.TryParse(Console.ReadLine(), out result))
        {
            break;
        }
        else
        {
            Console.WriteLine("Ввели не число.");
        }
    }

    return result;
}


//метод инициализации массива
int[] InitArray(int dimension)
{
    int[] array = new int[dimension];
    Random rnd = new Random();

    for (int i = 0; i < dimension; i++)
    {
        array[i] = rnd.Next(-9, 9);
    }

    return array;
}

// метод нахождения двух максимальных элементов массива

void Max(int[] array)
{
    int max1 = 0;
    int max2 = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] >= max1)
        {
            max2 = max1;
            max1 = array[i];
        }
    }
    Console.WriteLine($"{max1}, {max2}");
}



//метод печати массива
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

int dimension = GetNumber("Введите размерность массива");
int[] array = InitArray(dimension);
PrintArray(array);
Max(array);
