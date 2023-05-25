using Ranch_Sorting.Controleur;
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
        int nbrVache;
        private static Stopwatch chrono;
        static DateTime startTime;
        private int numVache;

        public Controle Ctrlr 
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
        public Round()
        {
            InitializeComponent();
            timer = new Timer();
            timer.Interval = 10;
            timer.Tick += Timer_Tick;
        }

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
                chrono.Stop();
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
       

        private void btnValidationResultats_Click(object sender, EventArgs e)
        {
            btnEquipeSuivante.Enabled = true;
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
            if (nbrVache == 9)
            {
                chrono.Stop();
                btnBonneVache.Enabled = false;
                btnMauvaiseVache.Enabled = false;
                btnValidationResultats.Enabled = true;
            }
            //string temps = TempsVache(numVache);
           // string nomEpreuve = parent.GetNomEpreuve();
           // string dateEpreuve = parent.GetDateEpreuve();
           // string nomEquipe = parent.GetNomEquipe();

            //controleur.AjouterTempsVache(nomEpreuve, dateEpreuve, nomEquipe, numVache, temps);
            richTextBoxResultats.AppendText('\n' + "Vache " + numVache + " : " + TempsVache(numVache));

            if (numVache == 9)
            {
                numVache = 0;
            }
            else
            {
                numVache++;
            }
            nbrVache++;
        }

        private void btnMauvaiseVache_Click_1(object sender, EventArgs e)
        {

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
            GetScoreRoundEpreuve();
            btnStart.Enabled = true;
        }
    }
}
