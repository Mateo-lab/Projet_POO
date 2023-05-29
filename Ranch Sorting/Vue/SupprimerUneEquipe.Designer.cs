namespace Ranch_Sorting.Vue
{
    partial class SupprimerUneEquipe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SupprimerUneEquipe));
            this.lblSupprimerEquipe = new System.Windows.Forms.Label();
            this.txtBoxEquipeASupprimer = new System.Windows.Forms.TextBox();
            this.btnQuitter = new System.Windows.Forms.Button();
            this.btnValider = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblSupprimerEquipe
            // 
            this.lblSupprimerEquipe.AutoSize = true;
            this.lblSupprimerEquipe.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSupprimerEquipe.Location = new System.Drawing.Point(140, 80);
            this.lblSupprimerEquipe.Name = "lblSupprimerEquipe";
            this.lblSupprimerEquipe.Size = new System.Drawing.Size(515, 37);
            this.lblSupprimerEquipe.TabIndex = 0;
            this.lblSupprimerEquipe.Text = "Entrer le nom de l\'equipe à supprimer :";
            // 
            // txtBoxEquipeASupprimer
            // 
            this.txtBoxEquipeASupprimer.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxEquipeASupprimer.Location = new System.Drawing.Point(256, 165);
            this.txtBoxEquipeASupprimer.Name = "txtBoxEquipeASupprimer";
            this.txtBoxEquipeASupprimer.Size = new System.Drawing.Size(269, 43);
            this.txtBoxEquipeASupprimer.TabIndex = 1;
            // 
            // btnQuitter
            // 
            this.btnQuitter.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.btnQuitter.Location = new System.Drawing.Point(520, 283);
            this.btnQuitter.Margin = new System.Windows.Forms.Padding(2);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(175, 52);
            this.btnQuitter.TabIndex = 13;
            this.btnQuitter.Text = "Quitter";
            this.btnQuitter.UseVisualStyleBackColor = true;
            this.btnQuitter.Click += new System.EventHandler(this.btnQuitter_Click);
            // 
            // btnValider
            // 
            this.btnValider.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.btnValider.Location = new System.Drawing.Point(123, 283);
            this.btnValider.Margin = new System.Windows.Forms.Padding(2);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(175, 52);
            this.btnValider.TabIndex = 12;
            this.btnValider.Text = "Valider";
            this.btnValider.UseVisualStyleBackColor = true;
            this.btnValider.Click += new System.EventHandler(this.btnValider_Click);
            // 
            // SupprimerUneEquipe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnQuitter);
            this.Controls.Add(this.btnValider);
            this.Controls.Add(this.txtBoxEquipeASupprimer);
            this.Controls.Add(this.lblSupprimerEquipe);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SupprimerUneEquipe";
            this.Text = "Supprimer une équipe";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSupprimerEquipe;
        private System.Windows.Forms.TextBox txtBoxEquipeASupprimer;
        private System.Windows.Forms.Button btnQuitter;
        private System.Windows.Forms.Button btnValider;
    }
}