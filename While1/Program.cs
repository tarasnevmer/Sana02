using System.Text;

Console.OutputEncoding = Encoding.UTF8;
Console.Write("Введіть натуральне число n: ");

int n = Convert.ToInt32(Console.ReadLine());

double resultA = CalculateA(n);
double resultB = CalculateB(n);
long resultC = CalculateC(n);

Console.WriteLine($"a = {resultA}");
Console.WriteLine($"b = {resultB}");
Console.WriteLine($"c = {resultC}");

Console.ReadLine();

static double CalculateA(int n)
{
    double result = 0.0;

    for (int i = 0; i <= n; i++)
    {
        result += Math.Pow(-1, i) / (2 * i + 1);
    }

    return result;
}

static double CalculateB(int n)
{
    double result = 0.0;

    for (int i = 1; i <= n; i++)
    {
        result += 1 + 1.0 / Math.Pow(i, 2);
    }

    return result;
}

static long CalculateC(int n)
{
    long result = 0;
    long factorial = 1;

    for (int i = 1; i <= n; i++)
    {
        factorial *= i;
        result += factorial;
    }

    return result;
}