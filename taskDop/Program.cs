/*Дополнительно. Дан массив. Найдите MEX массива. MEX (Minimum EXcluded)
 - минимальный отсутствующий элемент. */

int GetMEX(int[] values)
{
    for (int mex = 0; mex < values.Length; mex++)
    {
        bool notFound = true;
        for (int i = 0; i < values.Length; i++)
        {
            if (values[i] == mex)
            {
                notFound = false;
                break;
            }
        }
        if (notFound)
        {
            return mex;
        }
    }
    return values.Length;
}
int[] GenerateArray(int length, int minRandom, int maxRandom)
{
    Random rnd = new Random();
    int[] array = new int[length];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(minRandom, maxRandom + 1);
    }
    return array;
}
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write(array[i] + "\t");
    }
    System.Console.WriteLine();
}
int[] array = GenerateArray(14, 0, 10);
PrintArray(array);
int mex = GetMEX(array);
Console.WriteLine($"MEX (Minimum EXcluded) - минимальный отсутствующий элемент в массиве: {mex}");
