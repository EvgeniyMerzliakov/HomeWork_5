// Задача 30: - HARD необязательная 
// Напишите программу, которая на вход получает размерность массива. Далее заполняет его случайными уникальными числами и выводит на экран. Далее производим сортировку массива от большего 
// к меньшему и выводим на экран. Далее придумываем алгоритм перемешивания списка на основе случайности , применяем этот алгоритм и выводим на экран результат. 
// Встроенные методы работы со списками использовать нельзя.


void FillArray(int[] col)
{
    for (int i = 0; i < col.Length; i++)
    {
        int x = new Random().Next(-99, 100);
 
        if (col.Contains(x))
        {
            i--;
        }
        else
        {
            col[i] = x;
        }
    }
}

void Printarray(int[] col)
{
    foreach (int item in col)
        Console.Write(item + " ");
}

void Sorting(int[] col)
{
    for (int i = 1; i < col.Length; i++)
    {
        int x = 0;
        for (int j = 0; j < col.Length - 1; j++)
        {
            if (col[j] < col[j + 1])
            {
                x = col[j];
                col[j] = col[j + 1];
                col[j + 1] = x;
            } 
        }   
    }
}

void Mixing(int[] col)
{
    int a = 0;
    for (int i = 0; i < col.Length; i++)
    {
        int x = new Random().Next(0, 2);

        if (x == 1 && col.Length != (i + 2) && col.Length != (i + 1))
        {
            a = col[i];
            col[i] = col[i + 2];
            col[i + 2] = a;
        }
    }
    for (int i = 1; i < col.Length; i++)
    {
        int x = new Random().Next(0, 2);

        if (x == 1)
        {
            a = col[i - 1];
            col[i - 1] = col[i];
            col[i] = a;
        }
    }
    for (int i = 0; i < col.Length; i++)
    {
        int x = new Random().Next(0, 2);

        if (x == 1)
        {
            a = col[i];
            col[i] = col[col.Length - i - 1];
            col[col.Length - i - 1] = a;
        }
    }
}



Console.WriteLine("Введите мерность массива");
int N = Convert.ToInt32(Console.ReadLine());
int[] array = new int[N];

FillArray(array);
Printarray(array);
Console.WriteLine();
Sorting(array);
Printarray(array);
Console.WriteLine();
Console.WriteLine();
Mixing(array);
Printarray(array);


