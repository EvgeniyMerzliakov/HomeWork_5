// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0


void FillArray(int[] col)
{
    for (int i = 0; i < col.Length; i++)
        col[i] = new Random().Next(-99, 100);
}

void Printarray(int[] col)
{
    foreach (int item in col)
        Console.Write(item + " ");
}

int SummUneven(int[] col)
{
    int sum = 0;
    for (int i = 0; i < col.Length; i++)
    {
        if (i % 2 != 0)
            sum = sum + col[i]; 
    }
    return sum;
}


Console.WriteLine("Введите мерность массива");
int N = Convert.ToInt32(Console.ReadLine());
int[] array = new int[N];

FillArray(array);
Printarray(array);
Console.WriteLine();
Console.WriteLine(SummUneven(array));