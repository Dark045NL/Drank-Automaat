double dBedrag = 0;
Random rnd = new Random();
int iRandom = rnd.Next(0, 10);
int iDrank = 0;

Console.WriteLine("Hey welkom!");
Console.WriteLine("Welk drankje zou je graag willen ik heb.");
Console.WriteLine("1. Cola, 2. Cola-light, 3. Sinas, 4. Ice-tea, 5. Energie drankje");
Console.WriteLine("Geef het nummer van het drankje.");
iDrank = Convert.ToInt32(Console.ReadLine());

switch (iDrank)
{
    case 1:
        dBedrag = 1.80;
        Console.WriteLine($"Uw Cola kost {dBedrag}");
        break;


    case 2:
        dBedrag = 1.80;
        Console.WriteLine($"Uw Cola-light kost {dBedrag}");
        break;


    case 3:
        dBedrag = 2.00;
        Console.WriteLine($"Uw Sinas kost {dBedrag}");
        break;


    case 4:
        dBedrag = 2.20;
        Console.WriteLine($"Uw Ice-tea kost {dBedrag}");
        break;


    case 5:
        dBedrag = 2.10;
        Console.WriteLine($"Uw Energie drankje kost {dBedrag}");
        break;
}

Console.WriteLine("Wilt u pin betalen? Ja/Nee");
string sBetaalWijze = Console.ReadLine();

if (sBetaalWijze == "Ja")
{

    Console.WriteLine("Betaling succesvol.");
}

else if (sBetaalWijze == "Nee")
{
    Console.WriteLine($"Gooi {dBedrag} in de automaat.");
    Console.WriteLine("Kunt u gepast betalen j/n");
    string sGepast = Console.ReadLine();

    if (sGepast == "j")
    {
        Console.WriteLine("Betaling gelukt");
    }
    else
    {
        Console.WriteLine("Hoeveel gooit u in de automaat ?");
        double dGeld = Convert.ToInt32(Console.ReadLine());
        double dWisselgeld = dGeld - dBedrag;
        Console.WriteLine($"Uw krijgt nog {dWisselgeld} terug");
    }
}

if (iRandom < 7)
{
    Console.WriteLine("Blikje blijft hangen");
}

else
{
    Console.WriteLine("Pak uw blikje");
}