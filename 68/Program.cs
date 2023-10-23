Console.WriteLine("Введите значение m: ");
        int m = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Введите значение n: ");
        int n = Convert.ToInt32(Console.ReadLine());

        int result = AckermannFunction(m, n);

        Console.WriteLine($"A({m}, {n}) = {result}");
 static int AckermannFunction(int m, int n)
    {
        if (m == 0)
        {
            return n + 1;
        }
        else if (n == 0)
        {
            return AckermannFunction(m - 1, 1);
        }
        else
        {
            return AckermannFunction(m - 1, AckermannFunction(m, n - 1));
        }
    }