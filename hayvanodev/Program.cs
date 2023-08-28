using System;


abstract class Hayvan
{
    public string Isim { get; set; }
    public int Yas { get; set; }
    public string Tur { get; set; }

    public abstract void SesCikar();
}


class Kopek : Hayvan
{
    public Kopek(string isim, int yas)
    {
        Isim = isim;
        Yas = yas;
        Tur = "Köpek";
    }

    public override void SesCikar()
    {
        Console.WriteLine("Hav hav!");
    }
}

class Kus : Hayvan
{
    public Kus(string isim, int yas)
    {
        Isim = isim;
        Yas = yas;
        Tur = "Kuş";
    }

    public override void SesCikar()
    {
        Console.WriteLine("Cik cik");
    }
}

class Kedi : Hayvan
{
    public Kedi(string isim, int yas)
    {
        Isim = isim;
        Yas = yas;
        Tur = "Kedi";
    }

    public override void SesCikar()
    {
        Console.WriteLine("Miyav");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Kopek kopek = new Kopek("Atıl Kurt", 3);
        Kus kus = new Kus("Serçe", 1);
        Kedi kedi = new Kedi("Tekir", 1);

        Console.WriteLine($"{kopek.Tur} {kopek.Isim} ({kopek.Yas} yaş) ses çıkarıyor:");
        kopek.SesCikar();

        Console.WriteLine($"{kus.Tur} {kus.Isim} ({kus.Yas} yaş) ses çıkarıyor:");
        kus.SesCikar();

        Console.WriteLine($"{kedi.Tur} {kedi.Isim} ({kedi.Yas} yaş) ses çıkarıyor:");
        kedi.SesCikar();
    }
}
