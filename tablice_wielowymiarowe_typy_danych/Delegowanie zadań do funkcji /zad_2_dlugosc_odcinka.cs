// See https://aka.ms/new-console-template for more information

using System;

public class dlugosc_odcinka
{
    public static double DlugoscOdcinka(double x1, double y1, double x2, double y2)
    {
        double dx = x2 - x1;
        double dy = y2 - y1;
        double dlugosc = Math.Sqrt(dx * dx + dy * dy);
        return dlugosc;
    }

    public static void Main()
    {
        double x1 = 1.0;
        double y1 = 2.0;
        double x2 = 4.0;
        double y2 = 6.0;

        double wynik = DlugoscOdcinka(x1, y1, x2, y2);

        Console.WriteLine("Długość odcinka: " + wynik);
    }
}
