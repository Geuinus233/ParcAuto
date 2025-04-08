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

        private TextBox txtID, txtMarca, txtModel, txtAnul;
        private Label lblEroareID, lblEroareMarca, lblEroareModel, lblEroareAnul;
        private Button btnAdauga, btnRefresh;

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

            this.btnAdauga = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAdauga
            // 
            this.btnAdauga.Location = new System.Drawing.Point(50, 350);
            this.btnAdauga.Name = "btnAdauga";
            this.btnAdauga.Size = new System.Drawing.Size(100, 30);
            this.btnAdauga.TabIndex = 0;
            this.btnAdauga.Text = "Adaugă";
            this.btnAdauga.UseVisualStyleBackColor = true;
            this.btnAdauga.Click += new System.EventHandler(this.BtnAdauga_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(200, 350);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(100, 30);
            this.btnRefresh.TabIndex = 1;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.BtnRefresh_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAdauga);
            this.Controls.Add(this.btnRefresh);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);


            // Setare proprietăți formă
            this.Size = new Size(800, 600);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Font = new Font("Arial", 9, FontStyle.Bold);
            this.ForeColor = Color.DarkRed;
            this.Text = "Administrare Vehicule";

            // Adăugare controale
            AdaugaLabelSiTextBox("ID", out txtID, out lblEroareID, 1);
            AdaugaLabelSiTextBox("Marca", out txtMarca, out lblEroareMarca, 2);
            AdaugaLabelSiTextBox("Model", out txtModel, out lblEroareModel, 3);
            AdaugaLabelSiTextBox("Anul", out txtAnul, out lblEroareAnul, 4);

            btnAdauga = AdaugaButton("Adaugă Vehicul", OnButtonAdaugaClicked, 1, 2);
            btnRefresh = AdaugaButton("Refresh", OnButtonRefreshClicked, 2, 2);

            this.Load += new EventHandler(Form1_Load);
        }

        private void AdaugaLabelSiTextBox(string labelText, out TextBox textBox, out Label eroareLabel, int pozitieX)
        {
            Label label = new Label
            {
                Width = LATIME_CONTROL,
                Text = labelText,
                Left = pozitieX * DIMENSIUNE_PAS_X,
                ForeColor = Color.DarkGreen
            };
            this.Controls.Add(label);

            textBox = new TextBox
            {
                Width = LATIME_CONTROL,
                Left = pozitieX * DIMENSIUNE_PAS_X,
                Top = DIMENSIUNE_PAS_Y
            };
            this.Controls.Add(textBox);

            eroareLabel = new Label
            {
                Width = LATIME_CONTROL,
                Left = pozitieX * DIMENSIUNE_PAS_X,
                Top = 2 * DIMENSIUNE_PAS_Y,
                ForeColor = Color.Red
            };
            this.Controls.Add(eroareLabel);
        }

        private Button AdaugaButton(string text, EventHandler onClick, int pozitieX, int pozitieY)
        {
            Button button = new Button
            {
                Width = LATIME_CONTROL,
                Text = text,
                Location = new Point(pozitieX * DIMENSIUNE_PAS_X, pozitieY * DIMENSIUNE_PAS_Y)
            };
            button.Click += onClick;
            this.Controls.Add(button);
            return button;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            AfisareVehicule();
        }

        private void OnButtonAdaugaClicked(object sender, EventArgs e)
        {
            // Resetare mesaje eroare
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

        private void OnButtonRefreshClicked(object sender, EventArgs e)
        {
            AfisareVehicule();
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

        private bool Validare()
        {
            bool valid = true;

            if (string.IsNullOrWhiteSpace(txtID.Text) || !int.TryParse(txtID.Text, out _))
            {
                lblEroareID.Text = "ID trebuie să fie un număr întreg!";
                valid = false;
            }

            if (string.IsNullOrWhiteSpace(txtMarca.Text))
            {
                lblEroareMarca.Text = "Marca nu poate fi goală!";
                valid = false;
            }

            if (string.IsNullOrWhiteSpace(txtModel.Text))
            {
                lblEroareModel.Text = "Modelul nu poate fi gol!";
                valid = false;
            }

            if (string.IsNullOrWhiteSpace(txtAnul.Text) || !int.TryParse(txtAnul.Text, out _))
            {
                lblEroareAnul.Text = "Anul trebuie să fie un număr întreg!";
                valid = false;
            }

            return valid;
        }
        private void BtnAdauga_Click(object sender, EventArgs e)
        {
            // Validare date introduse
            if (!Validare())
            {
                MessageBox.Show("Datele introduse nu sunt valide!");
                return;
            }

            // Creare vehicul și salvare în fișier
            int id = int.Parse(txtID.Text);
            string marca = txtMarca.Text;
            string model = txtModel.Text;
            int anul = int.Parse(txtAnul.Text);

            Vehicul vehicul = new Vehicul(id, marca, model, anul, "", "", Culoare.Alb);
            gestiuneAuto.AddVehicul(vehicul);

            MessageBox.Show("Vehiculul a fost adăugat cu succes!");
        }

        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            // Reîmprospătare afișare vehicule
            AfisareVehicule();
        }
    }
}

