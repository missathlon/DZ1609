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