class Program
{
    static void Main(string[] args)
    {
        LagerstatusManager lagerManager = new LagerstatusManager();

        bool running = true;

        while (running)
        {
            Console.Clear();
            Console.WriteLine("Velkommen til lagerstatusmenuen:");
            Console.WriteLine("1. Vis lagerstatus");
            Console.WriteLine("2. Tilføj nyt spil");
            Console.WriteLine("3. Ændr eksisterende spil");
            Console.WriteLine("4. Søg efter spil");
            Console.WriteLine("5. Ændr en pris");
            Console.WriteLine("6. Afslut");

            Console.Write("Indtast dit valg: ");
            string userInput = Console.ReadLine();

            switch (userInput)
            {
                case "1":
                    lagerManager.VisLagerstatus();
                    break;
                case "2":
                    Console.Write("Indtast navnet på spillet: ");
                    string nytSpilNavn = Console.ReadLine();
                    Console.Write("Indtast versionen af spillet: ");
                    string nytSpilVersion = Console.ReadLine();
                    Console.Write("Indtast standen på spillet: ");
                    string nytSpilStand = Console.ReadLine();
                    Console.Write("Indtast prisen på spillet: ");
                    decimal nytSpilPris = Convert.ToDecimal(Console.ReadLine());
                    Console.Write("Indtast antallet af spillet: ");
                    int nytSpilAntal = Convert.ToInt32(Console.ReadLine());
                    lagerManager.TilføjSpil(nytSpilNavn, nytSpilVersion, nytSpilStand, nytSpilPris, nytSpilAntal);
                    break;
                case "3":
                    Console.Write("Indtast navnet på spillet, du vil ændre: ");
                    string eksisterendeSpilNavn = Console.ReadLine();
                    Console.Write("Indtast versionen af spillet, du vil ændre: ");
                    string eksisterendeSpilVersion = Console.ReadLine();
                    Console.Write("Indtast den nye stand for spillet: ");
                    string nyStand = Console.ReadLine();
                    Console.Write("Indtast den nye pris for spillet: ");
                    decimal nyPris = Convert.ToDecimal(Console.ReadLine());
                    Console.Write("Indtast det nye antal for spillet: ");
                    int nyAntal = Convert.ToInt32(Console.ReadLine());
                    lagerManager.ÆndrSpil(eksisterendeSpilNavn, eksisterendeSpilVersion, nyStand, nyPris, nyAntal);
                    break;
                case "4":
                    Console.Write("Indtast søgekriterie: Navn, version, stand, pris, eller antal");
                    string søgeord = Console.ReadLine();
                    lagerManager.SøgSpil(søgeord);
                    break;
                case "5":
                    Console.Write("Indtast navnet på spillet, du vil ændre prisen på: ");
                    string spilnavn = Console.ReadLine();
                    Console.Write("Indtast versionen af spillet: ");
                    string version = Console.ReadLine();
                    Console.Write("Indtast den fastgjorte pris: ");
                    decimal fastgjortPris = Convert.ToDecimal(Console.ReadLine());
                    lagerManager.ÆndrPris(spilnavn, version, fastgjortPris);
                    break;
                case "6":
                    running = false;
                    break;
                default:
                    Console.WriteLine("Ugyldigt valg. Prøv igen.");
                    break;
            }

            Console.WriteLine("Tryk på en tast for at fortsætte...");
            Console.ReadKey();
        }
    }
}