using System;

public class Zabawka : IBibliotekaItem, IZabawka
{
    public bool czyDostepna { get; set; }

    public string Producent { get; set; }

    public int Numer { get; set; }

    public string Tytul { get; set; }

    public void Wypozycz()
    {
        czyDostepna = false;
    }

    public void Zwrot()
    {
        czyDostepna = true;
        Console.WriteLine("Zwrócono artykuł \n");
    }

    public override string ToString()
    {
        return Numer + ": " + Tytul + ": " + Producent + ": " + (czyDostepna ? "Dostępne" : "Niedostępne");
    }
}