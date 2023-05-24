using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace Ranch_Sorting.Vue
{
    public partial class NouvelleEquipe : Form
    {
        Lobby parent;
        public NouvelleEquipe(Lobby parent_)
        {
            InitializeComponent();
            parent = parent_;
        }

        

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            try
            {
                parent.Controleur.AjouterEquipe(txtBoxNomEquipe.Text, txtBoxNomPremierCavalier.Text, txtBoxNomPremierCheval.Text, txtBoxNomDeuxiemeCavalier.Text, txtBoxNomDeuxiemeCheval.Text);
                parent.GetEquipe();
            }
            catch (Exception exc)
            {
                MessageBox.Show("Erreur : \n" + exc.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            DialogResult dr = MessageBox.Show("Voulez vous ajoutez une autre equipe ?", "Ajout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.No)
                this.Close();
            else
            {
                txtBoxNomPremierCheval.Clear();   
                txtBoxNomPremierCavalier.Clear();
                txtBoxNomDeuxiemeCheval.Clear();
                txtBoxNomDeuxiemeCavalier.Clear();
            }
        }

        private void txtBoxNomEquipe_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBoxNomDeuxiemeCheval_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBoxNomDeuxiemeCavalier_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBoxNomPremierCheval_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBoxNomPremierCavalier_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblNomEquipe_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
