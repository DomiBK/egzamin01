using System;

public class Osoba
{
    private int id;
    private string imie;

    private static int liczbaInstancji = 0;

    public Osoba() : this(0, "") { }

    public Osoba(int id, string imie)
    {
        this.id = id;
        this.imie = imie ?? throw new ArgumentNullException(nameof(imie));
        InkrementujLiczbeInstancji();
    }

    public Osoba(Osoba osoba)
    {
        this.id = osoba.id;
        this.imie = osoba.imie;
        InkrementujLiczbeInstancji();
    }

    private void InkrementujLiczbeInstancji()
    {
        liczbaInstancji++;
    }

    public void WypiszImie(string argument)
    {
        if (!string.IsNullOrEmpty(imie))
        {
            Console.WriteLine($"Cześć {argument}, mam na imię {imie}");
        }
        else
        {
            Console.WriteLine("Brak danych");
        }
    }

    public static int LiczbaInstancji => liczbaInstancji;
}
