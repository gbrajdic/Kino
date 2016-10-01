namespace Kino
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
            this.naslov = new System.Windows.Forms.Label();
            this.filmovi = new System.Windows.Forms.Button();
            this.dvorane = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // naslov
            // 
            this.naslov.AutoSize = true;
            this.naslov.BackColor = System.Drawing.Color.Transparent;
            this.naslov.Font = new System.Drawing.Font("Monotype Corsiva", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.naslov.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.naslov.Location = new System.Drawing.Point(218, 131);
            this.naslov.Name = "naslov";
            this.naslov.Size = new System.Drawing.Size(359, 57);
            this.naslov.TabIndex = 0;
            this.naslov.Text = "Dobrodošli u kino!";
            // 
            // filmovi
            // 
            this.filmovi.AutoSize = true;
            this.filmovi.BackColor = System.Drawing.Color.Transparent;
            this.filmovi.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.filmovi.FlatAppearance.BorderSize = 0;
            this.filmovi.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Firebrick;
            this.filmovi.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Firebrick;
            this.filmovi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.filmovi.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.filmovi.ForeColor = System.Drawing.Color.White;
            this.filmovi.Location = new System.Drawing.Point(328, 259);
            this.filmovi.Name = "filmovi";
            this.filmovi.Size = new System.Drawing.Size(162, 44);
            this.filmovi.TabIndex = 1;
            this.filmovi.Text = "Uskoro u kinu";
            this.filmovi.UseVisualStyleBackColor = false;
            this.filmovi.Click += new System.EventHandler(this.filmovi_Click);
            // 
            // dvorane
            // 
            this.dvorane.AutoSize = true;
            this.dvorane.BackColor = System.Drawing.Color.Transparent;
            this.dvorane.FlatAppearance.BorderSize = 0;
            this.dvorane.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Firebrick;
            this.dvorane.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Firebrick;
            this.dvorane.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dvorane.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dvorane.ForeColor = System.Drawing.Color.White;
            this.dvorane.Location = new System.Drawing.Point(548, 259);
            this.dvorane.Name = "dvorane";
            this.dvorane.Size = new System.Drawing.Size(108, 44);
            this.dvorane.TabIndex = 3;
            this.dvorane.Text = "Dvorane";
            this.dvorane.UseVisualStyleBackColor = false;
            this.dvorane.Click += new System.EventHandler(this.dvorane_Click);
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.button1.FlatAppearance.BorderSize = 0;
            
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Firebrick;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Firebrick;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(90, 259);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(179, 44);
            this.button1.TabIndex = 4;
            this.button1.Text = "Trenutno u kinu";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.AutoSize = true;
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button2.ForeColor = System.Drawing.Color.Coral;
            this.button2.Location = new System.Drawing.Point(328, 330);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(162, 44);
            this.button2.TabIndex = 5;
            this.button2.Text = "Izlaz";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Kino.Properties.Resources.kino3;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.ClientSize = new System.Drawing.Size(792, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dvorane);
            this.Controls.Add(this.filmovi);
            this.Controls.Add(this.naslov);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label naslov;
        private System.Windows.Forms.Button filmovi;
        private System.Windows.Forms.Button dvorane;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

