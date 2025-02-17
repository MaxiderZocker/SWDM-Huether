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
            this.textBoxKontoNr = new System.Windows.Forms.TextBox();
            this.textBoxSaldo = new System.Windows.Forms.TextBox();
            this.speichern = new System.Windows.Forms.Button();
            this.loeschen = new System.Windows.Forms.Button();
            this.anzeigen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(77, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kontonummer:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(127, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Saldo:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // textBoxKontoNr
            // 
            this.textBoxKontoNr.Location = new System.Drawing.Point(207, 53);
            this.textBoxKontoNr.Name = "textBoxKontoNr";
            this.textBoxKontoNr.Size = new System.Drawing.Size(134, 22);
            this.textBoxKontoNr.TabIndex = 2;
            // 
            // textBoxSaldo
            // 
            this.textBoxSaldo.Location = new System.Drawing.Point(207, 82);
            this.textBoxSaldo.Name = "textBoxSaldo";
            this.textBoxSaldo.Size = new System.Drawing.Size(134, 22);
            this.textBoxSaldo.TabIndex = 3;
            // 
            // speichern
            // 
            this.speichern.Location = new System.Drawing.Point(80, 146);
            this.speichern.Name = "speichern";
            this.speichern.Size = new System.Drawing.Size(101, 42);
            this.speichern.TabIndex = 4;
            this.speichern.Text = "Speichern";
            this.speichern.UseVisualStyleBackColor = true;
            this.speichern.Click += new System.EventHandler(this.speichern_Click);
            // 
            // loeschen
            // 
            this.loeschen.Location = new System.Drawing.Point(187, 146);
            this.loeschen.Name = "loeschen";
            this.loeschen.Size = new System.Drawing.Size(101, 42);
            this.loeschen.TabIndex = 5;
            this.loeschen.Text = "Löschen";
            this.loeschen.UseVisualStyleBackColor = true;
            this.loeschen.Click += new System.EventHandler(this.loeschen_Click);
            // 
            // anzeigen
            // 
            this.anzeigen.Location = new System.Drawing.Point(294, 146);
            this.anzeigen.Name = "anzeigen";
            this.anzeigen.Size = new System.Drawing.Size(101, 42);
            this.anzeigen.TabIndex = 6;
            this.anzeigen.Text = "Anzeigen";
            this.anzeigen.UseVisualStyleBackColor = true;
            this.anzeigen.Click += new System.EventHandler(this.anzeigen_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.anzeigen);
            this.Controls.Add(this.loeschen);
            this.Controls.Add(this.speichern);
            this.Controls.Add(this.textBoxSaldo);
            this.Controls.Add(this.textBoxKontoNr);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxKontoNr;
        private System.Windows.Forms.TextBox textBoxSaldo;
        private System.Windows.Forms.Button speichern;
        private System.Windows.Forms.Button loeschen;
        private System.Windows.Forms.Button anzeigen;
    }
}

