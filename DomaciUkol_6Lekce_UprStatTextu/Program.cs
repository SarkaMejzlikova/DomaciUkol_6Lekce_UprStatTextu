using DomaciUkol_6Lekce_UprStatTextu;
using System.Collections.Generic;
using System.Xml;

string vstupniText = "Ema má maso. Máma má mísu.";
List<Znak> statistika = new List<Znak>();

foreach (char znak in vstupniText)
{
    Znak provereniZnaku = null;
    for (int i = 0; i < statistika.Count; i++)
    {
        if (statistika[i].Pismeno == znak)
        {
            provereniZnaku = statistika[i];
        }
    }

    if (provereniZnaku != null)
    {
        provereniZnaku.Pocet++;
    }
    else
    {
        statistika.Add(new Znak() { Pismeno = znak, Pocet = 1 });
    }
}

foreach (var i in statistika)
{
    Console.WriteLine($"{i.Pismeno} - {i.Pocet}");
}

Console.WriteLine("\nVyskytuje se každý znak právě jednou? " + statistika.All(x => x.Pocet == 1));
Console.WriteLine("Vyskytuje se nějaký znak alespoň 5x? " + statistika.Any(x => x.Pocet > 5));
Console.WriteLine("Jaký je minimální počet výskytů jednoho znaku? " + statistika.Min(x => x.Pocet));
Console.WriteLine("Jaký je maximální počet výskytů jednoho znaku? " + statistika.Max(x => x.Pocet));
Console.WriteLine("Jaký je průměrný výskyt jednoho znaku? " + Math.Round(statistika.Average(x => x.Pocet),0));
Console.WriteLine("Jaký je počet použitých znaků? " + statistika.Count());
Console.WriteLine("Kolik bylo celkem použito znaků? " + statistika.Sum(x => x.Pocet));

Console.ReadLine();