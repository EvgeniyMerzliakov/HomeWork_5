// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.


void FillArray(double[] col)
{
    for (int i = 0; i < col.Length; i++)
    {
        col[i] = new Random().Next(-9900, 10000);
        col[i] = col[i] / 100;
    }
}

void Printarray(double[] col)
{
    foreach (double item in col)
        Console.Write(item + " ");
}

double Difference(double[] col)
{
    double max = col[0];
    double min = col[0];
    double dif = 0;
    for (int i = 0; i < col.Length; i++)
    {
        if (col[i] > max) max = col[i];
        else if (col[i] < min) min = col[i];
    }
    dif = max - min;
    return dif;
}



Console.WriteLine("Введите мерность массива");
int N = Convert.ToInt32(Console.ReadLine());
double[] array = new double[N];

FillArray(array);
Printarray(array);
Console.WriteLine();
Console.WriteLine(Difference(array));


