using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Messe_Projekt_Client
{
    public partial class _2_Admin_Panel : Form
    {
        public _2_Admin_Panel()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Event-Handler für den Button "Daten übertragen".
        /// Überprüft auf noch nicht gesendete Kunden und überträgt deren Informationen an eine Web-API.
        /// </summary>
        private async void button1_Click(object sender, EventArgs e)
        {
            rTB_usernames.Clear();
            using var db = new MesseDbContext();
            var kunden = db.Kunde.Where(k => k.Confirmed == false).ToList();

            foreach (var kunde in kunden)
            {
                db.Entry(kunde).Reference(k => k.Anschrift).Load();
                db.Entry(kunde).Reference(f => f.Firma).Load();
                if (kunde.Firma == null)
                {
                    Firma firma = new Firma();
                    firma.Name = "N/A"; // Hacky but for quick error resolving
                    kunde.Firma = firma;
                }
                InfoItem ergebnis = await NetworkHelper.CheckWebapi(kunde.Vorname, kunde.Nachname, kunde.Anschrift.Strasse, kunde.Anschrift.Hausnummer, kunde.Anschrift.Plz, kunde.Anschrift.Ort, kunde.Firma.Name);

                if (ergebnis != null)
                {
                    rTB_usernames.AppendText($"\n---\nBenutzername {ergebnis.Username} - Bestätigt: {ergebnis.Confirmed}\n{ergebnis.RequestTime}\n---");
                    kunde.Confirmed = true;
                }
                db.SaveChanges();
            }
            MessageBox.Show("Daten erfolgreich an die Zentrale übertragen!");
        }

        /// <summary>
        /// Event-Handler für den Button "Einträge in DB anzeigen".
        /// Lädt alle Datenbankeinträge und zeigt sie in einem Textfeld an.
        /// </summary>
        private void btn_show_db_entries_Click(object sender, EventArgs e)
        {
            rTB_database_entries.Clear();
            using var db = new MesseDbContext();
            var kunden = db.Kunde.ToList();

            foreach (var kunde in kunden)
            {
                db.Entry(kunde).Reference(k => k.Anschrift).Load();
                rTB_database_entries.AppendText($"\n---\nVom Server erhalten: {kunde.Confirmed}\n{kunde.Vorname} {kunde.Nachname}\n{kunde.Anschrift.Strasse} {kunde.Anschrift.Hausnummer}\n{kunde.Anschrift.Plz} {kunde.Anschrift.Ort}\n---");
            }
        }
    }
}
