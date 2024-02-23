//новая строка для коммита
Console.Write("Введите количество строк (N): ");
int n = int.Parse(Console.ReadLine());

Console.Write("Введите количество столбцов (M): ");
int m = int.Parse(Console.ReadLine());

// Создаем двумерный массив (матрицу) размерности NxM
int[,] matrix = new int[n, m];

// Заполняем матрицу пользовательским вводом
Console.WriteLine("Введите элементы матрицы:");

for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m; j++)
    {
        Console.Write($"Элемент [{i + 1},{j + 1}]: ");
        matrix[i, j] = int.Parse(Console.ReadLine());
    }
}

// Находим максимальные элементы и их индексы
List<Tuple<int, int>> maxIndices = new List<Tuple<int, int>>();
int maxElement = matrix[0, 0];

for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m; j++)
    {
        int currentElement = matrix[i, j];

        if (currentElement > maxElement)
        {
            maxElement = currentElement;
            maxIndices.Clear(); // Очищаем список, так как нашли новый максимальный элемент
        }

        if (currentElement == maxElement)
        {
            maxIndices.Add(Tuple.Create(i, j));
        }
    }
}

// Выводим результат
Console.WriteLine($"Максимальный элемент: {maxElement}");

if (maxIndices.Count > 0)
{
    Console.WriteLine("Индексы максимальных элементов:");

    foreach (var index in maxIndices)
    {
        Console.WriteLine($"[{index.Item1 + 1},{index.Item2 + 1}]");
    }
}
else
{
    Console.WriteLine("Максимальных элементов нет.");
}