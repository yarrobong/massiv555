using System;

class MagicSquareChecker
{
    static bool IsMagicSquare(int[,] square)
    {
        int n = square.GetLength(0);

        int sum = 0;
        for (int j = 0; j < n; j++)
        {
            sum += square[0, j];
        }

        for (int i = 1; i < n; i++)
        {
            int rowSum = 0;
            for (int j = 0; j < n; j++)
            {
                rowSum += square[i, j];
            }
            if (rowSum != sum)
            {
                return false;
            }
        }

        for (int j = 0; j < n; j++)
        {
            int colSum = 0;
            for (int i = 0; i < n; i++)
            {
                colSum += square[i, j];
            }
            if (colSum != sum)
            {
                return false;
            }
        }

        int diagSum = 0;
        for (int i = 0; i < n; i++)
        {
            diagSum += square[i, i];
        }
        if (diagSum != sum)
        {
            return false;
        }

        diagSum = 0;
        for (int i = 0; i < n; i++)
        {
            diagSum += square[i, n - 1 - i];
        }
        if (diagSum != sum)
        {
            return false;
        }

        return true;
    }

    static void Main()
    {
        
        int n = 3; // Размер квадрата 
        int[,] randomSquare = new int[n, n];
        Random rnd = new Random();

        
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                randomSquare[i, j] = rnd.Next(1, n * n + 1); 
                Console.Write(randomSquare[i, j] + "\t");
            }
            Console.WriteLine();
        }

        bool isMagic = IsMagicSquare(randomSquare);

        if (isMagic)
        {
            Console.WriteLine("Данный массив является магическим квадратом.");
        }
        else
        {
            Console.WriteLine("Данный массив не является магическим квадратом.");
        }
    }
}
