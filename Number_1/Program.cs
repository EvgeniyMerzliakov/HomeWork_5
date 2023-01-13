// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2


void FillArray(int[] col)
{
    for (int i = 0; i < col.Length; i++)
        col[i] = new Random().Next(100, 1000);
}

void Printarray(int[] col)
{
    foreach (int item in col)
        Console.Write(item + " ");
}

int EvenNumbers(int[] col)
{
    int x = 0;
    for (int i = 0; i < col.Length; i++)
    {
        if (col[i] % 2 == 0)
            x+=1;
    }
    return x;
}


Console.WriteLine("Введите мерность массива");
int N = Convert.ToInt32(Console.ReadLine());
int[] array = new int[N];

FillArray(array);
Printarray(array);
Console.WriteLine();
Console.WriteLine(EvenNumbers(array));