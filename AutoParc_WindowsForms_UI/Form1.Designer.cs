using System.Drawing;
using MetroFramework.Controls;
namespace AutoParc_WindowsForms_UI
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnRefresh = new MetroFramework.Controls.MetroButton();
            this.btnCautare = new MetroFramework.Controls.MetroButton();
            this.dataGridVeh = new MetroFramework.Controls.MetroGrid();
            this.btnMod = new MetroFramework.Controls.MetroButton();
            this.btnSterg = new MetroFramework.Controls.MetroButton();
            this.btnAdauga = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridVeh)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(34, 125);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(79, 45);
            this.btnRefresh.TabIndex = 1;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseSelectable = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click_1);
            // 
            // btnCautare
            // 
            this.btnCautare.Location = new System.Drawing.Point(34, 185);
            this.btnCautare.Name = "btnCautare";
            this.btnCautare.Size = new System.Drawing.Size(79, 45);
            this.btnCautare.TabIndex = 6;
            this.btnCautare.Text = "Search";
            this.btnCautare.UseSelectable = true;
            this.btnCautare.Click += new System.EventHandler(this.btnCautare_Click);
            // 
            // dataGridVeh
            // 
            this.dataGridVeh.AllowUserToResizeRows = false;
            this.dataGridVeh.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridVeh.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dataGridVeh.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridVeh.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridVeh.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(170)))), ((int)(((byte)(173)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(201)))), ((int)(((byte)(206)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridVeh.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridVeh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(201)))), ((int)(((byte)(206)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridVeh.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridVeh.EnableHeadersVisualStyles = false;
            this.dataGridVeh.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dataGridVeh.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dataGridVeh.Location = new System.Drawing.Point(168, 63);
            this.dataGridVeh.Name = "dataGridVeh";
            this.dataGridVeh.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(170)))), ((int)(((byte)(173)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(201)))), ((int)(((byte)(206)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridVeh.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridVeh.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridVeh.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridVeh.Size = new System.Drawing.Size(967, 312);
            this.dataGridVeh.Style = MetroFramework.MetroColorStyle.Teal;
            this.dataGridVeh.TabIndex = 7;
            // 
            // btnMod
            // 
            this.btnMod.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnMod.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMod.Location = new System.Drawing.Point(34, 255);
            this.btnMod.Name = "btnMod";
            this.btnMod.Size = new System.Drawing.Size(79, 45);
            this.btnMod.TabIndex = 8;
            this.btnMod.Text = "Modifica";
            this.btnMod.UseSelectable = true;
            this.btnMod.Click += new System.EventHandler(this.btnMod_Click);
            // 
            // btnSterg
            // 
            this.btnSterg.Location = new System.Drawing.Point(34, 330);
            this.btnSterg.Name = "btnSterg";
            this.btnSterg.Size = new System.Drawing.Size(79, 45);
            this.btnSterg.TabIndex = 9;
            this.btnSterg.Text = "Sterge";
            this.btnSterg.UseSelectable = true;
            this.btnSterg.Click += new System.EventHandler(this.btnSterg_Click);
            // 
            // btnAdauga
            // 
            this.btnAdauga.Location = new System.Drawing.Point(34, 63);
            this.btnAdauga.Name = "btnAdauga";
            this.btnAdauga.Size = new System.Drawing.Size(79, 45);
            this.btnAdauga.TabIndex = 0;
            this.btnAdauga.Text = "Adauga";
            this.btnAdauga.UseSelectable = true;
            this.btnAdauga.Click += new System.EventHandler(this.btnAdauga_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1162, 638);
            this.Controls.Add(this.btnSterg);
            this.Controls.Add(this.btnMod);
            this.Controls.Add(this.dataGridVeh);
            this.Controls.Add(this.btnCautare);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnAdauga);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Style = MetroFramework.MetroColorStyle.Teal;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridVeh)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private MetroButton btnRefresh;
        private MetroButton btnCautare;
        private MetroGrid dataGridVeh;
        private MetroButton btnMod;
        private MetroButton btnSterg;
        private MetroButton btnAdauga;
    }
}

