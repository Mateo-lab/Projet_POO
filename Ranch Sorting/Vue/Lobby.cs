using Ranch_Sorting.Controleur;
using Ranch_Sorting.Modeles;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Ranch_Sorting.Vue
{
    public partial class Lobby : Form
    {
        private Controle controleur; // donnée membre privée pour stocker le contrôleu
        private string _selectedEpreuve, _dateEpreuve;
        public Lobby()
        {
            InitializeComponent();
        }
        public Controle Controleur  // propriété set Contrôleur pour modifier la donnée membre privée ctrl
        {
            set => controleur = value;

            get => controleur;
        }
        public void GetEquipe()
        {
            try
            {
                dataGridViewListeEquipe.DataSource = controleur.GetEquipe();
            }
            catch (Exception e)
            {
                MessageBox.Show("Erreur : \n" + e.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // throw e;   // Q : qu'est-ce que cette instruction produit ?
            }
        }
        public void GetEpreuve()
        {
            try
            {
                dataGridViewListeEpreuve.DataSource = controleur.GetEpreuves();
            }
            catch (Exception e)
            {
                MessageBox.Show("Erreur : \n" + e.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // throw e;   // Q : qu'est-ce que cette instruction produit ?
            }
        }
        public void GetInscriptions(string nomEpreuve)
        {
            List<Inscription> listeDesInscriptions = null;
            try
            {
                listeDesInscriptions = controleur.GetInscriptions(nomEpreuve);
                dataGridViewEquipeInscrite.DataSource = listeDesInscriptions;
            }
            catch (Exception e)
            {
                MessageBox.Show("Erreur : \n" + e.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // throw e;   // Q : qu'est-ce que cette instruction produit ?
            }
        }
        public int GetIdInscription(string nomEpreuve, string nomEquipe)
        {
            return controleur.GetIdInscription(nomEpreuve, nomEquipe);
        }
        public void ClearComboBox()
        {
            cmbBoxLieu.Items.Clear();
        }
        public void MaJComboBoxNomLieu()
        {
            try
            {
                cmbBoxLieu.Items.AddRange(controleur.GetNomLieux().ToArray());
            }
            catch (Exception e)
            {
                MessageBox.Show("Erreur : \n" + e.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // throw e;   // Q : qu'est-ce que cette instruction produit ?
            }
        }
        private void Lobby_Load(object sender, EventArgs e)
        {
            // lobby load represente le chargement de la page
            // et la difference entre lobby load et Initialize component c'est que
            // lobby load est appelé à chaque fois que la page est chargée grace à this.show()
            // alors que initialize component est appelé une seule fois au chargement de la page
            // donc on met les fonctions qui doivent etre appelé à chaque fois dans lobby load
            // et les fonctions qui doivent etre appelé une seule fois dans initialize component
            // comme la connexion à la base de données par exemple qui se fait une seule fois

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
            MaJComboBoxNomLieu();
        }
        private void Lobby_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                controleur.fermeBD();
                //MessageBox.Show("Déconnexion de la base de données réussie", "Déconnexion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception exc)
            {
                MessageBox.Show("Erreur : \n" + exc.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnAjouterEquipe_Click(object sender, EventArgs e)
        {
            NouvelleEquipe nouvelleEquipe = new NouvelleEquipe(this);
            nouvelleEquipe.Show();
        }
        private void btnLancerUnRound_Click(object sender, EventArgs e)
        {
            Round round = new Round(this);
            round.Show();   
        }
        private void btnSupprEquipe_Click(object sender, EventArgs e)
        {
            

            SupprimerUneEquipe supprimerUneEquipe = new SupprimerUneEquipe(this);
            supprimerUneEquipe.Show();
        }
        private void btnNouveauLieu_Click(object sender, EventArgs e)
        {

            NouveauLieu nouveauLieu = new NouveauLieu(this);
            nouveauLieu.Show();
        }
        private void btnSupprimerUnLieu_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dr = MessageBox.Show("Voulez-vous vraiment supprimer ce lieu ?", "Supprimer un lieu", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.No)
                {
                    return;
                }
                else if (dr == DialogResult.Yes)
                {
                    string nomLieuASupprimer = cmbBoxLieu.Text;
                    Controleur.SupprimerLieu(nomLieuASupprimer);
                    ClearComboBox();
                    MaJComboBoxNomLieu();
                    cmbBoxLieu.Text = "";
                }
            }
            catch (Exception exc)
            {
                string exceptionName = exc.GetType().Name;
                if (exceptionName == "SqlException" && exc.Message.Contains("Violation d'unicité")) // Numéro d'erreur spécifique pour violation d'unicité
                {
                    MessageBox.Show("L'élément existe déjà dans la table.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Erreur : \n" + exc.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }

        }
        private void btnInscription_Click(object sender, EventArgs e)
        {
            //Cette fonction va ajouter une inscription dans la table Inscription et  mettre à jour la table Equipe
            try
            {
                int nbrRound = Convert.ToInt32(numericUpDownNbrRound.Value);

                string nomEquipe = txtBoxInscription.Text;
                string dateInscription = DateTime.Now.ToString("d-MM-yy");
                bool payé = checkBoxPayé.CheckState == CheckState.Checked ? true : false; // si la case est cochée, payé = true, sinon payé = false 
                
                if (Controleur.CheckInscription(_selectedEpreuve, nomEquipe))
                {

                    txtBoxInscription.Clear();
                    throw new Exception("L'equipe est déjà inscrite");
                    
                }
                else
                {
                    Controleur.AjouterInscriptionEtEquipeScore(_selectedEpreuve, _dateEpreuve, nomEquipe, dateInscription, payé, nbrRound, 1, "", "", "", "", "", "", "", "", "", "", "");
                    GetInscriptions(_selectedEpreuve);
                    DialogResult dr = MessageBox.Show("L'equipe inscrite", "Inscrite", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtBoxInscription.Clear();
                }
                
            }
            catch (Exception exc)
            {
                MessageBox.Show("Erreur : \n" + exc.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; //permet de sortir de la methode sans executer DialogResult
            }
            
            checkBoxPayé.CheckState = CheckState.Unchecked;
            
        }
        private void btnDesinscrire_Click(object sender, EventArgs e)
        {
            try
            {
                string dateEpreuve = dateTimePicker.Value.ToString("d-MM-yy");
                string nomEquipe = txtBoxInscription.Text;
                string dateInscription = DateTime.Now.ToString("d-MM-yy");
                int idInscritption = GetIdInscription(_selectedEpreuve, nomEquipe);


                Controleur.SupprimerInscriptionDansScore(idInscritption);
                Controleur.SupprimerUneInscription(idInscritption);
                GetInscriptions(_selectedEpreuve);
                txtBoxInscription.Clear();
            }
            catch (Exception exc)
            {
                MessageBox.Show("Erreur : \n" + exc.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; //permet de sortir de la methode sans executer DialogResult
            }

            DialogResult dr = MessageBox.Show("L'equipe désinscrite", "Désinscrite", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
        }
        private void btnCreerEpreuve_Click(object sender, EventArgs e)
        {
            try
            {
                //Epreuve.Nom
                _selectedEpreuve = txtBoxNomEpreuve.Text;
                _dateEpreuve = dateTimePicker.Value.ToString("d-MM-yy");
                string nomLieu = cmbBoxLieu.Text;
                int nbrRound = Convert.ToInt32(numericUpDownNbrRound.Value);

                Controleur.CreerEpreuve(_selectedEpreuve, _dateEpreuve, nomLieu,nbrRound);

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
        private void btnCreeUneNouvelleEpreuve_Click(object sender, EventArgs e)
        {
            lblNomEpreuve.Visible = true;
            lblDate.Visible = true;
            lblNomLieu.Visible = true;
            lblNmbrRound.Visible = true;
            txtBoxNomEpreuve.Visible = true;
            dateTimePicker.Visible = true;
            cmbBoxLieu.Visible = true;
            btnCreerEpreuve.Visible=true;
            numericUpDownNbrRound.Visible = true;
            btnNouveauLieu.Visible=true;
            btnSupprimerUnLieu.Visible = true;
            btnRetour.Visible = true;
            btnVisualiserEpreeuveExistante.Visible = false;
            btnCreeUneNouvelleEpreuve.Visible=false;

        }
        private void btnRetour_Click(object sender, EventArgs e)
        {
            lblNomEpreuve.Visible = false;
            txtBoxNomEpreuve.Clear();
            lblDate.Visible = false;
            lblNomLieu.Visible = false;
            lblNmbrRound.Visible = false;
            txtBoxNomEpreuve.Visible = false;
            dateTimePicker.Visible = false;
            cmbBoxLieu.Visible = false;
            btnCreerEpreuve.Visible = false;
            numericUpDownNbrRound.Visible = false;
            btnNouveauLieu.Visible = false;
            btnSupprimerUnLieu.Visible = false;
            btnRetour.Visible = false;
            lblObtienListeInscrit.Visible = false;
            txtBoxInscription.Enabled = false;
            checkBoxPayé.Enabled = false;
            btnInscription.Enabled = false;
            btnDesinscrire.Enabled = false;
            dataGridViewListeEpreuve.Visible = false;
            btnVisualiserEpreeuveExistante.Visible = true;
            btnCreeUneNouvelleEpreuve.Visible = true;
            txtBoxNomEpreuve.Enabled = true;
            dateTimePicker.Enabled = true;
            cmbBoxLieu.Enabled = true;
            btnCreerEpreuve.Enabled = true;
            dataGridViewListeEpreuve.DataSource = "";
            dataGridViewEquipeInscrite.DataSource = "";
        }
        private void btnSelectionEpreeuveExistante_Click(object sender, EventArgs e)
        {
            GetEpreuve();   
            dataGridViewListeEpreuve.Visible = true;
            lblObtienListeInscrit.Visible = true;
            btnRetour.Visible = true;
            txtBoxInscription.Enabled = true;
            checkBoxPayé.Enabled = true;
            btnInscription.Enabled = true;
            btnDesinscrire.Enabled = true;
            btnVisualiserEpreeuveExistante.Visible=false;
            btnCreeUneNouvelleEpreuve.Visible = false;
        }
        private void btnListeInscrit_Click(object sender, EventArgs e)
        {
            try
            {
                
                string nomEpreuve = txtBoxNomEpreuve.Text;
                GetInscriptions(nomEpreuve);

                txtBoxInscription.Enabled = true;
                checkBoxPayé.Enabled = true;
                btnInscription.Enabled = true;
                btnDesinscrire.Enabled = true;
            }

            catch (Exception exc)
            {
                MessageBox.Show("Erreur : \n" + exc.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
                txtBoxInscription.Enabled = false;
                checkBoxPayé.Enabled = false;
                btnInscription.Enabled = false;
                btnDesinscrire.Enabled = false;
            }
            
        }

        private void dataGridViewListeEpreuve_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                _selectedEpreuve = dataGridViewListeEpreuve.CurrentRow.Cells[0].Value.ToString();
                _dateEpreuve = dataGridViewListeEpreuve.CurrentRow.Cells[1].Value.ToString();
                GetInscriptions(_selectedEpreuve);

                txtBoxInscription.Enabled = true;
                checkBoxPayé.Enabled = true;
                btnInscription.Enabled = true;
                btnDesinscrire.Enabled = true;
            }

            catch (Exception exc)
            {
                MessageBox.Show("Erreur : \n" + exc.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);

                txtBoxInscription.Enabled = false;
                checkBoxPayé.Enabled = false;
                btnInscription.Enabled = false;
                btnDesinscrire.Enabled = false;
            }
        }
    }
}
