//Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
//[3 7 22 2 78] -> 76

Console.WriteLine("Введите размерность массива");
int size = Convert.ToInt32(Console.ReadLine());
double[] array = FillArray(size);

void PrintArray(double[] array)
{
    Console.Write("[ ");
    for(int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i] + "  ");
        }
    Console.Write("]");
}
double[] FillArray(int sizeArray)
{
    double[] resultArray = new double[sizeArray];
    for (int i = 0; i < resultArray.Length; i++)
    {
        resultArray[i] =  Convert.ToDouble(new Random().Next(1,1000)) / 100;
    }
    return  resultArray ;
}
PrintArray(array);

double Raznica(double[] inputArray)
{
    double min = inputArray[0];
    double max = inputArray[0];
    for (int i = 0; i < inputArray.Length; i++)
    {
        if (inputArray[i]>max) max = inputArray[i];
    }
     for (int i = 0; i < inputArray.Length; i++)
    {
        if (inputArray[i]<min) min = inputArray[i];
    }
    return(max-min);
}
Console.WriteLine("\nРазница между максимальным и минимальным значением:"+ Raznica(array));