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
    public partial class _1_Admin_Password : Form
    {
        public _1_Admin_Password()
        {
            InitializeComponent();
        }
        string pw;
        int versuche = 5;
        private void button1_Click(object sender, EventArgs e)
        {
            pw = pwbox.Text;

            if (PWChecker() == true)
            {
                _2_Admin_Panel _2_Admin_Panel = new _2_Admin_Panel();
                _2_Admin_Panel.Show();
                this.Hide();
            }

        }

        private bool PWChecker()
        {
            while (versuche > 0)
            {
                if (pwbox.Text == "MesseProjekt24")
                {
                    return true;
                }
                else
                {
                    versuche -= 1;
                    string nachricht = "Password falsch! Du hast noch: " + versuche + " Versuche";
                    MessageBox.Show(nachricht);
                    return false;
                }
            }
            if (versuche <= 0)
            {
                string nachricht2 = "Adminpanel wurde gesperrt, zu viele Fehlversuche";
                MessageBox.Show(nachricht2);
                return false;
            }
            return false;
        }
    }
}
