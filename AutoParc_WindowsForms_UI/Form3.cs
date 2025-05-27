using LibrarieModele;
using StocareDate;
using System;
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
using MetroFramework.Forms;

namespace AutoParc_WindowsForms_UI
{
    public partial class Form3 : MetroForm
    {
        private AdministrareVehicule_FisierText gestiuneAuto;
        public Form3()
        {
            InitializeComponent();
            string numeFisier = ConfigurationManager.AppSettings["NumeFisier"];
            string locatieFisierSolutie = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName;
            string caleCompletaFisierVehicule = Path.Combine(locatieFisierSolutie, numeFisier);

            gestiuneAuto = new AdministrareVehicule_FisierText(caleCompletaFisierVehicule);
        }
        public List<Vehicul> VehiculeGasite { get; set; }

        private void btnCauta_Click(object sender, EventArgs e)
        {
            string modelCautat = txtModel.Text.Trim();

            if (string.IsNullOrWhiteSpace(modelCautat))
            {
                MessageBox.Show("Introduceți un model pentru căutare.", "Eroare de validare");
                return;
            }

            Vehicul[] vehiculeGasite = gestiuneAuto.CautaVehiculeDupaModel(modelCautat, out int nrGasite);

            if (nrGasite > 0)
            {
                VehiculeGasite = vehiculeGasite.ToList();
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Nu a fost găsit niciun vehicul cu modelul specificat.");
                txtModel.Text = string.Empty;
            }
        }


    }
}
