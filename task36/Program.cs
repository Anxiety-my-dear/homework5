//  Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
Console.WriteLine("Введите размерность массива");
int size = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите минимальное допустимое значение в массиве");
int min = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите максимальное допустимое значение в массиве");
int max = Convert.ToInt32(Console.ReadLine());

int[] array = FillArray(size, min, max);

int SumElementsOfTheOddPosition(int[] inputArray)
{
    int Sum = 0;
    for (int i = 1; i < inputArray.Length; i+= +2) // 0 это ведь чётное, поэтому с  i1 начинаю
    {
     Sum += inputArray[i];
    }
    return Sum;
}

int[] FillArray(int sizeArray, int minValue, int maxValue)
{
    Random random = new Random();
    int[] resultArray = new int[sizeArray];
    for (int i = 0; i < resultArray.Length; i++)
    {
        resultArray[i] = random.Next(minValue, maxValue + 1);
    }
    return resultArray;
}
Console.WriteLine($"Получившийся массив:[{string.Join(",",array)}]");
Console.WriteLine("Сумма элементов на нечётных позициях:"+ SumElementsOfTheOddPosition(array));