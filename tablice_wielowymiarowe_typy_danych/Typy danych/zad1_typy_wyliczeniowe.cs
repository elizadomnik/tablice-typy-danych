using System;

class Program
{
    public enum BierkiSzachowe
    {
        Pionek,
        Skoczek,
        Goniec,
        Wieża,
        Hetman,
        Krol
    }

    public enum DniTygodnia
    {
        Poniedzialek,
        Wtorek,
        Sroda,
        Czwartek,
        Piatek,
        Sobota,
        Niedziela
    }

    public enum EtapyPrania
    {
        Pranie,
        Płukanie,
        Wirowanie,
        Suszenie
    }

    public enum Posilki
    {
        Sniadanie,
        DrugieSniadanie,
        Obiad,
        Podwieczorek,
        Kolacja
    }
    static void Main()
    {
        DniTygodnia dzien = DniTygodnia.Wtorek;
        Console.WriteLine("Dzisiaj jest: " + dzien);

        EtapyPrania etap = EtapyPrania.Pranie;
        Console.WriteLine("Aktualny etap prania: " + etap);

        Posilki posilek = Posilki.Obiad;
        Console.WriteLine("Czas na: " + posilek);

        BierkiSzachowe bierka = BierkiSzachowe.Skoczek;
        Console.WriteLine("Wybrana bierka: " + bierka);
    }
}