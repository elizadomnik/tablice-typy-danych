using System;

public class formatowanie_czasu
{
    public static string FormatujCzas(int sekundy)
    {
        int godziny = sekundy / 3600;
        int minuty = (sekundy % 3600) / 60;
        int resztaSekundy = sekundy % 60;

        string czasSformatowany = $"{godziny:00}:{minuty:00}:{resztaSekundy:00}";
        return czasSformatowany;
    }

    public static void Main(string[] args)
    {
        int czas = 332;
        string czasSformatowany = FormatujCzas(czas);
        Console.WriteLine(czasSformatowany);
    }
}