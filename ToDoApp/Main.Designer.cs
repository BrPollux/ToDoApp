
namespace ToDoApp
{
    partial class Main
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
            this.btn_yeniproje = new MetroFramework.Controls.MetroButton();
            this.btn_projeler = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // btn_yeniproje
            // 
            this.btn_yeniproje.Location = new System.Drawing.Point(59, 93);
            this.btn_yeniproje.Name = "btn_yeniproje";
            this.btn_yeniproje.Size = new System.Drawing.Size(97, 63);
            this.btn_yeniproje.TabIndex = 0;
            this.btn_yeniproje.Text = "Yeni Proje Ekle";
            this.btn_yeniproje.UseSelectable = true;
            this.btn_yeniproje.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // btn_projeler
            // 
            this.btn_projeler.Location = new System.Drawing.Point(264, 93);
            this.btn_projeler.Name = "btn_projeler";
            this.btn_projeler.Size = new System.Drawing.Size(97, 63);
            this.btn_projeler.TabIndex = 1;
            this.btn_projeler.Text = "Projeler";
            this.btn_projeler.UseSelectable = true;
            this.btn_projeler.Click += new System.EventHandler(this.metroButton2_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 209);
            this.Controls.Add(this.btn_projeler);
            this.Controls.Add(this.btn_yeniproje);
            this.Name = "Main";
            this.Text = "To Do App";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Theme = MetroFramework.MetroThemeStyle.Default;
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroButton btn_yeniproje;
        private MetroFramework.Controls.MetroButton btn_projeler;
    }
}

