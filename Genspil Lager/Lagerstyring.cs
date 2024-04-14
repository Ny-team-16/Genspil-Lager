using System;
using System.Collections.Generic;

public class LagerstatusManager
{
    public List<Lagerstatus> lagerstatusListe;

    public LagerstatusManager()
    {
        lagerstatusListe = new List<Lagerstatus>();

        // Tilføj initialdata til lagerstatuslisten
        TilføjInitialData();
    }

    public List<Lagerstatus> GetLagerStatusListe()
    {
        return lagerstatusListe;
    }

    private void TilføjInitialData()
    {
        lagerstatusListe.Add(new Lagerstatus("Sequence", "Original", "I god stand", 0m, 1));
        lagerstatusListe.Add(new Lagerstatus("Sequence", "Original", "Til reparation", 0m, 2));
        lagerstatusListe.Add(new Lagerstatus("Sequence", "Junior", "Lidt skrammet", 0m, 1));
        lagerstatusListe.Add(new Lagerstatus("Sequence", "Giant", "Ikke på lager", 0m, 0));
        lagerstatusListe.Add(new Lagerstatus("Sequence", "Rejsespil", "I god stand", 0m, 2));

        lagerstatusListe.Add(new Lagerstatus("Ticket to ride", "Berlin", "I god stand", 0m, 3));
        lagerstatusListe.Add(new Lagerstatus("Ticket to ride", "Berlin", "lidt slidt", 0m, 1));
        lagerstatusListe.Add(new Lagerstatus("Ticket to ride", "Berlin", "Til reparation", 0m, 1));
        lagerstatusListe.Add(new Lagerstatus("Ticket to ride", "Europe - engelsk", "Ikke på lager", 0m, 0));
        lagerstatusListe.Add(new Lagerstatus("Ticket to ride", "Europe - dansk", "I god stand", 0m, 2));
        lagerstatusListe.Add(new Lagerstatus("Ticket to ride", "First journey", "På venteliste til Mejse Johansen", 0m, 1));
        lagerstatusListe.Add(new Lagerstatus("Ticket to ride", "Europa 1912", "Ikke på lager", 0m, 0));
        lagerstatusListe.Add(new Lagerstatus("Ticket to ride", "Ghost train", "Måske 1 på vej?", 0m, 0));
        lagerstatusListe.Add(new Lagerstatus("Ticket to ride", "New York", "Ikke på lager", 0m, 0));
        lagerstatusListe.Add(new Lagerstatus("Ticket to ride", "Japan & Italy", "I ok stand", 0m, 1));
        lagerstatusListe.Add(new Lagerstatus("Ticket to ride", "Northern lights", "Ikke på lager", 0m, 0));

        lagerstatusListe.Add(new Lagerstatus("7 Wonders", "Dansk 2nd edition", "Reserveret til Torstein", 0m, 1));
        lagerstatusListe.Add(new Lagerstatus("7 Wonders", "Architects - dansk", "I ok stand", 0m, 2));
        lagerstatusListe.Add(new Lagerstatus("7 Wonders", "Architects - dansk", "Ikke åbnet", 0m, 1));
        lagerstatusListe.Add(new Lagerstatus("7 Wonders", "Architects – Medals", "skadet i hjørnet men fin stand", 0m, 1));
        lagerstatusListe.Add(new Lagerstatus("7 Wonders", "2nd edition Cities - engelsk", "Til rep", 0m, 1));
        lagerstatusListe.Add(new Lagerstatus("7 Wonders", "dansk Duel – agora", "I ok stand", 0m, 2));
        lagerstatusListe.Add(new Lagerstatus("7 Wonders", "dansk Duel – agora", "Helt ny", 0m, 1));
        lagerstatusListe.Add(new Lagerstatus("7 Wonders", "Duel – agora – engelsk", "Kan måske fixes", 0m, 1));

        lagerstatusListe.Add(new Lagerstatus("Alverdens", "Original", "På venteliste til Cille", 0m, 0));
        lagerstatusListe.Add(new Lagerstatus("Alverdens", "Helte", "Til reparation", 0m, 1));
        lagerstatusListe.Add(new Lagerstatus("Alverdens", "OMG", "Helt ny", 0m, 1));
        lagerstatusListe.Add(new Lagerstatus("Alverdens", "Popkultur", "I god stand", 0m, 1));
        lagerstatusListe.Add(new Lagerstatus("Alverdens", "Popkultur", "Lidt ridset", 0m, 2));
        lagerstatusListe.Add(new Lagerstatus("Alverdens", "Arkitektur", "Stand?", 0m, 2));
        lagerstatusListe.Add(new Lagerstatus("Alverdens", "Helte", "I god stand", 0m, 1));

        lagerstatusListe.Add(new Lagerstatus("A la carte: dessert", "Original", "I god stand", 0m, 1));
        lagerstatusListe.Add(new Lagerstatus("Bad people", "Original", "På venteliste til Allan", 0m, 0));
    }

