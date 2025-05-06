using LibrarieModele;
using StocareDate;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoParc_WindowsForms_UI
{
    public partial class Form2 : Form
    {
        private AdministrareVehicule_FisierText gestiuneAuto;
        ArrayList optiuniSelectate = new ArrayList();
        public Form2()
        {
            
            InitializeComponent();
            string numeFisier = ConfigurationManager.AppSettings["NumeFisier"];
            string locatieFisierSolutie = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName;
            string caleCompletaFisierVehicule = Path.Combine(locatieFisierSolutie, numeFisier);

            gestiuneAuto = new AdministrareVehicule_FisierText(caleCompletaFisierVehicule);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            
            lblEroareID.Text = "";
            lblEroareMarca.Text = "";
            lblEroareModel.Text = "";
            lblEroareAnul.Text = "";

            // Validare date
            if (!Validare())
                return;

            // Creare vehicul și adăugare în fișier
            int id = int.Parse(txtID.Text);
            string marca = txtMarca.Text;
            string model = txtModel.Text;
            int anul = int.Parse(txtAnul.Text);
            string numarInmatriculare = txtNrDeIm.Text;
            string stareTehnica = txtStare.Text;
            Culoare dimensiuneSelectata = GetCuloareSelectata();

            ArrayList OptiuniVehicule = new ArrayList();
            OptiuniVehicule.AddRange(optiuniSelectate);

            Vehicul vehicul = new Vehicul(id, marca, model, anul,numarInmatriculare, stareTehnica, dimensiuneSelectata, OptiuniVehicule);
            gestiuneAuto.AddVehicul(vehicul);

            MessageBox.Show("Vehiculul a fost adăugat cu succes!");
        }
        
        private Culoare GetCuloareSelectata()
        {
            if (rdbRed.Checked)
                return Culoare.Rosu;
            else if (rdbVerde.Checked)
                return Culoare.Verde;
            else if (rdbAlbastru.Checked)
                return Culoare.Albastru;
            else
                return Culoare.Necunoscut;
        }
        
        
        
        
        private bool Validare()
        {
            bool valid = true;

            if (string.IsNullOrWhiteSpace(txtID.Text) || !int.TryParse(txtID.Text, out _))
            {
                
                lblEroareID.Text = "ID trebuie să fie un număr întreg!";
                ForeColor = Color.Red;
                valid = false;
            }

            if (string.IsNullOrWhiteSpace(txtMarca.Text))
            {
                lblEroareMarca.Text = "Marca nu poate fi goală!";
                ForeColor = Color.Red;
                valid = false;
            }

            if (string.IsNullOrWhiteSpace(txtModel.Text))
            {
                lblEroareModel.Text = "Modelul nu poate fi gol!";
                ForeColor = Color.Red;
                valid = false;
            }

            if (string.IsNullOrWhiteSpace(txtAnul.Text) || !int.TryParse(txtAnul.Text, out _))
            {
                lblEroareAnul.Text = "Anul trebuie să fie un număr întreg!";
                ForeColor = Color.Red;
                valid = false;
            }

            return valid;
        }

        private void CkbOptiuniVehicule_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBoxControl = sender as CheckBox;

            string optiuneSelectata = checkBoxControl.Text;

            if (checkBoxControl.Checked)
                optiuniSelectate.Add(optiuneSelectata);
            else
                optiuniSelectate.Remove(optiuneSelectata);
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}

