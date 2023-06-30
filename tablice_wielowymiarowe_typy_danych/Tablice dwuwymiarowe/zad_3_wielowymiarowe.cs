using System;

class zad_3_wielowymiarowe
{
    static void Main()
    {
        Console.Write("Podaj rozmiar tablicy: ");
        int rozmiar;

        while (!int.TryParse(Console.ReadLine(), out rozmiar) || rozmiar <= 0)
        {
            Console.WriteLine("Podaj poprawny rozmiar tablicy (liczba całkowita większa od zera): ");
        }

        int[,] tablica = new int[rozmiar, rozmiar];

        for (int i = 0; i < rozmiar; i++)
        {
            if (i % 2 == 0) // wiersze parzyste
            {
                for (int j = 0; j < rozmiar; j++)
                {
                    tablica[i, j] = i * rozmiar + j + 1;
                }
            }
            else // wiersze nieparzyste
            {
                for (int j = 0; j < rozmiar; j++)
                {
                    tablica[i, j] = (i + 1) * rozmiar - j;
                }
            }
        }

        // Wypisanie tablicy na ekranie
        for (int i = 0; i < rozmiar; i++)
        {
            for (int j = 0; j < rozmiar; j++)
            {
                Console.Write(tablica[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }
}
