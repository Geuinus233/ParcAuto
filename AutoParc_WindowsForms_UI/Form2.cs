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
    public partial class Form2 : Form
    {
        private AdministrareVehicule_FisierText gestiuneAuto;
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

            Vehicul vehicul = new Vehicul(id, marca, model, anul, "", "", Culoare.Alb);
            gestiuneAuto.AddVehicul(vehicul);

            MessageBox.Show("Vehiculul a fost adăugat cu succes!");
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

        
    }
}

