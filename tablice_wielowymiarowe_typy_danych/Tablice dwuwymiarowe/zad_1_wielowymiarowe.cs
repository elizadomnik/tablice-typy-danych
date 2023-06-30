using System;

class zad_1_wielowymiarowe
{
    static void Main()
    {
        int[,] tablica = new int[10, 10];

        for (int i = 0; i < 10; i++)
        {
            if (i % 2 == 0) // parzyste
            {
                for (int j = 0; j < 10; j++)
                {
                    tablica[i, j] = i * 10 + j + 1;
                }
            }
            else // nieparzyste
            {
                for (int j = 0; j < 10; j++)
                {
                    tablica[i, j] = (i + 1) * 10 - j;
                }
            }
        }

        for (int i = 0; i < 10; i++)
        {
            for (int j = 0; j < 10; j++)
            {
                Console.Write(tablica[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }
}
