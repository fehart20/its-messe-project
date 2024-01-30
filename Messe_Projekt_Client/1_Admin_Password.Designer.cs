namespace Messe_Projekt_Client
{
    partial class _1_Admin_Password
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
            pwbox = new TextBox();
            button1 = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // pwbox
            // 
            pwbox.Location = new Point(21, 35);
            pwbox.Name = "pwbox";
            pwbox.PasswordChar = '*';
            pwbox.Size = new Size(181, 23);
            pwbox.TabIndex = 5;
            // 
            // button1
            // 
            button1.Location = new Point(21, 64);
            button1.Name = "button1";
            button1.Size = new Size(181, 23);
            button1.TabIndex = 4;
            button1.Text = "Check";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(63, 17);
            label1.Name = "label1";
            label1.Size = new Size(98, 15);
            label1.TabIndex = 3;
            label1.Text = "Admin-Password";
            // 
            // _1_Admin_Password
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(226, 102);
            Controls.Add(pwbox);
            Controls.Add(button1);
            Controls.Add(label1);
            Name = "_1_Admin_Password";
            Text = "_1_Admin_Password";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox pwbox;
        private Button button1;
        private Label label1;
    }
}