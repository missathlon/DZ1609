// Дана строка, состоящая из N попарно различных символов. 
// Требуется вывести все перестановки символов данной строки.

// Входные данные
// Входной файл INPUT.TXT содержит строку, состоящую из N символов (1 ≤ N ≤ 8), 
// символы - буквы английского алфавита и цифры.

Console.Write("Vvedite kolichestvo simvolov N = ");
int N = Convert.ToInt32(Console.ReadLine());

void InputString(char[] array)
{
    for (int i = 0; i < N; i++)
    {
        array[i] = Convert.ToChar(Console.ReadLine());
    }
}
void Permute(char[] a, int i, int n)
{
    int j;

    if (i == n)
    {
        Console.WriteLine(new string(a));
    }
    else
    {
        char temp;
        for (j = i; j <= n; j++)
        {
            // swap(a[i], a[j]);
            temp = a[i];
            a[i] = a[j];
            a[j] = temp;

            Permute(a, i + 1, n);

            // swap(a[i], a[j]);
            temp = a[i];
            a[i] = a[j];
            a[j] = temp;
        }
    }
}

char[] symbols = new char[N];
InputString(symbols);
Console.WriteLine(string.Join(", ", symbols));
Permute(symbols, 0, symbols.Length - 1);