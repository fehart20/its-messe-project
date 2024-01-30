namespace MesseAPI
{
    public class InfoItem
    {
        public string Username { get; set; }
        public string Vorname { get; set; }
        public string Nachname { get; set; }
        public string Strasse { get; set; }
        public string Hausnummer { get; set; }
        public int Plz { get; set; }
        public string Ort { get; set; }
        public string Firma { get; set; }
        public List<String>? Interessen { get; set; }
        public bool Confirmed { get; set; }
        public DateTime RequestTime { get; set; }
    }
}
