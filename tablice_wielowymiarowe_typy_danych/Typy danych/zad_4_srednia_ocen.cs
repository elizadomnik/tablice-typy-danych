
using System;

public enum Plec
{
    Kobieta,
    Mezczyzna
}

public struct Student
{
    public string Nazwisko;
    public int NrAlbumu;
    public double Ocena;
    public Plec Plec;
}

public class zad_4_typy_danych
{
    public static void StworzStudenta(ref Student student, string nazwisko, int nrAlbumu, double ocena, Plec plec)
    {
        student.Nazwisko = nazwisko;
        student.NrAlbumu = nrAlbumu;

        if (ocena < 2.0)
            student.Ocena = 2.0;
        else if (ocena > 5.0)
            student.Ocena = 5.0;
        else
            student.Ocena = ocena;

        student.Plec = plec;
    }

    public static double ObliczSrednia(Student[] grupa)
    {
        double sumaOcen = 0.0;

        foreach (var student in grupa)
        {
            sumaOcen += student.Ocena;
        }

        double srednia = sumaOcen / grupa.Length;
        return srednia;
    }

    public static void WyswietlStudenta(Student student)
    {
        string plec = student.Plec == Plec.Kobieta ? "Kobieta" : "Mężczyzna";
        Console.WriteLine($"Nazwisko: {student.Nazwisko}, Nr albumu: {student.NrAlbumu}, Ocena: {student.Ocena}, Płeć: {plec}");
    }

    public static void Start()
    {
        Student[] grupa = new Student[5];

        StworzStudenta(ref grupa[0], "Maciek Y", 12345, 4.5, Plec.Mezczyzna);
        StworzStudenta(ref grupa[1], "Zosia F", 54321, 3.8, Plec.Kobieta);
        StworzStudenta(ref grupa[2], "Krystian G", 98765, 5.0, Plec.Mezczyzna);
        StworzStudenta(ref grupa[3], "Maria S", 24680, 1.5, Plec.Kobieta);
        StworzStudenta(ref grupa[4], "Janusz L", 13579, 4.2, Plec.Mezczyzna);

        foreach (var student in grupa)
        {
            WyswietlStudenta(student);
        }

        double srednia = ObliczSrednia(grupa);
        Console.WriteLine($"Średnia ocen: {srednia}");
    }
}
