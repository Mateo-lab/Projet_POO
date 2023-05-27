using Ranch_Sorting.Controleur;
using Ranch_Sorting.Modeles;
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
        Lobby parent; // donnée membre privée pour stocker le contrôleur
        ListeNomsEquipes listeNomsEquipes;

        private Timer timer;
        private int nbrParticipants, numeroDePassage, numVache, nbrVache;
        private static Stopwatch chrono;
        static DateTime startTime;

        
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
           

            if (elapsedTime.TotalSeconds >= 10)
            {

                string nomEpreuve = cmbBoxSelectEpreuve.Text;
                string dateEpreuve = GetDateEpreuve(cmbBoxSelectEpreuve.Text);
                string nomEquipe = lblNomEquipeEnCours.Text;
                int.TryParse(cmbBoxNumRound.Text, out int numRound);

                chrono.Stop();
                parent.Controleur.ResultatsEquipe(nomEpreuve, nomEquipe, numRound, nbrVache.ToString());
                GetScoreRoundEpreuve();

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
            MaJComboBoxNomEpreuve();
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
            btnBonneVache.Enabled = true;
            btnMauvaiseVache.Enabled = true;

            GestionTimer();
            btnStart.Enabled = false;
            lblNumVache.Text = RandomNumber(0, 9).ToString();
            lblNumVache.Visible = true;
            numVache = int.Parse(lblNumVache.Text);
        }
        private void BtnStopChrono_Click(object sender, EventArgs e)
        {
            chrono.Stop();
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
            GetScoreRoundEpreuve();

            if (nbrVache == 10)
            {
                parent.Controleur.ResultatsEquipe(nomEpreuve, nomEquipe, numRound, "TEN COWS");
                GetScoreRoundEpreuve();
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

            parent.Controleur.ResultatsEquipe(nomEpreuve, nomEquipe, numRound, "00-NO TIME");
            GetScoreRoundEpreuve();
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

            int.TryParse(cmbBoxNumRound.Text, out int numRound);
            string nomEpreuve = cmbBoxSelectEpreuve.Text;

            if (numeroDePassage != nbrParticipants)
            {
                lblNomEquipeEnCours.Text = listeNomsEquipes.GetNomEquipeEnCours(numeroDePassage);
                lblNomEquipeSuivante.Text = listeNomsEquipes.GetNomEquipeSuivante(numeroDePassage);
                numeroDePassage++;
            }
            else
            {

                lblEquipeEncours.Text = listeNomsEquipes.GetNomEquipeEnCours(numeroDePassage);
                lblEquipeSuivante.Text = "Aucun équipe restantes";
                numeroDePassage = 0;
            }

            listeNomsEquipes.Clear(); // vide la liste des noms d'équipes après chaque passage
            //pour éviter que les noms d'équipes ne se répètent et que la memoire ne soit pas surchargée

            //FinDuRound();

            lblTimer.Text = "00:00:000";
            btnStart.Enabled = true;
            btnValidationResultats.Enabled = false;
            btnEquipeSuivante.Enabled = false;
            richTextBoxResultats.Clear();
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

        private void GetScoreRoundEpreuve()
        {
            try
            {
                int.TryParse(cmbBoxNumRound.Text, out int numRound);
                string nomEpreuve = cmbBoxSelectEpreuve.Text;
                dataGridViewScoresEquipe.DataSource = parent.Controleur.GetScores(nomEpreuve, numRound);
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

            int.TryParse(cmbBoxNumRound.Text, out int numRound);
            string nomEpreuve = cmbBoxSelectEpreuve.Text;
            listeNomsEquipes = new ListeNomsEquipes(parent.Controleur.ObtienOrdreParticipants(nomEpreuve, numRound));
            nbrParticipants = listeNomsEquipes.CompterEquipes();

            if (nbrParticipants == 0)
            {
                MessageBox.Show("Aucune équipe n'est inscrite à cette épreuve", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            lblNomEquipeEnCours.Text = listeNomsEquipes.GetNomEquipeEnCours(numeroDePassage);
            lblNomEquipeSuivante.Text = listeNomsEquipes.GetNomEquipeSuivante(numeroDePassage);
            GetScoreRoundEpreuve();
            btnStart.Enabled = true;
        }
    }
}
