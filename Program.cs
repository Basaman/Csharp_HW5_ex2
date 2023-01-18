//Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, 
//стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0

int lenght = GetArrayLenghtFromUser("Введите длину массива: ");
int[] array = GetRandomArray(lenght, -100, 100);
int SumOddPosNumbers = GetSumOddPosNumbers(array);

Console.WriteLine("Выполняется создание массива... ");
Console.WriteLine();
Console.WriteLine($"[{String.Join(", ", array)}] -> {SumOddPosNumbers}");

int GetArrayLenghtFromUser(string lenghtMessage)
{
    Console.Write(lenghtMessage);
    int userInput = int.Parse(Console.ReadLine() ?? "");
    return userInput;
}

int[] GetRandomArray(int size, int minValue, int maxValue)
{
    int[] result = new int[size];
    var rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        result[i] = rnd.Next(minValue, maxValue);
    }
    return result;
}

int GetSumOddPosNumbers(int[] array)
{
    int oddSum = 0;
    for (int i = 1; i < lenght; i = i + 2)
    {
        oddSum = oddSum + array[i];
    }
    return oddSum;
}