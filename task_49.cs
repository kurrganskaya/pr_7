// Задача 49: Показать двумерный массив размером m×n, заполненный вещественными числами.
Console.Write("Введите количество строк: ");
int m = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int n = int.Parse(Console.ReadLine());
double [,] array = new double[m,n];

for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        array [i,j] = new Random().Next(1,5) + new Random().NextDouble();
        Console.Write(array [i,j] + " ");
    }
    Console.WriteLine();
}
