/* Задача 38: Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементов 
массива.

[3 7 22 2 78] -> 76 */

int[] InitArray (int userLength)
{
    int[] randomArray = new int[userLength];
    Random rnd = new Random();
    for (int i=0; i < userLength; i++)
    {
        randomArray[i] = rnd.Next(1,100);
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
    Console.Write($"{array[array.Length-1]}]");
    Console.WriteLine();
}

(int, int, int) MaxMinDif(int[] array)
{
    int max = array[0];
    int min = array[0];
    for (int i=0; i<array.Length; i++)
    {
        if (array[i] > max)
            max = array[i];
        else if (array[i] < min)
            min = array[i];
    }
    int dif = max - min;
    return (max, min, dif);
}

Console.WriteLine("Введите размер массива");
int arrayLength = Convert.ToInt32(Console.ReadLine());

int[] array = InitArray(arrayLength);
PrintArr(array);
(int maxItem, int minItem, int difference) = MaxMinDif(array);
Console.WriteLine($"разница между max ({maxItem}) и min ({minItem}) элементом: {difference}");