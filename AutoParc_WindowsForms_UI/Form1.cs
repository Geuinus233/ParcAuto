using System;
using LibrarieModele;
using StocareDate;
using System.Configuration;
using System.Drawing;
using System.IO;
using System.Windows.Forms;


namespace AutoParc_WindowsForms_UI
{
    public partial class Form1 : Form
    {
        private AdministrareVehicule_FisierText gestiuneAuto;

        
        

        private const int LATIME_CONTROL = 150;
        private const int DIMENSIUNE_PAS_Y = 40;
        private const int DIMENSIUNE_PAS_X = 160;
        

        public Form1()
        {
            InitializeComponent();

            string numeFisier = ConfigurationManager.AppSettings["NumeFisier"];
            string locatieFisierSolutie = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName;
            string caleCompletaFisierVehicule = Path.Combine(locatieFisierSolutie, numeFisier);

            gestiuneAuto = new AdministrareVehicule_FisierText(caleCompletaFisierVehicule);

            this.SuspendLayout();
            // 
            // btnAdauga
            
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);


            // Setare proprietăți formă
            this.Size = new Size(800, 600);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Font = new Font("Arial", 9, FontStyle.Bold);
            this.ForeColor = Color.Black;
            this.Text = "Administrare Vehicule";

            // Adăugare controale
            
            
           

            this.Load += new EventHandler(Form1_Load);
        }

       
       

        private void Form1_Load(object sender, EventArgs e)
        {
            AfisareVehicule();
        }

        

        private void btnAdauga_Click_1(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();

        }

        

        private void AfisareVehicule()
        {
            Vehicul[] vehicule = gestiuneAuto.GetVehicule(out int nrVehicule);

            int pozitieY = 3;
            foreach (Vehicul vehicul in vehicule)
            {
                AdaugaLabelDinamic(vehicul.ID.ToString(), 1, pozitieY);
                AdaugaLabelDinamic(vehicul.Marca, 2, pozitieY);
                AdaugaLabelDinamic(vehicul.Model, 3, pozitieY);
                AdaugaLabelDinamic(vehicul.AnFabricatie.ToString(), 4, pozitieY);
                pozitieY++;
            }
        }

        private void AdaugaLabelDinamic(string text, int pozitieX, int pozitieY)
        {
            Label label = new Label
            {
                Width = LATIME_CONTROL,
                Text = text,
                Left = pozitieX * DIMENSIUNE_PAS_X,
                Top = pozitieY * DIMENSIUNE_PAS_Y
            };
            this.Controls.Add(label);
        }

        
      

        

        private void btnRefresh_Click_1(object sender, EventArgs e)
        {
            AfisareVehicule();
        }

        private void btnCautare_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
        }
    }
}

