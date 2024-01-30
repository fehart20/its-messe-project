using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MesseClient
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void bAPICall_Click(object sender, EventArgs e)
        {
            InfoItem ergebnis = await NetworkHelper.CheckWebapi(tbVorname.Text.Trim(), tbNachname.Text.Trim());

            if (ergebnis != null)
            {
                tbErgebnis.Text = $"{ergebnis.Vorname} {ergebnis.Nachname} hat den Benutzernamen {ergebnis.Username} erhalten";
            }
        }
    }
}
