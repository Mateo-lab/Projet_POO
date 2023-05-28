using Ranch_Sorting.Controleur;
using Ranch_Sorting.Modeles;
using Ranch_Sorting_App.Donnees;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;
using Timer = System.Windows.Forms.Timer;

namespace Ranch_Sorting.Vue
{
    public partial class Round : Form
    {
        Lobby parent; 
        ListeNomsEquipes listeNomsEquipes;
        List<Inscription> listePassage;
        Timer timer;

        private int nbrParticipants, numVache, nbrVache, equipeCouranteIndex;
        private static Stopwatch chrono;
        static DateTime startTime;
        private bool enCoursDEpreuve = false;

        
        public Round(Lobby parent_)
        {
            parent = parent_;
            InitializeComponent();
            timer = new Timer();
            timer.Interval = 10;
            timer.Tick += Timer_Tick;
        }

        ////////////////////////////////////////////////////
        private void Timer_Tick(object sender, EventArgs e)
        {
            // Appeler la mise à jour du libellé à chaque tick du Timer
            UpdateTimerLabel();

            // Vérifier si le chronomètre doit être arrêté
            if (!chrono.IsRunning)
            {
                timer.Stop(); // Arrêter le timer
                timer.Dispose(); // Disposer le timer
            }
        }
        private void UpdateTimerLabel()
        {
            // Récupération du temps écoulé
            TimeSpan elapsedTime = chrono.Elapsed;

            // Mise à jour du libellé avec le temps écoulé en minutes, secondes et millisecondes
            if (lblTimer.InvokeRequired)
            {
                lblTimer.BeginInvoke(new Action(() =>
                {
                    lblTimer.Text = string.Format("{0:00}:{1:00}:{2:000}",
                        elapsedTime.Minutes, elapsedTime.Seconds, elapsedTime.Milliseconds);
                }));
            }
            else
            {
                lblTimer.Text = string.Format("{0:00}:{1:00}:{2:000}",
                    elapsedTime.Minutes, elapsedTime.Seconds, elapsedTime.Milliseconds);
            }
           

            if (elapsedTime.TotalSeconds >= 120)
            {

                string nomEpreuve = cmbBoxSelectEpreuve.Text;
                string dateEpreuve = GetDateEpreuve(cmbBoxSelectEpreuve.Text);
                string nomEquipe = lblNomEquipeEnCours.Text;
                int.TryParse(cmbBoxNumRound.Text, out int numRound);

                chrono.Stop();
                parent.Controleur.ResultatsEquipe(nomEpreuve, nomEquipe, numRound, nbrVache.ToString());
                GetScore();

                nbrVache = 0;
                btnBonneVache.Enabled = false;
                btnMauvaiseVache.Enabled = false;
                btnValidationResultats.Enabled = true;

            }

        }
        private int RandomNumber(int min, int max)
        {
            Random random = new Random();
            return random.Next(min, max);
        }
        private void GestionTimer()
        {
            timer.Start();
            chrono = new Stopwatch();

            // Démarrage du chronomètre
            chrono.Start();
        }
        private string TempsVache()
        {
            string temps = lblTimer.Text;
            return temps;
        }
        private void Round_Load(object sender, EventArgs e)
        {
            string message = "Pour lancer une nouvelle Epreuve, sélectionné la dans la zone Jaune, choisisé le numero du round puis appuyer sur lancé lancer l'epreuve";
            MessageBox.Show(message, "Bienvenu", MessageBoxButtons.OK, MessageBoxIcon.Information);
            MaJComboBoxNomEpreuve();
        }
        private void Round_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (enCoursDEpreuve)
            {
                e.Cancel = true; // Annule la fermeture de la fenêtre
                MessageBox.Show("Veuillez patienter jusqu'à la fin de l'epreuve.");
            }
        }
        private void MaJComboBoxNomEpreuve()
        {
            try
            {
                cmbBoxSelectEpreuve.Items.AddRange(parent.Controleur.GetNomEpreuve().ToArray());
            }
            catch (Exception e)
            {
                MessageBox.Show("Erreur : \n" + e.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // throw e;   // Q : qu'est-ce que cette instruction produit ?
            }
        }
        private void MaJComboBoxNbrRound(string nomEpreuve)
        {
            try
            {
                List<string> nbrRound = parent.Controleur.GetNbrRound(nomEpreuve);
                if (nbrRound[0] == "2")
                    cmbBoxNumRound.Items.AddRange(nbrRound.ToArray());
            }
            catch (Exception e)
            {
                MessageBox.Show("Erreur : \n" + e.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // throw e;   // Q : qu'est-ce que cette instruction produit ?
            }
        }


        ///////////////////////////////////////////////////
        private void btnStart_Click(object sender, EventArgs e)
        {
            enCoursDEpreuve = true;
            btnRetour.Enabled = false;  
            btnBonneVache.Enabled = true;
            btnMauvaiseVache.Enabled = true;

            GestionTimer();
            btnStart.Enabled = false;
            lblNumVache.Text = RandomNumber(0, 9).ToString();
            lblNumVache.Visible = true;
            numVache = int.Parse(lblNumVache.Text);
        }
        private void btnBonneVache_Click(object sender, EventArgs e)
        { 
            nbrVache++;
            string nomEpreuve = cmbBoxSelectEpreuve.Text;
            string nomEquipe = lblNomEquipeEnCours.Text;
            int.TryParse(cmbBoxNumRound.Text, out int numRound);
            string temps = TempsVache();

            parent.Controleur.AjouterTempsVache(nomEpreuve, nomEquipe, numRound, numVache, temps);
            richTextBoxResultats.AppendText('\n' + "Vache " + numVache + " : " + TempsVache());
            GetScore();

            if (nbrVache == 10)
            {
                parent.Controleur.ResultatsEquipe(nomEpreuve, nomEquipe, numRound, "TEN COWS");
                GetScore();
                chrono.Stop();
                btnBonneVache.Enabled = false;
                btnMauvaiseVache.Enabled = false;
                btnValidationResultats.Enabled = true;
                nbrVache = 0;
            }
            if (numVache == 9)
            {
                numVache = 0;
            }else numVache++;
        }

        private void btnMauvaiseVache_Click(object sender, EventArgs e)
        {
            string nomEpreuve = cmbBoxSelectEpreuve.Text;
            string nomEquipe = lblNomEquipeEnCours.Text;
            int.TryParse(cmbBoxNumRound.Text, out int numRound);

            parent.Controleur.ResultatsEquipe(nomEpreuve, nomEquipe, numRound, "");
            GetScore();
            chrono.Stop();

            nbrVache = 0;
            richTextBoxResultats.AppendText('\n' + "NULL");
            btnValidationResultats.Enabled = true;
            btnBonneVache.Enabled = false;
            btnMauvaiseVache.Enabled = false;

        }

        private void btnValidationResultats_Click(object sender, EventArgs e)
        {
            btnEquipeSuivante.Enabled = true;
        }

        private void btnEquipeSuivante_Click(object sender, EventArgs e)
        {
            equipeCouranteIndex++;

            // Afficher l'équipe courante et l'équipe suivante
            AfficherEquipeCourante();
            AfficherEquipeSuivante();
            // vide la liste des noms d'équipes après chaque passage
            //pour éviter que les noms d'équipes ne se répètent et que la memoire ne soit pas surchargée

            //FinDuRound();

            
            richTextBoxResultats.Clear();
        }
        private void AfficherEquipeCourante()
        {
            // Afficher l'équipe courante dans votre interface utilisateur (par exemple, dans un label)
            // Par exemple :
            if (equipeCouranteIndex < listePassage.Count)
            {
                Inscription equipeCourante = listePassage[equipeCouranteIndex];
                lblNomEquipeEnCours.Text = equipeCourante.NomEquipe; // Remplacez "NomEquipe" par le nom de la propriété correspondante dans votre classe Inscription
                lblTimer.Text = "00:00:000";
                btnStart.Enabled = true;
                btnValidationResultats.Enabled = false;
                btnEquipeSuivante.Enabled = false;
            }
            else
            {
                btnRetour.Enabled = true;
                enCoursDEpreuve = false;
                lblNomEquipeEnCours.Text = "Toutes les équipes ont terminé";
                btnStart.Enabled = false;
                DialogResult dr = MessageBox.Show("Toutes les équipes ont terminé ! Voulez-vous fermer cette fenetre ?", "Fin de la liste de passage", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dr == DialogResult.Yes) Close();
                else
                {
                   MessageBox.Show("Pour lancer une nouvelle Epreuve, sélectionné et lancer l'epreuve", "Fin de la liste de passage", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void AfficherEquipeSuivante()
        {
            // Afficher l'équipe suivante dans votre interface utilisateur (par exemple, dans un label)
            // Par exemple :
            int equipeSuivanteIndex = equipeCouranteIndex + 1;
            if (equipeSuivanteIndex < listePassage.Count)
            {
                Inscription equipeSuivante = listePassage[equipeSuivanteIndex];
                lblNomEquipeSuivante.Text = equipeSuivante.NomEquipe; // Remplacez "NomEquipe" par le nom de la propriété correspondante dans votre classe Inscription
            }
            else
            {
                lblNomEquipeSuivante.Text = "Fin de la liste de passage";
            }
        }
        private void cmbBoxNumRound_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnLancer.Enabled = true;
        }

        private void cmbBoxSelectEpreuve_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbBoxNumRound.Items.Remove("2");
            string nomEpreuve = cmbBoxSelectEpreuve.Text;
            MaJComboBoxNbrRound(nomEpreuve);
            cmbBoxNumRound.Enabled = true;
        }

        private void GetScore()
        {
            try
            {
                int.TryParse(cmbBoxNumRound.Text, out int numRound);
                string nomEpreuve = cmbBoxSelectEpreuve.Text;
                bool sansScore = false;
                bool sansInscrit = false;
                dataGridViewScoresEquipe.DataSource = parent.Controleur.GetScores(nomEpreuve, numRound, out sansScore);

            }
            catch (Exception e)
            {
                MessageBox.Show("Erreur : \n" + e.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // throw e;   // Q : qu'est-ce que cette instruction produit ?
            }
        }

        private void btnRetour_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void GetScoreRoundEpreuve()
        {
            try
            {
                int.TryParse(cmbBoxNumRound.Text, out int numRound);
                string nomEpreuve = cmbBoxSelectEpreuve.Text;
                bool sansScore = false;
                
                List<Scores> scores = parent.Controleur.GetScores(nomEpreuve, numRound, out sansScore);
                if (sansScore)
                {
                    dataGridViewScoresEquipe.DataSource = scores;
                    btnStart.Enabled = true;
                    // Création de la liste de passage avec les inscriptions en ordre aléatoire
                    listePassage = parent.Controleur.CreateRandomPassageList(nomEpreuve);

                    // Initialisation de l'équipe courante à la première équipe de la liste de passage
                    equipeCouranteIndex = 0;

                    // Affichage de l'équipe courante et de l'équipe suivante
                    AfficherEquipeCourante();
                    AfficherEquipeSuivante();
                }
                else
                {
                    dataGridViewScoresEquipe.DataSource = scores;
                    MessageBox.Show("L'épreuve a déjà eu lieu ou aucune inscription n'ont été enregistrée! \n Vous pouvez  visualiser les résultats ou choisir une autre épreuve", "Score existant", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnStart.Enabled = false;
                }
                

            }
            catch (Exception e)
            {
                MessageBox.Show("Erreur : \n" + e.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // throw e;   // Q : qu'est-ce que cette instruction produit ?
            }
        }

        private string GetDateEpreuve(string nomEpreuve)
        {
            string dateEpreuve = "";
            try
            {
               dateEpreuve = parent.Controleur.GetDateEpreuve(nomEpreuve);
            }
            catch (Exception e)
            {
                MessageBox.Show("Erreur : \n" + e.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // throw e;   // Q : qu'est-ce que cette instruction produit ?
            }

            return dateEpreuve;
        }
        private void btnLancer_Click(object sender, EventArgs e)
        {

            string nomEpreuve = cmbBoxSelectEpreuve.Text;

            GetScoreRoundEpreuve();
            

        }
    }
}
