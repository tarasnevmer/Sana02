Console.WriteLine("Введіть коефіцієнти квадратного рівняння ax^2 + bx + c = 0");

Console.Write("Введіть a: ");
double a = Convert.ToDouble(Console.ReadLine());

Console.Write("Введіть b: ");
double b = Convert.ToDouble(Console.ReadLine());

Console.Write("Введіть c: ");
double c = Convert.ToDouble(Console.ReadLine());

double discriminant = b * b - 4 * a * c;

if (discriminant > 0)
{
    double x1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
    double x2 = (-b - Math.Sqrt(discriminant)) / (2 * a);

    Console.WriteLine($"Дискримінант: {discriminant}");
    Console.WriteLine($"Корені рівняння: x1 = {x1}, x2 = {x2}");
}
else if (discriminant == 0)
{
    double x = -b / (2 * a);
    Console.WriteLine($"Дискримінант: {discriminant}");
    Console.WriteLine($"Один корінь рівняння: x = {x}");
}
else
{
    Console.WriteLine("Дискримінант від'ємний, розв'язків немає.");
}

Console.ReadLine();