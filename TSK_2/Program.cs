double CheckNumbers(string param)
{
    while (true)
    {
        Console.Write($"{param} = ");
        if (double.TryParse(Console.ReadLine()!, out double number))
        {
            return number;
        }
        else
        {
            Console.WriteLine("Число введено неправильно.");
        }
    }
}
void IntersectionPoint(double k1, double b1, double k2, double b2)
{
    if (k1 == k2) Console.WriteLine("Точки пересечения не существует, т.к. k1 = k2.");
    else
    {
        double x = Math.Round((b2 - b1) / (k1 - k2), 2);
        double y = Math.Round(k1 * x + b1, 2);
        Console.WriteLine($"Точка пересечения функций y = {k1}x + {b1} и y = {k2}x + {b2} имеет координаты x = {x} и y = {y}.");
    }
}

Console.WriteLine("Введите числа первой функции:");
double k1 = CheckNumbers("k1");
double b1 = CheckNumbers("b1");
Console.WriteLine("Введите числа второй функции:");
double k2 = CheckNumbers("k2");
double b2 = CheckNumbers("b2");
IntersectionPoint(k1, b1, k2, b2);