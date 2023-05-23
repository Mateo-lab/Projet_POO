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
            this.btnImporterOrdreDePassage = new System.Windows.Forms.Button();
            this.btnDesinscrire = new System.Windows.Forms.Button();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.button3 = new System.Windows.Forms.Button();
            this.lblDate = new System.Windows.Forms.Label();
            this.cmbBoxLieu = new System.Windows.Forms.ComboBox();
            this.lblNomLieu = new System.Windows.Forms.Label();
            this.txtBoxNomEquipe = new System.Windows.Forms.TextBox();
            this.btnLancerUnRound = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.lblNomEpreuve = new System.Windows.Forms.Label();
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
            this.splitContainer1.Panel1.Controls.Add(this.flowLayoutPanel1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(1314, 730);
            this.splitContainer1.SplitterDistance = 634;
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
            this.flowLayoutPanel1.Size = new System.Drawing.Size(566, 654);
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
            this.dataGridViewListeEquipe.Size = new System.Drawing.Size(564, 652);
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
            this.splitContainer2.Panel1.Controls.Add(this.btnSupprEquipe);
            this.splitContainer2.Panel1.Controls.Add(this.btnAjouterEquipe);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.btnImporterOrdreDePassage);
            this.splitContainer2.Panel2.Controls.Add(this.btnDesinscrire);
            this.splitContainer2.Panel2.Controls.Add(this.dateTimePicker);
            this.splitContainer2.Panel2.Controls.Add(this.button3);
            this.splitContainer2.Panel2.Controls.Add(this.lblDate);
            this.splitContainer2.Panel2.Controls.Add(this.cmbBoxLieu);
            this.splitContainer2.Panel2.Controls.Add(this.lblNomLieu);
            this.splitContainer2.Panel2.Controls.Add(this.txtBoxNomEquipe);
            this.splitContainer2.Panel2.Controls.Add(this.btnLancerUnRound);
            this.splitContainer2.Panel2.Controls.Add(this.button1);
            this.splitContainer2.Panel2.Controls.Add(this.lblNomEpreuve);
            this.splitContainer2.Size = new System.Drawing.Size(677, 730);
            this.splitContainer2.SplitterDistance = 195;
            this.splitContainer2.SplitterWidth = 3;
            this.splitContainer2.TabIndex = 0;
            this.splitContainer2.SplitterMoved += new System.Windows.Forms.SplitterEventHandler(this.splitContainer2_SplitterMoved);
            // 
            // btnSupprEquipe
            // 
            this.btnSupprEquipe.AutoSize = true;
            this.btnSupprEquipe.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSupprEquipe.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnSupprEquipe.Location = new System.Drawing.Point(386, 70);
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
            this.btnAjouterEquipe.Location = new System.Drawing.Point(127, 70);
            this.btnAjouterEquipe.Margin = new System.Windows.Forms.Padding(2);
            this.btnAjouterEquipe.Name = "btnAjouterEquipe";
            this.btnAjouterEquipe.Size = new System.Drawing.Size(167, 31);
            this.btnAjouterEquipe.TabIndex = 7;
            this.btnAjouterEquipe.Text = "Ajouter une equipe";
            this.btnAjouterEquipe.UseVisualStyleBackColor = true;
            this.btnAjouterEquipe.Click += new System.EventHandler(this.btnAjouterEquipe_Click);
            // 
            // btnImporterOrdreDePassage
            // 
            this.btnImporterOrdreDePassage.AutoSize = true;
            this.btnImporterOrdreDePassage.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnImporterOrdreDePassage.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.btnImporterOrdreDePassage.Location = new System.Drawing.Point(162, 263);
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
            this.btnDesinscrire.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnDesinscrire.Location = new System.Drawing.Point(344, 199);
            this.btnDesinscrire.Margin = new System.Windows.Forms.Padding(2);
            this.btnDesinscrire.Name = "btnDesinscrire";
            this.btnDesinscrire.Size = new System.Drawing.Size(194, 31);
            this.btnDesinscrire.TabIndex = 21;
            this.btnDesinscrire.Text = "Desinscrire une equipe";
            this.btnDesinscrire.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.dateTimePicker.Location = new System.Drawing.Point(303, 79);
            this.dateTimePicker.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(240, 29);
            this.dateTimePicker.TabIndex = 20;
            // 
            // button3
            // 
            this.button3.AutoSize = true;
            this.button3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.button3.Location = new System.Drawing.Point(96, 199);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(166, 31);
            this.button3.TabIndex = 15;
            this.button3.Text = "Inscrire une equipe";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(98, 84);
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
            this.cmbBoxLieu.Location = new System.Drawing.Point(303, 129);
            this.cmbBoxLieu.Margin = new System.Windows.Forms.Padding(2);
            this.cmbBoxLieu.Name = "cmbBoxLieu";
            this.cmbBoxLieu.Size = new System.Drawing.Size(240, 29);
            this.cmbBoxLieu.TabIndex = 19;
            // 
            // lblNomLieu
            // 
            this.lblNomLieu.AutoSize = true;
            this.lblNomLieu.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomLieu.Location = new System.Drawing.Point(98, 136);
            this.lblNomLieu.Margin = new System.Windows.Forms.Padding(15, 2, 2, 2);
            this.lblNomLieu.Name = "lblNomLieu";
            this.lblNomLieu.Size = new System.Drawing.Size(114, 21);
            this.lblNomLieu.TabIndex = 18;
            this.lblNomLieu.Text = "Nom du lieu :";
            // 
            // txtBoxNomEquipe
            // 
            this.txtBoxNomEquipe.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxNomEquipe.Location = new System.Drawing.Point(303, 35);
            this.txtBoxNomEquipe.Margin = new System.Windows.Forms.Padding(2);
            this.txtBoxNomEquipe.Name = "txtBoxNomEquipe";
            this.txtBoxNomEquipe.Size = new System.Drawing.Size(240, 29);
            this.txtBoxNomEquipe.TabIndex = 17;
            // 
            // btnLancerUnRound
            // 
            this.btnLancerUnRound.AutoSize = true;
            this.btnLancerUnRound.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnLancerUnRound.Enabled = false;
            this.btnLancerUnRound.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.btnLancerUnRound.Location = new System.Drawing.Point(219, 330);
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
            this.button1.Location = new System.Drawing.Point(459, 163);
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
            this.lblNomEpreuve.Location = new System.Drawing.Point(98, 40);
            this.lblNomEpreuve.Margin = new System.Windows.Forms.Padding(15, 2, 2, 2);
            this.lblNomEpreuve.Name = "lblNomEpreuve";
            this.lblNomEpreuve.Size = new System.Drawing.Size(158, 21);
            this.lblNomEpreuve.TabIndex = 12;
            this.lblNomEpreuve.Text = "Nom de l\'epreuve :";
            // 
            // Lobby
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1314, 730);
            this.Controls.Add(this.splitContainer1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Lobby";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Lobby_Load_1);
            this.splitContainer1.Panel1.ResumeLayout(false);
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Button btnAjouterEquipe;
        private System.Windows.Forms.Button btnDesinscrire;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.ComboBox cmbBoxLieu;
        private System.Windows.Forms.Label lblNomLieu;
        private System.Windows.Forms.TextBox txtBoxNomEquipe;
        private System.Windows.Forms.Button btnLancerUnRound;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblNomEpreuve;
        private System.Windows.Forms.Button btnSupprEquipe;
        private System.Windows.Forms.Button btnImporterOrdreDePassage;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.DataGridView dataGridViewListeEquipe;
    }
}