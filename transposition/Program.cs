// Задана целочисленная матрица, состоящая из N строк и M столбцов. 
// Требуется транспонировать ее относительно горизонтали.

Console.Write("Vvedite kolichestvo strok N = ");
int N = Convert.ToInt32(Console.ReadLine());

Console.Write("Vvedite kolichestvo stolbtsov M = ");
int M = Convert.ToInt32(Console.ReadLine());

void FillMatrix(int[,] matrix)
{
    Random random = new Random();
    for (int i = 0; i < N; i++)
    {
        for (int j = 0; j < M; j++)
        {
            matrix[i, j] = random.Next(10);
            Console.Write($" {matrix[i, j]} ");
        }
        Console.WriteLine();
    }
}

void Exchange(int[,] matrix)
{
    for (int i = 0; i < N / 2; i++)
    {

        for (int j = 0; j < M; j++)
        {
            int t = matrix[i, j];
            matrix[i, j] = matrix[N - i - 1, j];
            matrix[N - i - 1, j] = t;
        }
    }
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < N; i++)
    {
        for (int j = 0; j < M; j++)
        {
            Console.Write($" {matrix[i, j]} ");
        }
        Console.WriteLine();
    }
}

int[,] FirstMatrix = new int[N, M];
FillMatrix(FirstMatrix);
Console.WriteLine();
Exchange(FirstMatrix);
Console.WriteLine();
PrintMatrix(FirstMatrix);


// Console.Clear();

// void InputMatrix(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//             matrix[i, j] = new Random().Next(-10, 11);
//     }
// }


// void PrintMatrix(int[,] matrix)
// {
//     Console.WriteLine();
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//             Console.Write(matrix[i, j] + " \t");
//         Console.WriteLine();
//     }
// }
// void ReleaseMatrix(int[,] matrix)
// {
//     int[,] ResultMatrix = new int[matrix.GetLength(0), matrix.GetLength(1)];
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//             ResultMatrix[i, j] = matrix[matrix.GetLength(0) - i - 1, j];
//         Console.WriteLine();
//     }
//     PrintMatrix(ResultMatrix);
// }


// Console.Write("Введите кол-во строк: ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите кол-во столбцов: ");
// int m = Convert.ToInt32(Console.ReadLine());
// int[, ] matrix = new int[n, m];
// InputMatrix(matrix);
// PrintMatrix(matrix);
// ReleaseMatrix(matrix);
