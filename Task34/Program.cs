/* Задача 34: Задайте массив заполненный случайными 
положительными трёхзначными числами. Напишите программу, 
которая покажет количество чётных чисел в массиве.

[345, 897, 568, 234] -> 2
*/

int[] InitArray (int userLength)
{
    int[] randomArray = new int[userLength];
    Random rnd = new Random();
    for (int i=0; i < userLength; i++)
    {
        randomArray[i] = rnd.Next(100,1000);
    }
    return randomArray;
}

void PrintArr(int[] array)
{
    Console.Write("[");
    for (int i=0; i < array.Length-1; i++)
    {
        Console.Write($"{array[i]}, ");
    }
    Console.Write($"{array[array.Length-1]}] ");
}

int NumberOfEvenItem(int[] array)
{
    int evenItem = 0;
    for (int i=0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
            evenItem += 1;
    }
    return evenItem;
}

Console.WriteLine("Введите размер массива");
int arrayLength = Convert.ToInt32(Console.ReadLine());

int[] array = InitArray(arrayLength);
PrintArr(array);
int even = NumberOfEvenItem(array);
Console.WriteLine($"четных чисел в массиве: {even}");