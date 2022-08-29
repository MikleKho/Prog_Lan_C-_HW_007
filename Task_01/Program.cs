// Задача 1: Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

int Prompt(string message)
{
    System.Console.Write(message);
    string readValue = Console.ReadLine();
    int result = int.Parse(readValue);
    return result;
}

double[,] Mass_rnd_inject(double[,] massInside)
{
    Random rnd = new Random();

    for (int i = 0; i < massInside.GetLength(0); i++)
    {
        for (int j = 0; j < massInside.GetLength(1); j++)
        {
            massInside[i, j] = Math.Round((rnd.NextDouble() * 10), 2);
        }
    }

    return massInside;
}

void MassPrint(double[,] massInside)
{
    System.Console.WriteLine("Массив -->  ");

    for (int i = 0; i < massInside.GetLength(0); i++)
    {
        for (int j = 0; j < massInside.GetLength(1); j++)
        {
            System.Console.Write($"  {massInside[i, j].ToString("F2")}");
        }
        System.Console.WriteLine();
    }

    return;
}

int massNumberRows = Prompt("Введите количество строк массива (>= 1) -->  ");
int massNumberColumns = Prompt("Введите количество столбцов массива (>= 1) -->  ");

double[,] mass = new double[massNumberRows, massNumberColumns];

mass = Mass_rnd_inject(mass);
MassPrint(mass);

