using Ranch_Sorting.Controleur;
using Ranch_Sorting.Modeles;
using System;
using System.Diagnostics;
using System.Windows.Forms;
using Timer = System.Windows.Forms.Timer;

namespace Ranch_Sorting.Vue
{
    public partial class Round : Form
    {
        private Controle ctrl; // donnée membre privée pour stocker le contrôleur

        private Timer timer;
        private int nbrParticipants, numeroDePassage, numVache, nbrVache;
        private static Stopwatch chrono;
        static DateTime startTime;

        public Round()
        {
            InitializeComponent();
            timer = new Timer();
            timer.Interval = 10;
            timer.Tick += Timer_Tick;
        }

        //Constructeur
        public Controle Ctrl
        {
            set
            {
                ctrl = value;
            }
            get
            {
                return ctrl;
            }
        } // propriété set Contrôleur pour modifier la donnée membre privée ctrl
        
        //Méthodes
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
            lblTimer.Invoke(new Action(() =>
            {
                lblTimer.Text = string.Format("{0:00}:{1:00}:{2:000}",
                    elapsedTime.Minutes, elapsedTime.Seconds, elapsedTime.Milliseconds);
            }));

            if (elapsedTime.Seconds == 90)
            {

                string nomEpreuve = cmbBoxSelectEpreuve.Text;
                string dateEpreuve = GetDateEpreuve(cmbBoxSelectEpreuve.Text);
                string nomEquipe = lblEquipeEncours.Text;
                int.TryParse(cmbBoxNumRound.Text, out int numRound);
                string temps = GetTempsDerniereVache();

                chrono.Stop();
                ctrl.ResultatsEquipe(nomEpreuve, dateEpreuve, nomEquipe, numRound, nbrVache , temps);
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
        private void button1_Click_1(object sender, EventArgs e)
        {
            chrono.Stop();
        }
        private string TempsVache(int numvache)
        {
            string temps = lblTimer.Text;
            return temps;
        }

        private string GetTempsDerniereVache()
        {
            int lastLineIndex = richTextBoxResultats.Lines.Length - 1; // Indice de la dernière ligne
            string lastLine = richTextBoxResultats.Lines[lastLineIndex]; // Lecture de la dernière ligne

            int commaIndex = lastLine.IndexOf(":"); // Recherche de la position de la virgule
            string temps = lastLine.Substring(commaIndex + 2); // Extraction de la sous-chaîne après la virgule
            // le + 2 permet de ne pas prendre les deux points et l'espace
            return temps;
        }
       
        private void btnStart_Click_1(object sender, EventArgs e)
        {
            btnBonneVache.Enabled = true;
            btnMauvaiseVache.Enabled = true;
            GestionTimer();
            btnStart.Enabled = false;
            lblNumVache.Text = RandomNumber(0, 9).ToString();
            lblNumVache.Visible = true; 
            numVache = int.Parse(lblNumVache.Text);
        }

        private void btnBonneVache_Click_1(object sender, EventArgs e)
        {

            nbrVache++; // correspond au nombre de vache passée donc il doit commebcer à 1

            string nomEpreuve = cmbBoxSelectEpreuve.Text;
            string dateEpreuve = GetDateEpreuve(cmbBoxSelectEpreuve.Text);
            string nomEquipe = lblEquipeEncours.Text;
            int.TryParse(cmbBoxNumRound.Text, out int numRound);
            string temps = TempsVache(numVache);

            ctrl.AjouterTempsVache(nomEpreuve, dateEpreuve, nomEquipe, numRound, numVache, temps);
            richTextBoxResultats.AppendText('\n' + "Vache " + numVache + " : " + TempsVache(numVache));

            if (nbrVache == 10)
            {
                chrono.Stop();
                ctrl.ResultatsEquipe(nomEpreuve, dateEpreuve, nomEquipe, numRound, nbrVache, temps );
                btnBonneVache.Enabled = false;
                btnMauvaiseVache.Enabled = false;
                btnValidationResultats.Enabled = true;
            }
            if (numVache == 9)
            {
                numVache = 0;
            }
            else
            {
                numVache++;
            }
        }

        private void btnMauvaiseVache_Click_1(object sender, EventArgs e)
        {

            string nomEpreuve = cmbBoxSelectEpreuve.Text;
            string dateEpreuve = GetDateEpreuve(cmbBoxSelectEpreuve.Text);
            string nomEquipe = lblEquipeEncours.Text;
            int.TryParse(cmbBoxNumRound.Text, out int numRound);

            ctrl.ResultatsEquipe(nomEpreuve, dateEpreuve, nomEquipe, numRound, 99 , null);

            chrono.Stop();
            richTextBoxResultats.AppendText('\n' + "NULL");
            btnValidationResultats.Enabled = true;
            btnBonneVache.Enabled = false;
            btnMauvaiseVache.Enabled = false;
        }

        private void BtnStopChrono_Click_1(object sender, EventArgs e)
        {
            chrono.Stop();
        }
        private void btnValidationResultats_Click_1(object sender, EventArgs e)
        {

            btnEquipeSuivante.Enabled = true;
        }
        private void btnEquipeSuivante_Click_2(object sender, EventArgs e)
        {

            int.TryParse(cmbBoxNumRound.Text, out int numRound);
            string nomEpreuve = cmbBoxSelectEpreuve.Text;
            string dateEpreuve = GetDateEpreuve(cmbBoxSelectEpreuve.Text);

            ListeNomsEquipes listeNomsEquipes = ctrl.ObtienOrdreParticipants(nomEpreuve, dateEpreuve, numRound);
            
            if (numeroDePassage != nbrParticipants )
            {
                lblEquipeEncours.Text = listeNomsEquipes.GetNomEquipeEnCours(numeroDePassage);
                lblEquipeSuivante.Text = listeNomsEquipes.GetNomEquipeSuivante(numeroDePassage);
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

        private void Round_Load(object sender, EventArgs e)
        {
            MaJComboBoxNomEpreuve();
        }
        private void MaJComboBoxNomEpreuve()
        {
            try
            {
                cmbBoxSelectEpreuve.Items.AddRange(ctrl.GetNomEpreuve().ToArray());
            }
            catch (Exception e)
            {
                MessageBox.Show("Erreur : \n" + e.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // throw e;   // Q : qu'est-ce que cette instruction produit ?
            }
        }
        private void GetScoreRoundEpreuve()
        {
            try
            {
                int.TryParse(cmbBoxNumRound.Text, out int numRound);
                string nomEpreuve = cmbBoxSelectEpreuve.Text;
                string dateEpreuve = GetDateEpreuve(cmbBoxSelectEpreuve.Text);
                dataGridViewScoresEquipe.DataSource = ctrl.GetScores(nomEpreuve, dateEpreuve, numRound);
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
               dateEpreuve = ctrl.GetDateEpreuve(nomEpreuve);
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
            string dateEpreuve = GetDateEpreuve(cmbBoxSelectEpreuve.Text);

            ListeNomsEquipes listeNomsEquipes = ctrl.ObtienOrdreParticipants(nomEpreuve, dateEpreuve, numRound);
            nbrParticipants = listeNomsEquipes.CompterEquipes();

            if (nbrParticipants == 0)
            {
                MessageBox.Show("Aucune équipe n'est inscrite à cette épreuve", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            lblEquipeEncours.Text = listeNomsEquipes.GetNomEquipeEnCours(numeroDePassage);
            lblEquipeSuivante.Text = listeNomsEquipes.GetNomEquipeSuivante(numeroDePassage);
            GetScoreRoundEpreuve();
            btnStart.Enabled = true;
        }
    }
}
