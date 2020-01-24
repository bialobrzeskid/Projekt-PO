public interface IBibliotekaItem
{
    int Numer { get; set; }
    string Tytul { get; set; }
    bool czyDostepna { get; set; }

    void Wypozycz();
    void Zwrot();

    string ToString();

}
