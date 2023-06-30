using System;

class zad_2_typy_danych
{
    public struct Student
    {
        public string Imie;
        public string Nazwisko;
        public int NumerIndeksu;
        public string Kierunek;
        public int RokStudiow;
    }


    public struct Przedmiot
    {
        public string Nazwa;
        public string KodPrzedmiotu;
        public string Wykladowca;
    }

    public struct Nauczyciel
    {
        public string Imie;
        public string Nazwisko;
        public string StopienNaukowy;
        public string Uczelnia;
        public string Stanowisko;
    }

    public enum Posilki
    {
        Sniadanie,
        DrugieSniadanie,
        Obiad,
        Podwieczorek,
        Kolacja
    }
    static void Studia()
    {
        Student student = new Student();
        student.Imie = "Jan";
        student.Nazwisko = "Kowalski";
        student.NumerIndeksu = 12345;
        student.Kierunek = "Informatyka";
        student.RokStudiow = 3;

        Przedmiot przedmiot = new Przedmiot();
        przedmiot.Nazwa = "Programowanie";
        przedmiot.KodPrzedmiotu = "INF101";
        przedmiot.Wykladowca = "dr. Anna Nowak";

        Nauczyciel nauczyciel = new Nauczyciel();
        nauczyciel.Imie = "Adam";
        nauczyciel.Nazwisko = "Nowak";
        nauczyciel.StopienNaukowy = "prof. dr hab.";
        nauczyciel.Uczelnia = "Informatyka";
        nauczyciel.Stanowisko = "Nauczyciel";

        Console.WriteLine("Student: " + student.Imie + " " + student.Nazwisko);
        Console.WriteLine("Przedmiot: " + przedmiot.Nazwa);
        Console.WriteLine("Nauczyciel: " + nauczyciel.StopienNaukowy + " " + nauczyciel.Imie + " " + nauczyciel.Nazwisko);

    }
}