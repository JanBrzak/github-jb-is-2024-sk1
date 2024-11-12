using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Zadejte text k analyze:");
        string text = Console.ReadLine();

        int pocetSamohlasek = 0;
        int pocetSouhlasek = 0;
        int pocetCisel = 0;
        int pocetOstatnich = 0;
        int pocetVelkychPismen = 0;
        int pocetMalychPismen = 0;

        foreach (char znak in text)
        {
            if ("aeiouáéíóúůý".Contains(char.ToLower(znak)))  
            {
                pocetSamohlasek++;
            }
            else if ("bcčdďfghjklmnňpqrřsštťvwxzž".Contains(char.ToLower(znak)))  
            {
                pocetSouhlasek++;
            }
            else if (char.IsDigit(znak))  
            {
                pocetCisel++;
            }
            else if (!char.IsWhiteSpace(znak))  
            {
                pocetOstatnich++;
            }

            if (char.IsUpper(znak))  
            {
                pocetVelkychPismen++;
            }
            else if (char.IsLower(znak))  
            {
                pocetMalychPismen++;
            }
        }
        Console.WriteLine($"Počet samohlásek: {pocetSamohlasek}");
        Console.WriteLine($"Počet souhlásek: {pocetSouhlasek}");
        Console.WriteLine($"Počet číslic: {pocetCisel}");
        Console.WriteLine($"Počet ostatních znaků: {pocetOstatnich}");
        Console.WriteLine($"Počet velkých písmen: {pocetVelkychPismen}");
        Console.WriteLine($"Počet malých písmen: {pocetMalychPismen}");
    }
}
