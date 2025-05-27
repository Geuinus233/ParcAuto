using MetroFramework.Controls;
namespace AutoParc_WindowsForms_UI

{
    partial class Form2
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.lblID = new MetroFramework.Controls.MetroLabel();
            this.lblMarca = new MetroFramework.Controls.MetroLabel();
            this.lblModel = new MetroFramework.Controls.MetroLabel();
            this.lblAn = new MetroFramework.Controls.MetroLabel();
            this.txtID = new MetroFramework.Controls.MetroTextBox();
            this.txtMarca = new MetroFramework.Controls.MetroTextBox();
            this.txtModel = new MetroFramework.Controls.MetroTextBox();
            this.txtAnul = new MetroFramework.Controls.MetroTextBox();
            this.btnSave = new MetroFramework.Controls.MetroButton();
            this.ckbIncalzScaune = new MetroFramework.Controls.MetroCheckBox();
            this.ckbCruise = new MetroFramework.Controls.MetroCheckBox();
            this.ckbAppleCar = new MetroFramework.Controls.MetroCheckBox();
            this.ckbCamera = new MetroFramework.Controls.MetroCheckBox();
            this.ckbSenzori = new MetroFramework.Controls.MetroCheckBox();
            this.ckbKeyless = new MetroFramework.Controls.MetroCheckBox();
            this.OptiuniVeh = new MetroFramework.Controls.MetroLabel();
            this.rdbAlb = new MetroFramework.Controls.MetroRadioButton();
            this.rdbRed = new MetroFramework.Controls.MetroRadioButton();
            this.rdbAlbastru = new MetroFramework.Controls.MetroRadioButton();
            this.rdbVerde = new MetroFramework.Controls.MetroRadioButton();
            this.lblNrDeIm = new MetroFramework.Controls.MetroLabel();
            this.lblStare = new MetroFramework.Controls.MetroLabel();
            this.txtNrDeIm = new MetroFramework.Controls.MetroTextBox();
            this.txtStare = new MetroFramework.Controls.MetroTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(44, 90);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(21, 19);
            this.lblID.TabIndex = 0;
            this.lblID.Text = "ID";
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Location = new System.Drawing.Point(44, 125);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(46, 19);
            this.lblMarca.TabIndex = 1;
            this.lblMarca.Text = "Marca";
            // 
            // lblModel
            // 
            this.lblModel.AutoSize = true;
            this.lblModel.Location = new System.Drawing.Point(44, 164);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(47, 19);
            this.lblModel.TabIndex = 2;
            this.lblModel.Text = "Model";
            // 
            // lblAn
            // 
            this.lblAn.AutoSize = true;
            this.lblAn.Location = new System.Drawing.Point(44, 202);
            this.lblAn.Name = "lblAn";
            this.lblAn.Size = new System.Drawing.Size(35, 19);
            this.lblAn.TabIndex = 3;
            this.lblAn.Text = "Anul";
            // 
            // txtID
            // 
            // 
            // 
            // 
            this.txtID.CustomButton.Image = null;
            this.txtID.CustomButton.Location = new System.Drawing.Point(78, 1);
            this.txtID.CustomButton.Name = "";
            this.txtID.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtID.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtID.CustomButton.TabIndex = 1;
            this.txtID.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtID.CustomButton.UseSelectable = true;
            this.txtID.CustomButton.Visible = false;
            this.txtID.Lines = new string[0];
            this.txtID.Location = new System.Drawing.Point(141, 90);
            this.txtID.MaxLength = 32767;
            this.txtID.Name = "txtID";
            this.txtID.PasswordChar = '\0';
            this.txtID.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtID.SelectedText = "";
            this.txtID.SelectionLength = 0;
            this.txtID.SelectionStart = 0;
            this.txtID.ShortcutsEnabled = true;
            this.txtID.Size = new System.Drawing.Size(100, 23);
            this.txtID.TabIndex = 4;
            this.txtID.UseSelectable = true;
            this.txtID.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtID.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtMarca
            // 
            // 
            // 
            // 
            this.txtMarca.CustomButton.Image = null;
            this.txtMarca.CustomButton.Location = new System.Drawing.Point(78, 1);
            this.txtMarca.CustomButton.Name = "";
            this.txtMarca.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtMarca.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtMarca.CustomButton.TabIndex = 1;
            this.txtMarca.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtMarca.CustomButton.UseSelectable = true;
            this.txtMarca.CustomButton.Visible = false;
            this.txtMarca.Lines = new string[0];
            this.txtMarca.Location = new System.Drawing.Point(141, 125);
            this.txtMarca.MaxLength = 32767;
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.PasswordChar = '\0';
            this.txtMarca.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtMarca.SelectedText = "";
            this.txtMarca.SelectionLength = 0;
            this.txtMarca.SelectionStart = 0;
            this.txtMarca.ShortcutsEnabled = true;
            this.txtMarca.Size = new System.Drawing.Size(100, 23);
            this.txtMarca.TabIndex = 5;
            this.txtMarca.UseSelectable = true;
            this.txtMarca.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtMarca.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtModel
            // 
            // 
            // 
            // 
            this.txtModel.CustomButton.Image = null;
            this.txtModel.CustomButton.Location = new System.Drawing.Point(78, 1);
            this.txtModel.CustomButton.Name = "";
            this.txtModel.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtModel.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtModel.CustomButton.TabIndex = 1;
            this.txtModel.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtModel.CustomButton.UseSelectable = true;
            this.txtModel.CustomButton.Visible = false;
            this.txtModel.Lines = new string[0];
            this.txtModel.Location = new System.Drawing.Point(141, 164);
            this.txtModel.MaxLength = 32767;
            this.txtModel.Name = "txtModel";
            this.txtModel.PasswordChar = '\0';
            this.txtModel.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtModel.SelectedText = "";
            this.txtModel.SelectionLength = 0;
            this.txtModel.SelectionStart = 0;
            this.txtModel.ShortcutsEnabled = true;
            this.txtModel.Size = new System.Drawing.Size(100, 23);
            this.txtModel.TabIndex = 6;
            this.txtModel.UseSelectable = true;
            this.txtModel.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtModel.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtAnul
            // 
            // 
            // 
            // 
            this.txtAnul.CustomButton.Image = null;
            this.txtAnul.CustomButton.Location = new System.Drawing.Point(78, 1);
            this.txtAnul.CustomButton.Name = "";
            this.txtAnul.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtAnul.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtAnul.CustomButton.TabIndex = 1;
            this.txtAnul.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtAnul.CustomButton.UseSelectable = true;
            this.txtAnul.CustomButton.Visible = false;
            this.txtAnul.Lines = new string[0];
            this.txtAnul.Location = new System.Drawing.Point(141, 202);
            this.txtAnul.MaxLength = 32767;
            this.txtAnul.Name = "txtAnul";
            this.txtAnul.PasswordChar = '\0';
            this.txtAnul.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtAnul.SelectedText = "";
            this.txtAnul.SelectionLength = 0;
            this.txtAnul.SelectionStart = 0;
            this.txtAnul.ShortcutsEnabled = true;
            this.txtAnul.Size = new System.Drawing.Size(100, 23);
            this.txtAnul.TabIndex = 7;
            this.txtAnul.UseSelectable = true;
            this.txtAnul.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtAnul.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnSave
            // 
            this.btnSave.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSave.Location = new System.Drawing.Point(44, 498);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(70, 49);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Save";
            this.btnSave.UseCustomBackColor = true;
            this.btnSave.UseCustomForeColor = true;
            this.btnSave.UseSelectable = true;
            this.btnSave.UseStyleColors = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // ckbIncalzScaune
            // 
            this.ckbIncalzScaune.AutoSize = true;
            this.ckbIncalzScaune.Location = new System.Drawing.Point(47, 350);
            this.ckbIncalzScaune.Name = "ckbIncalzScaune";
            this.ckbIncalzScaune.Size = new System.Drawing.Size(106, 15);
            this.ckbIncalzScaune.TabIndex = 13;
            this.ckbIncalzScaune.Text = "Incalzire scaune";
            this.ckbIncalzScaune.UseSelectable = true;
            this.ckbIncalzScaune.CheckedChanged += new System.EventHandler(this.CkbOptiuniVehicule_CheckedChanged);
            // 
            // ckbCruise
            // 
            this.ckbCruise.AutoSize = true;
            this.ckbCruise.Location = new System.Drawing.Point(47, 373);
            this.ckbCruise.Name = "ckbCruise";
            this.ckbCruise.Size = new System.Drawing.Size(97, 15);
            this.ckbCruise.TabIndex = 14;
            this.ckbCruise.Text = "Cruise control";
            this.ckbCruise.UseSelectable = true;
            this.ckbCruise.CheckedChanged += new System.EventHandler(this.CkbOptiuniVehicule_CheckedChanged);
            // 
            // ckbAppleCar
            // 
            this.ckbAppleCar.AutoSize = true;
            this.ckbAppleCar.Location = new System.Drawing.Point(156, 350);
            this.ckbAppleCar.Name = "ckbAppleCar";
            this.ckbAppleCar.Size = new System.Drawing.Size(177, 15);
            this.ckbAppleCar.TabIndex = 15;
            this.ckbAppleCar.Text = "Android Auto/ Apple CarPlay";
            this.ckbAppleCar.UseSelectable = true;
            this.ckbAppleCar.CheckedChanged += new System.EventHandler(this.CkbOptiuniVehicule_CheckedChanged);
            // 
            // ckbCamera
            // 
            this.ckbCamera.AutoSize = true;
            this.ckbCamera.Location = new System.Drawing.Point(156, 373);
            this.ckbCamera.Name = "ckbCamera";
            this.ckbCamera.Size = new System.Drawing.Size(90, 15);
            this.ckbCamera.TabIndex = 16;
            this.ckbCamera.Text = "Camera 360°";
            this.ckbCamera.UseSelectable = true;
            this.ckbCamera.CheckedChanged += new System.EventHandler(this.CkbOptiuniVehicule_CheckedChanged);
            // 
            // ckbSenzori
            // 
            this.ckbSenzori.AutoSize = true;
            this.ckbSenzori.Location = new System.Drawing.Point(47, 397);
            this.ckbSenzori.Name = "ckbSenzori";
            this.ckbSenzori.Size = new System.Drawing.Size(119, 15);
            this.ckbSenzori.TabIndex = 17;
            this.ckbSenzori.Text = "Senzori de parcare";
            this.ckbSenzori.UseSelectable = true;
            this.ckbSenzori.CheckedChanged += new System.EventHandler(this.CkbOptiuniVehicule_CheckedChanged);
            // 
            // ckbKeyless
            // 
            this.ckbKeyless.AutoSize = true;
            this.ckbKeyless.Location = new System.Drawing.Point(156, 397);
            this.ckbKeyless.Name = "ckbKeyless";
            this.ckbKeyless.Size = new System.Drawing.Size(121, 15);
            this.ckbKeyless.TabIndex = 18;
            this.ckbKeyless.Text = "Keyless Entry & Start";
            this.ckbKeyless.UseSelectable = true;
            this.ckbKeyless.CheckedChanged += new System.EventHandler(this.CkbOptiuniVehicule_CheckedChanged);
            // 
            // OptiuniVeh
            // 
            this.OptiuniVeh.AutoSize = true;
            this.OptiuniVeh.Location = new System.Drawing.Point(44, 322);
            this.OptiuniVeh.Name = "OptiuniVeh";
            this.OptiuniVeh.Size = new System.Drawing.Size(52, 19);
            this.OptiuniVeh.TabIndex = 19;
            this.OptiuniVeh.Text = "Optiuni";
            // 
            // rdbAlb
            // 
            this.rdbAlb.AutoSize = true;
            this.rdbAlb.Location = new System.Drawing.Point(47, 431);
            this.rdbAlb.Name = "rdbAlb";
            this.rdbAlb.Size = new System.Drawing.Size(47, 15);
            this.rdbAlb.TabIndex = 20;
            this.rdbAlb.TabStop = true;
            this.rdbAlb.Text = "Alba";
            this.rdbAlb.UseSelectable = true;
            // 
            // rdbRed
            // 
            this.rdbRed.AutoSize = true;
            this.rdbRed.Location = new System.Drawing.Point(156, 431);
            this.rdbRed.Name = "rdbRed";
            this.rdbRed.Size = new System.Drawing.Size(49, 15);
            this.rdbRed.TabIndex = 21;
            this.rdbRed.TabStop = true;
            this.rdbRed.Text = "Rosu";
            this.rdbRed.UseSelectable = true;
            // 
            // rdbAlbastru
            // 
            this.rdbAlbastru.AutoSize = true;
            this.rdbAlbastru.Location = new System.Drawing.Point(47, 455);
            this.rdbAlbastru.Name = "rdbAlbastru";
            this.rdbAlbastru.Size = new System.Drawing.Size(67, 15);
            this.rdbAlbastru.TabIndex = 22;
            this.rdbAlbastru.TabStop = true;
            this.rdbAlbastru.Text = "Albastru";
            this.rdbAlbastru.UseSelectable = true;
            // 
            // rdbVerde
            // 
            this.rdbVerde.AutoSize = true;
            this.rdbVerde.Location = new System.Drawing.Point(156, 455);
            this.rdbVerde.Name = "rdbVerde";
            this.rdbVerde.Size = new System.Drawing.Size(52, 15);
            this.rdbVerde.TabIndex = 23;
            this.rdbVerde.TabStop = true;
            this.rdbVerde.Text = "Verde";
            this.rdbVerde.UseSelectable = true;
            // 
            // lblNrDeIm
            // 
            this.lblNrDeIm.AutoSize = true;
            this.lblNrDeIm.Location = new System.Drawing.Point(44, 233);
            this.lblNrDeIm.Name = "lblNrDeIm";
            this.lblNrDeIm.Size = new System.Drawing.Size(116, 19);
            this.lblNrDeIm.TabIndex = 24;
            this.lblNrDeIm.Text = "Nr de imatriculare";
            // 
            // lblStare
            // 
            this.lblStare.AutoSize = true;
            this.lblStare.Location = new System.Drawing.Point(44, 271);
            this.lblStare.Name = "lblStare";
            this.lblStare.Size = new System.Drawing.Size(91, 19);
            this.lblStare.TabIndex = 25;
            this.lblStare.Text = "Starea tehnica";
            // 
            // txtNrDeIm
            // 
            // 
            // 
            // 
            this.txtNrDeIm.CustomButton.Image = null;
            this.txtNrDeIm.CustomButton.Location = new System.Drawing.Point(78, 1);
            this.txtNrDeIm.CustomButton.Name = "";
            this.txtNrDeIm.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtNrDeIm.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNrDeIm.CustomButton.TabIndex = 1;
            this.txtNrDeIm.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNrDeIm.CustomButton.UseSelectable = true;
            this.txtNrDeIm.CustomButton.Visible = false;
            this.txtNrDeIm.Lines = new string[0];
            this.txtNrDeIm.Location = new System.Drawing.Point(141, 233);
            this.txtNrDeIm.MaxLength = 32767;
            this.txtNrDeIm.Name = "txtNrDeIm";
            this.txtNrDeIm.PasswordChar = '\0';
            this.txtNrDeIm.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNrDeIm.SelectedText = "";
            this.txtNrDeIm.SelectionLength = 0;
            this.txtNrDeIm.SelectionStart = 0;
            this.txtNrDeIm.ShortcutsEnabled = true;
            this.txtNrDeIm.Size = new System.Drawing.Size(100, 23);
            this.txtNrDeIm.TabIndex = 27;
            this.txtNrDeIm.UseSelectable = true;
            this.txtNrDeIm.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNrDeIm.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtStare
            // 
            // 
            // 
            // 
            this.txtStare.CustomButton.Image = null;
            this.txtStare.CustomButton.Location = new System.Drawing.Point(78, 1);
            this.txtStare.CustomButton.Name = "";
            this.txtStare.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtStare.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtStare.CustomButton.TabIndex = 1;
            this.txtStare.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtStare.CustomButton.UseSelectable = true;
            this.txtStare.CustomButton.Visible = false;
            this.txtStare.Lines = new string[0];
            this.txtStare.Location = new System.Drawing.Point(141, 268);
            this.txtStare.MaxLength = 32767;
            this.txtStare.Name = "txtStare";
            this.txtStare.PasswordChar = '\0';
            this.txtStare.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtStare.SelectedText = "";
            this.txtStare.SelectionLength = 0;
            this.txtStare.SelectionStart = 0;
            this.txtStare.ShortcutsEnabled = true;
            this.txtStare.Size = new System.Drawing.Size(100, 23);
            this.txtStare.TabIndex = 28;
            this.txtStare.UseSelectable = true;
            this.txtStare.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtStare.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(44, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(70, 71);
            this.pictureBox1.TabIndex = 30;
            this.pictureBox1.TabStop = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 562);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtStare);
            this.Controls.Add(this.txtNrDeIm);
            this.Controls.Add(this.lblStare);
            this.Controls.Add(this.lblNrDeIm);
            this.Controls.Add(this.rdbVerde);
            this.Controls.Add(this.rdbAlbastru);
            this.Controls.Add(this.rdbRed);
            this.Controls.Add(this.rdbAlb);
            this.Controls.Add(this.OptiuniVeh);
            this.Controls.Add(this.ckbKeyless);
            this.Controls.Add(this.ckbSenzori);
            this.Controls.Add(this.ckbCamera);
            this.Controls.Add(this.ckbAppleCar);
            this.Controls.Add(this.ckbCruise);
            this.Controls.Add(this.ckbIncalzScaune);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtAnul);
            this.Controls.Add(this.txtModel);
            this.Controls.Add(this.txtMarca);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.lblAn);
            this.Controls.Add(this.lblModel);
            this.Controls.Add(this.lblMarca);
            this.Controls.Add(this.lblID);
            this.Name = "Form2";
            this.Style = MetroFramework.MetroColorStyle.Teal;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroLabel lblID;
        private MetroLabel lblMarca;
        private MetroLabel lblModel;
        private MetroLabel lblAn;
        private MetroTextBox txtID;
        private MetroTextBox txtMarca;
        private MetroTextBox txtModel;
        private MetroTextBox txtAnul;
        private MetroButton btnSave;
        private MetroCheckBox ckbIncalzScaune;
        private MetroCheckBox ckbCruise;
        private MetroCheckBox ckbAppleCar;
        private MetroCheckBox ckbCamera;
        private MetroCheckBox ckbSenzori;
        private MetroCheckBox ckbKeyless;
        private MetroLabel OptiuniVeh;
        private MetroRadioButton rdbAlb;
        private MetroRadioButton rdbRed;
        private MetroRadioButton rdbAlbastru;
        private MetroRadioButton rdbVerde;
        private MetroLabel lblNrDeIm;
        private MetroLabel lblStare;
        private MetroTextBox txtNrDeIm;
        private MetroTextBox txtStare;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}