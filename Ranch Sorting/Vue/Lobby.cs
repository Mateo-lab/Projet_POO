using Ranch_Sorting.Controleur;
using Ranch_Sorting.Modeles;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        private void Lobby_Load(object sender, EventArgs e)
        {
            
        }

        public void getData()
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
        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void splitContainer2_SplitterMoved(object sender, SplitterEventArgs e)
        {

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
            getData();
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

       
    }
}
