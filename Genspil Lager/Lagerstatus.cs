using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
