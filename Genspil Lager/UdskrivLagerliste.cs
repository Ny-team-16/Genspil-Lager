using System.IO;

public class LagerstatusFilManager
{
    public void GemLagerstatusTilFil(List<Lagerstatus> lagerstatusListe, string filnavn)
    {
        using (StreamWriter writer = new StreamWriter(filnavn))
        {
            foreach (var spil in lagerstatusListe)
            {
                writer.WriteLine($"Spil: {spil.Spilnavn}, Version: {spil.Version}, Stand: {spil.Stand}, Pris: {spil.Pris}, Antal: {spil.Antal}");
            }
        }
        Console.WriteLine($"Lagerstatus gemt til fil: {filnavn}");
    }
}