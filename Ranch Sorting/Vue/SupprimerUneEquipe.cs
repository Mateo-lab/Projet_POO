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
    public partial class SupprimerUneEquipe : Form
    {
        Lobby parent;
        public SupprimerUneEquipe(Lobby parent_)
        {
            InitializeComponent();
            parent = parent_;
        }

        private void SupprimerUneEquipe_Load(object sender, EventArgs e)
        {

        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            try
            {
                parent.Controleur.SupprimerEquipe(txtBoxEquipeASupprimer.Text);
                parent.getData();
            }
            catch (Exception exc)
            {
                MessageBox.Show("Erreur : \n" + exc.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            DialogResult dr = MessageBox.Show("Voulez vous supprimer un autre equipe ?", "Ajout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.No)
                this.Close();
            else
            {
                txtBoxEquipeASupprimer.Clear();
            }
        }
    }
}
