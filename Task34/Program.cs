// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int[] array = new int[10];
int sizeArray = array.Length;
int resultEvenNumbers = 0;
int resultOddNumbers = 0;

for (int index = 0; index < sizeArray; index++)
{
    array[index] = Convert.ToInt32(new Random().Next(100, 1000));
}

var strArray = string.Join(" ", array);
Console.WriteLine($"[{strArray}]");

for (int index = 0; index < sizeArray; index++)
{
    int parityCheck = array[index] % 2;
    if (parityCheck != 0)
    {
        resultOddNumbers++;
    }
    else
    {
        resultEvenNumbers++;
    }
}

Console.WriteLine($"Четных - {resultEvenNumbers}");
Console.WriteLine($"Нечетных - {resultOddNumbers}");