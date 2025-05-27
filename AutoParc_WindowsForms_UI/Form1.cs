using System;
using LibrarieModele;
using StocareDate;
using System.Configuration;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Data;
using System.Collections;
using MetroFramework.Forms;

namespace AutoParc_WindowsForms_UI
{
    public partial class Form1 : MetroForm
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

        private void AfisareVehiculeInGrid(Vehicul[] vehicule)
        {
            dataGridVeh.DataSource = null;

            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("ID");
            dataTable.Columns.Add("Marca");
            dataTable.Columns.Add("Model");
            dataTable.Columns.Add("An");
            dataTable.Columns.Add("Numar Inmatriculare");
            dataTable.Columns.Add("Stare Tehnica");
            dataTable.Columns.Add("Culoare");
            dataTable.Columns.Add("Optiuni");

            foreach (Vehicul vehicul in vehicule)
            {
                DataRow row = dataTable.NewRow();
                row["ID"] = vehicul.ID;
                row["Marca"] = vehicul.Marca;
                row["Model"] = vehicul.Model;
                row["An"] = vehicul.AnFabricatie;
                row["Numar Inmatriculare"] = vehicul.NumarInmatriculare;
                row["Stare Tehnica"] = vehicul.StareTehnica;
                row["Culoare"] = vehicul.GetCuloareToString();
                row["Optiuni"] = vehicul.OptiuniVehiculeToString();
                dataTable.Rows.Add(row);
            }

            dataGridVeh.DataSource = dataTable;
        }



        


        private void btnRefresh_Click_1(object sender, EventArgs e)
        {
            // Refresh the grid after deletion
            Vehicul[] vehicule = gestiuneAuto.GetVehicule(out int nrVehicule);
            AfisareVehiculeInGrid(vehicule);
        }

        private void btnCautare_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            if (form3.ShowDialog() == DialogResult.OK && form3.VehiculeGasite != null)
            {
                // Convert List<Vehicul> to Vehicul[] to match the method signature
                AfisareVehiculeInGrid(form3.VehiculeGasite.ToArray());
            }
        }

        private void btnMod_Click(object sender, EventArgs e)
        {
            if  (dataGridVeh.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selectati o comanda pentru a o modifica.");
                return;
            }
            
            FormModificare form5 = new FormModificare(Convert.ToInt32(dataGridVeh.CurrentRow.Cells[0].Value));
            form5.Show();
        }

        private void btnSterg_Click(object sender, EventArgs e)
        {
            if (dataGridVeh.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selectați un vehicul pentru a-l șterge.");
                return;
            }

            int id = Convert.ToInt32(dataGridVeh.CurrentRow.Cells["ID"].Value);

            var confirmResult = MessageBox.Show("Sigur doriți să ștergeți acest vehicul?", "Confirmare ștergere", MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                bool rezultat = gestiuneAuto.StergeVehicul(id);
                if (rezultat)
                {
                    MessageBox.Show("Vehicul șters cu succes!");

                    // Fix: Pass the required parameter 'vehicule' to the method  
                    Vehicul[] vehicule = gestiuneAuto.GetVehicule(out int nrVehicule);
                    AfisareVehiculeInGrid(vehicule);
                }
                else
                {
                    MessageBox.Show("Vehiculul nu a putut fi șters (nu a fost găsit).");
                }
            }
        }
    }
}

