
namespace ToDoApp
{
    partial class Projeler
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btn_ac = new MetroFramework.Controls.MetroButton();
            this.btn_guncelle = new MetroFramework.Controls.MetroButton();
            this.btn_sil = new MetroFramework.Controls.MetroButton();
            this.btn_geridon = new MetroFramework.Controls.MetroButton();
            this.todoprojeDataSet = new ToDoApp.todoprojeDataSet();
            this.todoprojeDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.todoprojeDataSet1 = new ToDoApp.todoprojeDataSet1();
            this.todoprojeDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dtg_projeler = new MetroFramework.Controls.MetroGrid();
            ((System.ComponentModel.ISupportInitialize)(this.todoprojeDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.todoprojeDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.todoprojeDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.todoprojeDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_projeler)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_ac
            // 
            this.btn_ac.Location = new System.Drawing.Point(785, 536);
            this.btn_ac.Name = "btn_ac";
            this.btn_ac.Size = new System.Drawing.Size(88, 47);
            this.btn_ac.TabIndex = 1;
            this.btn_ac.Text = "Aç";
            this.btn_ac.UseSelectable = true;
            this.btn_ac.Click += new System.EventHandler(this.btn_ac_Click);
            // 
            // btn_guncelle
            // 
            this.btn_guncelle.Location = new System.Drawing.Point(691, 536);
            this.btn_guncelle.Name = "btn_guncelle";
            this.btn_guncelle.Size = new System.Drawing.Size(88, 47);
            this.btn_guncelle.TabIndex = 2;
            this.btn_guncelle.Text = "Güncelle";
            this.btn_guncelle.UseSelectable = true;
            this.btn_guncelle.Click += new System.EventHandler(this.btn_guncelle_Click);
            // 
            // btn_sil
            // 
            this.btn_sil.BackColor = System.Drawing.Color.White;
            this.btn_sil.Location = new System.Drawing.Point(597, 536);
            this.btn_sil.Name = "btn_sil";
            this.btn_sil.Size = new System.Drawing.Size(88, 47);
            this.btn_sil.TabIndex = 3;
            this.btn_sil.Text = "Sil";
            this.btn_sil.UseSelectable = true;
            this.btn_sil.Click += new System.EventHandler(this.btn_sil_Click);
            // 
            // btn_geridon
            // 
            this.btn_geridon.Location = new System.Drawing.Point(23, 536);
            this.btn_geridon.Name = "btn_geridon";
            this.btn_geridon.Size = new System.Drawing.Size(88, 47);
            this.btn_geridon.TabIndex = 4;
            this.btn_geridon.Text = "Geri Dön";
            this.btn_geridon.UseSelectable = true;
            this.btn_geridon.Click += new System.EventHandler(this.btn_geridon_Click);
            // 
            // todoprojeDataSet
            // 
            this.todoprojeDataSet.DataSetName = "todoprojeDataSet";
            this.todoprojeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // todoprojeDataSetBindingSource
            // 
            this.todoprojeDataSetBindingSource.DataSource = this.todoprojeDataSet;
            this.todoprojeDataSetBindingSource.Position = 0;
            // 
            // todoprojeDataSet1
            // 
            this.todoprojeDataSet1.DataSetName = "todoprojeDataSet1";
            this.todoprojeDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // todoprojeDataSet1BindingSource
            // 
            this.todoprojeDataSet1BindingSource.DataSource = this.todoprojeDataSet1;
            this.todoprojeDataSet1BindingSource.Position = 0;
            // 
            // dtg_projeler
            // 
            this.dtg_projeler.AllowUserToResizeRows = false;
            this.dtg_projeler.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dtg_projeler.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtg_projeler.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dtg_projeler.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtg_projeler.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtg_projeler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtg_projeler.DefaultCellStyle = dataGridViewCellStyle2;
            this.dtg_projeler.EnableHeadersVisualStyles = false;
            this.dtg_projeler.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dtg_projeler.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dtg_projeler.Location = new System.Drawing.Point(23, 63);
            this.dtg_projeler.Name = "dtg_projeler";
            this.dtg_projeler.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtg_projeler.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dtg_projeler.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dtg_projeler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtg_projeler.Size = new System.Drawing.Size(850, 456);
            this.dtg_projeler.TabIndex = 5;
            // 
            // Projeler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(899, 606);
            this.Controls.Add(this.dtg_projeler);
            this.Controls.Add(this.btn_geridon);
            this.Controls.Add(this.btn_sil);
            this.Controls.Add(this.btn_guncelle);
            this.Controls.Add(this.btn_ac);
            this.Name = "Projeler";
            this.Text = "Projeler";
            this.Load += new System.EventHandler(this.Projeler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.todoprojeDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.todoprojeDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.todoprojeDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.todoprojeDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_projeler)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroButton btn_ac;
        private MetroFramework.Controls.MetroButton btn_guncelle;
        private MetroFramework.Controls.MetroButton btn_sil;
        private MetroFramework.Controls.MetroButton btn_geridon;
        private System.Windows.Forms.BindingSource todoprojeDataSetBindingSource;
        private todoprojeDataSet todoprojeDataSet;
        private System.Windows.Forms.BindingSource todoprojeDataSet1BindingSource;
        private todoprojeDataSet1 todoprojeDataSet1;
        private MetroFramework.Controls.MetroGrid dtg_projeler;
    }
}