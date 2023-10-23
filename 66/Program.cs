Console.WriteLine("Введите значение M: ");
        int M = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Введите значение N: ");
        int N = Convert.ToInt32(Console.ReadLine());

        if (M < 1 || N < 1)
        {
            Console.WriteLine("Некорректный ввод!");
            return;
        }

        int sum = CalculateSum(M, N);
        Console.WriteLine($"Сумма натуральных чисел в промежутке от {M} до {N} равна: {sum}");
    
static int CalculateSum(int numM, int numN)
    {
        if (numM == numN)
            return numN;
        
        return numM + CalculateSum(numM + 1, numN);
    }
