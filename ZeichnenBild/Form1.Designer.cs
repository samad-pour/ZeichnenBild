namespace ZeichnenBild
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
            this.BtnAuswahl = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnAuswahl
            // 
            this.BtnAuswahl.Location = new System.Drawing.Point(242, 12);
            this.BtnAuswahl.Name = "BtnAuswahl";
            this.BtnAuswahl.Size = new System.Drawing.Size(75, 23);
            this.BtnAuswahl.TabIndex = 0;
            this.BtnAuswahl.Text = "Auswahl";
            this.BtnAuswahl.UseVisualStyleBackColor = true;
            this.BtnAuswahl.Click += new System.EventHandler(this.BtnAuswahl_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 393);
            this.Controls.Add(this.BtnAuswahl);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private Button BtnAuswahl;
    }
}