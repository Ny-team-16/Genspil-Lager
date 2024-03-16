using System;
using System.Collections.Generic;

public class Lagerstatus
{
    public string Spilnavn { get; set; }
    public string Version { get; set; }
    public string Stand { get; set; }
    public decimal Pris { get; set; }
    public int Antal { get; set; }

    public Lagerstatus(string spilnavn, string version, string stand, decimal pris, int antal)
    {
        Spilnavn = spilnavn;
        Version = version;
        Stand = stand;
        Pris = pris;
        Antal = antal;
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Opret en liste til at opbevare lagerstatus for hvert spil
        List<Lagerstatus> lagerstatusListe = new List<Lagerstatus>();

        // Tilføj data til lagerstatuslisten
        //string1 = spilnavn, string2 = version, string3 = stand, decimal = pris, int = antal
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
        

        // Udskriv lagerstatus for hvert spil
        foreach (var item in lagerstatusListe)
        {
            Console.WriteLine($"Spil: {item.Spilnavn}, Version: {item.Version}, Stand: {item.Stand}, Pris: {item.Pris}, Antal: {item.Antal}");
        }
    }
}