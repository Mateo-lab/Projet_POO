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
            this.lblTimer = new System.Windows.Forms.Label();
            this.lblNumVache = new System.Windows.Forms.Label();
            this.lblAnnoncePremiereVache = new System.Windows.Forms.Label();
            this.BtnStopChrono = new System.Windows.Forms.Button();
            this.btnEquipeSuivante = new System.Windows.Forms.Button();
            this.btnValidationResultats = new System.Windows.Forms.Button();
            this.btnMauvaiseVache = new System.Windows.Forms.Button();
            this.btnBonneVache = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
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
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(1175, 839);
            this.splitContainer1.SplitterDistance = 540;
            this.splitContainer1.SplitterWidth = 3;
            this.splitContainer1.TabIndex = 0;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.richTextBox1);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.lblTimer);
            this.splitContainer2.Panel2.Controls.Add(this.lblNumVache);
            this.splitContainer2.Panel2.Controls.Add(this.lblAnnoncePremiereVache);
            this.splitContainer2.Panel2.Controls.Add(this.BtnStopChrono);
            this.splitContainer2.Panel2.Controls.Add(this.btnEquipeSuivante);
            this.splitContainer2.Panel2.Controls.Add(this.btnValidationResultats);
            this.splitContainer2.Panel2.Controls.Add(this.btnMauvaiseVache);
            this.splitContainer2.Panel2.Controls.Add(this.btnBonneVache);
            this.splitContainer2.Panel2.Controls.Add(this.btnStart);
            this.splitContainer2.Size = new System.Drawing.Size(1175, 540);
            this.splitContainer2.SplitterDistance = 391;
            this.splitContainer2.TabIndex = 27;
            // 
            // lblTimer
            // 
            this.lblTimer.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblTimer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTimer.Font = new System.Drawing.Font("Segoe UI", 50F, System.Drawing.FontStyle.Bold);
            this.lblTimer.Location = new System.Drawing.Point(225, 66);
            this.lblTimer.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(390, 110);
            this.lblTimer.TabIndex = 35;
            this.lblTimer.Text = "00:00";
            this.lblTimer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNumVache
            // 
            this.lblNumVache.AutoSize = true;
            this.lblNumVache.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumVache.Location = new System.Drawing.Point(489, 211);
            this.lblNumVache.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNumVache.Name = "lblNumVache";
            this.lblNumVache.Size = new System.Drawing.Size(230, 37);
            this.lblNumVache.TabIndex = 34;
            this.lblNumVache.Text = "*Random vache*";
            this.lblNumVache.Visible = false;
            // 
            // lblAnnoncePremiereVache
            // 
            this.lblAnnoncePremiereVache.AutoSize = true;
            this.lblAnnoncePremiereVache.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnnoncePremiereVache.Location = new System.Drawing.Point(61, 211);
            this.lblAnnoncePremiereVache.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAnnoncePremiereVache.Name = "lblAnnoncePremiereVache";
            this.lblAnnoncePremiereVache.Size = new System.Drawing.Size(410, 37);
            this.lblAnnoncePremiereVache.TabIndex = 33;
            this.lblAnnoncePremiereVache.Text = "Numero de la premiere vache :";
            // 
            // BtnStopChrono
            // 
            this.BtnStopChrono.AutoSize = true;
            this.BtnStopChrono.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnStopChrono.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.BtnStopChrono.Location = new System.Drawing.Point(603, 296);
            this.BtnStopChrono.Margin = new System.Windows.Forms.Padding(2);
            this.BtnStopChrono.Name = "BtnStopChrono";
            this.BtnStopChrono.Size = new System.Drawing.Size(50, 29);
            this.BtnStopChrono.TabIndex = 32;
            this.BtnStopChrono.Text = "Stop";
            this.BtnStopChrono.UseVisualStyleBackColor = true;
            // 
            // btnEquipeSuivante
            // 
            this.btnEquipeSuivante.AutoSize = true;
            this.btnEquipeSuivante.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnEquipeSuivante.Enabled = false;
            this.btnEquipeSuivante.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.btnEquipeSuivante.Location = new System.Drawing.Point(517, 436);
            this.btnEquipeSuivante.Margin = new System.Windows.Forms.Padding(2);
            this.btnEquipeSuivante.Name = "btnEquipeSuivante";
            this.btnEquipeSuivante.Size = new System.Drawing.Size(172, 38);
            this.btnEquipeSuivante.TabIndex = 31;
            this.btnEquipeSuivante.Text = "Equipe suivante";
            this.btnEquipeSuivante.UseVisualStyleBackColor = true;
            // 
            // btnValidationResultats
            // 
            this.btnValidationResultats.AutoSize = true;
            this.btnValidationResultats.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnValidationResultats.Enabled = false;
            this.btnValidationResultats.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.btnValidationResultats.Location = new System.Drawing.Point(110, 436);
            this.btnValidationResultats.Margin = new System.Windows.Forms.Padding(2);
            this.btnValidationResultats.Name = "btnValidationResultats";
            this.btnValidationResultats.Size = new System.Drawing.Size(207, 38);
            this.btnValidationResultats.TabIndex = 30;
            this.btnValidationResultats.Text = "Valider les résultats";
            this.btnValidationResultats.UseVisualStyleBackColor = true;
            // 
            // btnMauvaiseVache
            // 
            this.btnMauvaiseVache.AutoSize = true;
            this.btnMauvaiseVache.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnMauvaiseVache.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.btnMauvaiseVache.Location = new System.Drawing.Point(517, 367);
            this.btnMauvaiseVache.Margin = new System.Windows.Forms.Padding(2);
            this.btnMauvaiseVache.Name = "btnMauvaiseVache";
            this.btnMauvaiseVache.Size = new System.Drawing.Size(179, 38);
            this.btnMauvaiseVache.TabIndex = 29;
            this.btnMauvaiseVache.Text = "Mauvaise  vache";
            this.btnMauvaiseVache.UseVisualStyleBackColor = true;
            // 
            // btnBonneVache
            // 
            this.btnBonneVache.AutoSize = true;
            this.btnBonneVache.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnBonneVache.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.btnBonneVache.Location = new System.Drawing.Point(147, 367);
            this.btnBonneVache.Margin = new System.Windows.Forms.Padding(2);
            this.btnBonneVache.Name = "btnBonneVache";
            this.btnBonneVache.Size = new System.Drawing.Size(143, 38);
            this.btnBonneVache.TabIndex = 28;
            this.btnBonneVache.Text = "Bonne vache";
            this.btnBonneVache.UseVisualStyleBackColor = true;
            // 
            // btnStart
            // 
            this.btnStart.AutoSize = true;
            this.btnStart.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnStart.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Bold);
            this.btnStart.Location = new System.Drawing.Point(381, 274);
            this.btnStart.Margin = new System.Windows.Forms.Padding(2);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(80, 56);
            this.btnStart.TabIndex = 27;
            this.btnStart.Text = "GO";
            this.btnStart.UseVisualStyleBackColor = true;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 103);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(361, 391);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // Round
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1175, 839);
            this.Controls.Add(this.splitContainer1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Round";
            this.Text = "Round";
            this.splitContainer1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.Label lblNumVache;
        private System.Windows.Forms.Label lblAnnoncePremiereVache;
        private System.Windows.Forms.Button BtnStopChrono;
        private System.Windows.Forms.Button btnEquipeSuivante;
        private System.Windows.Forms.Button btnValidationResultats;
        private System.Windows.Forms.Button btnMauvaiseVache;
        private System.Windows.Forms.Button btnBonneVache;
        private System.Windows.Forms.Button btnStart;
    }
}