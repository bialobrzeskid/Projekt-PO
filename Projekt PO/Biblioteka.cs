using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Biblioteka
{
    public List<IBibliotekaItem> Items = new List<IBibliotekaItem>();

    public Biblioteka()
    {
        Items.Add(
            new Ksiazka
            {
                Numer = 1,
                Autor = "J. K. Rowling",
                Tytul = "Harry Potter i Kamień Filozoficzny",
                Strony = 265,
                czyDostepna = true
            }
        );

        Items.Add(
            new Ksiazka
            {
                Numer = 2,
                Autor = "Andrzej Sapkowski",
                Tytul = "Wiedźmin Ostatnie Życzenie",
                Strony = 330,
                czyDostepna = true
            }
        );

        Items.Add(
            new Ksiazka
            {
                Numer = 3,
                Autor = "Joseph Murphy",
                Tytul = "Potęga podświadomości",
                Strony = 330,
                czyDostepna = true
            }
        );

        Items.Add(
            new Magazyn
            {
                Numer = 4,
                Tytul = "The New York Times",
                czyDostepna = true,
                Strony = 222
            }
        );

        Items.Add(
            new Zabawka
            {
                Numer = 5,
                Producent = "Hot Wheels",
                Tytul = "Porsche 934 Turbo RSR",
                czyDostepna = true
            }
        );
    }

    public void ListItems()
    {
        Console.WriteLine("Stan: ");

        foreach (var item in Items)
        {
            Console.WriteLine("{0}  {1}", item.GetType().Name, item.ToString());
        }

    }

    public IBibliotekaItem Wypozycz(int number)
    {
        IBibliotekaItem item = null;

        try
        {
            item = Items.Find(b => b.Numer == number);
            item.Wypozycz();
        }
        catch (Exception)
        {

        }

        return item;
    }

    public void Zwrot(int number)
    {
        IBibliotekaItem item = null;

        try
        {
            item = Items.Find(b => b.Numer == number);

            item.Zwrot();

        }
        catch (Exception)
        {

        }
    }

}

