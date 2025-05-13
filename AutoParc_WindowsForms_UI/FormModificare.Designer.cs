namespace AutoParc_WindowsForms_UI
{
    partial class FormModificare
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtStare = new System.Windows.Forms.TextBox();
            this.txtNrDeIm = new System.Windows.Forms.TextBox();
            this.lblStare = new System.Windows.Forms.Label();
            this.lblNrDeIm = new System.Windows.Forms.Label();
            this.rdbVerde = new System.Windows.Forms.RadioButton();
            this.rdbAlbastru = new System.Windows.Forms.RadioButton();
            this.rdbRed = new System.Windows.Forms.RadioButton();
            this.rdbAlb = new System.Windows.Forms.RadioButton();
            this.ckbKeyless = new System.Windows.Forms.CheckBox();
            this.ckbSenzori = new System.Windows.Forms.CheckBox();
            this.ckbCamera = new System.Windows.Forms.CheckBox();
            this.ckbAppleCar = new System.Windows.Forms.CheckBox();
            this.ckbCruise = new System.Windows.Forms.CheckBox();
            this.ckbIncalzScaune = new System.Windows.Forms.CheckBox();
            this.lblEroareAnul = new System.Windows.Forms.Label();
            this.lblEroareModel = new System.Windows.Forms.Label();
            this.lblEroareMarca = new System.Windows.Forms.Label();
            this.lblEroareID = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtAnul = new System.Windows.Forms.TextBox();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lblAn = new System.Windows.Forms.Label();
            this.lblModel = new System.Windows.Forms.Label();
            this.lblMarca = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.gpbOptiuni = new System.Windows.Forms.GroupBox();
            this.gpbOptiuni.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtStare
            // 
            this.txtStare.Location = new System.Drawing.Point(138, 187);
            this.txtStare.Name = "txtStare";
            this.txtStare.Size = new System.Drawing.Size(100, 20);
            this.txtStare.TabIndex = 56;
            // 
            // txtNrDeIm
            // 
            this.txtNrDeIm.Location = new System.Drawing.Point(138, 152);
            this.txtNrDeIm.Name = "txtNrDeIm";
            this.txtNrDeIm.Size = new System.Drawing.Size(100, 20);
            this.txtNrDeIm.TabIndex = 55;
            // 
            // lblStare
            // 
            this.lblStare.AutoSize = true;
            this.lblStare.Location = new System.Drawing.Point(41, 190);
            this.lblStare.Name = "lblStare";
            this.lblStare.Size = new System.Drawing.Size(76, 13);
            this.lblStare.TabIndex = 54;
            this.lblStare.Text = "Starea tehnica";
            // 
            // lblNrDeIm
            // 
            this.lblNrDeIm.AutoSize = true;
            this.lblNrDeIm.Location = new System.Drawing.Point(41, 152);
            this.lblNrDeIm.Name = "lblNrDeIm";
            this.lblNrDeIm.Size = new System.Drawing.Size(89, 13);
            this.lblNrDeIm.TabIndex = 53;
            this.lblNrDeIm.Text = "Nr de imatriculare";
            // 
            // rdbVerde
            // 
            this.rdbVerde.AutoSize = true;
            this.rdbVerde.Location = new System.Drawing.Point(153, 397);
            this.rdbVerde.Name = "rdbVerde";
            this.rdbVerde.Size = new System.Drawing.Size(53, 17);
            this.rdbVerde.TabIndex = 52;
            this.rdbVerde.TabStop = true;
            this.rdbVerde.Text = "Verde";
            this.rdbVerde.UseVisualStyleBackColor = true;
            // 
            // rdbAlbastru
            // 
            this.rdbAlbastru.AutoSize = true;
            this.rdbAlbastru.Location = new System.Drawing.Point(44, 397);
            this.rdbAlbastru.Name = "rdbAlbastru";
            this.rdbAlbastru.Size = new System.Drawing.Size(63, 17);
            this.rdbAlbastru.TabIndex = 51;
            this.rdbAlbastru.TabStop = true;
            this.rdbAlbastru.Text = "Albastru";
            this.rdbAlbastru.UseVisualStyleBackColor = true;
            // 
            // rdbRed
            // 
            this.rdbRed.AutoSize = true;
            this.rdbRed.Location = new System.Drawing.Point(153, 373);
            this.rdbRed.Name = "rdbRed";
            this.rdbRed.Size = new System.Drawing.Size(50, 17);
            this.rdbRed.TabIndex = 50;
            this.rdbRed.TabStop = true;
            this.rdbRed.Text = "Rosu";
            this.rdbRed.UseVisualStyleBackColor = true;
            // 
            // rdbAlb
            // 
            this.rdbAlb.AutoSize = true;
            this.rdbAlb.Location = new System.Drawing.Point(44, 373);
            this.rdbAlb.Name = "rdbAlb";
            this.rdbAlb.Size = new System.Drawing.Size(46, 17);
            this.rdbAlb.TabIndex = 49;
            this.rdbAlb.TabStop = true;
            this.rdbAlb.Text = "Alba";
            this.rdbAlb.UseVisualStyleBackColor = true;
            // 
            // ckbKeyless
            // 
            this.ckbKeyless.AutoSize = true;
            this.ckbKeyless.Location = new System.Drawing.Point(115, 75);
            this.ckbKeyless.Name = "ckbKeyless";
            this.ckbKeyless.Size = new System.Drawing.Size(117, 17);
            this.ckbKeyless.TabIndex = 47;
            this.ckbKeyless.Text = "Keyless Entry & Start";
            this.ckbKeyless.UseVisualStyleBackColor = true;
            this.ckbKeyless.CheckedChanged += new System.EventHandler(this.CkbOptiuniVehicule_CheckedChanged);
            // 
            // ckbSenzori
            // 
            this.ckbSenzori.AutoSize = true;
            this.ckbSenzori.Location = new System.Drawing.Point(6, 75);
            this.ckbSenzori.Name = "ckbSenzori";
            this.ckbSenzori.Size = new System.Drawing.Size(115, 17);
            this.ckbSenzori.TabIndex = 46;
            this.ckbSenzori.Text = "Senzori de parcare";
            this.ckbSenzori.UseVisualStyleBackColor = true;
            this.ckbSenzori.CheckedChanged += new System.EventHandler(this.CkbOptiuniVehicule_CheckedChanged);
            // 
            // ckbCamera
            // 
            this.ckbCamera.AutoSize = true;
            this.ckbCamera.Location = new System.Drawing.Point(115, 51);
            this.ckbCamera.Name = "ckbCamera";
            this.ckbCamera.Size = new System.Drawing.Size(87, 17);
            this.ckbCamera.TabIndex = 45;
            this.ckbCamera.Text = "Camera 360°";
            this.ckbCamera.UseVisualStyleBackColor = true;
            this.ckbCamera.CheckedChanged += new System.EventHandler(this.CkbOptiuniVehicule_CheckedChanged);
            // 
            // ckbAppleCar
            // 
            this.ckbAppleCar.AutoSize = true;
            this.ckbAppleCar.Location = new System.Drawing.Point(115, 28);
            this.ckbAppleCar.Name = "ckbAppleCar";
            this.ckbAppleCar.Size = new System.Drawing.Size(161, 17);
            this.ckbAppleCar.TabIndex = 44;
            this.ckbAppleCar.Text = "Android Auto/ Apple CarPlay";
            this.ckbAppleCar.UseVisualStyleBackColor = true;
            this.ckbAppleCar.CheckedChanged += new System.EventHandler(this.CkbOptiuniVehicule_CheckedChanged);
            // 
            // ckbCruise
            // 
            this.ckbCruise.AutoSize = true;
            this.ckbCruise.Location = new System.Drawing.Point(6, 51);
            this.ckbCruise.Name = "ckbCruise";
            this.ckbCruise.Size = new System.Drawing.Size(90, 17);
            this.ckbCruise.TabIndex = 43;
            this.ckbCruise.Text = "Cruise control";
            this.ckbCruise.UseVisualStyleBackColor = true;
            this.ckbCruise.CheckedChanged += new System.EventHandler(this.CkbOptiuniVehicule_CheckedChanged);
            // 
            // ckbIncalzScaune
            // 
            this.ckbIncalzScaune.AutoSize = true;
            this.ckbIncalzScaune.Location = new System.Drawing.Point(6, 28);
            this.ckbIncalzScaune.Name = "ckbIncalzScaune";
            this.ckbIncalzScaune.Size = new System.Drawing.Size(103, 17);
            this.ckbIncalzScaune.TabIndex = 42;
            this.ckbIncalzScaune.Text = "Incalzire scaune";
            this.ckbIncalzScaune.UseVisualStyleBackColor = true;
            this.ckbIncalzScaune.CheckedChanged += new System.EventHandler(this.CkbOptiuniVehicule_CheckedChanged);
            // 
            // lblEroareAnul
            // 
            this.lblEroareAnul.AutoSize = true;
            this.lblEroareAnul.Location = new System.Drawing.Point(263, 124);
            this.lblEroareAnul.Name = "lblEroareAnul";
            this.lblEroareAnul.Size = new System.Drawing.Size(0, 13);
            this.lblEroareAnul.TabIndex = 41;
            // 
            // lblEroareModel
            // 
            this.lblEroareModel.AutoSize = true;
            this.lblEroareModel.Location = new System.Drawing.Point(263, 83);
            this.lblEroareModel.Name = "lblEroareModel";
            this.lblEroareModel.Size = new System.Drawing.Size(0, 13);
            this.lblEroareModel.TabIndex = 40;
            // 
            // lblEroareMarca
            // 
            this.lblEroareMarca.AutoSize = true;
            this.lblEroareMarca.Location = new System.Drawing.Point(263, 51);
            this.lblEroareMarca.Name = "lblEroareMarca";
            this.lblEroareMarca.Size = new System.Drawing.Size(0, 13);
            this.lblEroareMarca.TabIndex = 39;
            // 
            // lblEroareID
            // 
            this.lblEroareID.AutoSize = true;
            this.lblEroareID.Location = new System.Drawing.Point(263, 15);
            this.lblEroareID.Name = "lblEroareID";
            this.lblEroareID.Size = new System.Drawing.Size(0, 13);
            this.lblEroareID.TabIndex = 38;
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Candara", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSave.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSave.Location = new System.Drawing.Point(44, 433);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 37;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtAnul
            // 
            this.txtAnul.Location = new System.Drawing.Point(138, 121);
            this.txtAnul.Name = "txtAnul";
            this.txtAnul.Size = new System.Drawing.Size(100, 20);
            this.txtAnul.TabIndex = 36;
            // 
            // txtModel
            // 
            this.txtModel.Location = new System.Drawing.Point(138, 83);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(100, 20);
            this.txtModel.TabIndex = 35;
            // 
            // txtMarca
            // 
            this.txtMarca.Location = new System.Drawing.Point(138, 44);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(100, 20);
            this.txtMarca.TabIndex = 34;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(138, 9);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(100, 20);
            this.txtID.TabIndex = 33;
            // 
            // lblAn
            // 
            this.lblAn.AutoSize = true;
            this.lblAn.Location = new System.Drawing.Point(41, 121);
            this.lblAn.Name = "lblAn";
            this.lblAn.Size = new System.Drawing.Size(28, 13);
            this.lblAn.TabIndex = 32;
            this.lblAn.Text = "Anul";
            // 
            // lblModel
            // 
            this.lblModel.AutoSize = true;
            this.lblModel.Location = new System.Drawing.Point(41, 83);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(36, 13);
            this.lblModel.TabIndex = 31;
            this.lblModel.Text = "Model";
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Location = new System.Drawing.Point(41, 44);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(37, 13);
            this.lblMarca.TabIndex = 30;
            this.lblMarca.Text = "Marca";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(41, 9);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(18, 13);
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
            this.gpbOptiuni.Location = new System.Drawing.Point(44, 230);
            this.gpbOptiuni.Name = "gpbOptiuni";
            this.gpbOptiuni.Size = new System.Drawing.Size(294, 117);
            this.gpbOptiuni.TabIndex = 57;
            this.gpbOptiuni.TabStop = false;
            this.gpbOptiuni.Text = "Optiuni";
            // 
            // FormModificare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(851, 518);
            this.Controls.Add(this.gpbOptiuni);
            this.Controls.Add(this.txtStare);
            this.Controls.Add(this.txtNrDeIm);
            this.Controls.Add(this.lblStare);
            this.Controls.Add(this.lblNrDeIm);
            this.Controls.Add(this.rdbVerde);
            this.Controls.Add(this.rdbAlbastru);
            this.Controls.Add(this.rdbRed);
            this.Controls.Add(this.rdbAlb);
            this.Controls.Add(this.lblEroareAnul);
            this.Controls.Add(this.lblEroareModel);
            this.Controls.Add(this.lblEroareMarca);
            this.Controls.Add(this.lblEroareID);
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
            this.Text = "FormModificare";
            this.gpbOptiuni.ResumeLayout(false);
            this.gpbOptiuni.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtStare;
        private System.Windows.Forms.TextBox txtNrDeIm;
        private System.Windows.Forms.Label lblStare;
        private System.Windows.Forms.Label lblNrDeIm;
        private System.Windows.Forms.RadioButton rdbVerde;
        private System.Windows.Forms.RadioButton rdbAlbastru;
        private System.Windows.Forms.RadioButton rdbRed;
        private System.Windows.Forms.RadioButton rdbAlb;
        private System.Windows.Forms.CheckBox ckbKeyless;
        private System.Windows.Forms.CheckBox ckbSenzori;
        private System.Windows.Forms.CheckBox ckbCamera;
        private System.Windows.Forms.CheckBox ckbAppleCar;
        private System.Windows.Forms.CheckBox ckbCruise;
        private System.Windows.Forms.CheckBox ckbIncalzScaune;
        private System.Windows.Forms.Label lblEroareAnul;
        private System.Windows.Forms.Label lblEroareModel;
        private System.Windows.Forms.Label lblEroareMarca;
        private System.Windows.Forms.Label lblEroareID;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtAnul;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lblAn;
        private System.Windows.Forms.Label lblModel;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.GroupBox gpbOptiuni;
    }
}