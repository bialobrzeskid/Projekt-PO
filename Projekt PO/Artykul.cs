using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public abstract class Artykul: IBibliotekaItem
{
    public bool czyDostepna { get; set; }

    public int Numer { get; set; }

    public string Tytul { get; set; }

    public string Autor { get; set; }

    public int Strony { get; set; }

    public DateTime Publikacja { get; set; }

    void IBibliotekaItem.Wypozycz()
    {
        if (this.czyDostepna == false)
        {
            Console.WriteLine("Wybrany artykuł jest niedostępny.");

        }
        else
        {
            czyDostepna = false;
        }
    }
    void IBibliotekaItem.Zwrot()
    {
        czyDostepna = true;
        Console.WriteLine("Zwrócono artykuł \n");
    }
    public override string ToString()
    {
        return Numer + ": " + Tytul + ": " + Autor + ": " + Strony + ": " + (czyDostepna ? "Dostępne" : "Niedostępne");
    }
}

