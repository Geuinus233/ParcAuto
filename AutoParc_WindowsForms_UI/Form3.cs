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

namespace AutoParc_WindowsForms_UI
{
    public partial class Form3 : Form
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

        private void btnCauta_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtID.Text) && int.TryParse(txtID.Text, out int ID))
            {
                Vehicul IDgasit = gestiuneAuto.GetCar(ID);

                if (IDgasit != null)
                {
                    MessageBox.Show(IDgasit.Info(), "Vehicul gasit");
                }
                else
                {
                    MessageBox.Show("Comanda cu ID-ul specificat nu a fost gasita.");
                }
            }
        }
    }
}
