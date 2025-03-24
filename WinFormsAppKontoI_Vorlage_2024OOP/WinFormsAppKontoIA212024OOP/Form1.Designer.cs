namespace WinFormsAppKontoIA212024OOP
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
            label1 = new Label();
            label2 = new Label();
            textBoxKontoNr = new TextBox();
            textBoxSaldo = new TextBox();
            buttonLoeschen = new Button();
            buttonAnzeigen = new Button();
            buttonBack = new Button();
            buttonForward = new Button();
            buttonAdd = new Button();
            label3 = new Label();
            label4 = new Label();
            textBoxName = new TextBox();
            textBoxVorname = new TextBox();
            menuStrip1 = new MenuStrip();
            dateiToolStripMenuItem = new ToolStripMenuItem();
            speichernexportToolStripMenuItem = new ToolStripMenuItem();
            ladenimportToolStripMenuItem = new ToolStripMenuItem();
            ladenToolStripMenuItem = new ToolStripMenuItem();
            speichernToolStripMenuItem = new ToolStripMenuItem();
            openFileDialog1 = new OpenFileDialog();
            saveFileDialog1 = new SaveFileDialog();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label1.Location = new Point(82, 196);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(189, 32);
            label1.TabIndex = 0;
            label1.Text = "Kontonummer:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label2.Location = new Point(82, 263);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(84, 32);
            label2.TabIndex = 1;
            label2.Text = "Saldo:";
            // 
            // textBoxKontoNr
            // 
            textBoxKontoNr.Font = new Font("Segoe UI", 14F);
            textBoxKontoNr.Location = new Point(290, 192);
            textBoxKontoNr.Margin = new Padding(2, 1, 2, 1);
            textBoxKontoNr.Name = "textBoxKontoNr";
            textBoxKontoNr.Size = new Size(210, 39);
            textBoxKontoNr.TabIndex = 2;
            // 
            // textBoxSaldo
            // 
            textBoxSaldo.Font = new Font("Segoe UI", 14F);
            textBoxSaldo.Location = new Point(290, 259);
            textBoxSaldo.Margin = new Padding(2, 1, 2, 1);
            textBoxSaldo.Name = "textBoxSaldo";
            textBoxSaldo.Size = new Size(210, 39);
            textBoxSaldo.TabIndex = 3;
            // 
            // buttonLoeschen
            // 
            buttonLoeschen.Location = new Point(167, 355);
            buttonLoeschen.Margin = new Padding(2, 1, 2, 1);
            buttonLoeschen.Name = "buttonLoeschen";
            buttonLoeschen.Size = new Size(107, 45);
            buttonLoeschen.TabIndex = 5;
            buttonLoeschen.Text = "löschen";
            buttonLoeschen.UseVisualStyleBackColor = true;
            buttonLoeschen.Click += buttonLoeschen_Click;
            // 
            // buttonAnzeigen
            // 
            buttonAnzeigen.Location = new Point(289, 355);
            buttonAnzeigen.Margin = new Padding(2, 1, 2, 1);
            buttonAnzeigen.Name = "buttonAnzeigen";
            buttonAnzeigen.Size = new Size(169, 45);
            buttonAnzeigen.TabIndex = 6;
            buttonAnzeigen.Text = "speichern Änderung";
            buttonAnzeigen.UseVisualStyleBackColor = true;
            buttonAnzeigen.Click += buttonAnzeigen_Click;
            // 
            // buttonBack
            // 
            buttonBack.Font = new Font("Segoe UI", 14F);
            buttonBack.Location = new Point(82, 355);
            buttonBack.Margin = new Padding(3, 4, 3, 4);
            buttonBack.Name = "buttonBack";
            buttonBack.Size = new Size(79, 47);
            buttonBack.TabIndex = 7;
            buttonBack.Text = "<";
            buttonBack.UseVisualStyleBackColor = true;
            buttonBack.Click += buttonBack_Click;
            // 
            // buttonForward
            // 
            buttonForward.Font = new Font("Segoe UI", 14F);
            buttonForward.Location = new Point(638, 355);
            buttonForward.Margin = new Padding(3, 4, 3, 4);
            buttonForward.Name = "buttonForward";
            buttonForward.Size = new Size(79, 47);
            buttonForward.TabIndex = 8;
            buttonForward.Text = ">";
            buttonForward.UseVisualStyleBackColor = true;
            buttonForward.Click += buttonForward_Click;
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(464, 355);
            buttonAdd.Margin = new Padding(3, 4, 3, 4);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(167, 47);
            buttonAdd.TabIndex = 9;
            buttonAdd.Text = "speichern neues Konto";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label3.Location = new Point(82, 63);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(123, 32);
            label3.TabIndex = 10;
            label3.Text = "Vorname:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label4.Location = new Point(82, 129);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(142, 32);
            label4.TabIndex = 11;
            label4.Text = "Nachname:";
            // 
            // textBoxName
            // 
            textBoxName.Font = new Font("Segoe UI", 14F);
            textBoxName.Location = new Point(290, 125);
            textBoxName.Margin = new Padding(2, 1, 2, 1);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(210, 39);
            textBoxName.TabIndex = 12;
            // 
            // textBoxVorname
            // 
            textBoxVorname.Font = new Font("Segoe UI", 14F);
            textBoxVorname.Location = new Point(290, 59);
            textBoxVorname.Margin = new Padding(2, 1, 2, 1);
            textBoxVorname.Name = "textBoxVorname";
            textBoxVorname.Size = new Size(210, 39);
            textBoxVorname.TabIndex = 13;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { dateiToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(803, 28);
            menuStrip1.TabIndex = 14;
            menuStrip1.Text = "menuStrip1";
            // 
            // dateiToolStripMenuItem
            // 
            dateiToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { speichernexportToolStripMenuItem, ladenimportToolStripMenuItem, ladenToolStripMenuItem, speichernToolStripMenuItem });
            dateiToolStripMenuItem.Name = "dateiToolStripMenuItem";
            dateiToolStripMenuItem.Size = new Size(59, 24);
            dateiToolStripMenuItem.Text = "Datei";
            // 
            // speichernexportToolStripMenuItem
            // 
            speichernexportToolStripMenuItem.Name = "speichernexportToolStripMenuItem";
            speichernexportToolStripMenuItem.Size = new Size(204, 26);
            speichernexportToolStripMenuItem.Text = "speichern_export";
            // 
            // ladenimportToolStripMenuItem
            // 
            ladenimportToolStripMenuItem.Name = "ladenimportToolStripMenuItem";
            ladenimportToolStripMenuItem.Size = new Size(204, 26);
            ladenimportToolStripMenuItem.Text = "laden_import";
            // 
            // ladenToolStripMenuItem
            // 
            ladenToolStripMenuItem.Name = "ladenToolStripMenuItem";
            ladenToolStripMenuItem.Size = new Size(204, 26);
            ladenToolStripMenuItem.Text = "öffnen";
            ladenToolStripMenuItem.Click += ladenToolStripMenuItem_Click;
            // 
            // speichernToolStripMenuItem
            // 
            speichernToolStripMenuItem.Name = "speichernToolStripMenuItem";
            speichernToolStripMenuItem.Size = new Size(204, 26);
            speichernToolStripMenuItem.Text = "speichern";
            speichernToolStripMenuItem.Click += speichernToolStripMenuItem_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(803, 465);
            Controls.Add(textBoxVorname);
            Controls.Add(textBoxName);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(buttonAdd);
            Controls.Add(buttonForward);
            Controls.Add(buttonBack);
            Controls.Add(buttonAnzeigen);
            Controls.Add(buttonLoeschen);
            Controls.Add(textBoxSaldo);
            Controls.Add(textBoxKontoNr);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(2, 1, 2, 1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBoxKontoNr;
        private TextBox textBoxSaldo;
        private Button buttonLoeschen;
        private Button buttonAnzeigen;
        private Button buttonBack;
        private Button buttonForward;
        private Button buttonAdd;
        private Label label3;
        private Label label4;
        private TextBox textBoxName;
        private TextBox textBoxVorname;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem dateiToolStripMenuItem;
        private ToolStripMenuItem speichernexportToolStripMenuItem;
        private ToolStripMenuItem ladenimportToolStripMenuItem;
        private ToolStripMenuItem ladenToolStripMenuItem;
        private ToolStripMenuItem speichernToolStripMenuItem;
        private OpenFileDialog openFileDialog1;
        private SaveFileDialog saveFileDialog1;
    }
}
