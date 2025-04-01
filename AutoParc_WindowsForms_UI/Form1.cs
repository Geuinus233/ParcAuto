using System;
using LibrarieModele;
using StocareDate;
using System.Collections.Generic;
using System.Configuration;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace AutoParc_WindowsForms_UI
{
    public partial class Form1 : Form
    {
        private AdministrareVehicule_FisierText gestiuneAuto;

        private Label lblID, lblMarca, lblModel, lblAnul;
        private Label[] lblsID, lblsMarca, lblsModel, lblsAnul;

        private const int LATIME_CONTROL = 100;
        private const int DIMENSIUNE_PAS_Y = 30;

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }

        private const int DIMENSIUNE_PAS_X = 120;

        public Form1()
        {
            InitializeComponent();

            string numeFisier = ConfigurationManager.AppSettings["NumeFisier"];
            string locatieFisierSolutie = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName;
            string caleCompletaFisierVehicule = Path.Combine(locatieFisierSolutie, numeFisier);

            gestiuneAuto = new AdministrareVehicule_FisierText(caleCompletaFisierVehicule);
            
            this.Size = new Size(800, 400);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Font = new Font("Arial", 9, FontStyle.Bold);
            this.ForeColor = Color.DarkRed;
            this.Text = "Informatii Vehicule";

            lblID = CreateLabel("ID", 1);
            lblMarca = CreateLabel("Marca", 2);
            lblModel = CreateLabel("Model", 3);
            lblAnul = CreateLabel("Anul", 4);

            this.Load += new EventHandler(Form1_Load);
        }

        private Label CreateLabel(string text, int positionX)
        {
            Label label = new Label();
            label.Width = LATIME_CONTROL;
            label.Text = text;
            label.Left = positionX * DIMENSIUNE_PAS_X;
            label.ForeColor = Color.DarkBlue;
            this.Controls.Add(label);
            return label;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            AfisareVehicule();
        }

        private void AfisareVehicule()
        {
            Vehicul[] vehicule = gestiuneAuto.GetVehicule(out int nrVehicule);

            lblsID = new Label[nrVehicule];
            lblsMarca = new Label[nrVehicule];
            lblsModel = new Label[nrVehicule];
            lblsAnul = new Label[nrVehicule];

            for (int i = 0; i < nrVehicule; i++)
            {
                lblsID[i] = CreateDynamicLabel(vehicule[i].ID.ToString(), 1, i + 1);
                lblsMarca[i] = CreateDynamicLabel(vehicule[i].Marca, 2, i + 1);
                lblsModel[i] = CreateDynamicLabel(vehicule[i].Model, 3, i + 1);
                lblsAnul[i] = CreateDynamicLabel(vehicule[i].AnFabricatie.ToString(), 4, i + 1);
            }
        }

        private Label CreateDynamicLabel(string text, int positionX, int positionY)
        {
            Label label = new Label();
            label.Width = LATIME_CONTROL;
            label.Text = text;
            label.Left = positionX * DIMENSIUNE_PAS_X;
            label.Top = positionY * DIMENSIUNE_PAS_Y;
            this.Controls.Add(label);
            return label;
        }
    }
}