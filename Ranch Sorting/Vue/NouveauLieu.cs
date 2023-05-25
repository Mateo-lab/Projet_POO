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
    public partial class NouveauLieu : Form
    {
        Lobby parent;
        public NouveauLieu(Lobby parent_)
        {
            InitializeComponent();
            parent = parent_;   
        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            try
            {
                parent.Controleur.AjouterLieu(txtBoxNomLieu.Text, txtBoxAdresse.Text, txtBoxNomProprietaire.Text);
                parent.ClearComboBox();
                parent.MaJComboBoxNomLieu();
            }
            catch (Exception exc)
            {
                MessageBox.Show("Erreur : \n" + exc.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            DialogResult dr = MessageBox.Show("Voulez vous ajoutez un autre lieu ?", "Ajout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.No)
                this.Close();
            else
            {
                txtBoxNomLieu.Clear();
                txtBoxAdresse.Clear();
                txtBoxNomProprietaire.Clear();
                
            }
        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
