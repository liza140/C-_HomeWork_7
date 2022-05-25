// Сформировать трехмерный массив не повторяющимися двузначными числами показать
// его построчно на экран выводя индексы соответствующего элемента

// Создание трехмерного массива
int[,,] CreateArray(int m, int n, int p)
{
    int[,,] array = new int[m, n, p];
    return array;
}

// Заполнение массива
void FillArray(int[,,] array)
{
    int N = 10;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                if (N > 9 && N < 100)
                {
                    array[i, j, k] = N;
                    N++;
                }
                else
                {
                    N = -N + 1;
                    if (N > -100 && N < -9)
                    {
                        array[i, j, k] = N;
                        N++;
                    }
                    else Console.WriteLine("Дальнейшее заполнение массива неповторяющимеся двузначными числами невозможно");
                }
            }

        }

    }
}

// Печать массива
void PrintArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write($"{array[i, j, k]} ({i},{j},{k}) ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}

int X = 3;
int Y = 3;
int Z = 3;
int[,,] Array = CreateArray(X, Y, Z);
FillArray(Array);
PrintArray(Array);