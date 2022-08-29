// Задача 2: Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и 
// возвращает значение этого элемента или же указание, что такого элемента нет.
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
void AnalyzeElementIn(double[,] massInside, int massRowNumberIn, int massColumnNumberIn)
{
    if (massRowNumberIn > massInside.GetLength(0) || massColumnNumberIn > massInside.GetLength(1))
    {

        System.Console.WriteLine("Введенной позиции в массиве не существует");
    }
    else
    {
        System.Console.WriteLine($"Указанный элемент массива равен {massInside[massRowNumberIn - 1, massColumnNumberIn - 1].ToString("F2")}");
    }
    return;
    }


    int massNumberRows = Prompt("Введите количество строк массива (>= 1) -->  ");
    int massNumberColumns = Prompt("Введите количество столбцов массива (>= 1) -->  ");

    double[,] mass = new double[massNumberRows, massNumberColumns];
    mass = Mass_rnd_inject(mass);
    MassPrint(mass);

    int massRowNumber = Prompt("Введите номер строки массива (>= 1) -->  ");
    int massColumnNumber = Prompt("Введите номер столбца массива (>= 1) -->  ");
    AnalyzeElementIn(mass, massRowNumber, massColumnNumber);

