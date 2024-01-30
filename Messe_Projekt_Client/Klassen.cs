using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Messe_Projekt_Client
{
    public class Kunde
    {
        public int KundeId { get; set; }
        public string Vorname { get; set; }
        public string Nachname { get; set; }
        public Anschrift Anschrift { get; set; }
        public List<Interesse>? Interessen { get; set; }
        public Firma? Firma { get; set; }
        public bool Confirmed { get; set; }
    }

    public class Anschrift
    {
        public int AnschriftId { get; set; }
        public string Strasse { get; set; }
        public string Hausnummer { get; set; }
        public int Plz { get; set; }
        public string Ort { get; set; }
        public int KundeId { get; set; }
        public Kunde Kunde { get; set; }
    }

    public class Interesse
    {
        public int InteresseId { get; set; }
        public string ProduktgruppeName { get; set; }

    }

    public class Firma
    {
        public int FirmaId { get; set; }
        public string Name { get; set; }
    }
}
