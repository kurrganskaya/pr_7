// Задача 53: В двумерном массиве показать позиции числа, заданного пользователем, или указать, что такого элемента нет.
Console.Write("Введите количество строк: ");
int k = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int n = int.Parse(Console.ReadLine());
int[,] array = new int[k, n];

void FillArray(int[,] massiv)
{
    for (int i = 0; i < k; i++)
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
    for (int i = 0; i < k; i++)
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
Console.WriteLine("Какое число найти в массиве?");
int find = int.Parse(Console.ReadLine());
bool check = false;
for (int i = 0; i < k; i++)
{
    for (int j = 0; j < n; j++)
    {
        if (find == array[i, j]) {Console.WriteLine($"Число находится на позиции ({i}, {j})."); check = true;}
        //Console.WriteLine();
    }
}
if (check) Console.WriteLine("");
else Console.WriteLine("В матрице нет такого значения.");
