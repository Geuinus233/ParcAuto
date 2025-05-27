using MetroFramework.Controls;
namespace AutoParc_WindowsForms_UI
{
    partial class FormModificare
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormModificare));
            this.txtStare = new MetroFramework.Controls.MetroTextBox();
            this.txtNrDeIm = new MetroFramework.Controls.MetroTextBox();
            this.lblStare = new MetroFramework.Controls.MetroLabel();
            this.lblNrDeIm = new MetroFramework.Controls.MetroLabel();
            this.rdbVerde = new MetroFramework.Controls.MetroRadioButton();
            this.rdbAlbastru = new MetroFramework.Controls.MetroRadioButton();
            this.rdbRed = new MetroFramework.Controls.MetroRadioButton();
            this.rdbAlb = new MetroFramework.Controls.MetroRadioButton();
            this.btnSave = new MetroFramework.Controls.MetroButton();
            this.txtAnul = new MetroFramework.Controls.MetroTextBox();
            this.txtModel = new MetroFramework.Controls.MetroTextBox();
            this.txtMarca = new MetroFramework.Controls.MetroTextBox();
            this.txtID = new MetroFramework.Controls.MetroTextBox();
            this.lblAn = new MetroFramework.Controls.MetroLabel();
            this.lblModel = new MetroFramework.Controls.MetroLabel();
            this.lblMarca = new MetroFramework.Controls.MetroLabel();
            this.lblID = new MetroFramework.Controls.MetroLabel();
            this.gpbOptiuni = new MetroFramework.Controls.MetroPanel();
            this.ckbIncalzScaune = new MetroFramework.Controls.MetroCheckBox();
            this.ckbCruise = new MetroFramework.Controls.MetroCheckBox();
            this.ckbAppleCar = new MetroFramework.Controls.MetroCheckBox();
            this.ckbCamera = new MetroFramework.Controls.MetroCheckBox();
            this.ckbSenzori = new MetroFramework.Controls.MetroCheckBox();
            this.ckbKeyless = new MetroFramework.Controls.MetroCheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gpbOptiuni.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
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
            this.txtStare.Location = new System.Drawing.Point(140, 286);
            this.txtStare.MaxLength = 32767;
            this.txtStare.Name = "txtStare";
            this.txtStare.PasswordChar = '\0';
            this.txtStare.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtStare.SelectedText = "";
            this.txtStare.SelectionLength = 0;
            this.txtStare.SelectionStart = 0;
            this.txtStare.ShortcutsEnabled = true;
            this.txtStare.Size = new System.Drawing.Size(100, 23);
            this.txtStare.TabIndex = 56;
            this.txtStare.UseSelectable = true;
            this.txtStare.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtStare.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
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
            this.txtNrDeIm.Location = new System.Drawing.Point(140, 251);
            this.txtNrDeIm.MaxLength = 32767;
            this.txtNrDeIm.Name = "txtNrDeIm";
            this.txtNrDeIm.PasswordChar = '\0';
            this.txtNrDeIm.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNrDeIm.SelectedText = "";
            this.txtNrDeIm.SelectionLength = 0;
            this.txtNrDeIm.SelectionStart = 0;
            this.txtNrDeIm.ShortcutsEnabled = true;
            this.txtNrDeIm.Size = new System.Drawing.Size(100, 23);
            this.txtNrDeIm.TabIndex = 55;
            this.txtNrDeIm.UseSelectable = true;
            this.txtNrDeIm.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNrDeIm.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblStare
            // 
            this.lblStare.AutoSize = true;
            this.lblStare.Location = new System.Drawing.Point(43, 289);
            this.lblStare.Name = "lblStare";
            this.lblStare.Size = new System.Drawing.Size(91, 19);
            this.lblStare.TabIndex = 54;
            this.lblStare.Text = "Starea tehnica";
            // 
            // lblNrDeIm
            // 
            this.lblNrDeIm.AutoSize = true;
            this.lblNrDeIm.Location = new System.Drawing.Point(43, 251);
            this.lblNrDeIm.Name = "lblNrDeIm";
            this.lblNrDeIm.Size = new System.Drawing.Size(116, 19);
            this.lblNrDeIm.TabIndex = 53;
            this.lblNrDeIm.Text = "Nr de imatriculare";
            // 
            // rdbVerde
            // 
            this.rdbVerde.AutoSize = true;
            this.rdbVerde.Location = new System.Drawing.Point(155, 496);
            this.rdbVerde.Name = "rdbVerde";
            this.rdbVerde.Size = new System.Drawing.Size(52, 15);
            this.rdbVerde.TabIndex = 52;
            this.rdbVerde.TabStop = true;
            this.rdbVerde.Text = "Verde";
            this.rdbVerde.UseSelectable = true;
            // 
            // rdbAlbastru
            // 
            this.rdbAlbastru.AutoSize = true;
            this.rdbAlbastru.Location = new System.Drawing.Point(46, 496);
            this.rdbAlbastru.Name = "rdbAlbastru";
            this.rdbAlbastru.Size = new System.Drawing.Size(67, 15);
            this.rdbAlbastru.TabIndex = 51;
            this.rdbAlbastru.TabStop = true;
            this.rdbAlbastru.Text = "Albastru";
            this.rdbAlbastru.UseSelectable = true;
            // 
            // rdbRed
            // 
            this.rdbRed.AutoSize = true;
            this.rdbRed.Location = new System.Drawing.Point(155, 472);
            this.rdbRed.Name = "rdbRed";
            this.rdbRed.Size = new System.Drawing.Size(49, 15);
            this.rdbRed.TabIndex = 50;
            this.rdbRed.TabStop = true;
            this.rdbRed.Text = "Rosu";
            this.rdbRed.UseSelectable = true;
            // 
            // rdbAlb
            // 
            this.rdbAlb.AutoSize = true;
            this.rdbAlb.Location = new System.Drawing.Point(46, 472);
            this.rdbAlb.Name = "rdbAlb";
            this.rdbAlb.Size = new System.Drawing.Size(47, 15);
            this.rdbAlb.TabIndex = 49;
            this.rdbAlb.TabStop = true;
            this.rdbAlb.Text = "Alba";
            this.rdbAlb.UseSelectable = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(46, 532);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(86, 57);
            this.btnSave.TabIndex = 37;
            this.btnSave.Text = "Modifica";
            this.btnSave.UseSelectable = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
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
            this.txtAnul.Location = new System.Drawing.Point(140, 220);
            this.txtAnul.MaxLength = 32767;
            this.txtAnul.Name = "txtAnul";
            this.txtAnul.PasswordChar = '\0';
            this.txtAnul.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtAnul.SelectedText = "";
            this.txtAnul.SelectionLength = 0;
            this.txtAnul.SelectionStart = 0;
            this.txtAnul.ShortcutsEnabled = true;
            this.txtAnul.Size = new System.Drawing.Size(100, 23);
            this.txtAnul.TabIndex = 36;
            this.txtAnul.UseSelectable = true;
            this.txtAnul.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtAnul.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
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
            this.txtModel.Location = new System.Drawing.Point(140, 182);
            this.txtModel.MaxLength = 32767;
            this.txtModel.Name = "txtModel";
            this.txtModel.PasswordChar = '\0';
            this.txtModel.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtModel.SelectedText = "";
            this.txtModel.SelectionLength = 0;
            this.txtModel.SelectionStart = 0;
            this.txtModel.ShortcutsEnabled = true;
            this.txtModel.Size = new System.Drawing.Size(100, 23);
            this.txtModel.TabIndex = 35;
            this.txtModel.UseSelectable = true;
            this.txtModel.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtModel.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
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
            this.txtMarca.Location = new System.Drawing.Point(140, 143);
            this.txtMarca.MaxLength = 32767;
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.PasswordChar = '\0';
            this.txtMarca.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtMarca.SelectedText = "";
            this.txtMarca.SelectionLength = 0;
            this.txtMarca.SelectionStart = 0;
            this.txtMarca.ShortcutsEnabled = true;
            this.txtMarca.Size = new System.Drawing.Size(100, 23);
            this.txtMarca.TabIndex = 34;
            this.txtMarca.UseSelectable = true;
            this.txtMarca.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtMarca.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
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
            this.txtID.Location = new System.Drawing.Point(140, 108);
            this.txtID.MaxLength = 32767;
            this.txtID.Name = "txtID";
            this.txtID.PasswordChar = '\0';
            this.txtID.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtID.SelectedText = "";
            this.txtID.SelectionLength = 0;
            this.txtID.SelectionStart = 0;
            this.txtID.ShortcutsEnabled = true;
            this.txtID.Size = new System.Drawing.Size(100, 23);
            this.txtID.TabIndex = 33;
            this.txtID.UseSelectable = true;
            this.txtID.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtID.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblAn
            // 
            this.lblAn.AutoSize = true;
            this.lblAn.Location = new System.Drawing.Point(43, 220);
            this.lblAn.Name = "lblAn";
            this.lblAn.Size = new System.Drawing.Size(35, 19);
            this.lblAn.TabIndex = 32;
            this.lblAn.Text = "Anul";
            // 
            // lblModel
            // 
            this.lblModel.AutoSize = true;
            this.lblModel.Location = new System.Drawing.Point(43, 182);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(47, 19);
            this.lblModel.TabIndex = 31;
            this.lblModel.Text = "Model";
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Location = new System.Drawing.Point(43, 143);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(46, 19);
            this.lblMarca.TabIndex = 30;
            this.lblMarca.Text = "Marca";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(43, 108);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(21, 19);
            this.lblID.TabIndex = 29;
            this.lblID.Text = "ID";
            // 
            // gpbOptiuni
            // 
            this.gpbOptiuni.Controls.Add(this.ckbIncalzScaune);
            this.gpbOptiuni.Controls.Add(this.ckbCruise);
            this.gpbOptiuni.Controls.Add(this.ckbAppleCar);
            this.gpbOptiuni.Controls.Add(this.ckbCamera);
            this.gpbOptiuni.Controls.Add(this.ckbSenzori);
            this.gpbOptiuni.Controls.Add(this.ckbKeyless);
            this.gpbOptiuni.HorizontalScrollbarBarColor = true;
            this.gpbOptiuni.HorizontalScrollbarHighlightOnWheel = false;
            this.gpbOptiuni.HorizontalScrollbarSize = 10;
            this.gpbOptiuni.Location = new System.Drawing.Point(46, 329);
            this.gpbOptiuni.Name = "gpbOptiuni";
            this.gpbOptiuni.Size = new System.Drawing.Size(294, 117);
            this.gpbOptiuni.TabIndex = 57;
            this.gpbOptiuni.VerticalScrollbarBarColor = true;
            this.gpbOptiuni.VerticalScrollbarHighlightOnWheel = false;
            this.gpbOptiuni.VerticalScrollbarSize = 10;
            // 
            // ckbIncalzScaune
            // 
            this.ckbIncalzScaune.AutoSize = true;
            this.ckbIncalzScaune.Location = new System.Drawing.Point(6, 28);
            this.ckbIncalzScaune.Name = "ckbIncalzScaune";
            this.ckbIncalzScaune.Size = new System.Drawing.Size(106, 15);
            this.ckbIncalzScaune.TabIndex = 42;
            this.ckbIncalzScaune.Text = "Incalzire scaune";
            this.ckbIncalzScaune.UseSelectable = true;
            this.ckbIncalzScaune.CheckedChanged += new System.EventHandler(this.CkbOptiuniVehicule_CheckedChanged);
            // 
            // ckbCruise
            // 
            this.ckbCruise.AutoSize = true;
            this.ckbCruise.Location = new System.Drawing.Point(6, 51);
            this.ckbCruise.Name = "ckbCruise";
            this.ckbCruise.Size = new System.Drawing.Size(97, 15);
            this.ckbCruise.TabIndex = 43;
            this.ckbCruise.Text = "Cruise control";
            this.ckbCruise.UseSelectable = true;
            this.ckbCruise.CheckedChanged += new System.EventHandler(this.CkbOptiuniVehicule_CheckedChanged);
            // 
            // ckbAppleCar
            // 
            this.ckbAppleCar.AutoSize = true;
            this.ckbAppleCar.Location = new System.Drawing.Point(127, 28);
            this.ckbAppleCar.Name = "ckbAppleCar";
            this.ckbAppleCar.Size = new System.Drawing.Size(177, 15);
            this.ckbAppleCar.TabIndex = 44;
            this.ckbAppleCar.Text = "Android Auto/ Apple CarPlay";
            this.ckbAppleCar.UseSelectable = true;
            this.ckbAppleCar.CheckedChanged += new System.EventHandler(this.CkbOptiuniVehicule_CheckedChanged);
            // 
            // ckbCamera
            // 
            this.ckbCamera.AutoSize = true;
            this.ckbCamera.Location = new System.Drawing.Point(127, 52);
            this.ckbCamera.Name = "ckbCamera";
            this.ckbCamera.Size = new System.Drawing.Size(90, 15);
            this.ckbCamera.TabIndex = 45;
            this.ckbCamera.Text = "Camera 360°";
            this.ckbCamera.UseSelectable = true;
            this.ckbCamera.CheckedChanged += new System.EventHandler(this.CkbOptiuniVehicule_CheckedChanged);
            // 
            // ckbSenzori
            // 
            this.ckbSenzori.AutoSize = true;
            this.ckbSenzori.Location = new System.Drawing.Point(6, 75);
            this.ckbSenzori.Name = "ckbSenzori";
            this.ckbSenzori.Size = new System.Drawing.Size(119, 15);
            this.ckbSenzori.TabIndex = 46;
            this.ckbSenzori.Text = "Senzori de parcare";
            this.ckbSenzori.UseSelectable = true;
            this.ckbSenzori.CheckedChanged += new System.EventHandler(this.CkbOptiuniVehicule_CheckedChanged);
            // 
            // ckbKeyless
            // 
            this.ckbKeyless.AutoSize = true;
            this.ckbKeyless.Location = new System.Drawing.Point(127, 75);
            this.ckbKeyless.Name = "ckbKeyless";
            this.ckbKeyless.Size = new System.Drawing.Size(121, 15);
            this.ckbKeyless.TabIndex = 47;
            this.ckbKeyless.Text = "Keyless Entry & Start";
            this.ckbKeyless.UseSelectable = true;
            this.ckbKeyless.CheckedChanged += new System.EventHandler(this.CkbOptiuniVehicule_CheckedChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(46, 33);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(76, 72);
            this.pictureBox1.TabIndex = 58;
            this.pictureBox1.TabStop = false;
            // 
            // FormModificare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 603);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.gpbOptiuni);
            this.Controls.Add(this.txtStare);
            this.Controls.Add(this.txtNrDeIm);
            this.Controls.Add(this.lblStare);
            this.Controls.Add(this.lblNrDeIm);
            this.Controls.Add(this.rdbVerde);
            this.Controls.Add(this.rdbAlbastru);
            this.Controls.Add(this.rdbRed);
            this.Controls.Add(this.rdbAlb);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtAnul);
            this.Controls.Add(this.txtModel);
            this.Controls.Add(this.txtMarca);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.lblAn);
            this.Controls.Add(this.lblModel);
            this.Controls.Add(this.lblMarca);
            this.Controls.Add(this.lblID);
            this.Name = "FormModificare";
            this.Style = MetroFramework.MetroColorStyle.Teal;
            this.gpbOptiuni.ResumeLayout(false);
            this.gpbOptiuni.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroTextBox txtStare;
        private MetroTextBox txtNrDeIm;
        private MetroLabel lblStare;
        private MetroLabel lblNrDeIm;
        private MetroRadioButton rdbVerde;
        private MetroRadioButton rdbAlbastru;
        private MetroRadioButton rdbRed;
        private MetroRadioButton rdbAlb;
        private MetroButton btnSave;
        private MetroTextBox txtAnul;
        private MetroTextBox txtModel;
        private MetroTextBox txtMarca;
        private MetroTextBox txtID;
        private MetroLabel lblAn;
        private MetroLabel lblModel;
        private MetroLabel lblMarca;
        private MetroLabel lblID;
        private MetroPanel gpbOptiuni;
        private MetroCheckBox ckbIncalzScaune;
        private MetroCheckBox ckbCruise;
        private MetroCheckBox ckbAppleCar;
        private MetroCheckBox ckbCamera;
        private MetroCheckBox ckbSenzori;
        private MetroCheckBox ckbKeyless;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}