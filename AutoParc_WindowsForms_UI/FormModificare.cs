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

    public partial class FormModificare : MetroForm
    {
        private AdministrareVehicule_FisierText gestiuneAuto;
        ArrayList optiuniSelectate = new ArrayList();
        public FormModificare(int ID)
        {
            
            InitializeComponent();
            string numeFisier = ConfigurationManager.AppSettings["NumeFisier"];
            string locatieFisierSolutie = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName;
            string caleCompletaFisierVehicule = Path.Combine(locatieFisierSolutie, numeFisier);

            txtID.Text = ID.ToString();

            gestiuneAuto = new AdministrareVehicule_FisierText(caleCompletaFisierVehicule);
            SetareControale();
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
                RdbAlbastru = rdbAlbastru
            };
            return ValidareDate.Valideaza(controale);
        }


        private void SetareControale()
        {
            
            Vehicul vehicul = gestiuneAuto.GetVehiculByIndex(Int32.Parse(txtID.Text));


            txtMarca.Text = vehicul.Marca;
            txtModel.Text = vehicul.Model;
            txtAnul.Text = vehicul.AnFabricatie.ToString();
            txtNrDeIm.Text = vehicul.NumarInmatriculare;
            txtStare.Text = vehicul.StareTehnica;
            if (vehicul.Culoare == Culoare.Rosu)
                rdbRed.Checked = true;
            else if (vehicul.Culoare == Culoare.Verde)
                rdbVerde.Checked = true;
            else if (vehicul.Culoare == Culoare.Albastru)
                rdbAlbastru.Checked = true;

            foreach (var optiune in gpbOptiuni.Controls)
            {
                if (optiune is CheckBox)
                {
                    var optiune1 = optiune as CheckBox;
                    foreach (String dis in vehicul.OptiuniVehicule)
                    {
                        if (optiune1.Text == dis)
                        {
                            optiune1.Checked = true;

                        }
                    }
                }
            }

            switch (vehicul.Culoare)
            {
                case Culoare.Alb:
                    rdbAlb.Checked = true;
                    break;
                case Culoare.Rosu:
                    rdbRed.Checked = true;
                    break;
                case Culoare.Verde:
                    rdbVerde.Checked = true;
                    break;
                case Culoare.Albastru:
                    rdbAlbastru.Checked = true;
                    break;

            }
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
        private void btnSave_Click(object sender, EventArgs e)
        {

            if (!Validare())
                return;

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

            Vehicul vehicul = new Vehicul(id, marca, model, anul, numarInmatriculare, stareTehnica, dimensiuneSelectata, OptiuniVehicule);
            gestiuneAuto.UpdateVehicul(vehicul);
            MessageBox.Show("Vehiculul a fost modificat cu succes!");

        }

    }
}
