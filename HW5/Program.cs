// В двумерном массиве целых чисел. Удалить строку и столбец, 
// на пересечении которых расположен наименьший элемент.

// Создание массива
int[,] CreateArray(int m, int n)
{
    int[,] array = new int[m, n];
    return array;
}

// Заполнение массива
void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10);
        }
    }
}

// Печать массива
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

// Поиск индексов наименьшего элемента массива
(int, int) IndexMinElement(int[,] array)
{
    int Min = array[0, 0];
    int indexR = 0;
    int indexC = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] < Min)
            {
                Min = array[i, j];
                indexR = i;
                indexC = j;
            }
        }
    }
    return (indexR, indexC);
}

// Заполнение нового массива без учета удаленных строки и столбца
void FillNewArray(int[,] array, int[,] newarray, int indexR, int indexC)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (i != indexR && j != indexC)
            {
                if (i < indexR)
                {
                    if (j < indexC) newarray[i, j] = array[i, j];
                    else newarray[i, j - 1] = array[i, j];
                }
                else
                {
                    if (j < indexC) newarray[i - 1, j] = array[i, j];
                    else newarray[i - 1, j - 1] = array[i, j];
                }
            }
        }
    }
}

int M = 4;
int N = 4;
int[,] Array = CreateArray(M, N);
FillArray(Array);
PrintArray(Array);
Console.WriteLine();
(int IndexRow, int IndexCol) = IndexMinElement(Array);
Console.WriteLine($"Индекс строки минимального элемента = {IndexRow}");
Console.WriteLine($"Индекс столбца минимального элемента = {IndexCol}");
Console.WriteLine();
int[,] NewArray = CreateArray(M - 1, N - 1);
FillNewArray(Array, NewArray, IndexRow, IndexCol);
Console.WriteLine("Новый массив:");
PrintArray(NewArray);

