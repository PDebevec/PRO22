
namespace MojGoFish
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
            this.karte = new System.Windows.Forms.ListBox();
            this.tbime = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tbinfo = new System.Windows.Forms.TextBox();
            this.tbkompleti = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // karte
            // 
            this.karte.FormattingEnabled = true;
            this.karte.Location = new System.Drawing.Point(200, 13);
            this.karte.Name = "karte";
            this.karte.Size = new System.Drawing.Size(120, 251);
            this.karte.TabIndex = 0;
            // 
            // tbime
            // 
            this.tbime.Location = new System.Drawing.Point(13, 13);
            this.tbime.Name = "tbime";
            this.tbime.Size = new System.Drawing.Size(100, 20);
            this.tbime.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(119, 11);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Start";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // tbinfo
            // 
            this.tbinfo.Location = new System.Drawing.Point(13, 40);
            this.tbinfo.Multiline = true;
            this.tbinfo.Name = "tbinfo";
            this.tbinfo.ReadOnly = true;
            this.tbinfo.Size = new System.Drawing.Size(181, 224);
            this.tbinfo.TabIndex = 3;
            // 
            // tbkompleti
            // 
            this.tbkompleti.Location = new System.Drawing.Point(13, 271);
            this.tbkompleti.Multiline = true;
            this.tbkompleti.Name = "tbkompleti";
            this.tbkompleti.ReadOnly = true;
            this.tbkompleti.Size = new System.Drawing.Size(181, 181);
            this.tbkompleti.TabIndex = 4;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(200, 271);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(120, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Vleči karto";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(200, 301);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(120, 23);
            this.button3.TabIndex = 6;
            this.button3.Text = "Sort";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 463);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.tbkompleti);
            this.Controls.Add(this.tbinfo);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbime);
            this.Controls.Add(this.karte);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox karte;
        private System.Windows.Forms.TextBox tbime;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tbinfo;
        private System.Windows.Forms.TextBox tbkompleti;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}

