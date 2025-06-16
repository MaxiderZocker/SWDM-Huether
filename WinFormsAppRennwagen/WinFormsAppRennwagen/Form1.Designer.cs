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
            pictureAutoRot.Location = new Point(100, 500);
            pictureAutoRot.Name = "pictureAutoRot";
            pictureAutoRot.Size = new Size(254, 66);
            pictureAutoRot.TabIndex = 0;
            pictureAutoRot.TabStop = false;
            // 
            // pictureAutoGruen
            // 
            pictureAutoGruen.Image = Properties.Resources.AutoGruen2;
            pictureAutoGruen.Location = new Point(100, 650);
            pictureAutoGruen.Name = "pictureAutoGruen";
            pictureAutoGruen.Size = new Size(254, 66);
            pictureAutoGruen.TabIndex = 1;
            pictureAutoGruen.TabStop = false;
            // 
            // pictureAutoBlau
            // 
            pictureAutoBlau.Image = Properties.Resources.AutoBlau2;
            pictureAutoBlau.Location = new Point(100, 800);
            pictureAutoBlau.Name = "pictureAutoBlau";
            pictureAutoBlau.Size = new Size(254, 66);
            pictureAutoBlau.TabIndex = 2;
            pictureAutoBlau.TabStop = false;
            // 
            // button1
            // 
            button1.Location = new Point(913, 144);
            button1.Name = "button1";
            button1.Size = new Size(271, 90);
            button1.TabIndex = 3;
            button1.Text = "Start";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.track;
            pictureBox3.Location = new Point(100, 466);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(1589, 120);
            pictureBox3.TabIndex = 4;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.track;
            pictureBox4.Location = new Point(100, 618);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(1589, 120);
            pictureBox4.TabIndex = 5;
            pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = Properties.Resources.track;
            pictureBox5.Location = new Point(100, 770);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(1589, 120);
            pictureBox5.TabIndex = 6;
            pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = Properties.Resources.ziel;
            pictureBox6.Location = new Point(1644, 312);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(61, 730);
            pictureBox6.TabIndex = 7;
            pictureBox6.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2332, 1216);
            Controls.Add(pictureBox6);
            Controls.Add(button1);
            Controls.Add(pictureAutoBlau);
            Controls.Add(pictureAutoGruen);
            Controls.Add(pictureAutoRot);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox5);
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
    }
}
