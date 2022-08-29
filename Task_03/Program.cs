// Задача 3: Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
int Prompt(string message)
{
    System.Console.Write(message);
    string readValue = Console.ReadLine();
    int result = int.Parse(readValue);
    return result;
}

int[,] MassRndInject(int[,] massInside)
{
    Random rnd = new Random();

    for (int i = 0; i < massInside.GetLength(0); i++)
    {
        for (int j = 0; j < massInside.GetLength(1); j++)
        {
            massInside[i, j] = rnd.Next(0, 100);
        }
    }

    return massInside;
}

void MassPrintInt(int[,] massInside)
{
    System.Console.WriteLine("Массив -->  ");

    for (int i = 0; i < massInside.GetLength(0); i++)
    {
        for (int j = 0; j < massInside.GetLength(1); j++)
        {
            System.Console.Write($"     {massInside[i, j].ToString("00")}");
        }
        System.Console.WriteLine();
    }

    return;
}

double[] CalcColumnAverage(int[,] massInside)
{
    double[] valueAverageForColumnsInside = new double[massInside.GetLength(1)];
    for (int j = 0; j < massInside.GetLength(1); j++)
    {
        for (int i = 0; i < massInside.GetLength(0); i++)
        {
            valueAverageForColumnsInside[j] = valueAverageForColumnsInside[j] + massInside[i, j];
        }
        valueAverageForColumnsInside[j] = valueAverageForColumnsInside[j] / massInside.GetLength(0);
    }

    return valueAverageForColumnsInside;
}

void MassPrintRes(double[] massInside)
{
    System.Console.WriteLine("Средние арифмеимческие значения по столбцам -->  ");

    for (int i = 0; i < massInside.GetLength(0); i++)
    {
        System.Console.Write($"   {massInside[i].ToString("F2")}");
    }
        System.Console.WriteLine();

    return;
}

int massNumberRows = Prompt("Введите количество строк массива (>= 1) -->  ");
int massNumberColumns = Prompt("Введите количество столбцов массива (>= 1) -->  ");

int[,] mass = new int[massNumberRows, massNumberColumns];
mass = MassRndInject(mass);
MassPrintInt(mass);

double[] valueAverageForColumns = new double[massNumberColumns];
valueAverageForColumns = CalcColumnAverage(mass);
MassPrintRes(valueAverageForColumns);