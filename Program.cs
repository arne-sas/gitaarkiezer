using System;

namespace Project
{
    class Program
    {
        static void Main(string[] args)
        {

            //declareer variabelen
            string gitaar = "";

            //print titel
            string titel = "Welkom bij Gitaarkiezer";
            for (int i = 1; i < (titel.Length + 1); i++)
            {
                Console.Write("#");
            }

            Console.WriteLine("\n" + titel);

            for (int i = 1; i < (titel.Length + 1); i++)
            {
                Console.Write("#");
            }

            Console.Write("\n\nWat is je budget (bvb: 200, 500, 1200): ");
            int budget = int.Parse(Console.ReadLine());

            Console.WriteLine("\nKies je favoriete genre:");
            Console.WriteLine("Rock (R), Indie (I), Blues (B), Metal (M), Pop (P)");
            Console.Write("Vul de letter van je favoriete genre in: ");
            string genre = Console.ReadLine();
            string artiest = "";
            switch (genre)
            {
                case "R":
                    Console.WriteLine("Selecteer je favoriete artiest: ");
                    Console.WriteLine("Jimmy Page (JP), Angus Young (AY), Kurt Cobain (KC)");
                    Console.Write("Vul de letter van je favoriete artiest in: ");
                    artiest = Console.ReadLine();
                    break;
                case "I":
                    Console.WriteLine("Selecteer je favoriete artiest: ");
                    Console.WriteLine("Thom Yorke (TY), Noel Gallagher (NG), Alex Turner (AT)");
                    Console.Write("Vul de letter van je favoriete artiest in: ");
                    artiest = Console.ReadLine();
                    break;

                case "B":
                    Console.WriteLine("Selecteer je favoriete artiest: ");
                    Console.WriteLine("Jimmy Page (JP), Jimi Hendrix (JH), BB King (BK)");
                    Console.Write("Vul de letter van je favoriete artiest in: ");
                    artiest = Console.ReadLine();
                    break;
                case "M":
                    Console.WriteLine("Selecteer je favoriete artiest: ");
                    Console.WriteLine("James Hetfield (J), Tony Iommi (TI), Dave Murray (DM)");
                    Console.Write("Vul de letter van je favoriete artiest in: ");
                    artiest = Console.ReadLine();
                    break;
                case "P":
                    Console.WriteLine("Selecteer je favoriete artiest: ");
                    Console.WriteLine("The Edge (TE), George Harrison (GH), Steve Lukather (SL)");
                    Console.Write("Vul de letter van je favoriete artiest in: ");
                    artiest = Console.ReadLine();
                    break;
            }

            switch (artiest)
            {
                case "TE":
                    if (budget < 400)
                    {
                        gitaar = ("Fender Squier Telecaster");
                    }

                    else
                    {
                        gitaar = ("Fender Telecaster");
                    }
                    break;
                case "JP":
                case "SL":
                    if (budget < 400)
                    {
                        gitaar = ("Epiphone Les Paul");
                    }

                    else
                    {
                        gitaar = ("Gibson Les Paul");
                    }
                    break;
                case "AY":
                case "TI":
                    if (budget < 400)
                    {
                        gitaar = ("Epiphone SG");
                    }

                    else
                    {
                        gitaar = ("Gibson SG");
                    }
                    break;
                case "KC":
                    if (budget < 400)
                    {
                        gitaar = ("Fender Squier Jaguar");
                    }

                    else
                    {
                        gitaar = ("Fender Jaguar");
                    }
                    break;
                case "TY":
                case "AT":
                    if (budget < 400)
                    {
                        gitaar = ("Fender Squier Jazzmaster");
                    }

                    else
                    {
                        gitaar = ("Fender Jazzmaster");
                    }
                    break;
                case "NG":
                case "BK":
                    if (budget < 400)
                    {
                        gitaar = ("Epiphone ES-355");
                    }

                    else
                    {
                        gitaar = ("Gibson ES-355");
                    }
                    break;
                case "JH":
                case "DM":
                case "GH":
                    if (budget < 400)
                    {
                        gitaar = "Fender Squier Stratocaster";
                    }

                    else
                    {
                        gitaar = "Fender Stratocaster";
                    }
                    break;
                case "J":
                    if (budget < 400)
                    {
                        gitaar = "Epiphone Explorer";
                    }

                    else
                    {
                        gitaar = "Gibson Explorer";
                    }
                    break;
            }
            Console.WriteLine("Je favoriete gitaar: " + gitaar);
        }

    }
}
