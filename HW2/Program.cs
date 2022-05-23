// Найти произведение двух матриц

// Создание массива
int[,] CreateArray(int m, int n)
{
    int[,] array = new int[m, n];
    return array;
}

// Проверка массивов на совместимость
bool CheckArray(int[,] Array1, int[,] Array2)
{
    bool check = false;
    if (Array1.GetLength(1) == Array2.GetLength(0)) check = true;
    return check;
}

// Заполнение массива
void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
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

// Произведение двух матриц
void MultiplicationArray(int[,] Array1, int[,] Array2, int[,] finArray)
{
    for (int i = 0; i < Array1.GetLength(0); i++)
    {
        for (int j = 0; j < Array2.GetLength(1); j++)
        {
            for (int k = 0; k < Array2.GetLength(0); k++)
            {
                finArray[i, j] = finArray[i, j] + Array1[i, k] * Array2[k, j];
            }
        }
    }
}


int M = 3;
int N = 3;
int[,] Firstrray = CreateArray(M, N);
int[,] SecondArray = CreateArray(M, N);
bool Check = CheckArray(Firstrray, SecondArray);
if (Check == true)
{
    int[,] FinalArray = CreateArray(M, N);
    FillArray(Firstrray);
    FillArray(SecondArray);
    MultiplicationArray(Firstrray, SecondArray, FinalArray);
    Console.WriteLine("Первый массив: ");
    PrintArray(Firstrray);
    Console.WriteLine();
    Console.WriteLine("Второй массив: ");
    PrintArray(SecondArray);
    Console.WriteLine();
    Console.WriteLine("Итоговый массив: ");
    PrintArray(FinalArray);
}
else Console.WriteLine("Перемножить массивы невозможно");