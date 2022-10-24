namespace Seznami
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbvnos = new System.Windows.Forms.TextBox();
            this.btndodaj = new System.Windows.Forms.Button();
            this.btnodstrani = new System.Windows.Forms.Button();
            this.btnprvi = new System.Windows.Forms.Button();
            this.btnzadnji = new System.Windows.Forms.Button();
            this.btnprazen = new System.Windows.Forms.Button();
            this.btntrim = new System.Windows.Forms.Button();
            this.btnvsebuje = new System.Windows.Forms.Button();
            this.btnlokacija = new System.Windows.Forms.Button();
            this.btnstatistika = new System.Windows.Forms.Button();
            this.btnizpis = new System.Windows.Forms.Button();
            this.tbkonzola = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "vnesi niz";
            // 
            // tbvnos
            // 
            this.tbvnos.Location = new System.Drawing.Point(118, 13);
            this.tbvnos.Name = "tbvnos";
            this.tbvnos.Size = new System.Drawing.Size(213, 20);
            this.tbvnos.TabIndex = 1;
            // 
            // btndodaj
            // 
            this.btndodaj.Location = new System.Drawing.Point(406, 9);
            this.btndodaj.Name = "btndodaj";
            this.btndodaj.Size = new System.Drawing.Size(75, 23);
            this.btndodaj.TabIndex = 2;
            this.btndodaj.Text = "dodaj";
            this.btndodaj.UseVisualStyleBackColor = true;
            this.btndodaj.Click += new System.EventHandler(this.btndodaj_Click);
            // 
            // btnodstrani
            // 
            this.btnodstrani.Location = new System.Drawing.Point(16, 69);
            this.btnodstrani.Name = "btnodstrani";
            this.btnodstrani.Size = new System.Drawing.Size(75, 23);
            this.btnodstrani.TabIndex = 3;
            this.btnodstrani.Text = "odstrani";
            this.btnodstrani.UseVisualStyleBackColor = true;
            this.btnodstrani.Click += new System.EventHandler(this.btnodstrani_Click);
            // 
            // btnprvi
            // 
            this.btnprvi.Location = new System.Drawing.Point(97, 69);
            this.btnprvi.Name = "btnprvi";
            this.btnprvi.Size = new System.Drawing.Size(75, 23);
            this.btnprvi.TabIndex = 4;
            this.btnprvi.Text = "prvi";
            this.btnprvi.UseVisualStyleBackColor = true;
            this.btnprvi.Click += new System.EventHandler(this.btnprvi_Click);
            // 
            // btnzadnji
            // 
            this.btnzadnji.Location = new System.Drawing.Point(180, 69);
            this.btnzadnji.Name = "btnzadnji";
            this.btnzadnji.Size = new System.Drawing.Size(75, 23);
            this.btnzadnji.TabIndex = 5;
            this.btnzadnji.Text = "zadnji";
            this.btnzadnji.UseVisualStyleBackColor = true;
            this.btnzadnji.Click += new System.EventHandler(this.btnzadnji_Click);
            // 
            // btnprazen
            // 
            this.btnprazen.Location = new System.Drawing.Point(16, 99);
            this.btnprazen.Name = "btnprazen";
            this.btnprazen.Size = new System.Drawing.Size(75, 23);
            this.btnprazen.TabIndex = 6;
            this.btnprazen.Text = "je prazna?";
            this.btnprazen.UseVisualStyleBackColor = true;
            this.btnprazen.Click += new System.EventHandler(this.btnprazen_Click);
            // 
            // btntrim
            // 
            this.btntrim.Location = new System.Drawing.Point(16, 129);
            this.btntrim.Name = "btntrim";
            this.btntrim.Size = new System.Drawing.Size(75, 23);
            this.btntrim.TabIndex = 7;
            this.btntrim.Text = "trim";
            this.btntrim.UseVisualStyleBackColor = true;
            this.btntrim.Click += new System.EventHandler(this.btntrim_Click);
            // 
            // btnvsebuje
            // 
            this.btnvsebuje.Location = new System.Drawing.Point(98, 98);
            this.btnvsebuje.Name = "btnvsebuje";
            this.btnvsebuje.Size = new System.Drawing.Size(75, 23);
            this.btnvsebuje.TabIndex = 8;
            this.btnvsebuje.Text = "vsebuje";
            this.btnvsebuje.UseVisualStyleBackColor = true;
            this.btnvsebuje.Click += new System.EventHandler(this.btnvsebuje_Click);
            // 
            // btnlokacija
            // 
            this.btnlokacija.Location = new System.Drawing.Point(180, 97);
            this.btnlokacija.Name = "btnlokacija";
            this.btnlokacija.Size = new System.Drawing.Size(75, 23);
            this.btnlokacija.TabIndex = 9;
            this.btnlokacija.Text = "lokacija";
            this.btnlokacija.UseVisualStyleBackColor = true;
            this.btnlokacija.Click += new System.EventHandler(this.btnlokacija_Click);
            // 
            // btnstatistika
            // 
            this.btnstatistika.Location = new System.Drawing.Point(98, 128);
            this.btnstatistika.Name = "btnstatistika";
            this.btnstatistika.Size = new System.Drawing.Size(75, 23);
            this.btnstatistika.TabIndex = 10;
            this.btnstatistika.Text = "statistika";
            this.btnstatistika.UseVisualStyleBackColor = true;
            this.btnstatistika.Click += new System.EventHandler(this.btnstatistika_Click);
            // 
            // btnizpis
            // 
            this.btnizpis.Location = new System.Drawing.Point(180, 127);
            this.btnizpis.Name = "btnizpis";
            this.btnizpis.Size = new System.Drawing.Size(75, 23);
            this.btnizpis.TabIndex = 11;
            this.btnizpis.Text = "izpisi";
            this.btnizpis.UseVisualStyleBackColor = true;
            this.btnizpis.Click += new System.EventHandler(this.btnizpis_Click);
            // 
            // tbkonzola
            // 
            this.tbkonzola.Location = new System.Drawing.Point(16, 177);
            this.tbkonzola.Multiline = true;
            this.tbkonzola.Name = "tbkonzola";
            this.tbkonzola.ReadOnly = true;
            this.tbkonzola.Size = new System.Drawing.Size(239, 152);
            this.tbkonzola.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 341);
            this.Controls.Add(this.tbkonzola);
            this.Controls.Add(this.btnizpis);
            this.Controls.Add(this.btnstatistika);
            this.Controls.Add(this.btnlokacija);
            this.Controls.Add(this.btnvsebuje);
            this.Controls.Add(this.btntrim);
            this.Controls.Add(this.btnprazen);
            this.Controls.Add(this.btnzadnji);
            this.Controls.Add(this.btnprvi);
            this.Controls.Add(this.btnodstrani);
            this.Controls.Add(this.btndodaj);
            this.Controls.Add(this.tbvnos);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbvnos;
        private System.Windows.Forms.Button btndodaj;
        private System.Windows.Forms.Button btnodstrani;
        private System.Windows.Forms.Button btnprvi;
        private System.Windows.Forms.Button btnzadnji;
        private System.Windows.Forms.Button btnprazen;
        private System.Windows.Forms.Button btntrim;
        private System.Windows.Forms.Button btnvsebuje;
        private System.Windows.Forms.Button btnlokacija;
        private System.Windows.Forms.Button btnstatistika;
        private System.Windows.Forms.Button btnizpis;
        private System.Windows.Forms.TextBox tbkonzola;
    }
}

