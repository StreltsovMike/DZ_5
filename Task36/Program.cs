// Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0
// В примере указаны нечетные позиции начиная с 0. Я так и сделал.

int[] array = new int[10];
int sizeArray = array.Length;
int sumOddIndex = 0;

for (int index = 0; index < sizeArray; index++)
{
    array[index] = Convert.ToInt32(new Random().Next(-10, 11));
}

var strArray = string.Join(" | ", array);
Console.WriteLine($"[{strArray}]");

for(int index=1; index<sizeArray; index+=2)
{
sumOddIndex = sumOddIndex + array[index];
}

Console.WriteLine($"Сумма чисел на нечетных позициях = {sumOddIndex}");