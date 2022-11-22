/*Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, 
сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3*/
Console.Write($"Введите число М (сколько чисел вы будите вводить):");
int M = Convert.ToInt32(Console.ReadLine());
int[] massiveNumbers = new int[M];
void InputNumbers(int M)
{
    for (int i = 0; i < M; i++)
    {
        Console.Write($"Введите {i+1} число > ");
        massiveNumbers[i] = Convert.ToInt32(Console.ReadLine());
    }
}
int CheckNumPositive(int[] massiveNumbers)
{
    int count = 0;
    for (int i = 0; i < massiveNumbers.Length; i++)
    {
        if(massiveNumbers[i] > 0 )
        count += 1;
    }
    return count;
}
InputNumbers(M);
int result = CheckNumPositive(massiveNumbers);
Console.WriteLine($"Введено чисел больше 0> {result}");
