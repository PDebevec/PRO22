namespace GoFish
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
            this.label2 = new System.Windows.Forms.Label();
            this.lblevo = new System.Windows.Forms.ListBox();
            this.lbdesno = new System.Windows.Forms.ListBox();
            this.btndesno = new System.Windows.Forms.Button();
            this.btnlevo = new System.Windows.Forms.Button();
            this.ponastaviena = new System.Windows.Forms.Button();
            this.mešajena = new System.Windows.Forms.Button();
            this.ponastavidva = new System.Windows.Forms.Button();
            this.mešajdva = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kup 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(298, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Kup 2";
            // 
            // lblevo
            // 
            this.lblevo.FormattingEnabled = true;
            this.lblevo.Location = new System.Drawing.Point(16, 63);
            this.lblevo.Name = "lblevo";
            this.lblevo.Size = new System.Drawing.Size(120, 290);
            this.lblevo.TabIndex = 2;
            // 
            // lbdesno
            // 
            this.lbdesno.FormattingEnabled = true;
            this.lbdesno.Location = new System.Drawing.Point(301, 63);
            this.lbdesno.Name = "lbdesno";
            this.lbdesno.Size = new System.Drawing.Size(120, 290);
            this.lbdesno.TabIndex = 3;
            // 
            // btndesno
            // 
            this.btndesno.Location = new System.Drawing.Point(184, 141);
            this.btndesno.Name = "btndesno";
            this.btndesno.Size = new System.Drawing.Size(75, 23);
            this.btndesno.TabIndex = 4;
            this.btndesno.Text = ">>";
            this.btndesno.UseVisualStyleBackColor = true;
            this.btndesno.Click += new System.EventHandler(this.btndesno_Click);
            // 
            // btnlevo
            // 
            this.btnlevo.Location = new System.Drawing.Point(184, 198);
            this.btnlevo.Name = "btnlevo";
            this.btnlevo.Size = new System.Drawing.Size(75, 23);
            this.btnlevo.TabIndex = 5;
            this.btnlevo.Text = "<<";
            this.btnlevo.UseVisualStyleBackColor = true;
            this.btnlevo.Click += new System.EventHandler(this.btnlevo_Click);
            // 
            // ponastaviena
            // 
            this.ponastaviena.Location = new System.Drawing.Point(16, 360);
            this.ponastaviena.Name = "ponastaviena";
            this.ponastaviena.Size = new System.Drawing.Size(120, 23);
            this.ponastaviena.TabIndex = 6;
            this.ponastaviena.Text = "ponastavi #1";
            this.ponastaviena.UseVisualStyleBackColor = true;
            this.ponastaviena.Click += new System.EventHandler(this.ponastaviena_Click);
            // 
            // mešajena
            // 
            this.mešajena.Location = new System.Drawing.Point(16, 390);
            this.mešajena.Name = "mešajena";
            this.mešajena.Size = new System.Drawing.Size(120, 23);
            this.mešajena.TabIndex = 7;
            this.mešajena.Text = "mešaj #1";
            this.mešajena.UseVisualStyleBackColor = true;
            this.mešajena.Click += new System.EventHandler(this.mešajena_Click);
            // 
            // ponastavidva
            // 
            this.ponastavidva.Location = new System.Drawing.Point(301, 361);
            this.ponastavidva.Name = "ponastavidva";
            this.ponastavidva.Size = new System.Drawing.Size(120, 23);
            this.ponastavidva.TabIndex = 8;
            this.ponastavidva.Text = "ponastavi #2";
            this.ponastavidva.UseVisualStyleBackColor = true;
            this.ponastavidva.Click += new System.EventHandler(this.ponastavidva_Click);
            // 
            // mešajdva
            // 
            this.mešajdva.Location = new System.Drawing.Point(301, 390);
            this.mešajdva.Name = "mešajdva";
            this.mešajdva.Size = new System.Drawing.Size(120, 23);
            this.mešajdva.TabIndex = 9;
            this.mešajdva.Text = "mešaj #2";
            this.mešajdva.UseVisualStyleBackColor = true;
            this.mešajdva.Click += new System.EventHandler(this.mešajdva_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 485);
            this.Controls.Add(this.mešajdva);
            this.Controls.Add(this.ponastavidva);
            this.Controls.Add(this.mešajena);
            this.Controls.Add(this.ponastaviena);
            this.Controls.Add(this.btnlevo);
            this.Controls.Add(this.btndesno);
            this.Controls.Add(this.lbdesno);
            this.Controls.Add(this.lblevo);
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
        private System.Windows.Forms.ListBox lblevo;
        private System.Windows.Forms.ListBox lbdesno;
        private System.Windows.Forms.Button btndesno;
        private System.Windows.Forms.Button btnlevo;
        private System.Windows.Forms.Button ponastaviena;
        private System.Windows.Forms.Button mešajena;
        private System.Windows.Forms.Button ponastavidva;
        private System.Windows.Forms.Button mešajdva;
    }
}

