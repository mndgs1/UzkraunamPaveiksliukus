namespace _20200428_GalerijaSuTab
{
    partial class Form1
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
            this.Galerija = new System.Windows.Forms.TabControl();
            this.PavadinimasTextBox = new System.Windows.Forms.TextBox();
            this.PletinysTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.UzkrautiFoto = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Galerija
            // 
            this.Galerija.Location = new System.Drawing.Point(270, 12);
            this.Galerija.Name = "Galerija";
            this.Galerija.SelectedIndex = 0;
            this.Galerija.Size = new System.Drawing.Size(1023, 513);
            this.Galerija.TabIndex = 0;
            this.Galerija.SelectedIndexChanged += new System.EventHandler(this.Galerija_SelectedIndexChanged);
            // 
            // PavadinimasTextBox
            // 
            this.PavadinimasTextBox.Location = new System.Drawing.Point(52, 61);
            this.PavadinimasTextBox.Name = "PavadinimasTextBox";
            this.PavadinimasTextBox.Size = new System.Drawing.Size(189, 22);
            this.PavadinimasTextBox.TabIndex = 1;
            // 
            // PletinysTextBox
            // 
            this.PletinysTextBox.Location = new System.Drawing.Point(52, 132);
            this.PletinysTextBox.Name = "PletinysTextBox";
            this.PletinysTextBox.Size = new System.Drawing.Size(189, 22);
            this.PletinysTextBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Pavadinimas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Pletinys";
            // 
            // UzkrautiFoto
            // 
            this.UzkrautiFoto.Location = new System.Drawing.Point(52, 392);
            this.UzkrautiFoto.Name = "UzkrautiFoto";
            this.UzkrautiFoto.Size = new System.Drawing.Size(189, 95);
            this.UzkrautiFoto.TabIndex = 5;
            this.UzkrautiFoto.Text = "Uzkrauti";
            this.UzkrautiFoto.UseVisualStyleBackColor = true;
            this.UzkrautiFoto.Click += new System.EventHandler(this.UzkrautiFoto_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1305, 537);
            this.Controls.Add(this.UzkrautiFoto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PletinysTextBox);
            this.Controls.Add(this.PavadinimasTextBox);
            this.Controls.Add(this.Galerija);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl Galerija;
        private System.Windows.Forms.TextBox PavadinimasTextBox;
        private System.Windows.Forms.TextBox PletinysTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button UzkrautiFoto;
    }
}

