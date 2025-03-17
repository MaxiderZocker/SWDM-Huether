namespace KontoPrototyp
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxVorname = new System.Windows.Forms.TextBox();
            this.textBoxNachname = new System.Windows.Forms.TextBox();
            this.textBoxKontoNr = new System.Windows.Forms.TextBox();
            this.textBoxSaldo = new System.Windows.Forms.TextBox();
            this.buttonZurueck = new System.Windows.Forms.Button();
            this.buttonLoeschen = new System.Windows.Forms.Button();
            this.buttonSpeichernAenderung = new System.Windows.Forms.Button();
            this.buttonSpeichernNeuesKonto = new System.Windows.Forms.Button();
            this.buttonVor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(51, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Vorname:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(51, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nachname:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(51, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Kontonummer:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(54, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Saldo:";
            // 
            // textBoxVorname
            // 
            this.textBoxVorname.Location = new System.Drawing.Point(174, 25);
            this.textBoxVorname.Name = "textBoxVorname";
            this.textBoxVorname.Size = new System.Drawing.Size(100, 22);
            this.textBoxVorname.TabIndex = 4;
            // 
            // textBoxNachname
            // 
            this.textBoxNachname.Location = new System.Drawing.Point(174, 54);
            this.textBoxNachname.Name = "textBoxNachname";
            this.textBoxNachname.Size = new System.Drawing.Size(100, 22);
            this.textBoxNachname.TabIndex = 5;
            // 
            // textBoxKontoNr
            // 
            this.textBoxKontoNr.Location = new System.Drawing.Point(174, 81);
            this.textBoxKontoNr.Name = "textBoxKontoNr";
            this.textBoxKontoNr.Size = new System.Drawing.Size(100, 22);
            this.textBoxKontoNr.TabIndex = 6;
            // 
            // textBoxSaldo
            // 
            this.textBoxSaldo.Location = new System.Drawing.Point(174, 110);
            this.textBoxSaldo.Name = "textBoxSaldo";
            this.textBoxSaldo.Size = new System.Drawing.Size(100, 22);
            this.textBoxSaldo.TabIndex = 7;
            // 
            // buttonZurueck
            // 
            this.buttonZurueck.Location = new System.Drawing.Point(54, 182);
            this.buttonZurueck.Name = "buttonZurueck";
            this.buttonZurueck.Size = new System.Drawing.Size(28, 23);
            this.buttonZurueck.TabIndex = 8;
            this.buttonZurueck.Text = "<";
            this.buttonZurueck.UseVisualStyleBackColor = true;
            this.buttonZurueck.Click += new System.EventHandler(this.buttonZurueck_Click);
            // 
            // buttonLoeschen
            // 
            this.buttonLoeschen.Location = new System.Drawing.Point(88, 182);
            this.buttonLoeschen.Name = "buttonLoeschen";
            this.buttonLoeschen.Size = new System.Drawing.Size(75, 23);
            this.buttonLoeschen.TabIndex = 9;
            this.buttonLoeschen.Text = "Löschen";
            this.buttonLoeschen.UseVisualStyleBackColor = true;
            this.buttonLoeschen.Click += new System.EventHandler(this.buttonLoeschen_Click);
            // 
            // buttonSpeichernAenderung
            // 
            this.buttonSpeichernAenderung.Location = new System.Drawing.Point(169, 182);
            this.buttonSpeichernAenderung.Name = "buttonSpeichernAenderung";
            this.buttonSpeichernAenderung.Size = new System.Drawing.Size(143, 23);
            this.buttonSpeichernAenderung.TabIndex = 10;
            this.buttonSpeichernAenderung.Text = "Speichern Anzeigen";
            this.buttonSpeichernAenderung.UseVisualStyleBackColor = true;
            this.buttonSpeichernAenderung.Click += new System.EventHandler(this.buttonSpeichernAenderung_Click);
            // 
            // buttonSpeichernNeuesKonto
            // 
            this.buttonSpeichernNeuesKonto.Location = new System.Drawing.Point(318, 182);
            this.buttonSpeichernNeuesKonto.Name = "buttonSpeichernNeuesKonto";
            this.buttonSpeichernNeuesKonto.Size = new System.Drawing.Size(154, 23);
            this.buttonSpeichernNeuesKonto.TabIndex = 11;
            this.buttonSpeichernNeuesKonto.Text = "Speichern neues Konto";
            this.buttonSpeichernNeuesKonto.UseVisualStyleBackColor = true;
            this.buttonSpeichernNeuesKonto.Click += new System.EventHandler(this.buttonSpeichernNeuesKonto_Click);
            // 
            // buttonVor
            // 
            this.buttonVor.Location = new System.Drawing.Point(479, 181);
            this.buttonVor.Name = "buttonVor";
            this.buttonVor.Size = new System.Drawing.Size(29, 23);
            this.buttonVor.TabIndex = 12;
            this.buttonVor.Text = ">";
            this.buttonVor.UseVisualStyleBackColor = true;
            this.buttonVor.Click += new System.EventHandler(this.buttonVor_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonVor);
            this.Controls.Add(this.buttonSpeichernNeuesKonto);
            this.Controls.Add(this.buttonSpeichernAenderung);
            this.Controls.Add(this.buttonLoeschen);
            this.Controls.Add(this.buttonZurueck);
            this.Controls.Add(this.textBoxSaldo);
            this.Controls.Add(this.textBoxKontoNr);
            this.Controls.Add(this.textBoxNachname);
            this.Controls.Add(this.textBoxVorname);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
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
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxVorname;
        private System.Windows.Forms.TextBox textBoxNachname;
        private System.Windows.Forms.TextBox textBoxKontoNr;
        private System.Windows.Forms.TextBox textBoxSaldo;
        private System.Windows.Forms.Button buttonZurueck;
        private System.Windows.Forms.Button buttonLoeschen;
        private System.Windows.Forms.Button buttonSpeichernAenderung;
        private System.Windows.Forms.Button buttonSpeichernNeuesKonto;
        private System.Windows.Forms.Button buttonVor;
    }
}

