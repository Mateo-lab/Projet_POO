using Ranch_Sorting.Controleur;
using Ranch_Sorting.Modeles;
using System;
using System.Windows.Forms;

namespace Ranch_Sorting.Vue
{
    public partial class Lobby : Form
    {
        private Controle controleur; // donnée membre privée pour stocker le contrôleur
        public Lobby()
        {
            InitializeComponent();
        }
        
        public Controle Controleur  // propriété set Contrôleur pour modifier la donnée membre privée ctrl
        {
            set
            {
                controleur = value;
            }

            get
            {
                return controleur;
            }
        }
        public void GetEquipe()
        {
            try
            {
                //bdsEquipe.DataSource = controleur.GetEquipe();
                //dataGridView1.DataSource = bdsEquipe;

                dataGridViewListeEquipe.DataSource = controleur.GetEquipe();
            }
            catch (Exception e)
            {
                MessageBox.Show("Erreur : \n" + e.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // throw e;   // Q : qu'est-ce que cette instruction produit ?
            }
        }
        public void GetInscriptions(string nomEpreuve)
        {     
            try
            {
                //bdsEquipe.DataSource = controleur.GetEquipe();
                //dataGridView1.DataSource = bdsEquipe;

                dataGridViewEquipeInscrite.DataSource = controleur.GetInscriptions(nomEpreuve);
            }
                       catch (Exception e)
            {
                MessageBox.Show("Erreur : \n" + e.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // throw e;   // Q : qu'est-ce que cette instruction produit ?
            }
        }
        public string GetNomEpreuve()
        { 
            //essayer de passer par inscriptions
            return null;
        }
        public string GetDateEpreuve()
        {
            return null;
        }
        public void ClearComboBox()
        {
            cmbBoxLieu.Items.Clear();
        }
        public void AddComboBoxNomLieu()
        {
            try
            {
                //List<string> nomLieux = controleur.GetNomLieux();
                cmbBoxLieu.Items.AddRange(controleur.GetNomLieux().ToArray());
            }
            catch (Exception e)
            {
                MessageBox.Show("Erreur : \n" + e.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // throw e;   // Q : qu'est-ce que cette instruction produit ?
            }
        }

        private void btnAjouterEquipe_Click(object sender, EventArgs e)
        {
            NouvelleEquipe nouvelleEquipe = new NouvelleEquipe(this);
            nouvelleEquipe.Show();
        }

        private void btnImporterOrdreDePassage_Click(object sender, EventArgs e)
        {
            btnLancerUnRound.Enabled = true;    
        }

        private void btnLancerUnRound_Click(object sender, EventArgs e)
        {
            Round round = new Round();
            round.Show();   
        }

        private void Lobby_Load_1(object sender, EventArgs e)
        {
            try
            {
                controleur.ouvreBD();
                //MessageBox.Show("Connexion à la base de données réussie", "Connexion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception exc)
            {
                MessageBox.Show("Erreur : \n" + exc.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            GetEquipe();
            AddComboBoxNomLieu();
            
        }

        private void btnSupprEquipe_Click(object sender, EventArgs e)
        {
            SupprimerUneEquipe supprimerUneEquipe = new SupprimerUneEquipe(this);
            supprimerUneEquipe.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NouveauLieu nouveauLieu = new NouveauLieu(this);
            nouveauLieu.Show();
        }

        private void btnInscription_Click(object sender, EventArgs e)
        {
            //Cette fonction va ajouter une inscription dans la table Inscription et  mettre à jour la table Equipe
            try
            {
                string nomEpreuve = txtBoxNomEpreuve.Text;
                string dateEpreuve = dateTimePicker.Value.ToString("d-M-yyy");
                string nomEquipe = txtBoxInscription.Text;
                string dateInscription = DateTime.Now.ToString("d-M-yyy");
                bool payé = checkBoxPayé.CheckState == CheckState.Checked ? true : false; // si la case est cochée, payé = true, sinon payé = false 
                

                Controleur.AjouterUneInscription(nomEpreuve, dateEpreuve, nomEquipe, dateInscription, payé);   
                Controleur.AjouterInscriptionDansScore(nomEpreuve, dateEpreuve, nomEquipe, 1 , 0, "", "", "", "", "", "", "", "", "", "", "");
                GetInscriptions(nomEpreuve);
            }
            catch (Exception exc)
            {
                MessageBox.Show("Erreur : \n" + exc.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            DialogResult dr = MessageBox.Show("L'equipe inscrite", "Inscrite", MessageBoxButtons.OK, MessageBoxIcon.Information);
            checkBoxPayé.CheckState = CheckState.Unchecked;
            
        }

        private void btnCreerEpreuve_Click(object sender, EventArgs e)
        {
            try
            {
                Epreuve.Nom
                string nomEpreuve = txtBoxNomEpreuve.Text;
                string dateEpreuve = dateTimePicker.Value.ToString("d-M-yyy");
                string nomLieu = cmbBoxLieu.Text;

                Controleur.CreerEpreuve(nomEpreuve, dateEpreuve, nomLieu);
                Controleur.CreationNouvelleTableScore(nomEpreuve, dateEpreuve);

                txtBoxNomEpreuve.Enabled = false;
                dateTimePicker.Enabled = false;
                cmbBoxLieu.Enabled = false;
                btnCreerEpreuve.Enabled = false;
                txtBoxInscription.Enabled = true;
                checkBoxPayé.Enabled = true;
                btnInscription.Enabled = true;
                btnDesinscrire.Enabled = true;
            }

            catch (Exception exc)
            {
                MessageBox.Show("Erreur : \n" + exc.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtBoxNomEpreuve.Enabled = true;
                dateTimePicker.Enabled = true;
                cmbBoxLieu.Enabled = true;
                btnCreerEpreuve.Enabled = true;
                txtBoxInscription.Enabled = false;
                checkBoxPayé.Enabled = false;
                btnInscription.Enabled = false;
                btnDesinscrire.Enabled = false;
            }
            

        }

        private void btnDesinscrire_Click(object sender, EventArgs e)
        {
            try
            {
                string nomEpreuve = txtBoxNomEpreuve.Text;
                Controleur.SupprimerUneInscription(txtBoxInscription.Text);
                Controleur.SupprimerInscriptionDansScore(txtBoxInscription.Text);
                GetInscriptions(nomEpreuve);
            }
            catch (Exception exc)
            {
                MessageBox.Show("Erreur : \n" + exc.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            DialogResult dr = MessageBox.Show("L'equipe désinscrite", "Désinscrite", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (dr == DialogResult.No)
                this.Close();
            else
            {
                txtBoxInscription.Text = "";
            }
        }

    }
}
