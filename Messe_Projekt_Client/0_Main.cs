using Messe_Projekt_Client;
using System.Text.Json;

namespace Messe_Projekt_Client
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            using var db = new MesseDbContext();

            try
            {
                if (string.IsNullOrEmpty(tb_Street.Text) ||
                    string.IsNullOrEmpty(tb_Hausnummer.Text) ||
                    string.IsNullOrEmpty(tb_PLZ.Text) ||
                    string.IsNullOrEmpty(tb_Vorname.Text) ||
                    string.IsNullOrEmpty(tb_Nachname.Text) ||
                    string.IsNullOrEmpty(tb_Ort.Text))
                {
                    throw new Exception("Alle Felder müssen ausgefüllt werden.");
                }

                Anschrift anschrift = new Anschrift
                {
                    Strasse = tb_Street.Text,
                    Hausnummer = tb_Hausnummer.Text,
                    Plz = Convert.ToInt32(tb_PLZ.Text),
                    Ort = tb_Ort.Text
                };

                Firma firma = new Firma
                {
                    Name = tb_Firma.Text ?? "-",
                };

                Kunde kunde = new Kunde()
                {
                    Vorname = tb_Vorname.Text,
                    Nachname = tb_Nachname.Text,
                    Anschrift = anschrift,
                    Firma = firma,
                    Interessen = new List<Interesse>(),
                    Confirmed = false
                };

                if (cb_Kueche.Checked)
                {
                    kunde.Interessen.Add(new Interesse { ProduktgruppeName = "Küche" });
                }
                if (cb_Garten.Checked)
                {
                    kunde.Interessen.Add(new Interesse { ProduktgruppeName = "Garten" });
                }
                if (cb_SmartHome.Checked)
                {
                    kunde.Interessen.Add(new Interesse { ProduktgruppeName = "Smart Home" });
                }
                db.Kunde.Add(kunde);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Fehlende Eingabe oder Fehler:\n{ex}", "Warnung", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            try { 
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Die Datenbank wurde nicht gefunden oder ist fehlerhaft:\n{ex}", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show("Daten erfolgreich erfasst - Vielen Dank!", "Erfolg!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            tb_Vorname.Clear();
            tb_Nachname.Clear();
            tb_Ort.Clear();
            tb_PLZ.Clear();
            tb_Street.Clear();
            tb_Hausnummer.Clear();
            tb_Firma.Clear();
            checkBox1.Checked = false;
            cb_agb.Checked = false;
            cb_dsgvo.Checked = false;
            cb_Garten.Checked = false;
            cb_SmartHome.Checked = false;
            cb_Kueche.Checked = false;

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string relativePath = @"..\..\..\..\Datenschutzerklaerung_Messeprojekt.txt";
            string fullPath = Path.Combine(Application.StartupPath, relativePath);
            try
            {
                System.Diagnostics.Process.Start("notepad.exe", fullPath);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ein Fehler ist aufgetreten: " + ex.Message);
            }
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string relativePath = @"..\..\..\..\AGBs.txt";
            string fullPath = Path.Combine(Application.StartupPath, relativePath);
            try
            {
                System.Diagnostics.Process.Start("notepad.exe", fullPath);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ein Fehler ist aufgetreten: " + ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            _1_Admin_Password _1_Admin_Password = new _1_Admin_Password();
            _1_Admin_Password.Show();
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                tb_Firma.Enabled = true;
            }
            else
            {
                tb_Firma.Enabled = false;
            }
        }

        private void cb_agb_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_agb.Checked)
            {
                btn_click_create_customer.Enabled = true;
            }
            else
            {
                btn_click_create_customer.Enabled = false;
            }
        }

        private void tb_PLZ_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(tb_PLZ.Text, "[^0-9]"))
            {
                MessageBox.Show("Bitte nur Nummern eingeben!");
                tb_PLZ.Text = tb_PLZ.Text.Remove(tb_PLZ.Text.Length - 1);
            }
        }
    }
}
