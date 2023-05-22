namespace Ranch_Sorting.Vue
{
    partial class Main
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
            this.btnAjouterEquipe = new System.Windows.Forms.Button();
            this.btnDesinscrire = new System.Windows.Forms.Button();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.button3 = new System.Windows.Forms.Button();
            this.lblDate = new System.Windows.Forms.Label();
            this.cmbBoxLieu = new System.Windows.Forms.ComboBox();
            this.lblNomLieu = new System.Windows.Forms.Label();
            this.txtBoxNomEquipe = new System.Windows.Forms.TextBox();
            this.btnValider = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.lblNomEpreuve = new System.Windows.Forms.Label();
            this.btnSupprEquipe = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(1157, 685);
            this.splitContainer1.SplitterDistance = 440;
            this.splitContainer1.TabIndex = 0;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
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
            this.splitContainer2.Panel2.Controls.Add(this.btnDesinscrire);
            this.splitContainer2.Panel2.Controls.Add(this.dateTimePicker);
            this.splitContainer2.Panel2.Controls.Add(this.button3);
            this.splitContainer2.Panel2.Controls.Add(this.lblDate);
            this.splitContainer2.Panel2.Controls.Add(this.cmbBoxLieu);
            this.splitContainer2.Panel2.Controls.Add(this.lblNomLieu);
            this.splitContainer2.Panel2.Controls.Add(this.txtBoxNomEquipe);
            this.splitContainer2.Panel2.Controls.Add(this.btnValider);
            this.splitContainer2.Panel2.Controls.Add(this.button1);
            this.splitContainer2.Panel2.Controls.Add(this.lblNomEpreuve);
            this.splitContainer2.Size = new System.Drawing.Size(713, 685);
            this.splitContainer2.SplitterDistance = 283;
            this.splitContainer2.TabIndex = 0;
            this.splitContainer2.SplitterMoved += new System.Windows.Forms.SplitterEventHandler(this.splitContainer2_SplitterMoved);
            // 
            // btnAjouterEquipe
            // 
            this.btnAjouterEquipe.AutoSize = true;
            this.btnAjouterEquipe.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAjouterEquipe.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnAjouterEquipe.Location = new System.Drawing.Point(66, 54);
            this.btnAjouterEquipe.Name = "btnAjouterEquipe";
            this.btnAjouterEquipe.Size = new System.Drawing.Size(204, 38);
            this.btnAjouterEquipe.TabIndex = 7;
            this.btnAjouterEquipe.Text = "Ajouter une equipe";
            this.btnAjouterEquipe.UseVisualStyleBackColor = true;
            // 
            // btnDesinscrire
            // 
            this.btnDesinscrire.AutoSize = true;
            this.btnDesinscrire.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDesinscrire.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnDesinscrire.Location = new System.Drawing.Point(389, 229);
            this.btnDesinscrire.Name = "btnDesinscrire";
            this.btnDesinscrire.Size = new System.Drawing.Size(238, 38);
            this.btnDesinscrire.TabIndex = 21;
            this.btnDesinscrire.Text = "Desinscrire une equipe";
            this.btnDesinscrire.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.dateTimePicker.Location = new System.Drawing.Point(335, 81);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(319, 34);
            this.dateTimePicker.TabIndex = 20;
            // 
            // button3
            // 
            this.button3.AutoSize = true;
            this.button3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.button3.Location = new System.Drawing.Point(59, 229);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(203, 38);
            this.button3.TabIndex = 15;
            this.button3.Text = "Inscrire une equipe";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(61, 87);
            this.lblDate.Margin = new System.Windows.Forms.Padding(20, 3, 3, 3);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(238, 28);
            this.lblDate.TabIndex = 13;
            this.lblDate.Text = "Selectionner une date :";
            // 
            // cmbBoxLieu
            // 
            this.cmbBoxLieu.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.cmbBoxLieu.FormattingEnabled = true;
            this.cmbBoxLieu.Location = new System.Drawing.Point(335, 143);
            this.cmbBoxLieu.Name = "cmbBoxLieu";
            this.cmbBoxLieu.Size = new System.Drawing.Size(319, 36);
            this.cmbBoxLieu.TabIndex = 19;
            // 
            // lblNomLieu
            // 
            this.lblNomLieu.AutoSize = true;
            this.lblNomLieu.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomLieu.Location = new System.Drawing.Point(61, 151);
            this.lblNomLieu.Margin = new System.Windows.Forms.Padding(20, 3, 3, 3);
            this.lblNomLieu.Name = "lblNomLieu";
            this.lblNomLieu.Size = new System.Drawing.Size(146, 28);
            this.lblNomLieu.TabIndex = 18;
            this.lblNomLieu.Text = "Nom du lieu :";
            // 
            // txtBoxNomEquipe
            // 
            this.txtBoxNomEquipe.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxNomEquipe.Location = new System.Drawing.Point(335, 27);
            this.txtBoxNomEquipe.Name = "txtBoxNomEquipe";
            this.txtBoxNomEquipe.Size = new System.Drawing.Size(319, 34);
            this.txtBoxNomEquipe.TabIndex = 17;
            // 
            // btnValider
            // 
            this.btnValider.AutoSize = true;
            this.btnValider.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnValider.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.btnValider.Location = new System.Drawing.Point(269, 280);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(117, 47);
            this.btnValider.TabIndex = 16;
            this.btnValider.Text = "Valider";
            this.btnValider.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button1.BackColor = System.Drawing.SystemColors.Control;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.button1.Location = new System.Drawing.Point(543, 185);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 30);
            this.button1.TabIndex = 14;
            this.button1.Text = "Nouveau lieu";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // lblNomEpreuve
            // 
            this.lblNomEpreuve.AutoSize = true;
            this.lblNomEpreuve.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomEpreuve.Location = new System.Drawing.Point(61, 33);
            this.lblNomEpreuve.Margin = new System.Windows.Forms.Padding(20, 3, 3, 3);
            this.lblNomEpreuve.Name = "lblNomEpreuve";
            this.lblNomEpreuve.Size = new System.Drawing.Size(201, 28);
            this.lblNomEpreuve.TabIndex = 12;
            this.lblNomEpreuve.Text = "Nom de l\'epreuve :";
            // 
            // btnSupprEquipe
            // 
            this.btnSupprEquipe.AutoSize = true;
            this.btnSupprEquipe.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSupprEquipe.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnSupprEquipe.Location = new System.Drawing.Point(412, 54);
            this.btnSupprEquipe.Name = "btnSupprEquipe";
            this.btnSupprEquipe.Size = new System.Drawing.Size(231, 38);
            this.btnSupprEquipe.TabIndex = 8;
            this.btnSupprEquipe.Text = "Supprimer une equipe";
            this.btnSupprEquipe.UseVisualStyleBackColor = true;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1157, 685);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Main";
            this.Text = "Main";
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
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
        private System.Windows.Forms.Button btnValider;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblNomEpreuve;
        private System.Windows.Forms.Button btnSupprEquipe;
    }
}