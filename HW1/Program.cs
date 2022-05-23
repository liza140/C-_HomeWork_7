// Составить частотный словарь элементов двумерного массива/

// Создание массива
int[,] CreateArray(int m, int n)
{
    int[,] array = new int[m, n];
    return array;
}

// Заполнение массива
void FillArray(int[,] array, int firstEl, int lastEl)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(firstEl, lastEl + 1);
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

// создание частотного словаря
int[,] CreateDictionary(int[,] array, int firstEl, int lastEl)
{
    int[,] diction = new int[2, lastEl - firstEl + 1];
    int elements = 1;
    for (int j = 0; j < diction.GetLength(1); j++)
    {
        diction[0, j] = elements;
        elements++;
    }
    return diction;
}

// Заполнение частотного словаря
void FillDictionary(int[,] array, int[,] diction)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < diction.GetLength(1); k++)
            {
                if (array[i, j] == diction[0, k]) diction[1, k]++;
            }
        }
    }
}

// Печать частотного словаря
void PrintDictionary(int[,] diction)
{
    for (int j = 0; j < diction.GetLength(1); j++)
    {
        if (diction[1, j] % 10 == 2
        || diction[1, j] % 10 == 3
        || diction[1, j] % 10 == 4
        && diction[1, j] % 100 != 12
        && diction[1, j] % 100 != 13
        && diction[1, j] % 100 != 14)
        {
            Console.WriteLine($"Элемент {diction[0, j]} встречается {diction[1, j]} раза");
        }
        else Console.WriteLine($"Элемент {diction[0, j]} встречается {diction[1, j]} раз");
    }
}



int M = 4;
int N = 4;
int FirstElement = 1;
int LastElement = 9;
int[,] Array = CreateArray(M, N);
FillArray(Array, FirstElement, LastElement);
PrintArray(Array);
Console.WriteLine();
int[,] Dictionary = CreateDictionary(Array, FirstElement, LastElement);
FillDictionary(Array, Dictionary);
PrintDictionary(Dictionary);





