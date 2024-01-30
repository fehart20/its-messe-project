namespace Messe_Projekt_Client
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btn_click_create_customer = new Button();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            linkLabel2 = new LinkLabel();
            linkLabel1 = new LinkLabel();
            button2 = new Button();
            cb_agb = new CheckBox();
            cb_dsgvo = new CheckBox();
            cb_Garten = new CheckBox();
            cb_Kueche = new CheckBox();
            tb_Ort = new TextBox();
            tb_PLZ = new TextBox();
            tb_Hausnummer = new TextBox();
            tb_Street = new TextBox();
            tb_Nachname = new TextBox();
            tb_Vorname = new TextBox();
            label1 = new Label();
            checkBox1 = new CheckBox();
            tb_Firma = new TextBox();
            cb_SmartHome = new CheckBox();
            SuspendLayout();
            // 
            // btn_click_create_customer
            // 
            btn_click_create_customer.Enabled = false;
            btn_click_create_customer.Location = new Point(49, 322);
            btn_click_create_customer.Name = "btn_click_create_customer";
            btn_click_create_customer.Size = new Size(370, 23);
            btn_click_create_customer.TabIndex = 15;
            btn_click_create_customer.Text = "Kundenkarte erstellen";
            btn_click_create_customer.UseVisualStyleBackColor = true;
            btn_click_create_customer.Click += button1_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(158, 154);
            label8.Name = "label8";
            label8.Size = new Size(37, 15);
            label8.TabIndex = 47;
            label8.Text = "Firma";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(158, 103);
            label7.Name = "label7";
            label7.Size = new Size(24, 15);
            label7.TabIndex = 46;
            label7.Text = "Ort";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(49, 103);
            label6.Name = "label6";
            label6.Size = new Size(27, 15);
            label6.TabIndex = 45;
            label6.Text = "PLZ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(261, 58);
            label5.Name = "label5";
            label5.Size = new Size(48, 15);
            label5.TabIndex = 44;
            label5.Text = "Hausnr.";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(49, 61);
            label4.Name = "label4";
            label4.Size = new Size(40, 15);
            label4.TabIndex = 43;
            label4.Text = "Straße";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(157, 17);
            label3.Name = "label3";
            label3.Size = new Size(65, 15);
            label3.TabIndex = 42;
            label3.Text = "Nachname";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(49, 17);
            label2.Name = "label2";
            label2.Size = new Size(54, 15);
            label2.TabIndex = 41;
            label2.Text = "Vorname";
            // 
            // linkLabel2
            // 
            linkLabel2.AutoSize = true;
            linkLabel2.Location = new Point(335, 298);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(56, 15);
            linkLabel2.TabIndex = 14;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "Anzeigen";
            linkLabel2.LinkClicked += linkLabel2_LinkClicked;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(352, 272);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(56, 15);
            linkLabel1.TabIndex = 12;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Anzeigen";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // button2
            // 
            button2.Location = new Point(417, 9);
            button2.Name = "button2";
            button2.Size = new Size(92, 23);
            button2.TabIndex = 16;
            button2.Text = "Adminpanel";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // cb_agb
            // 
            cb_agb.AutoSize = true;
            cb_agb.Location = new Point(49, 297);
            cb_agb.Name = "cb_agb";
            cb_agb.Size = new Size(280, 19);
            cb_agb.TabIndex = 13;
            cb_agb.Text = "Ich habe die AGB gelesen und bin einverstanden";
            cb_agb.UseVisualStyleBackColor = true;
            cb_agb.CheckedChanged += cb_agb_CheckedChanged;
            // 
            // cb_dsgvo
            // 
            cb_dsgvo.AutoSize = true;
            cb_dsgvo.Location = new Point(49, 272);
            cb_dsgvo.Name = "cb_dsgvo";
            cb_dsgvo.Size = new Size(294, 19);
            cb_dsgvo.TabIndex = 11;
            cb_dsgvo.Text = "Hiermit bestätige ich die Datenschutzbedingungen";
            cb_dsgvo.UseVisualStyleBackColor = true;
            cb_dsgvo.CheckedChanged += checkBox4_CheckedChanged;
            // 
            // cb_Garten
            // 
            cb_Garten.AutoSize = true;
            cb_Garten.Location = new Point(114, 225);
            cb_Garten.Name = "cb_Garten";
            cb_Garten.Size = new Size(61, 19);
            cb_Garten.TabIndex = 9;
            cb_Garten.Text = "Garten";
            cb_Garten.UseVisualStyleBackColor = true;
            // 
            // cb_Kueche
            // 
            cb_Kueche.AutoSize = true;
            cb_Kueche.Location = new Point(49, 225);
            cb_Kueche.Name = "cb_Kueche";
            cb_Kueche.Size = new Size(59, 19);
            cb_Kueche.TabIndex = 8;
            cb_Kueche.Text = "Küche";
            cb_Kueche.UseVisualStyleBackColor = true;
            // 
            // tb_Ort
            // 
            tb_Ort.Location = new Point(158, 121);
            tb_Ort.Name = "tb_Ort";
            tb_Ort.Size = new Size(177, 23);
            tb_Ort.TabIndex = 5;
            // 
            // tb_PLZ
            // 
            tb_PLZ.Location = new Point(49, 121);
            tb_PLZ.Name = "tb_PLZ";
            tb_PLZ.Size = new Size(100, 23);
            tb_PLZ.TabIndex = 4;
            tb_PLZ.TextChanged += tb_PLZ_TextChanged;
            // 
            // tb_Hausnummer
            // 
            tb_Hausnummer.Location = new Point(261, 76);
            tb_Hausnummer.Name = "tb_Hausnummer";
            tb_Hausnummer.Size = new Size(71, 23);
            tb_Hausnummer.TabIndex = 3;
            // 
            // tb_Street
            // 
            tb_Street.Location = new Point(49, 76);
            tb_Street.Name = "tb_Street";
            tb_Street.Size = new Size(206, 23);
            tb_Street.TabIndex = 2;
            // 
            // tb_Nachname
            // 
            tb_Nachname.Location = new Point(155, 35);
            tb_Nachname.Name = "tb_Nachname";
            tb_Nachname.Size = new Size(100, 23);
            tb_Nachname.TabIndex = 1;
            // 
            // tb_Vorname
            // 
            tb_Vorname.Location = new Point(49, 35);
            tb_Vorname.Name = "tb_Vorname";
            tb_Vorname.Size = new Size(100, 23);
            tb_Vorname.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(49, 207);
            label1.Name = "label1";
            label1.Size = new Size(253, 15);
            label1.TabIndex = 26;
            label1.Text = "Was interessiert Sie auf der Messe am meisten?";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(49, 174);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(103, 19);
            checkBox1.TabIndex = 6;
            checkBox1.Text = "Firmenkontakt";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // tb_Firma
            // 
            tb_Firma.Enabled = false;
            tb_Firma.Location = new Point(158, 172);
            tb_Firma.Name = "tb_Firma";
            tb_Firma.Size = new Size(177, 23);
            tb_Firma.TabIndex = 7;
            // 
            // cb_SmartHome
            // 
            cb_SmartHome.AutoSize = true;
            cb_SmartHome.Location = new Point(181, 225);
            cb_SmartHome.Name = "cb_SmartHome";
            cb_SmartHome.Size = new Size(93, 19);
            cb_SmartHome.TabIndex = 10;
            cb_SmartHome.Text = "Smart Home";
            cb_SmartHome.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(521, 366);
            Controls.Add(cb_SmartHome);
            Controls.Add(tb_Firma);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(linkLabel2);
            Controls.Add(linkLabel1);
            Controls.Add(button2);
            Controls.Add(cb_agb);
            Controls.Add(cb_dsgvo);
            Controls.Add(cb_Garten);
            Controls.Add(cb_Kueche);
            Controls.Add(tb_Ort);
            Controls.Add(tb_PLZ);
            Controls.Add(tb_Hausnummer);
            Controls.Add(tb_Street);
            Controls.Add(tb_Nachname);
            Controls.Add(tb_Vorname);
            Controls.Add(label1);
            Controls.Add(checkBox1);
            Controls.Add(btn_click_create_customer);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            Text = "Messe Kiosk Client";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_click_create_customer;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private LinkLabel linkLabel2;
        private LinkLabel linkLabel1;
        private Button button2;
        private CheckBox cb_agb;
        private CheckBox cb_dsgvo;
        private CheckBox cb_Garten;
        private CheckBox cb_Kueche;
        private TextBox tb_Ort;
        private TextBox tb_PLZ;
        private TextBox tb_Hausnummer;
        private TextBox tb_Street;
        private TextBox tb_Nachname;
        private TextBox tb_Vorname;
        private Label label1;
        private CheckBox checkBox1;
        private TextBox tb_Firma;
        private CheckBox cb_SmartHome;
    }
}
