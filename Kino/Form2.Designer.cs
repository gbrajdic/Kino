using System.Drawing;

namespace Kino
{
    partial class Form2
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
            this.uskoro = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // uskoro
            // 
            this.uskoro.AutoScroll = true;
            this.uskoro.BackColor = System.Drawing.Color.Transparent;
            this.uskoro.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.uskoro.Location = new System.Drawing.Point(39, 38);
            this.uskoro.Margin = new System.Windows.Forms.Padding(4);
            this.uskoro.Name = "uskoro";
            this.uskoro.Size = new System.Drawing.Size(977, 473);
            this.uskoro.TabIndex = 0;
            this.uskoro.WrapContents = false;
            this.uskoro.MouseEnter += new System.EventHandler(this.uskoro_MouseEnter);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.BackgroundImage = global::Kino.Properties.Resources.kino2_manja;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1056, 554);
            this.Controls.Add(this.uskoro);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Filmovi";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel uskoro;
    }
}