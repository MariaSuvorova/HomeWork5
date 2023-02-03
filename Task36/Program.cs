/* Задача 36: Задайте одномерный массив, заполненный 
случайными числами. Найдите сумму элементов, 
стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0 */

int[] InitArray (int userLength)
{
    int[] randomArray = new int[userLength];
    Random rnd = new Random();
    for (int i=0; i < userLength; i++)
    {
        randomArray[i] = rnd.Next(1,10);
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

int SumOfOddPosition(int[] array)
{
    int oddPosSum = 0;
    for (int i=0; i<array.Length-1; i+=2)
    {
        oddPosSum += array[i+1];
    }
    return oddPosSum;
}

Console.WriteLine("Введите размер массива");
int arrayLength = Convert.ToInt32(Console.ReadLine());

int[] array = InitArray(arrayLength);
PrintArr(array);
int oddSum = SumOfOddPosition(array);
Console.WriteLine($"сумма элементов нечетных позиций: {oddSum}");