    public void VisLagerstatus()
    {
        Console.WriteLine("Lagerstatus:");
        foreach (var spil in lagerstatusListe)
        {
            Console.WriteLine($"Spil: {spil.Spilnavn}, Version: {spil.Version}, Stand: {spil.Stand}, Pris: {spil.Pris}, Antal: {spil.Antal}");
        }
    }

    public void ÆndrPris(string spilnavn, string version, decimal nyPris)
    {
        var spil = lagerstatusListe.FirstOrDefault(s => s.Spilnavn.Equals(spilnavn, StringComparison.OrdinalIgnoreCase) && s.Version.Equals(version, StringComparison.OrdinalIgnoreCase));

        if (spil != null)
        {
            spil.Pris = nyPris;
            Console.WriteLine($"Prisen for spillet {spilnavn} ({version}) er blevet ændret til {nyPris}.");
        }
        else
        {
            Console.WriteLine($"Spillet {spilnavn} ({version}) blev ikke fundet.");
        }
    }

    public void TilføjSpil(string spilnavn, string version, string stand, decimal pris, int antal)
    {
        lagerstatusListe.Add(new Lagerstatus(spilnavn, version, stand, pris, antal));
    }

    public void ÆndrSpil(string spilnavn, string version, string nyStand, decimal nyPris, int nyAntal)
    {
        foreach (var spil in lagerstatusListe)
        {
            if (spil.Spilnavn.Equals(spilnavn, StringComparison.OrdinalIgnoreCase) && spil.Version.Equals(version, StringComparison.OrdinalIgnoreCase))
            {
                spil.Stand = nyStand;
                spil.Pris = nyPris;
                spil.Antal = nyAntal;
                break;
            }
        }
    }
    public void SøgSpil(string søgekriterie)
    {
        Console.Clear();
        Console.WriteLine($"Søger efter spil baseret på {søgekriterie}:");

        // Søg i lagerstatuslisten baseret på det angivne søgekriterie
        switch (søgekriterie.ToLower())
        {
            case "navn":
                Console.Write("Indtast navnet på spillet: ");
                string spilNavn = Console.ReadLine();
                var resultaterNavn = lagerstatusListe.Where(spil => spil.Spilnavn.Equals(spilNavn, StringComparison.OrdinalIgnoreCase));
                VisSøgeresultater(resultaterNavn);
                break;
            case "version":
                Console.Write("Indtast versionen af spillet: ");
                string spilVersion = Console.ReadLine();
                var resultaterVersion = lagerstatusListe.Where(spil => spil.Version.Equals(spilVersion, StringComparison.OrdinalIgnoreCase));
                VisSøgeresultater(resultaterVersion);
                break;
            case "stand":
                Console.Write("Indtast standen på spillet: ");
                string spilStand = Console.ReadLine();
                var resultaterStand = lagerstatusListe.Where(spil => spil.Stand.Equals(spilStand, StringComparison.OrdinalIgnoreCase));
                VisSøgeresultater(resultaterStand);
                break;
            case "pris":
                Console.Write("Indtast prisen på spillet: ");
                decimal spilPris = Convert.ToDecimal(Console.ReadLine());
                var resultaterPris = lagerstatusListe.Where(spil => spil.Pris == spilPris);
                VisSøgeresultater(resultaterPris);
                break;
            case "antal":
                Console.Write("Indtast antallet af spillet: ");
                int spilAntal = Convert.ToInt32(Console.ReadLine());
                var resultaterAntal = lagerstatusListe.Where(spil => spil.Antal == spilAntal);
                VisSøgeresultater(resultaterAntal);
                break;
            default:
                Console.WriteLine("Ugyldigt søgekriterie.");
                break;
        }
    }

    private void VisSøgeresultater(IEnumerable<Lagerstatus> resultater)
    {
        if (resultater.Any())
        {
            Console.WriteLine("Søgeresultater:");
            foreach (var spil in resultater)
            {
                Console.WriteLine($"Spil: {spil.Spilnavn}, Version: {spil.Version}, Stand: {spil.Stand}, Pris: {spil.Pris}, Antal: {spil.Antal}");
            }
        }
        else
        {
            Console.WriteLine("Ingen matchende resultater fundet.");
        }
    }
}

