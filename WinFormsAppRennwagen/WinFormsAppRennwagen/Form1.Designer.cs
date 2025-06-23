namespace WinFormsAppRennwagen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pictureAutoRot = new PictureBox();
            pictureAutoGruen = new PictureBox();
            pictureAutoBlau = new PictureBox();
            button1 = new Button();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox5 = new PictureBox();
            pictureBox6 = new PictureBox();
            button2 = new Button();
            button3 = new Button();
            punkteRot = new Label();
            punkteGruen = new Label();
            punkteBlau = new Label();
            pRotBox = new TextBox();
            pGruenBox = new TextBox();
            pBlauBox = new TextBox();
            labelGewinner = new Label();
            buttonBoostRot = new Button();
            buttonBoostGruen = new Button();
            buttonBoostBlau = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureAutoRot).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureAutoGruen).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureAutoBlau).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            SuspendLayout();
            // 
            // pictureAutoRot
            // 
            pictureAutoRot.Image = (Image)resources.GetObject("pictureAutoRot.Image");
            pictureAutoRot.Location = new Point(62, 312);
            pictureAutoRot.Margin = new Padding(2);
            pictureAutoRot.Name = "pictureAutoRot";
            pictureAutoRot.Size = new Size(156, 41);
            pictureAutoRot.SizeMode = PictureBoxSizeMode.Zoom;
            pictureAutoRot.TabIndex = 0;
            pictureAutoRot.TabStop = false;
            // 
            // pictureAutoGruen
            // 
            pictureAutoGruen.Image = Properties.Resources.AutoGruen2;
            pictureAutoGruen.Location = new Point(62, 406);
            pictureAutoGruen.Margin = new Padding(2);
            pictureAutoGruen.Name = "pictureAutoGruen";
            pictureAutoGruen.Size = new Size(156, 41);
            pictureAutoGruen.SizeMode = PictureBoxSizeMode.Zoom;
            pictureAutoGruen.TabIndex = 1;
            pictureAutoGruen.TabStop = false;
            // 
            // pictureAutoBlau
            // 
            pictureAutoBlau.Image = Properties.Resources.AutoBlau2;
            pictureAutoBlau.Location = new Point(62, 500);
            pictureAutoBlau.Margin = new Padding(2);
            pictureAutoBlau.Name = "pictureAutoBlau";
            pictureAutoBlau.Size = new Size(156, 41);
            pictureAutoBlau.SizeMode = PictureBoxSizeMode.Zoom;
            pictureAutoBlau.TabIndex = 2;
            pictureAutoBlau.TabStop = false;
            // 
            // button1
            // 
            button1.Location = new Point(126, 11);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(167, 56);
            button1.TabIndex = 3;
            button1.Text = "Start";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.track;
            pictureBox3.Location = new Point(62, 291);
            pictureBox3.Margin = new Padding(2);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(978, 75);
            pictureBox3.TabIndex = 4;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.track;
            pictureBox4.Location = new Point(62, 386);
            pictureBox4.Margin = new Padding(2);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(978, 75);
            pictureBox4.TabIndex = 5;
            pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = Properties.Resources.track;
            pictureBox5.Location = new Point(62, 481);
            pictureBox5.Margin = new Padding(2);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(978, 75);
            pictureBox5.TabIndex = 6;
            pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = Properties.Resources.ziel;
            pictureBox6.Location = new Point(1012, 195);
            pictureBox6.Margin = new Padding(2);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(38, 456);
            pictureBox6.TabIndex = 7;
            pictureBox6.TabStop = false;
            // 
            // button2
            // 
            button2.Location = new Point(297, 11);
            button2.Margin = new Padding(2);
            button2.Name = "button2";
            button2.Size = new Size(167, 56);
            button2.TabIndex = 8;
            button2.Text = "Stop";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(468, 11);
            button3.Margin = new Padding(2);
            button3.Name = "button3";
            button3.Size = new Size(167, 56);
            button3.TabIndex = 9;
            button3.Text = "Reset";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // punkteRot
            // 
            punkteRot.AutoSize = true;
            punkteRot.Font = new Font("Segoe UI", 14F);
            punkteRot.Location = new Point(126, 84);
            punkteRot.Name = "punkteRot";
            punkteRot.Size = new Size(135, 32);
            punkteRot.TabIndex = 10;
            punkteRot.Text = "Punkte Rot:";
            // 
            // punkteGruen
            // 
            punkteGruen.AutoSize = true;
            punkteGruen.Font = new Font("Segoe UI", 14F);
            punkteGruen.Location = new Point(126, 116);
            punkteGruen.Name = "punkteGruen";
            punkteGruen.Size = new Size(152, 32);
            punkteGruen.TabIndex = 11;
            punkteGruen.Text = "Punkte Grün:";
            // 
            // punkteBlau
            // 
            punkteBlau.AutoSize = true;
            punkteBlau.Font = new Font("Segoe UI", 14F);
            punkteBlau.Location = new Point(126, 148);
            punkteBlau.Name = "punkteBlau";
            punkteBlau.Size = new Size(146, 32);
            punkteBlau.TabIndex = 12;
            punkteBlau.Text = "Punkte Blau:";
            // 
            // pRotBox
            // 
            pRotBox.Location = new Point(339, 89);
            pRotBox.Name = "pRotBox";
            pRotBox.Size = new Size(125, 27);
            pRotBox.TabIndex = 13;
            // 
            // pGruenBox
            // 
            pGruenBox.Location = new Point(339, 121);
            pGruenBox.Name = "pGruenBox";
            pGruenBox.Size = new Size(125, 27);
            pGruenBox.TabIndex = 14;
            // 
            // pBlauBox
            // 
            pBlauBox.Location = new Point(339, 153);
            pBlauBox.Name = "pBlauBox";
            pBlauBox.Size = new Size(125, 27);
            pBlauBox.TabIndex = 15;
            // 
            // labelGewinner
            // 
            labelGewinner.AutoSize = true;
            labelGewinner.Font = new Font("Microsoft Sans Serif", 24F);
            labelGewinner.Location = new Point(358, 217);
            labelGewinner.Name = "labelGewinner";
            labelGewinner.Size = new Size(0, 46);
            labelGewinner.TabIndex = 16;
            labelGewinner.Visible = false;
            // 
            // buttonBoostRot
            // 
            buttonBoostRot.Location = new Point(770, 25);
            buttonBoostRot.Name = "buttonBoostRot";
            buttonBoostRot.Size = new Size(94, 29);
            buttonBoostRot.TabIndex = 17;
            buttonBoostRot.Text = "Boost Rot";
            buttonBoostRot.UseVisualStyleBackColor = true;
            buttonBoostRot.Click += buttonBoostRot_Click;
            // 
            // buttonBoostGruen
            // 
            buttonBoostGruen.Location = new Point(770, 60);
            buttonBoostGruen.Name = "buttonBoostGruen";
            buttonBoostGruen.Size = new Size(94, 29);
            buttonBoostGruen.TabIndex = 18;
            buttonBoostGruen.Text = "Boost Grün";
            buttonBoostGruen.UseVisualStyleBackColor = true;
            buttonBoostGruen.Click += buttonBoostGruen_Click;
            // 
            // buttonBoostBlau
            // 
            buttonBoostBlau.Location = new Point(770, 95);
            buttonBoostBlau.Name = "buttonBoostBlau";
            buttonBoostBlau.Size = new Size(94, 29);
            buttonBoostBlau.TabIndex = 19;
            buttonBoostBlau.Text = "Boost Blau";
            buttonBoostBlau.UseVisualStyleBackColor = true;
            buttonBoostBlau.Click += buttonBoostBlau_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1184, 659);
            Controls.Add(buttonBoostBlau);
            Controls.Add(buttonBoostGruen);
            Controls.Add(buttonBoostRot);
            Controls.Add(labelGewinner);
            Controls.Add(pBlauBox);
            Controls.Add(pGruenBox);
            Controls.Add(pRotBox);
            Controls.Add(punkteBlau);
            Controls.Add(punkteGruen);
            Controls.Add(punkteRot);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(pictureBox6);
            Controls.Add(button1);
            Controls.Add(pictureAutoBlau);
            Controls.Add(pictureAutoGruen);
            Controls.Add(pictureAutoRot);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox5);
            Margin = new Padding(2);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureAutoRot).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureAutoGruen).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureAutoBlau).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureAutoRot;
        private PictureBox pictureAutoGruen;
        private PictureBox pictureAutoBlau;
        private Button button1;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private PictureBox pictureBox6;
        private Button button2;
        private Button button3;
        private Label punkteRot;
        private Label punkteGruen;
        private Label punkteBlau;
        private TextBox pRotBox;
        private TextBox pGruenBox;
        private TextBox pBlauBox;
        private Label labelGewinner;
        private Button buttonBoostRot;
        private Button buttonBoostGruen;
        private Button buttonBoostBlau;
    }
}
