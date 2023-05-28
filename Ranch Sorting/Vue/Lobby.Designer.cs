namespace Ranch_Sorting.Vue
{
    partial class Lobby
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
            this.dataGridViewListeEquipe = new System.Windows.Forms.DataGridView();
            this.lblListeEquipe = new System.Windows.Forms.Label();
            this.btnSupprEquipe = new System.Windows.Forms.Button();
            this.btnAjouterEquipe = new System.Windows.Forms.Button();
            this.btnListeInscrit = new System.Windows.Forms.Button();
            this.btnRetour = new System.Windows.Forms.Button();
            this.btnCreeUneNouvelleEpreuve = new System.Windows.Forms.Button();
            this.btnVisualiserEpreeuveExistante = new System.Windows.Forms.Button();
            this.btnLancerEpreuve = new System.Windows.Forms.Button();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.dataGridViewEquipeInscrite = new System.Windows.Forms.DataGridView();
            this.lblListeInscrit = new System.Windows.Forms.Label();
            this.numericUpDownNbrRound = new System.Windows.Forms.NumericUpDown();
            this.lblNmbrRound = new System.Windows.Forms.Label();
            this.btnSupprimerUnLieu = new System.Windows.Forms.Button();
            this.btnCreerEpreuve = new System.Windows.Forms.Button();
            this.checkBoxPayé = new System.Windows.Forms.CheckBox();
            this.lblNomEpreuve = new System.Windows.Forms.Label();
            this.txtBoxInscription = new System.Windows.Forms.TextBox();
            this.btnNouveauLieu = new System.Windows.Forms.Button();
            this.btnDesinscrire = new System.Windows.Forms.Button();
            this.txtBoxNomEpreuve = new System.Windows.Forms.TextBox();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.lblNomLieu = new System.Windows.Forms.Label();
            this.btnInscription = new System.Windows.Forms.Button();
            this.cmbBoxLieu = new System.Windows.Forms.ComboBox();
            this.lblDate = new System.Windows.Forms.Label();
            this.dataGridViewListeEpreuve = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListeEquipe)).BeginInit();
            this.flowLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEquipeInscrite)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNbrRound)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListeEpreuve)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.AutoScroll = true;
            this.splitContainer1.Panel1.Controls.Add(this.dataGridViewListeEquipe);
            this.splitContainer1.Panel1.Controls.Add(this.lblListeEquipe);
            this.splitContainer1.Panel1.Controls.Add(this.btnSupprEquipe);
            this.splitContainer1.Panel1.Controls.Add(this.btnAjouterEquipe);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.btnListeInscrit);
            this.splitContainer1.Panel2.Controls.Add(this.btnRetour);
            this.splitContainer1.Panel2.Controls.Add(this.btnCreeUneNouvelleEpreuve);
            this.splitContainer1.Panel2.Controls.Add(this.btnVisualiserEpreeuveExistante);
            this.splitContainer1.Panel2.Controls.Add(this.btnLancerEpreuve);
            this.splitContainer1.Panel2.Controls.Add(this.flowLayoutPanel2);
            this.splitContainer1.Panel2.Controls.Add(this.lblListeInscrit);
            this.splitContainer1.Panel2.Controls.Add(this.numericUpDownNbrRound);
            this.splitContainer1.Panel2.Controls.Add(this.lblNmbrRound);
            this.splitContainer1.Panel2.Controls.Add(this.btnSupprimerUnLieu);
            this.splitContainer1.Panel2.Controls.Add(this.btnCreerEpreuve);
            this.splitContainer1.Panel2.Controls.Add(this.checkBoxPayé);
            this.splitContainer1.Panel2.Controls.Add(this.lblNomEpreuve);
            this.splitContainer1.Panel2.Controls.Add(this.txtBoxInscription);
            this.splitContainer1.Panel2.Controls.Add(this.btnNouveauLieu);
            this.splitContainer1.Panel2.Controls.Add(this.btnDesinscrire);
            this.splitContainer1.Panel2.Controls.Add(this.txtBoxNomEpreuve);
            this.splitContainer1.Panel2.Controls.Add(this.dateTimePicker);
            this.splitContainer1.Panel2.Controls.Add(this.lblNomLieu);
            this.splitContainer1.Panel2.Controls.Add(this.btnInscription);
            this.splitContainer1.Panel2.Controls.Add(this.cmbBoxLieu);
            this.splitContainer1.Panel2.Controls.Add(this.lblDate);
            this.splitContainer1.Panel2.Controls.Add(this.dataGridViewListeEpreuve);
            this.splitContainer1.Size = new System.Drawing.Size(1346, 782);
            this.splitContainer1.SplitterDistance = 640;
            this.splitContainer1.SplitterWidth = 3;
            this.splitContainer1.TabIndex = 0;
            // 
            // dataGridViewListeEquipe
            // 
            this.dataGridViewListeEquipe.AllowUserToAddRows = false;
            this.dataGridViewListeEquipe.AllowUserToDeleteRows = false;
            this.dataGridViewListeEquipe.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewListeEquipe.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridViewListeEquipe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewListeEquipe.Location = new System.Drawing.Point(32, 58);
            this.dataGridViewListeEquipe.Margin = new System.Windows.Forms.Padding(0);
            this.dataGridViewListeEquipe.Name = "dataGridViewListeEquipe";
            this.dataGridViewListeEquipe.ReadOnly = true;
            this.dataGridViewListeEquipe.RowHeadersWidth = 51;
            this.dataGridViewListeEquipe.RowTemplate.Height = 24;
            this.dataGridViewListeEquipe.Size = new System.Drawing.Size(513, 637);
            this.dataGridViewListeEquipe.TabIndex = 0;
            // 
            // lblListeEquipe
            // 
            this.lblListeEquipe.AutoSize = true;
            this.lblListeEquipe.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListeEquipe.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblListeEquipe.Location = new System.Drawing.Point(183, 25);
            this.lblListeEquipe.Margin = new System.Windows.Forms.Padding(15, 2, 2, 2);
            this.lblListeEquipe.Name = "lblListeEquipe";
            this.lblListeEquipe.Size = new System.Drawing.Size(222, 21);
            this.lblListeEquipe.TabIndex = 44;
            this.lblListeEquipe.Text = "Liste des équipes connues :";
            this.lblListeEquipe.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnSupprEquipe
            // 
            this.btnSupprEquipe.AutoSize = true;
            this.btnSupprEquipe.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSupprEquipe.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnSupprEquipe.Location = new System.Drawing.Point(326, 716);
            this.btnSupprEquipe.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSupprEquipe.Name = "btnSupprEquipe";
            this.btnSupprEquipe.Size = new System.Drawing.Size(190, 31);
            this.btnSupprEquipe.TabIndex = 8;
            this.btnSupprEquipe.Text = "Supprimer une equipe";
            this.btnSupprEquipe.UseVisualStyleBackColor = true;
            this.btnSupprEquipe.Click += new System.EventHandler(this.btnSupprEquipe_Click);
            // 
            // btnAjouterEquipe
            // 
            this.btnAjouterEquipe.AutoSize = true;
            this.btnAjouterEquipe.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAjouterEquipe.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnAjouterEquipe.Location = new System.Drawing.Point(67, 716);
            this.btnAjouterEquipe.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAjouterEquipe.Name = "btnAjouterEquipe";
            this.btnAjouterEquipe.Size = new System.Drawing.Size(167, 31);
            this.btnAjouterEquipe.TabIndex = 7;
            this.btnAjouterEquipe.Text = "Ajouter une equipe";
            this.btnAjouterEquipe.UseVisualStyleBackColor = true;
            this.btnAjouterEquipe.Click += new System.EventHandler(this.btnAjouterEquipe_Click);
            // 
            // btnListeInscrit
            // 
            this.btnListeInscrit.AutoSize = true;
            this.btnListeInscrit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnListeInscrit.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.btnListeInscrit.Location = new System.Drawing.Point(189, 235);
            this.btnListeInscrit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnListeInscrit.Name = "btnListeInscrit";
            this.btnListeInscrit.Size = new System.Drawing.Size(288, 40);
            this.btnListeInscrit.TabIndex = 49;
            this.btnListeInscrit.Text = "Obtenir la liste des inscrit";
            this.btnListeInscrit.UseVisualStyleBackColor = true;
            this.btnListeInscrit.Visible = false;
            this.btnListeInscrit.Click += new System.EventHandler(this.btnListeInscrit_Click);
            // 
            // btnRetour
            // 
            this.btnRetour.AutoSize = true;
            this.btnRetour.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnRetour.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnRetour.Location = new System.Drawing.Point(537, 240);
            this.btnRetour.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnRetour.Name = "btnRetour";
            this.btnRetour.Size = new System.Drawing.Size(71, 31);
            this.btnRetour.TabIndex = 48;
            this.btnRetour.Text = "Retour";
            this.btnRetour.UseVisualStyleBackColor = true;
            this.btnRetour.Visible = false;
            this.btnRetour.Click += new System.EventHandler(this.btnRetour_Click);
            // 
            // btnCreeUneNouvelleEpreuve
            // 
            this.btnCreeUneNouvelleEpreuve.AutoSize = true;
            this.btnCreeUneNouvelleEpreuve.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCreeUneNouvelleEpreuve.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.btnCreeUneNouvelleEpreuve.Location = new System.Drawing.Point(189, 124);
            this.btnCreeUneNouvelleEpreuve.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCreeUneNouvelleEpreuve.Name = "btnCreeUneNouvelleEpreuve";
            this.btnCreeUneNouvelleEpreuve.Size = new System.Drawing.Size(306, 40);
            this.btnCreeUneNouvelleEpreuve.TabIndex = 47;
            this.btnCreeUneNouvelleEpreuve.Text = "Créer une nouvelle épreuve";
            this.btnCreeUneNouvelleEpreuve.UseVisualStyleBackColor = true;
            this.btnCreeUneNouvelleEpreuve.Click += new System.EventHandler(this.btnCreeUneNouvelleEpreuve_Click);
            // 
            // btnVisualiserEpreeuveExistante
            // 
            this.btnVisualiserEpreeuveExistante.AutoSize = true;
            this.btnVisualiserEpreeuveExistante.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnVisualiserEpreeuveExistante.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.btnVisualiserEpreeuveExistante.Location = new System.Drawing.Point(166, 184);
            this.btnVisualiserEpreeuveExistante.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnVisualiserEpreeuveExistante.Name = "btnVisualiserEpreeuveExistante";
            this.btnVisualiserEpreeuveExistante.Size = new System.Drawing.Size(357, 40);
            this.btnVisualiserEpreeuveExistante.TabIndex = 46;
            this.btnVisualiserEpreeuveExistante.Text = "Visualiser une épreuve existante";
            this.btnVisualiserEpreeuveExistante.UseVisualStyleBackColor = true;
            this.btnVisualiserEpreeuveExistante.Click += new System.EventHandler(this.btnSelectionEpreeuveExistante_Click);
            // 
            // btnLancerEpreuve
            // 
            this.btnLancerEpreuve.AutoSize = true;
            this.btnLancerEpreuve.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnLancerEpreuve.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.btnLancerEpreuve.Location = new System.Drawing.Point(238, 721);
            this.btnLancerEpreuve.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnLancerEpreuve.Name = "btnLancerEpreuve";
            this.btnLancerEpreuve.Size = new System.Drawing.Size(225, 40);
            this.btnLancerEpreuve.TabIndex = 16;
            this.btnLancerEpreuve.Text = "Lancer une epreuve";
            this.btnLancerEpreuve.UseVisualStyleBackColor = true;
            this.btnLancerEpreuve.Click += new System.EventHandler(this.btnLancerUnRound_Click);
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.flowLayoutPanel2.Controls.Add(this.dataGridViewEquipeInscrite);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(30, 462);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(640, 218);
            this.flowLayoutPanel2.TabIndex = 29;
            // 
            // dataGridViewEquipeInscrite
            // 
            this.dataGridViewEquipeInscrite.AllowUserToAddRows = false;
            this.dataGridViewEquipeInscrite.AllowUserToDeleteRows = false;
            this.dataGridViewEquipeInscrite.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewEquipeInscrite.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEquipeInscrite.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewEquipeInscrite.Margin = new System.Windows.Forms.Padding(0);
            this.dataGridViewEquipeInscrite.Name = "dataGridViewEquipeInscrite";
            this.dataGridViewEquipeInscrite.ReadOnly = true;
            this.dataGridViewEquipeInscrite.RowHeadersWidth = 51;
            this.dataGridViewEquipeInscrite.Size = new System.Drawing.Size(640, 218);
            this.dataGridViewEquipeInscrite.TabIndex = 0;
            // 
            // lblListeInscrit
            // 
            this.lblListeInscrit.AutoSize = true;
            this.lblListeInscrit.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListeInscrit.Location = new System.Drawing.Point(222, 435);
            this.lblListeInscrit.Margin = new System.Windows.Forms.Padding(15, 2, 2, 2);
            this.lblListeInscrit.Name = "lblListeInscrit";
            this.lblListeInscrit.Size = new System.Drawing.Size(224, 21);
            this.lblListeInscrit.TabIndex = 43;
            this.lblListeInscrit.Text = "Nom des équipes inscrites :";
            // 
            // numericUpDownNbrRound
            // 
            this.numericUpDownNbrRound.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownNbrRound.Location = new System.Drawing.Point(315, 192);
            this.numericUpDownNbrRound.Maximum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericUpDownNbrRound.Name = "numericUpDownNbrRound";
            this.numericUpDownNbrRound.Size = new System.Drawing.Size(209, 29);
            this.numericUpDownNbrRound.TabIndex = 45;
            this.numericUpDownNbrRound.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDownNbrRound.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownNbrRound.Visible = false;
            // 
            // lblNmbrRound
            // 
            this.lblNmbrRound.AutoSize = true;
            this.lblNmbrRound.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNmbrRound.Location = new System.Drawing.Point(79, 192);
            this.lblNmbrRound.Margin = new System.Windows.Forms.Padding(15, 2, 2, 2);
            this.lblNmbrRound.Name = "lblNmbrRound";
            this.lblNmbrRound.Size = new System.Drawing.Size(231, 21);
            this.lblNmbrRound.TabIndex = 44;
            this.lblNmbrRound.Text = "Nombre de Round  (max 2): ";
            this.lblNmbrRound.Visible = false;
            // 
            // btnSupprimerUnLieu
            // 
            this.btnSupprimerUnLieu.AutoSize = true;
            this.btnSupprimerUnLieu.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSupprimerUnLieu.BackColor = System.Drawing.SystemColors.Control;
            this.btnSupprimerUnLieu.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnSupprimerUnLieu.Location = new System.Drawing.Point(537, 165);
            this.btnSupprimerUnLieu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSupprimerUnLieu.Name = "btnSupprimerUnLieu";
            this.btnSupprimerUnLieu.Size = new System.Drawing.Size(116, 25);
            this.btnSupprimerUnLieu.TabIndex = 42;
            this.btnSupprimerUnLieu.Text = "Supprimer un lieu";
            this.btnSupprimerUnLieu.UseVisualStyleBackColor = true;
            this.btnSupprimerUnLieu.Visible = false;
            this.btnSupprimerUnLieu.Click += new System.EventHandler(this.btnSupprimerUnLieu_Click);
            // 
            // btnCreerEpreuve
            // 
            this.btnCreerEpreuve.AutoSize = true;
            this.btnCreerEpreuve.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCreerEpreuve.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.btnCreerEpreuve.Location = new System.Drawing.Point(189, 235);
            this.btnCreerEpreuve.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCreerEpreuve.Name = "btnCreerEpreuve";
            this.btnCreerEpreuve.Size = new System.Drawing.Size(290, 40);
            this.btnCreerEpreuve.TabIndex = 41;
            this.btnCreerEpreuve.Text = "Creer la Nouvelle epreuve";
            this.btnCreerEpreuve.UseVisualStyleBackColor = true;
            this.btnCreerEpreuve.Visible = false;
            this.btnCreerEpreuve.Click += new System.EventHandler(this.btnCreerEpreuve_Click);
            // 
            // checkBoxPayé
            // 
            this.checkBoxPayé.AutoSize = true;
            this.checkBoxPayé.Enabled = false;
            this.checkBoxPayé.Location = new System.Drawing.Point(494, 335);
            this.checkBoxPayé.Name = "checkBoxPayé";
            this.checkBoxPayé.Size = new System.Drawing.Size(135, 17);
            this.checkBoxPayé.TabIndex = 40;
            this.checkBoxPayé.Text = "L\'equipe a-t-elle payé ?";
            this.checkBoxPayé.UseVisualStyleBackColor = true;
            // 
            // lblNomEpreuve
            // 
            this.lblNomEpreuve.AutoSize = true;
            this.lblNomEpreuve.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomEpreuve.Location = new System.Drawing.Point(79, 58);
            this.lblNomEpreuve.Margin = new System.Windows.Forms.Padding(15, 2, 2, 2);
            this.lblNomEpreuve.Name = "lblNomEpreuve";
            this.lblNomEpreuve.Size = new System.Drawing.Size(158, 21);
            this.lblNomEpreuve.TabIndex = 30;
            this.lblNomEpreuve.Text = "Nom de l\'epreuve :";
            this.lblNomEpreuve.Visible = false;
            // 
            // txtBoxInscription
            // 
            this.txtBoxInscription.Enabled = false;
            this.txtBoxInscription.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxInscription.Location = new System.Drawing.Point(160, 323);
            this.txtBoxInscription.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtBoxInscription.Name = "txtBoxInscription";
            this.txtBoxInscription.Size = new System.Drawing.Size(314, 29);
            this.txtBoxInscription.TabIndex = 39;
            this.txtBoxInscription.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnNouveauLieu
            // 
            this.btnNouveauLieu.AutoSize = true;
            this.btnNouveauLieu.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnNouveauLieu.BackColor = System.Drawing.SystemColors.Control;
            this.btnNouveauLieu.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnNouveauLieu.Location = new System.Drawing.Point(537, 136);
            this.btnNouveauLieu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnNouveauLieu.Name = "btnNouveauLieu";
            this.btnNouveauLieu.Size = new System.Drawing.Size(90, 25);
            this.btnNouveauLieu.TabIndex = 32;
            this.btnNouveauLieu.Text = "Nouveau lieu";
            this.btnNouveauLieu.UseVisualStyleBackColor = true;
            this.btnNouveauLieu.Visible = false;
            this.btnNouveauLieu.Click += new System.EventHandler(this.btnNouveauLieu_Click);
            // 
            // btnDesinscrire
            // 
            this.btnDesinscrire.AutoSize = true;
            this.btnDesinscrire.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDesinscrire.Enabled = false;
            this.btnDesinscrire.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnDesinscrire.Location = new System.Drawing.Point(387, 379);
            this.btnDesinscrire.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDesinscrire.Name = "btnDesinscrire";
            this.btnDesinscrire.Size = new System.Drawing.Size(194, 31);
            this.btnDesinscrire.TabIndex = 38;
            this.btnDesinscrire.Text = "Desinscrire une equipe";
            this.btnDesinscrire.UseVisualStyleBackColor = true;
            this.btnDesinscrire.Click += new System.EventHandler(this.btnDesinscrire_Click);
            // 
            // txtBoxNomEpreuve
            // 
            this.txtBoxNomEpreuve.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxNomEpreuve.Location = new System.Drawing.Point(284, 54);
            this.txtBoxNomEpreuve.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtBoxNomEpreuve.Name = "txtBoxNomEpreuve";
            this.txtBoxNomEpreuve.Size = new System.Drawing.Size(240, 29);
            this.txtBoxNomEpreuve.TabIndex = 34;
            this.txtBoxNomEpreuve.Visible = false;
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.dateTimePicker.Location = new System.Drawing.Point(284, 98);
            this.dateTimePicker.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(240, 29);
            this.dateTimePicker.TabIndex = 37;
            this.dateTimePicker.Visible = false;
            // 
            // lblNomLieu
            // 
            this.lblNomLieu.AutoSize = true;
            this.lblNomLieu.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomLieu.Location = new System.Drawing.Point(79, 155);
            this.lblNomLieu.Margin = new System.Windows.Forms.Padding(15, 2, 2, 2);
            this.lblNomLieu.Name = "lblNomLieu";
            this.lblNomLieu.Size = new System.Drawing.Size(114, 21);
            this.lblNomLieu.TabIndex = 35;
            this.lblNomLieu.Text = "Nom du lieu :";
            this.lblNomLieu.Visible = false;
            // 
            // btnInscription
            // 
            this.btnInscription.AutoSize = true;
            this.btnInscription.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnInscription.Enabled = false;
            this.btnInscription.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnInscription.Location = new System.Drawing.Point(105, 379);
            this.btnInscription.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnInscription.Name = "btnInscription";
            this.btnInscription.Size = new System.Drawing.Size(166, 31);
            this.btnInscription.TabIndex = 33;
            this.btnInscription.Text = "Inscrire une equipe";
            this.btnInscription.UseVisualStyleBackColor = true;
            this.btnInscription.Click += new System.EventHandler(this.btnInscription_Click);
            // 
            // cmbBoxLieu
            // 
            this.cmbBoxLieu.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.cmbBoxLieu.FormattingEnabled = true;
            this.cmbBoxLieu.Location = new System.Drawing.Point(284, 148);
            this.cmbBoxLieu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbBoxLieu.Name = "cmbBoxLieu";
            this.cmbBoxLieu.Size = new System.Drawing.Size(240, 29);
            this.cmbBoxLieu.TabIndex = 36;
            this.cmbBoxLieu.Visible = false;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(79, 103);
            this.lblDate.Margin = new System.Windows.Forms.Padding(15, 2, 2, 2);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(189, 21);
            this.lblDate.TabIndex = 31;
            this.lblDate.Text = "Selectionner une date :";
            this.lblDate.Visible = false;
            // 
            // dataGridViewListeEpreuve
            // 
            this.dataGridViewListeEpreuve.AllowUserToAddRows = false;
            this.dataGridViewListeEpreuve.AllowUserToDeleteRows = false;
            this.dataGridViewListeEpreuve.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewListeEpreuve.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewListeEpreuve.Location = new System.Drawing.Point(30, 102);
            this.dataGridViewListeEpreuve.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridViewListeEpreuve.Name = "dataGridViewListeEpreuve";
            this.dataGridViewListeEpreuve.ReadOnly = true;
            this.dataGridViewListeEpreuve.RowTemplate.Height = 24;
            this.dataGridViewListeEpreuve.Size = new System.Drawing.Size(640, 114);
            this.dataGridViewListeEpreuve.TabIndex = 50;
            this.dataGridViewListeEpreuve.Visible = false;
            // 
            // Lobby
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1346, 782);
            this.Controls.Add(this.splitContainer1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Lobby";
            this.Text = "Ranch Sorting Application";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Lobby_FormClosing);
            this.Load += new System.EventHandler(this.Lobby_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListeEquipe)).EndInit();
            this.flowLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEquipeInscrite)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNbrRound)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListeEpreuve)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button btnAjouterEquipe;
        private System.Windows.Forms.Button btnLancerEpreuve;
        private System.Windows.Forms.Button btnSupprEquipe;
        private System.Windows.Forms.DataGridView dataGridViewListeEquipe;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.DataGridView dataGridViewEquipeInscrite;
        private System.Windows.Forms.Label lblListeInscrit;
        private System.Windows.Forms.NumericUpDown numericUpDownNbrRound;
        private System.Windows.Forms.Label lblNmbrRound;
        private System.Windows.Forms.Button btnSupprimerUnLieu;
        private System.Windows.Forms.Button btnCreerEpreuve;
        private System.Windows.Forms.CheckBox checkBoxPayé;
        private System.Windows.Forms.Label lblNomEpreuve;
        private System.Windows.Forms.TextBox txtBoxInscription;
        private System.Windows.Forms.Button btnNouveauLieu;
        private System.Windows.Forms.Button btnDesinscrire;
        private System.Windows.Forms.TextBox txtBoxNomEpreuve;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Label lblNomLieu;
        private System.Windows.Forms.Button btnInscription;
        private System.Windows.Forms.ComboBox cmbBoxLieu;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Button btnVisualiserEpreeuveExistante;
        private System.Windows.Forms.Button btnCreeUneNouvelleEpreuve;
        private System.Windows.Forms.Button btnRetour;
        private System.Windows.Forms.Button btnListeInscrit;
        private System.Windows.Forms.Label lblListeEquipe;
        private System.Windows.Forms.DataGridView dataGridViewListeEpreuve;
    }
}