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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblTimer = new System.Windows.Forms.Label();
            this.lblNumVache = new System.Windows.Forms.Label();
            this.lblAnnoncePremiereVache = new System.Windows.Forms.Label();
            this.BtnStopChrono = new System.Windows.Forms.Button();
            this.btnEquipeSuivante = new System.Windows.Forms.Button();
            this.btnValidationResultats = new System.Windows.Forms.Button();
            this.btnMauvaiseVache = new System.Windows.Forms.Button();
            this.btnBonneVache = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.flowLayoutPanel1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.lblTimer);
            this.splitContainer1.Panel2.Controls.Add(this.lblNumVache);
            this.splitContainer1.Panel2.Controls.Add(this.lblAnnoncePremiereVache);
            this.splitContainer1.Panel2.Controls.Add(this.BtnStopChrono);
            this.splitContainer1.Panel2.Controls.Add(this.btnEquipeSuivante);
            this.splitContainer1.Panel2.Controls.Add(this.btnValidationResultats);
            this.splitContainer1.Panel2.Controls.Add(this.btnMauvaiseVache);
            this.splitContainer1.Panel2.Controls.Add(this.btnBonneVache);
            this.splitContainer1.Panel2.Controls.Add(this.btnStart);
            this.splitContainer1.Size = new System.Drawing.Size(1567, 863);
            this.splitContainer1.SplitterDistance = 522;
            this.splitContainer1.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.flowLayoutPanel1.Controls.Add(this.dataGridView1);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 86);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(475, 748);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(284, 209);
            this.dataGridView1.TabIndex = 0;
            // 
            // lblTimer
            // 
            this.lblTimer.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblTimer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTimer.Font = new System.Drawing.Font("Segoe UI", 50F, System.Drawing.FontStyle.Bold);
            this.lblTimer.Location = new System.Drawing.Point(290, 126);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(520, 136);
            this.lblTimer.TabIndex = 17;
            this.lblTimer.Text = "00:00";
            this.lblTimer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNumVache
            // 
            this.lblNumVache.AutoSize = true;
            this.lblNumVache.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumVache.Location = new System.Drawing.Point(643, 304);
            this.lblNumVache.Name = "lblNumVache";
            this.lblNumVache.Size = new System.Drawing.Size(279, 45);
            this.lblNumVache.TabIndex = 16;
            this.lblNumVache.Text = "*Random vache*";
            this.lblNumVache.Visible = false;
            // 
            // lblAnnoncePremiereVache
            // 
            this.lblAnnoncePremiereVache.AutoSize = true;
            this.lblAnnoncePremiereVache.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnnoncePremiereVache.Location = new System.Drawing.Point(72, 304);
            this.lblAnnoncePremiereVache.Name = "lblAnnoncePremiereVache";
            this.lblAnnoncePremiereVache.Size = new System.Drawing.Size(495, 45);
            this.lblAnnoncePremiereVache.TabIndex = 15;
            this.lblAnnoncePremiereVache.Text = "Numero de la premiere vache :";
            // 
            // BtnStopChrono
            // 
            this.BtnStopChrono.AutoSize = true;
            this.BtnStopChrono.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnStopChrono.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.BtnStopChrono.Location = new System.Drawing.Point(795, 409);
            this.BtnStopChrono.Name = "BtnStopChrono";
            this.BtnStopChrono.Size = new System.Drawing.Size(58, 33);
            this.BtnStopChrono.TabIndex = 14;
            this.BtnStopChrono.Text = "Stop";
            this.BtnStopChrono.UseVisualStyleBackColor = true;
            this.BtnStopChrono.Click += new System.EventHandler(this.BtnStopChrono_Click);
            // 
            // btnEquipeSuivante
            // 
            this.btnEquipeSuivante.AutoSize = true;
            this.btnEquipeSuivante.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnEquipeSuivante.Enabled = false;
            this.btnEquipeSuivante.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.btnEquipeSuivante.Location = new System.Drawing.Point(714, 672);
            this.btnEquipeSuivante.Name = "btnEquipeSuivante";
            this.btnEquipeSuivante.Size = new System.Drawing.Size(211, 45);
            this.btnEquipeSuivante.TabIndex = 13;
            this.btnEquipeSuivante.Text = "Equipe suivante";
            this.btnEquipeSuivante.UseVisualStyleBackColor = true;
            this.btnEquipeSuivante.Click += new System.EventHandler(this.btnEquipeSuivante_Click_1);
            // 
            // btnValidationResultats
            // 
            this.btnValidationResultats.AutoSize = true;
            this.btnValidationResultats.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnValidationResultats.Enabled = false;
            this.btnValidationResultats.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.btnValidationResultats.Location = new System.Drawing.Point(134, 672);
            this.btnValidationResultats.Name = "btnValidationResultats";
            this.btnValidationResultats.Size = new System.Drawing.Size(253, 45);
            this.btnValidationResultats.TabIndex = 12;
            this.btnValidationResultats.Text = "Valider les résultats";
            this.btnValidationResultats.UseVisualStyleBackColor = true;
            this.btnValidationResultats.Click += new System.EventHandler(this.btnValidationResultats_Click);
            // 
            // btnMauvaiseVache
            // 
            this.btnMauvaiseVache.AutoSize = true;
            this.btnMauvaiseVache.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnMauvaiseVache.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.btnMauvaiseVache.Location = new System.Drawing.Point(680, 496);
            this.btnMauvaiseVache.Name = "btnMauvaiseVache";
            this.btnMauvaiseVache.Size = new System.Drawing.Size(218, 45);
            this.btnMauvaiseVache.TabIndex = 11;
            this.btnMauvaiseVache.Text = "Mauvaise  vache";
            this.btnMauvaiseVache.UseVisualStyleBackColor = true;
            this.btnMauvaiseVache.Click += new System.EventHandler(this.btnMauvaiseVache_Click);
            // 
            // btnBonneVache
            // 
            this.btnBonneVache.AutoSize = true;
            this.btnBonneVache.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnBonneVache.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.btnBonneVache.Location = new System.Drawing.Point(186, 496);
            this.btnBonneVache.Name = "btnBonneVache";
            this.btnBonneVache.Size = new System.Drawing.Size(175, 45);
            this.btnBonneVache.TabIndex = 10;
            this.btnBonneVache.Text = "Bonne vache";
            this.btnBonneVache.UseVisualStyleBackColor = true;
            // 
            // btnStart
            // 
            this.btnStart.AutoSize = true;
            this.btnStart.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnStart.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Bold);
            this.btnStart.Location = new System.Drawing.Point(498, 381);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(97, 67);
            this.btnStart.TabIndex = 9;
            this.btnStart.Text = "GO";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // Round
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1567, 863);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Round";
            this.Text = "Round";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.DataGridView dataGridView1;
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