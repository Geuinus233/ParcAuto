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
using MetroFramework.Forms;
namespace AutoParc_WindowsForms_UI
{
    public partial class Form2 : MetroForm
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
            if (optiuniSelectate.Count == 0)
            {
                OptiuniVehicule.Add("Niciuna");
            }
            else
            {
                OptiuniVehicule.AddRange(optiuniSelectate);
            }

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
            else if (rdbAlb.Checked)
                return Culoare.Alb;
            else
                return Culoare.Necunoscut;
        }


        private bool Validare()
        {
            var controale = new ValidareDate.ControaleVehicul
            {
                TxtID = txtID,
                TxtMarca = txtMarca,
                TxtModel = txtModel,
                TxtAnul = txtAnul,
                TxtNrDeIm = txtNrDeIm,
                TxtStare = txtStare,
                RdbRed = rdbRed,
                RdbVerde = rdbVerde,
                RdbAlbastru = rdbAlbastru,
                RdbAlba = rdbAlb
            };
            return ValidareDate.Valideaza(controale);
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

        
    }
}

