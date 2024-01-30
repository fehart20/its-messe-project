namespace Messe_Projekt_Client
{
    partial class _2_Admin_Panel
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            rTB_usernames = new RichTextBox();
            rTB_database_entries = new RichTextBox();
            btn_show_db_entries = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(12, 12);
            button1.Name = "button1";
            button1.Size = new Size(140, 46);
            button1.TabIndex = 1;
            button1.Text = "Daten übertragen";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // rTB_usernames
            // 
            rTB_usernames.Enabled = false;
            rTB_usernames.Location = new Point(12, 83);
            rTB_usernames.Name = "rTB_usernames";
            rTB_usernames.ReadOnly = true;
            rTB_usernames.Size = new Size(140, 140);
            rTB_usernames.TabIndex = 2;
            rTB_usernames.Text = "";
            // 
            // rTB_database_entries
            // 
            rTB_database_entries.Location = new Point(225, 83);
            rTB_database_entries.Name = "rTB_database_entries";
            rTB_database_entries.ReadOnly = true;
            rTB_database_entries.Size = new Size(323, 140);
            rTB_database_entries.TabIndex = 3;
            rTB_database_entries.Text = "";
            // 
            // btn_show_db_entries
            // 
            btn_show_db_entries.Location = new Point(225, 17);
            btn_show_db_entries.Name = "btn_show_db_entries";
            btn_show_db_entries.Size = new Size(153, 41);
            btn_show_db_entries.TabIndex = 4;
            btn_show_db_entries.Text = "Einträge in DB anzeigen";
            btn_show_db_entries.UseVisualStyleBackColor = true;
            btn_show_db_entries.Click += btn_show_db_entries_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 61);
            label1.Name = "label1";
            label1.Size = new Size(108, 15);
            label1.TabIndex = 5;
            label1.Text = "!Nur neue Einträge!";
            // 
            // _2_Admin_Panel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(560, 234);
            Controls.Add(label1);
            Controls.Add(btn_show_db_entries);
            Controls.Add(rTB_database_entries);
            Controls.Add(rTB_usernames);
            Controls.Add(button1);
            Name = "_2_Admin_Panel";
            Text = "_2_Admin_Panel";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private RichTextBox rTB_usernames;
        private RichTextBox rTB_database_entries;
        private Button btn_show_db_entries;
        private Label label1;
    }
}