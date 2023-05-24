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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.dataGridViewListeEquipe = new System.Windows.Forms.DataGridView();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.btnSupprEquipe = new System.Windows.Forms.Button();
            this.btnAjouterEquipe = new System.Windows.Forms.Button();
            this.btnCreerEpreuve = new System.Windows.Forms.Button();
            this.checkBoxPayé = new System.Windows.Forms.CheckBox();
            this.txtBoxInscription = new System.Windows.Forms.TextBox();
            this.btnImporterOrdreDePassage = new System.Windows.Forms.Button();
            this.btnDesinscrire = new System.Windows.Forms.Button();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.btnInscription = new System.Windows.Forms.Button();
            this.lblDate = new System.Windows.Forms.Label();
            this.cmbBoxLieu = new System.Windows.Forms.ComboBox();
            this.lblNomLieu = new System.Windows.Forms.Label();
            this.txtBoxNomEpreuve = new System.Windows.Forms.TextBox();
            this.btnLancerUnRound = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.lblNomEpreuve = new System.Windows.Forms.Label();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.dataGridViewEquipeInscrite = new System.Windows.Forms.DataGridView();
            this.lblListeInscrit = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListeEquipe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEquipeInscrite)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(2);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.AutoScroll = true;
            this.splitContainer1.Panel1.Controls.Add(this.btnSupprEquipe);
            this.splitContainer1.Panel1.Controls.Add(this.flowLayoutPanel1);
            this.splitContainer1.Panel1.Controls.Add(this.btnAjouterEquipe);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(1347, 706);
            this.splitContainer1.SplitterDistance = 649;
            this.splitContainer1.SplitterWidth = 3;
            this.splitContainer1.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.flowLayoutPanel1.Controls.Add(this.dataGridViewListeEquipe);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(18, 29);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(564, 605);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // dataGridViewListeEquipe
            // 
            this.dataGridViewListeEquipe.AllowUserToOrderColumns = true;
            this.dataGridViewListeEquipe.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridViewListeEquipe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewListeEquipe.Location = new System.Drawing.Point(2, 2);
            this.dataGridViewListeEquipe.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewListeEquipe.Name = "dataGridViewListeEquipe";
            this.dataGridViewListeEquipe.RowHeadersWidth = 51;
            this.dataGridViewListeEquipe.RowTemplate.Height = 24;
            this.dataGridViewListeEquipe.Size = new System.Drawing.Size(564, 601);
            this.dataGridViewListeEquipe.TabIndex = 0;
            // 
            // splitContainer2
            // 
            this.splitContainer2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Margin = new System.Windows.Forms.Padding(2);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.btnCreerEpreuve);
            this.splitContainer2.Panel1.Controls.Add(this.checkBoxPayé);
            this.splitContainer2.Panel1.Controls.Add(this.lblNomEpreuve);
            this.splitContainer2.Panel1.Controls.Add(this.txtBoxInscription);
            this.splitContainer2.Panel1.Controls.Add(this.button1);
            this.splitContainer2.Panel1.Controls.Add(this.btnImporterOrdreDePassage);
            this.splitContainer2.Panel1.Controls.Add(this.btnLancerUnRound);
            this.splitContainer2.Panel1.Controls.Add(this.btnDesinscrire);
            this.splitContainer2.Panel1.Controls.Add(this.txtBoxNomEpreuve);
            this.splitContainer2.Panel1.Controls.Add(this.dateTimePicker);
            this.splitContainer2.Panel1.Controls.Add(this.lblNomLieu);
            this.splitContainer2.Panel1.Controls.Add(this.btnInscription);
            this.splitContainer2.Panel1.Controls.Add(this.cmbBoxLieu);
            this.splitContainer2.Panel1.Controls.Add(this.lblDate);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.lblListeInscrit);
            this.splitContainer2.Panel2.Controls.Add(this.flowLayoutPanel2);
            this.splitContainer2.Size = new System.Drawing.Size(695, 706);
            this.splitContainer2.SplitterDistance = 460;
            this.splitContainer2.SplitterWidth = 3;
            this.splitContainer2.TabIndex = 0;
            // 
            // btnSupprEquipe
            // 
            this.btnSupprEquipe.AutoSize = true;
            this.btnSupprEquipe.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSupprEquipe.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnSupprEquipe.Location = new System.Drawing.Point(355, 651);
            this.btnSupprEquipe.Margin = new System.Windows.Forms.Padding(2);
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
            this.btnAjouterEquipe.Location = new System.Drawing.Point(76, 651);
            this.btnAjouterEquipe.Margin = new System.Windows.Forms.Padding(2);
            this.btnAjouterEquipe.Name = "btnAjouterEquipe";
            this.btnAjouterEquipe.Size = new System.Drawing.Size(167, 31);
            this.btnAjouterEquipe.TabIndex = 7;
            this.btnAjouterEquipe.Text = "Ajouter une equipe";
            this.btnAjouterEquipe.UseVisualStyleBackColor = true;
            this.btnAjouterEquipe.Click += new System.EventHandler(this.btnAjouterEquipe_Click);
            // 
            // btnCreerEpreuve
            // 
            this.btnCreerEpreuve.AutoSize = true;
            this.btnCreerEpreuve.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCreerEpreuve.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.btnCreerEpreuve.Location = new System.Drawing.Point(182, 153);
            this.btnCreerEpreuve.Margin = new System.Windows.Forms.Padding(2);
            this.btnCreerEpreuve.Name = "btnCreerEpreuve";
            this.btnCreerEpreuve.Size = new System.Drawing.Size(290, 40);
            this.btnCreerEpreuve.TabIndex = 25;
            this.btnCreerEpreuve.Text = "Creer la Nouvelle epreuve";
            this.btnCreerEpreuve.UseVisualStyleBackColor = true;
            this.btnCreerEpreuve.Click += new System.EventHandler(this.btnCreerEpreuve_Click);
            // 
            // checkBoxPayé
            // 
            this.checkBoxPayé.AutoSize = true;
            this.checkBoxPayé.Enabled = false;
            this.checkBoxPayé.Location = new System.Drawing.Point(504, 222);
            this.checkBoxPayé.Name = "checkBoxPayé";
            this.checkBoxPayé.Size = new System.Drawing.Size(135, 17);
            this.checkBoxPayé.TabIndex = 24;
            this.checkBoxPayé.Text = "L\'equipe a-t-elle payé ?";
            this.checkBoxPayé.UseVisualStyleBackColor = true;
            // 
            // txtBoxInscription
            // 
            this.txtBoxInscription.Enabled = false;
            this.txtBoxInscription.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxInscription.Location = new System.Drawing.Point(167, 211);
            this.txtBoxInscription.Margin = new System.Windows.Forms.Padding(2);
            this.txtBoxInscription.Name = "txtBoxInscription";
            this.txtBoxInscription.Size = new System.Drawing.Size(314, 29);
            this.txtBoxInscription.TabIndex = 23;
            this.txtBoxInscription.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnImporterOrdreDePassage
            // 
            this.btnImporterOrdreDePassage.AutoSize = true;
            this.btnImporterOrdreDePassage.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnImporterOrdreDePassage.Enabled = false;
            this.btnImporterOrdreDePassage.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.btnImporterOrdreDePassage.Location = new System.Drawing.Point(167, 327);
            this.btnImporterOrdreDePassage.Margin = new System.Windows.Forms.Padding(2);
            this.btnImporterOrdreDePassage.Name = "btnImporterOrdreDePassage";
            this.btnImporterOrdreDePassage.Size = new System.Drawing.Size(314, 40);
            this.btnImporterOrdreDePassage.TabIndex = 22;
            this.btnImporterOrdreDePassage.Text = "Importer l\'ordre de passage";
            this.btnImporterOrdreDePassage.UseVisualStyleBackColor = true;
            this.btnImporterOrdreDePassage.Click += new System.EventHandler(this.btnImporterOrdreDePassage_Click);
            // 
            // btnDesinscrire
            // 
            this.btnDesinscrire.AutoSize = true;
            this.btnDesinscrire.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDesinscrire.Enabled = false;
            this.btnDesinscrire.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnDesinscrire.Location = new System.Drawing.Point(392, 260);
            this.btnDesinscrire.Margin = new System.Windows.Forms.Padding(2);
            this.btnDesinscrire.Name = "btnDesinscrire";
            this.btnDesinscrire.Size = new System.Drawing.Size(194, 31);
            this.btnDesinscrire.TabIndex = 21;
            this.btnDesinscrire.Text = "Desinscrire une equipe";
            this.btnDesinscrire.UseVisualStyleBackColor = true;
            this.btnDesinscrire.Click += new System.EventHandler(this.btnDesinscrire_Click);
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.dateTimePicker.Location = new System.Drawing.Point(309, 56);
            this.dateTimePicker.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(240, 29);
            this.dateTimePicker.TabIndex = 20;
            // 
            // btnInscription
            // 
            this.btnInscription.AutoSize = true;
            this.btnInscription.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnInscription.Enabled = false;
            this.btnInscription.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnInscription.Location = new System.Drawing.Point(108, 260);
            this.btnInscription.Margin = new System.Windows.Forms.Padding(2);
            this.btnInscription.Name = "btnInscription";
            this.btnInscription.Size = new System.Drawing.Size(166, 31);
            this.btnInscription.TabIndex = 15;
            this.btnInscription.Text = "Inscrire une equipe";
            this.btnInscription.UseVisualStyleBackColor = true;
            this.btnInscription.Click += new System.EventHandler(this.btnInscription_Click);
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(104, 61);
            this.lblDate.Margin = new System.Windows.Forms.Padding(15, 2, 2, 2);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(189, 21);
            this.lblDate.TabIndex = 13;
            this.lblDate.Text = "Selectionner une date :";
            // 
            // cmbBoxLieu
            // 
            this.cmbBoxLieu.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.cmbBoxLieu.FormattingEnabled = true;
            this.cmbBoxLieu.Location = new System.Drawing.Point(309, 106);
            this.cmbBoxLieu.Margin = new System.Windows.Forms.Padding(2);
            this.cmbBoxLieu.Name = "cmbBoxLieu";
            this.cmbBoxLieu.Size = new System.Drawing.Size(240, 29);
            this.cmbBoxLieu.TabIndex = 19;
            // 
            // lblNomLieu
            // 
            this.lblNomLieu.AutoSize = true;
            this.lblNomLieu.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomLieu.Location = new System.Drawing.Point(104, 113);
            this.lblNomLieu.Margin = new System.Windows.Forms.Padding(15, 2, 2, 2);
            this.lblNomLieu.Name = "lblNomLieu";
            this.lblNomLieu.Size = new System.Drawing.Size(114, 21);
            this.lblNomLieu.TabIndex = 18;
            this.lblNomLieu.Text = "Nom du lieu :";
            // 
            // txtBoxNomEpreuve
            // 
            this.txtBoxNomEpreuve.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxNomEpreuve.Location = new System.Drawing.Point(309, 12);
            this.txtBoxNomEpreuve.Margin = new System.Windows.Forms.Padding(2);
            this.txtBoxNomEpreuve.Name = "txtBoxNomEpreuve";
            this.txtBoxNomEpreuve.Size = new System.Drawing.Size(240, 29);
            this.txtBoxNomEpreuve.TabIndex = 17;
            // 
            // btnLancerUnRound
            // 
            this.btnLancerUnRound.AutoSize = true;
            this.btnLancerUnRound.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnLancerUnRound.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.btnLancerUnRound.Location = new System.Drawing.Point(232, 400);
            this.btnLancerUnRound.Margin = new System.Windows.Forms.Padding(2);
            this.btnLancerUnRound.Name = "btnLancerUnRound";
            this.btnLancerUnRound.Size = new System.Drawing.Size(191, 40);
            this.btnLancerUnRound.TabIndex = 16;
            this.btnLancerUnRound.Text = "Lancer un round";
            this.btnLancerUnRound.UseVisualStyleBackColor = true;
            this.btnLancerUnRound.Click += new System.EventHandler(this.btnLancerUnRound_Click);
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button1.BackColor = System.Drawing.SystemColors.Control;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.button1.Location = new System.Drawing.Point(563, 109);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 25);
            this.button1.TabIndex = 14;
            this.button1.Text = "Nouveau lieu";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblNomEpreuve
            // 
            this.lblNomEpreuve.AutoSize = true;
            this.lblNomEpreuve.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomEpreuve.Location = new System.Drawing.Point(104, 17);
            this.lblNomEpreuve.Margin = new System.Windows.Forms.Padding(15, 2, 2, 2);
            this.lblNomEpreuve.Name = "lblNomEpreuve";
            this.lblNomEpreuve.Size = new System.Drawing.Size(158, 21);
            this.lblNomEpreuve.TabIndex = 12;
            this.lblNomEpreuve.Text = "Nom de l\'epreuve :";
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.flowLayoutPanel2.Controls.Add(this.dataGridViewEquipeInscrite);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(49, 45);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(615, 163);
            this.flowLayoutPanel2.TabIndex = 0;
            // 
            // dataGridViewEquipeInscrite
            // 
            this.dataGridViewEquipeInscrite.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEquipeInscrite.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewEquipeInscrite.Name = "dataGridViewEquipeInscrite";
            this.dataGridViewEquipeInscrite.Size = new System.Drawing.Size(612, 160);
            this.dataGridViewEquipeInscrite.TabIndex = 0;
            // 
            // lblListeInscrit
            // 
            this.lblListeInscrit.AutoSize = true;
            this.lblListeInscrit.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListeInscrit.Location = new System.Drawing.Point(256, 19);
            this.lblListeInscrit.Margin = new System.Windows.Forms.Padding(15, 2, 2, 2);
            this.lblListeInscrit.Name = "lblListeInscrit";
            this.lblListeInscrit.Size = new System.Drawing.Size(224, 21);
            this.lblListeInscrit.TabIndex = 26;
            this.lblListeInscrit.Text = "Nom des équipes inscrites :";
            // 
            // Lobby
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1347, 706);
            this.Controls.Add(this.splitContainer1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Lobby";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Lobby_Load_1);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListeEquipe)).EndInit();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEquipeInscrite)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Button btnAjouterEquipe;
        private System.Windows.Forms.Button btnDesinscrire;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Button btnInscription;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.ComboBox cmbBoxLieu;
        private System.Windows.Forms.Label lblNomLieu;
        private System.Windows.Forms.TextBox txtBoxNomEpreuve;
        private System.Windows.Forms.Button btnLancerUnRound;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblNomEpreuve;
        private System.Windows.Forms.Button btnSupprEquipe;
        private System.Windows.Forms.Button btnImporterOrdreDePassage;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.DataGridView dataGridViewListeEquipe;
        private System.Windows.Forms.TextBox txtBoxInscription;
        private System.Windows.Forms.CheckBox checkBoxPayé;
        private System.Windows.Forms.Button btnCreerEpreuve;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Label lblListeInscrit;
        private System.Windows.Forms.DataGridView dataGridViewEquipeInscrite;
    }
}