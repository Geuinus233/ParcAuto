namespace AutoParc_WindowsForms_UI
{
    partial class Form2
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
            this.lblID = new System.Windows.Forms.Label();
            this.lblMarca = new System.Windows.Forms.Label();
            this.lblModel = new System.Windows.Forms.Label();
            this.lblAn = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.txtAnul = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblEroareID = new System.Windows.Forms.Label();
            this.lblEroareMarca = new System.Windows.Forms.Label();
            this.lblEroareModel = new System.Windows.Forms.Label();
            this.lblEroareAnul = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(36, 32);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(18, 13);
            this.lblID.TabIndex = 0;
            this.lblID.Text = "ID";
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Location = new System.Drawing.Point(36, 67);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(37, 13);
            this.lblMarca.TabIndex = 1;
            this.lblMarca.Text = "Marca";
            // 
            // lblModel
            // 
            this.lblModel.AutoSize = true;
            this.lblModel.Location = new System.Drawing.Point(36, 106);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(36, 13);
            this.lblModel.TabIndex = 2;
            this.lblModel.Text = "Model";
            // 
            // lblAn
            // 
            this.lblAn.AutoSize = true;
            this.lblAn.Location = new System.Drawing.Point(36, 144);
            this.lblAn.Name = "lblAn";
            this.lblAn.Size = new System.Drawing.Size(28, 13);
            this.lblAn.TabIndex = 3;
            this.lblAn.Text = "Anul";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(118, 32);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(100, 20);
            this.txtID.TabIndex = 4;
            // 
            // txtMarca
            // 
            this.txtMarca.Location = new System.Drawing.Point(118, 67);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(100, 20);
            this.txtMarca.TabIndex = 5;
            // 
            // txtModel
            // 
            this.txtModel.Location = new System.Drawing.Point(118, 106);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(100, 20);
            this.txtModel.TabIndex = 6;
            // 
            // txtAnul
            // 
            this.txtAnul.Location = new System.Drawing.Point(118, 144);
            this.txtAnul.Name = "txtAnul";
            this.txtAnul.Size = new System.Drawing.Size(100, 20);
            this.txtAnul.TabIndex = 7;
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Candara", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSave.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSave.Location = new System.Drawing.Point(39, 218);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblEroareID
            // 
            this.lblEroareID.AutoSize = true;
            this.lblEroareID.Location = new System.Drawing.Point(258, 38);
            this.lblEroareID.Name = "lblEroareID";
            this.lblEroareID.Size = new System.Drawing.Size(35, 13);
            this.lblEroareID.TabIndex = 9;
            this.lblEroareID.Text = "label1";
            // 
            // lblEroareMarca
            // 
            this.lblEroareMarca.AutoSize = true;
            this.lblEroareMarca.Location = new System.Drawing.Point(258, 74);
            this.lblEroareMarca.Name = "lblEroareMarca";
            this.lblEroareMarca.Size = new System.Drawing.Size(35, 13);
            this.lblEroareMarca.TabIndex = 10;
            this.lblEroareMarca.Text = "label2";
            // 
            // lblEroareModel
            // 
            this.lblEroareModel.AutoSize = true;
            this.lblEroareModel.Location = new System.Drawing.Point(258, 106);
            this.lblEroareModel.Name = "lblEroareModel";
            this.lblEroareModel.Size = new System.Drawing.Size(35, 13);
            this.lblEroareModel.TabIndex = 11;
            this.lblEroareModel.Text = "label3";
            // 
            // lblEroareAnul
            // 
            this.lblEroareAnul.AutoSize = true;
            this.lblEroareAnul.Location = new System.Drawing.Point(258, 147);
            this.lblEroareAnul.Name = "lblEroareAnul";
            this.lblEroareAnul.Size = new System.Drawing.Size(35, 13);
            this.lblEroareAnul.TabIndex = 12;
            this.lblEroareAnul.Text = "label4";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.Label lblModel;
        private System.Windows.Forms.Label lblAn;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.TextBox txtAnul;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblEroareID;
        private System.Windows.Forms.Label lblEroareMarca;
        private System.Windows.Forms.Label lblEroareModel;
        private System.Windows.Forms.Label lblEroareAnul;
    }
}