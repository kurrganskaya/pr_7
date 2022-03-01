// Задача 55: Дан целочисленный массив. Найти среднее арифметическое каждого из столбцов.

Console.Write("Введите количество строк: ");
int m = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int n = int.Parse(Console.ReadLine());
int[,] array = new int[m, n];

void FillArray(int[,] massiv)
{
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i, j] = new Random().Next(0, 10);
        }
    }
}
FillArray(array);

void PrintArray(int[,] massiv)
{
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            Console.Write($"{massiv[i, j]}  " + "\t");
        }
        Console.WriteLine();
    }
}
PrintArray(array);

Console.WriteLine();
for (int j = 0; j < n; j++)
{
    int sum = 0;
    for (int i = 0; i < m; i++)
    {
        sum = sum + array[i, j];
    }
    Console.WriteLine($"Ср. арифм. {j + 1} столбца: {(double)sum / n}.\n");
}
