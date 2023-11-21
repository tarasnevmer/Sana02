Console.WriteLine("Введіть 5 оцінок студента за 100-бальною шкалою:");

int[] marks = new int[5];
int sum = 0;

for (int i = 0; i < marks.Length; i++)
{
    Console.Write($"Оцінка {i + 1}: ");
    marks[i] = Convert.ToInt32(Console.ReadLine());

    
    if (marks[i] < 0 || marks[i] > 100)
    {
        Console.WriteLine("Оцінка повинна бути в межах 0-100. Спробуйте знову.");
        i--; 
    }
    sum += marks[i];
}

double averageMark = (double)sum / marks.Length;

if (averageMark >= 50)
{
    Console.WriteLine($"Середній бал: {averageMark}. Студент допущений до екзамену.");
}
else
{
    Console.WriteLine($"Середній бал: {averageMark}. Студент не допущений до екзамену.");
}

Console.ReadLine();
