namespace MesseClient
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbVorname = new System.Windows.Forms.TextBox();
            this.tbNachname = new System.Windows.Forms.TextBox();
            this.bAPICall = new System.Windows.Forms.Button();
            this.tbErgebnis = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Vorname";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nachname";
            // 
            // tbVorname
            // 
            this.tbVorname.Location = new System.Drawing.Point(199, 29);
            this.tbVorname.Name = "tbVorname";
            this.tbVorname.Size = new System.Drawing.Size(263, 26);
            this.tbVorname.TabIndex = 2;
            // 
            // tbNachname
            // 
            this.tbNachname.Location = new System.Drawing.Point(199, 92);
            this.tbNachname.Name = "tbNachname";
            this.tbNachname.Size = new System.Drawing.Size(263, 26);
            this.tbNachname.TabIndex = 3;
            // 
            // bAPICall
            // 
            this.bAPICall.Location = new System.Drawing.Point(326, 155);
            this.bAPICall.Name = "bAPICall";
            this.bAPICall.Size = new System.Drawing.Size(136, 40);
            this.bAPICall.TabIndex = 4;
            this.bAPICall.Text = "API abfragen";
            this.bAPICall.UseVisualStyleBackColor = true;
            this.bAPICall.Click += new System.EventHandler(this.bAPICall_Click);
            // 
            // tbErgebnis
            // 
            this.tbErgebnis.Location = new System.Drawing.Point(56, 217);
            this.tbErgebnis.Multiline = true;
            this.tbErgebnis.Name = "tbErgebnis";
            this.tbErgebnis.Size = new System.Drawing.Size(406, 131);
            this.tbErgebnis.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 394);
            this.Controls.Add(this.tbErgebnis);
            this.Controls.Add(this.bAPICall);
            this.Controls.Add(this.tbNachname);
            this.Controls.Add(this.tbVorname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbVorname;
        private System.Windows.Forms.TextBox tbNachname;
        private System.Windows.Forms.Button bAPICall;
        private System.Windows.Forms.TextBox tbErgebnis;
    }
}

