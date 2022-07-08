//  Задайте массив вещественных чисел. 
//  Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

//Тк рациональные числа входят в область вещественных, будем мработать с ними

double[] array = new double[10];
int sizeArray = array.Length;

for (int index = 0; index < sizeArray; index++)
{
    array[index] = Convert.ToDouble(new Random().Next(10, 100) / 10.0);
}

var strArray = string.Join(" ; ", array);
Console.WriteLine($"[{strArray}]");

double numberMax = array[0];
double numberMin = array[0];

for (int index = 0; index < sizeArray; index++)
{
    if(array[index]>numberMax)
    {
        numberMax=array[index];
    }
    else if(array[index]<numberMin)
    {
        numberMin=array[index];
    }
}

double differenceMaxMin = numberMax - numberMin;
differenceMaxMin = Math.Round(differenceMaxMin, 1);    //Вот тут у меня вопрос: 
                                                       //Если удалить эту строчку, то при вычислении разности 2х чисел с одним знаком после запятой 
                                                       //консоль выдает ответ типа "7,200000000000001" (с большим количеством 0 и цифрой в конце)
                                                       //Почему так происходит?
Console.WriteLine(numberMax);
Console.WriteLine(numberMin);
Console.WriteLine(differenceMaxMin);