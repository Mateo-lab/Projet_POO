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

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            try
            {
                parent.Controleur.SupprimerEquipe(txtBoxEquipeASupprimer.Text);
                parent.GetEquipe();

                DialogResult dr = MessageBox.Show("Voulez vous supprimer un autre equipe ?", "Ajout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.No) Close();
                else
                {
                    txtBoxEquipeASupprimer.Clear();
                }
            }
            catch (Exception exc)
            {
                string exceptionName = exc.GetType().Name;
                if (exceptionName == "OleDbException" && exc.Message.Contains("Impossible de supprimer ou de modifier l'enregistrement car la table « Inscriptions » comprend des enregistrements connexes.")) // Numéro d'erreur spécifique pour violation d'unicité
                {
                    DialogResult dr = MessageBox.Show("Supprimer une equipe entrainera la suppresion de toutes ses inscription et scores !! Voulez-vous continuez ?", "Supprimer une équipe", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (dr == DialogResult.Yes)
                    {

                        parent.Controleur.SupprimerUneInscriptionEtEquipe(txtBoxEquipeASupprimer.Text);
                        parent.GetEquipe();
                    }
                }
                else
                {
                    MessageBox.Show("Erreur : \n" + exc.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }

            
        }
    }
}
