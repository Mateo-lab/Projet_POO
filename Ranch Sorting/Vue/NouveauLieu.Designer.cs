namespace Ranch_Sorting.Vue
{
    partial class NouveauLieu
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
            this.btnQuitter = new System.Windows.Forms.Button();
            this.btnValider = new System.Windows.Forms.Button();
            this.txtBoxNomLieu = new System.Windows.Forms.TextBox();
            this.txtBoxNomProprietaire = new System.Windows.Forms.TextBox();
            this.txtBoxAdresse = new System.Windows.Forms.TextBox();
            this.lblNomLieux = new System.Windows.Forms.Label();
            this.lblProprietaire = new System.Windows.Forms.Label();
            this.lblAdresse = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnQuitter
            // 
            this.btnQuitter.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.btnQuitter.Location = new System.Drawing.Point(458, 285);
            this.btnQuitter.Margin = new System.Windows.Forms.Padding(2);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(175, 52);
            this.btnQuitter.TabIndex = 23;
            this.btnQuitter.Text = "Quitter";
            this.btnQuitter.UseVisualStyleBackColor = true;
            this.btnQuitter.Click += new System.EventHandler(this.btnQuitter_Click);
            // 
            // btnValider
            // 
            this.btnValider.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.btnValider.Location = new System.Drawing.Point(61, 285);
            this.btnValider.Margin = new System.Windows.Forms.Padding(2);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(175, 52);
            this.btnValider.TabIndex = 22;
            this.btnValider.Text = "Valider";
            this.btnValider.UseVisualStyleBackColor = true;
            this.btnValider.Click += new System.EventHandler(this.btnValider_Click);
            // 
            // txtBoxNomLieu
            // 
            this.txtBoxNomLieu.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxNomLieu.Location = new System.Drawing.Point(401, 48);
            this.txtBoxNomLieu.Margin = new System.Windows.Forms.Padding(2);
            this.txtBoxNomLieu.Name = "txtBoxNomLieu";
            this.txtBoxNomLieu.Size = new System.Drawing.Size(145, 27);
            this.txtBoxNomLieu.TabIndex = 21;
            // 
            // txtBoxNomProprietaire
            // 
            this.txtBoxNomProprietaire.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxNomProprietaire.Location = new System.Drawing.Point(401, 193);
            this.txtBoxNomProprietaire.Margin = new System.Windows.Forms.Padding(2);
            this.txtBoxNomProprietaire.Name = "txtBoxNomProprietaire";
            this.txtBoxNomProprietaire.Size = new System.Drawing.Size(145, 27);
            this.txtBoxNomProprietaire.TabIndex = 18;
            // 
            // txtBoxAdresse
            // 
            this.txtBoxAdresse.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxAdresse.Location = new System.Drawing.Point(401, 122);
            this.txtBoxAdresse.Margin = new System.Windows.Forms.Padding(2);
            this.txtBoxAdresse.Name = "txtBoxAdresse";
            this.txtBoxAdresse.Size = new System.Drawing.Size(145, 27);
            this.txtBoxAdresse.TabIndex = 17;
            // 
            // lblNomLieux
            // 
            this.lblNomLieux.AutoSize = true;
            this.lblNomLieux.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomLieux.Location = new System.Drawing.Point(140, 54);
            this.lblNomLieux.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNomLieux.Name = "lblNomLieux";
            this.lblNomLieux.Size = new System.Drawing.Size(193, 21);
            this.lblNomLieux.TabIndex = 16;
            this.lblNomLieux.Text = "Nom du nouveau lieux :";
            // 
            // lblProprietaire
            // 
            this.lblProprietaire.AutoSize = true;
            this.lblProprietaire.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblProprietaire.Location = new System.Drawing.Point(140, 199);
            this.lblProprietaire.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblProprietaire.Name = "lblProprietaire";
            this.lblProprietaire.Size = new System.Drawing.Size(175, 21);
            this.lblProprietaire.TabIndex = 15;
            this.lblProprietaire.Text = "Nom du proprietaire :";
            // 
            // lblAdresse
            // 
            this.lblAdresse.AutoSize = true;
            this.lblAdresse.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblAdresse.Location = new System.Drawing.Point(140, 128);
            this.lblAdresse.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAdresse.Name = "lblAdresse";
            this.lblAdresse.Size = new System.Drawing.Size(77, 21);
            this.lblAdresse.TabIndex = 12;
            this.lblAdresse.Text = "Adresse :";
            // 
            // NouveauLieu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 382);
            this.Controls.Add(this.btnQuitter);
            this.Controls.Add(this.btnValider);
            this.Controls.Add(this.txtBoxNomLieu);
            this.Controls.Add(this.txtBoxNomProprietaire);
            this.Controls.Add(this.txtBoxAdresse);
            this.Controls.Add(this.lblNomLieux);
            this.Controls.Add(this.lblProprietaire);
            this.Controls.Add(this.lblAdresse);
            this.Name = "NouveauLieu";
            this.Text = "NouveauLieu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnQuitter;
        private System.Windows.Forms.Button btnValider;
        private System.Windows.Forms.TextBox txtBoxNomLieu;
        private System.Windows.Forms.TextBox txtBoxNomProprietaire;
        private System.Windows.Forms.TextBox txtBoxAdresse;
        private System.Windows.Forms.Label lblNomLieux;
        private System.Windows.Forms.Label lblProprietaire;
        private System.Windows.Forms.Label lblAdresse;
    }
}