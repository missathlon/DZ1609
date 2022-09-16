// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

Console.Write("Vvedite kolichestvo chisel M = ");
int M = Convert.ToInt32(Console.ReadLine());

void FillArray(int[] array)
{
    for (int i = 0; i < M; i++)
    {
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
}

int Search(int[] array)
{
    int count = 0;
    for (int i = 0; i < M; i++)
    {
        if (array[i] > 0) count++;
    }
    return count;
}

int[] arr = new int[M];
FillArray(arr);
Console.WriteLine("[" + string.Join(", ", arr) + "]");
Console.WriteLine(Search(arr));