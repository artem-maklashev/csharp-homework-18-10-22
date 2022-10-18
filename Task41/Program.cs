/* Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

0, 7, 8, -2, -2 -> 2

1, -7, 567, 89, 223-> 3 */

int GetNumberOfNumbers(string message)
{
    Console.Clear();
    Console.Write(message);
    int result = 0;
    bool isCorrect = false;
    
    while (!isCorrect)
    if (int.TryParse(Console.ReadLine(), out result))
        isCorrect= true;
    else
        Console.Write("Было введено не число. Повторите ввод: ");
    Console.WriteLine();
    return result;
}

int[] InitialArrayOfNumbers(int arrayLength)
{
    Random rnd = new Random();
    int[] array = new int[arrayLength];

    for (int i = 0; i < arrayLength; i++)
    {
        array[i] = rnd.Next(-100, 101);
    }
    return array;
}

int CountOfPositiveNumbers(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0) count+=1;
    }
    return count;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}

int length = GetNumberOfNumbers("Введите размерность массива:");
int[] arrayOfNumbers = InitialArrayOfNumbers(length);
int countPositiveNumb = CountOfPositiveNumbers(arrayOfNumbers);
PrintArray(arrayOfNumbers);
Console.WriteLine($"-> {countPositiveNumb} чисел больше 0\n");