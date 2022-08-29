int[] GenerateArray(int M)
{
    int[] array = new int[M];
    for (int i = 0; i < array.Length; i++)
    {
        while (true)
        {
            Console.Write("Введите " + (i + 1) + "-ое целое число: ");
            if (int.TryParse(Console.ReadLine()!, out array[i])) break;
            else Console.WriteLine("Число введено неправильно.");
        }
    }
    return array;
}

void PrintNumbers(int[] array)
{
    Console.Write("Ваши введенные числа: ");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write(array[i] + ", ");
        else Console.Write(array[i] + ".");
    }
    Console.WriteLine();
}

void NumbersBiggerThanZero(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            count++;
        }
    }
    Console.WriteLine("Число чисел больше нуля равно " + count + ".");
}

while (true)
{
    Console.WriteLine("Введите количество чисел:");
    if (int.TryParse(Console.ReadLine()!, out int numberOfElements))
    {
        if (numberOfElements <= 0) Console.WriteLine("Число введено неправильно.");
        else
        {
            int[] array = GenerateArray(numberOfElements);
            Console.WriteLine();
            PrintNumbers(array);
            NumbersBiggerThanZero(array);
            break;
        }
    }
    else Console.WriteLine("Число введено неправильно.");
}