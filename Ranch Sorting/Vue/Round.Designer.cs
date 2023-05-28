namespace Ranch_Sorting.Vue
{
    partial class Round
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.lblGrilleResultat = new System.Windows.Forms.Label();
            this.richTextBoxResultats = new System.Windows.Forms.RichTextBox();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.lblNomEquipeSuivante = new System.Windows.Forms.Label();
            this.lblNomEquipeEnCours = new System.Windows.Forms.Label();
            this.lblEquipeSuivante = new System.Windows.Forms.Label();
            this.lblEquipeEncours = new System.Windows.Forms.Label();
            this.btnLancer = new System.Windows.Forms.Button();
            this.cmbBoxNumRound = new System.Windows.Forms.ComboBox();
            this.cmbBoxSelectEpreuve = new System.Windows.Forms.ComboBox();
            this.lblTimer = new System.Windows.Forms.Label();
            this.lblNumVache = new System.Windows.Forms.Label();
            this.lblAnnoncePremiereVache = new System.Windows.Forms.Label();
            this.btnEquipeSuivante = new System.Windows.Forms.Button();
            this.btnValidationResultats = new System.Windows.Forms.Button();
            this.btnMauvaiseVache = new System.Windows.Forms.Button();
            this.btnBonneVache = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.lblClassement = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.dataGridViewScoresEquipe = new System.Windows.Forms.DataGridView();
            this.btnRetour = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewScoresEquipe)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.lblClassement);
            this.splitContainer1.Panel2.Controls.Add(this.flowLayoutPanel1);
            this.splitContainer1.Size = new System.Drawing.Size(1567, 1033);
            this.splitContainer1.SplitterDistance = 663;
            this.splitContainer1.TabIndex = 0;
            // 
            // splitContainer2
            // 
            this.splitContainer2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Margin = new System.Windows.Forms.Padding(4);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.lblGrilleResultat);
            this.splitContainer2.Panel1.Controls.Add(this.richTextBoxResultats);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.splitContainer3);
            this.splitContainer2.Size = new System.Drawing.Size(1567, 663);
            this.splitContainer2.SplitterDistance = 408;
            this.splitContainer2.SplitterWidth = 5;
            this.splitContainer2.TabIndex = 27;
            // 
            // lblGrilleResultat
            // 
            this.lblGrilleResultat.AutoSize = true;
            this.lblGrilleResultat.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGrilleResultat.Location = new System.Drawing.Point(19, 66);
            this.lblGrilleResultat.Name = "lblGrilleResultat";
            this.lblGrilleResultat.Size = new System.Drawing.Size(286, 37);
            this.lblGrilleResultat.TabIndex = 36;
            this.lblGrilleResultat.Text = "Resultat de l\'equipe :";
            // 
            // richTextBoxResultats
            // 
            this.richTextBoxResultats.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBoxResultats.Location = new System.Drawing.Point(16, 127);
            this.richTextBoxResultats.Margin = new System.Windows.Forms.Padding(4);
            this.richTextBoxResultats.Name = "richTextBoxResultats";
            this.richTextBoxResultats.Size = new System.Drawing.Size(383, 425);
            this.richTextBoxResultats.TabIndex = 0;
            this.richTextBoxResultats.Text = "";
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Margin = new System.Windows.Forms.Padding(4);
            this.splitContainer3.Name = "splitContainer3";
            this.splitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.lblNomEquipeSuivante);
            this.splitContainer3.Panel1.Controls.Add(this.lblNomEquipeEnCours);
            this.splitContainer3.Panel1.Controls.Add(this.lblEquipeSuivante);
            this.splitContainer3.Panel1.Controls.Add(this.lblEquipeEncours);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.btnRetour);
            this.splitContainer3.Panel2.Controls.Add(this.btnLancer);
            this.splitContainer3.Panel2.Controls.Add(this.cmbBoxNumRound);
            this.splitContainer3.Panel2.Controls.Add(this.cmbBoxSelectEpreuve);
            this.splitContainer3.Panel2.Controls.Add(this.lblTimer);
            this.splitContainer3.Panel2.Controls.Add(this.lblNumVache);
            this.splitContainer3.Panel2.Controls.Add(this.lblAnnoncePremiereVache);
            this.splitContainer3.Panel2.Controls.Add(this.btnEquipeSuivante);
            this.splitContainer3.Panel2.Controls.Add(this.btnValidationResultats);
            this.splitContainer3.Panel2.Controls.Add(this.btnMauvaiseVache);
            this.splitContainer3.Panel2.Controls.Add(this.btnBonneVache);
            this.splitContainer3.Panel2.Controls.Add(this.btnStart);
            this.splitContainer3.Size = new System.Drawing.Size(1150, 659);
            this.splitContainer3.SplitterDistance = 116;
            this.splitContainer3.SplitterWidth = 5;
            this.splitContainer3.TabIndex = 36;
            // 
            // lblNomEquipeSuivante
            // 
            this.lblNomEquipeSuivante.AutoSize = true;
            this.lblNomEquipeSuivante.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.lblNomEquipeSuivante.Location = new System.Drawing.Point(571, 74);
            this.lblNomEquipeSuivante.Name = "lblNomEquipeSuivante";
            this.lblNomEquipeSuivante.Size = new System.Drawing.Size(149, 28);
            this.lblNomEquipeSuivante.TabIndex = 46;
            this.lblNomEquipeSuivante.Text = "Equipe suivante";
            // 
            // lblNomEquipeEnCours
            // 
            this.lblNomEquipeEnCours.AutoSize = true;
            this.lblNomEquipeEnCours.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.lblNomEquipeEnCours.Location = new System.Drawing.Point(571, 23);
            this.lblNomEquipeEnCours.Name = "lblNomEquipeEnCours";
            this.lblNomEquipeEnCours.Size = new System.Drawing.Size(162, 28);
            this.lblNomEquipeEnCours.TabIndex = 45;
            this.lblNomEquipeEnCours.Text = "Equipe en cours";
            // 
            // lblEquipeSuivante
            // 
            this.lblEquipeSuivante.AutoSize = true;
            this.lblEquipeSuivante.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.lblEquipeSuivante.Location = new System.Drawing.Point(95, 74);
            this.lblEquipeSuivante.Name = "lblEquipeSuivante";
            this.lblEquipeSuivante.Size = new System.Drawing.Size(244, 28);
            this.lblEquipeSuivante.TabIndex = 44;
            this.lblEquipeSuivante.Text = "Nom de l\'equipe suivante :";
            // 
            // lblEquipeEncours
            // 
            this.lblEquipeEncours.AutoSize = true;
            this.lblEquipeEncours.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.lblEquipeEncours.Location = new System.Drawing.Point(65, 23);
            this.lblEquipeEncours.Name = "lblEquipeEncours";
            this.lblEquipeEncours.Size = new System.Drawing.Size(266, 28);
            this.lblEquipeEncours.TabIndex = 43;
            this.lblEquipeEncours.Text = "Nom de l\'equipe en cours :";
            // 
            // btnLancer
            // 
            this.btnLancer.AutoSize = true;
            this.btnLancer.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnLancer.Enabled = false;
            this.btnLancer.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.btnLancer.Location = new System.Drawing.Point(903, 119);
            this.btnLancer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLancer.Name = "btnLancer";
            this.btnLancer.Size = new System.Drawing.Size(84, 38);
            this.btnLancer.TabIndex = 47;
            this.btnLancer.Text = "Lancer";
            this.btnLancer.UseVisualStyleBackColor = true;
            this.btnLancer.Click += new System.EventHandler(this.btnLancer_Click);
            // 
            // cmbBoxNumRound
            // 
            this.cmbBoxNumRound.BackColor = System.Drawing.Color.Yellow;
            this.cmbBoxNumRound.Enabled = false;
            this.cmbBoxNumRound.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cmbBoxNumRound.FormattingEnabled = true;
            this.cmbBoxNumRound.Items.AddRange(new object[] {
            "1"});
            this.cmbBoxNumRound.Location = new System.Drawing.Point(801, 84);
            this.cmbBoxNumRound.Margin = new System.Windows.Forms.Padding(4);
            this.cmbBoxNumRound.Name = "cmbBoxNumRound";
            this.cmbBoxNumRound.Size = new System.Drawing.Size(299, 24);
            this.cmbBoxNumRound.TabIndex = 46;
            this.cmbBoxNumRound.Text = "Sélectionner le numero du round";
            this.cmbBoxNumRound.SelectedIndexChanged += new System.EventHandler(this.cmbBoxNumRound_SelectedIndexChanged);
            // 
            // cmbBoxSelectEpreuve
            // 
            this.cmbBoxSelectEpreuve.BackColor = System.Drawing.Color.Yellow;
            this.cmbBoxSelectEpreuve.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cmbBoxSelectEpreuve.FormattingEnabled = true;
            this.cmbBoxSelectEpreuve.Location = new System.Drawing.Point(801, 36);
            this.cmbBoxSelectEpreuve.Margin = new System.Windows.Forms.Padding(4);
            this.cmbBoxSelectEpreuve.Name = "cmbBoxSelectEpreuve";
            this.cmbBoxSelectEpreuve.Size = new System.Drawing.Size(299, 24);
            this.cmbBoxSelectEpreuve.TabIndex = 45;
            this.cmbBoxSelectEpreuve.Text = "Sélectionner l\'épreuve à lancer";
            this.cmbBoxSelectEpreuve.SelectedIndexChanged += new System.EventHandler(this.cmbBoxSelectEpreuve_SelectedIndexChanged);
            // 
            // lblTimer
            // 
            this.lblTimer.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblTimer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTimer.Font = new System.Drawing.Font("Segoe UI", 50F, System.Drawing.FontStyle.Bold);
            this.lblTimer.Location = new System.Drawing.Point(267, 21);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(520, 135);
            this.lblTimer.TabIndex = 44;
            this.lblTimer.Text = "00:00";
            this.lblTimer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNumVache
            // 
            this.lblNumVache.AutoSize = true;
            this.lblNumVache.Enabled = false;
            this.lblNumVache.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumVache.Location = new System.Drawing.Point(649, 183);
            this.lblNumVache.Name = "lblNumVache";
            this.lblNumVache.Size = new System.Drawing.Size(230, 37);
            this.lblNumVache.TabIndex = 43;
            this.lblNumVache.Text = "*Random vache*";
            // 
            // lblAnnoncePremiereVache
            // 
            this.lblAnnoncePremiereVache.AutoSize = true;
            this.lblAnnoncePremiereVache.Enabled = false;
            this.lblAnnoncePremiereVache.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnnoncePremiereVache.Location = new System.Drawing.Point(79, 183);
            this.lblAnnoncePremiereVache.Name = "lblAnnoncePremiereVache";
            this.lblAnnoncePremiereVache.Size = new System.Drawing.Size(410, 37);
            this.lblAnnoncePremiereVache.TabIndex = 42;
            this.lblAnnoncePremiereVache.Text = "Numero de la premiere vache :";
            // 
            // btnEquipeSuivante
            // 
            this.btnEquipeSuivante.AutoSize = true;
            this.btnEquipeSuivante.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnEquipeSuivante.Enabled = false;
            this.btnEquipeSuivante.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.btnEquipeSuivante.Location = new System.Drawing.Point(687, 460);
            this.btnEquipeSuivante.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEquipeSuivante.Name = "btnEquipeSuivante";
            this.btnEquipeSuivante.Size = new System.Drawing.Size(172, 38);
            this.btnEquipeSuivante.TabIndex = 40;
            this.btnEquipeSuivante.Text = "Equipe suivante";
            this.btnEquipeSuivante.UseVisualStyleBackColor = true;
            this.btnEquipeSuivante.Click += new System.EventHandler(this.btnEquipeSuivante_Click);
            // 
            // btnValidationResultats
            // 
            this.btnValidationResultats.AutoSize = true;
            this.btnValidationResultats.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnValidationResultats.Enabled = false;
            this.btnValidationResultats.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.btnValidationResultats.Location = new System.Drawing.Point(144, 460);
            this.btnValidationResultats.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnValidationResultats.Name = "btnValidationResultats";
            this.btnValidationResultats.Size = new System.Drawing.Size(207, 38);
            this.btnValidationResultats.TabIndex = 39;
            this.btnValidationResultats.Text = "Valider les résultats";
            this.btnValidationResultats.UseVisualStyleBackColor = true;
            this.btnValidationResultats.Click += new System.EventHandler(this.btnValidationResultats_Click);
            // 
            // btnMauvaiseVache
            // 
            this.btnMauvaiseVache.AutoSize = true;
            this.btnMauvaiseVache.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnMauvaiseVache.Enabled = false;
            this.btnMauvaiseVache.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.btnMauvaiseVache.Location = new System.Drawing.Point(687, 375);
            this.btnMauvaiseVache.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMauvaiseVache.Name = "btnMauvaiseVache";
            this.btnMauvaiseVache.Size = new System.Drawing.Size(179, 38);
            this.btnMauvaiseVache.TabIndex = 38;
            this.btnMauvaiseVache.Text = "Mauvaise  vache";
            this.btnMauvaiseVache.UseVisualStyleBackColor = true;
            this.btnMauvaiseVache.Click += new System.EventHandler(this.btnMauvaiseVache_Click);
            // 
            // btnBonneVache
            // 
            this.btnBonneVache.AutoSize = true;
            this.btnBonneVache.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnBonneVache.Enabled = false;
            this.btnBonneVache.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.btnBonneVache.Location = new System.Drawing.Point(193, 375);
            this.btnBonneVache.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBonneVache.Name = "btnBonneVache";
            this.btnBonneVache.Size = new System.Drawing.Size(143, 38);
            this.btnBonneVache.TabIndex = 37;
            this.btnBonneVache.Text = "Bonne vache";
            this.btnBonneVache.UseVisualStyleBackColor = true;
            this.btnBonneVache.Click += new System.EventHandler(this.btnBonneVache_Click);
            // 
            // btnStart
            // 
            this.btnStart.AutoSize = true;
            this.btnStart.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnStart.BackColor = System.Drawing.Color.LawnGreen;
            this.btnStart.Enabled = false;
            this.btnStart.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Bold);
            this.btnStart.Location = new System.Drawing.Point(505, 261);
            this.btnStart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(80, 56);
            this.btnStart.TabIndex = 36;
            this.btnStart.Text = "GO";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // lblClassement
            // 
            this.lblClassement.AutoSize = true;
            this.lblClassement.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClassement.Location = new System.Drawing.Point(655, 14);
            this.lblClassement.Name = "lblClassement";
            this.lblClassement.Size = new System.Drawing.Size(177, 37);
            this.lblClassement.TabIndex = 37;
            this.lblClassement.Text = "Classement :";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.flowLayoutPanel1.Controls.Add(this.dataGridViewScoresEquipe);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(35, 59);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1516, 290);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // dataGridViewScoresEquipe
            // 
            this.dataGridViewScoresEquipe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewScoresEquipe.Location = new System.Drawing.Point(4, 4);
            this.dataGridViewScoresEquipe.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewScoresEquipe.Name = "dataGridViewScoresEquipe";
            this.dataGridViewScoresEquipe.RowHeadersWidth = 51;
            this.dataGridViewScoresEquipe.Size = new System.Drawing.Size(1509, 284);
            this.dataGridViewScoresEquipe.TabIndex = 0;
            // 
            // btnRetour
            // 
            this.btnRetour.AutoSize = true;
            this.btnRetour.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnRetour.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnRetour.Location = new System.Drawing.Point(977, 473);
            this.btnRetour.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRetour.Name = "btnRetour";
            this.btnRetour.Size = new System.Drawing.Size(146, 29);
            this.btnRetour.TabIndex = 49;
            this.btnRetour.Text = "Retour à l\'acceuille";
            this.btnRetour.UseVisualStyleBackColor = true;
            this.btnRetour.Click += new System.EventHandler(this.btnRetour_Click);
            // 
            // Round
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1567, 1033);
            this.Controls.Add(this.splitContainer1);
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Round";
            this.Text = "Round";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Round_FormClosing);
            this.Load += new System.EventHandler(this.Round_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel1.PerformLayout();
            this.splitContainer3.Panel2.ResumeLayout(false);
            this.splitContainer3.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewScoresEquipe)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.RichTextBox richTextBoxResultats;
        private System.Windows.Forms.Label lblGrilleResultat;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.Label lblEquipeSuivante;
        private System.Windows.Forms.Label lblEquipeEncours;
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.Label lblNumVache;
        private System.Windows.Forms.Label lblAnnoncePremiereVache;
        private System.Windows.Forms.Button btnEquipeSuivante;
        private System.Windows.Forms.Button btnValidationResultats;
        private System.Windows.Forms.Button btnMauvaiseVache;
        private System.Windows.Forms.Button btnBonneVache;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label lblNomEquipeSuivante;
        private System.Windows.Forms.Label lblNomEquipeEnCours;
        private System.Windows.Forms.Label lblClassement;
        private System.Windows.Forms.DataGridView dataGridViewScoresEquipe;
        private System.Windows.Forms.Button btnLancer;
        private System.Windows.Forms.ComboBox cmbBoxNumRound;
        private System.Windows.Forms.ComboBox cmbBoxSelectEpreuve;
        private System.Windows.Forms.Button btnRetour;
    }
}