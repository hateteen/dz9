void Zadacha68()
{
    Console.WriteLine("Введите два положительных числа: M и N.");
    int m = InputInt("Введите M: ");
    int n = InputInt("Введите N: ");
    Console.WriteLine($"A({m}, {n}) = {Akkerman(m, n)}");

    int InputInt(string output)
    {
        Console.Write(output);
        return int.Parse(Console.ReadLine());
    }

    int Akkerman(int m, int n)
    {
        if (m == 0)
            return n + 1;
        if (m > 0 && n == 0)
            return Akkerman(m - 1, 1);
        else
            return Akkerman(m - 1, Akkerman(m, n - 1));
    }
}

void Zadacha66()
{
    Console.WriteLine("Введите начальное число M:");
    int numberM = int.Parse(Console.ReadLine());

    Console.WriteLine("Введите начальное число N:");
    int numberN = int.Parse(Console.ReadLine());

    void GapNumberSum (int numberM, int numberN, int sum)
    {
        if (numberM > numberN) 
        {
            Console.WriteLine($"Сумма натуральных элементов в промежутке от M до N: {sum}"); 
            return;
        }
        sum = sum + (numberM++);
        GapNumberSum(numberM, numberN, sum);
    }

    GapNumberSum(numberM, numberN, 0);
}

void Zadacha64()
{

}