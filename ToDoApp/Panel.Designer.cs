
namespace ToDoApp
{
    partial class Panel
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle25 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle26 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle27 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle28 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle29 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle30 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle31 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle32 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btn_geri = new MetroFramework.Controls.MetroButton();
            this.lbl_aktifprojekodu = new MetroFramework.Controls.MetroLabel();
            this.lbl_aktifproje = new MetroFramework.Controls.MetroLabel();
            this.lbl_done = new MetroFramework.Controls.MetroLabel();
            this.lbl_inprogress = new MetroFramework.Controls.MetroLabel();
            this.lbl_research = new MetroFramework.Controls.MetroLabel();
            this.lbl_todo = new MetroFramework.Controls.MetroLabel();
            this.lbl_check = new MetroFramework.Controls.MetroLabel();
            this.dtg_todo = new MetroFramework.Controls.MetroGrid();
            this.dtg_InProgress = new MetroFramework.Controls.MetroGrid();
            this.dtg_research = new MetroFramework.Controls.MetroGrid();
            this.dtg_Check = new MetroFramework.Controls.MetroGrid();
            this.dtg_Done = new MetroFramework.Controls.MetroGrid();
            this.btn_2 = new MetroFramework.Controls.MetroButton();
            this.btn_4 = new MetroFramework.Controls.MetroButton();
            this.btn_3 = new MetroFramework.Controls.MetroButton();
            this.btn_6 = new MetroFramework.Controls.MetroButton();
            this.btn_5 = new MetroFramework.Controls.MetroButton();
            this.btn_8 = new MetroFramework.Controls.MetroButton();
            this.btn_7 = new MetroFramework.Controls.MetroButton();
            this.btn_1 = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_todo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_InProgress)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_research)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_Check)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_Done)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_geri
            // 
            this.btn_geri.Location = new System.Drawing.Point(23, 528);
            this.btn_geri.Name = "btn_geri";
            this.btn_geri.Size = new System.Drawing.Size(104, 54);
            this.btn_geri.TabIndex = 3;
            this.btn_geri.Text = "Geri Dön";
            this.btn_geri.UseSelectable = true;
            this.btn_geri.Click += new System.EventHandler(this.btn_geri_Click);
            // 
            // lbl_aktifprojekodu
            // 
            this.lbl_aktifprojekodu.AutoSize = true;
            this.lbl_aktifprojekodu.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lbl_aktifprojekodu.Location = new System.Drawing.Point(743, 34);
            this.lbl_aktifprojekodu.Name = "lbl_aktifprojekodu";
            this.lbl_aktifprojekodu.Size = new System.Drawing.Size(128, 19);
            this.lbl_aktifprojekodu.TabIndex = 5;
            this.lbl_aktifprojekodu.Text = "Aktif Proje Kodu :";
            // 
            // lbl_aktifproje
            // 
            this.lbl_aktifproje.AutoSize = true;
            this.lbl_aktifproje.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lbl_aktifproje.Location = new System.Drawing.Point(867, 34);
            this.lbl_aktifproje.Name = "lbl_aktifproje";
            this.lbl_aktifproje.Size = new System.Drawing.Size(0, 0);
            this.lbl_aktifproje.TabIndex = 6;
            // 
            // lbl_done
            // 
            this.lbl_done.AutoSize = true;
            this.lbl_done.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lbl_done.Location = new System.Drawing.Point(874, 89);
            this.lbl_done.Name = "lbl_done";
            this.lbl_done.Size = new System.Drawing.Size(44, 19);
            this.lbl_done.TabIndex = 20;
            this.lbl_done.Text = "Done";
            // 
            // lbl_inprogress
            // 
            this.lbl_inprogress.AutoSize = true;
            this.lbl_inprogress.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lbl_inprogress.Location = new System.Drawing.Point(468, 89);
            this.lbl_inprogress.Name = "lbl_inprogress";
            this.lbl_inprogress.Size = new System.Drawing.Size(84, 19);
            this.lbl_inprogress.TabIndex = 19;
            this.lbl_inprogress.Text = "In Progress";
            // 
            // lbl_research
            // 
            this.lbl_research.AutoSize = true;
            this.lbl_research.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lbl_research.Location = new System.Drawing.Point(279, 89);
            this.lbl_research.Name = "lbl_research";
            this.lbl_research.Size = new System.Drawing.Size(69, 19);
            this.lbl_research.TabIndex = 18;
            this.lbl_research.Text = "Research";
            // 
            // lbl_todo
            // 
            this.lbl_todo.AutoSize = true;
            this.lbl_todo.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lbl_todo.Location = new System.Drawing.Point(96, 89);
            this.lbl_todo.Name = "lbl_todo";
            this.lbl_todo.Size = new System.Drawing.Size(48, 19);
            this.lbl_todo.TabIndex = 17;
            this.lbl_todo.Text = "To Do";
            // 
            // lbl_check
            // 
            this.lbl_check.AutoSize = true;
            this.lbl_check.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lbl_check.Location = new System.Drawing.Point(676, 89);
            this.lbl_check.Name = "lbl_check";
            this.lbl_check.Size = new System.Drawing.Size(49, 19);
            this.lbl_check.TabIndex = 22;
            this.lbl_check.Text = "Check";
            // 
            // dtg_todo
            // 
            this.dtg_todo.AllowDrop = true;
            this.dtg_todo.AllowUserToResizeRows = false;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtg_todo.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle17;
            this.dtg_todo.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dtg_todo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dtg_todo.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dtg_todo.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtg_todo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle18;
            this.dtg_todo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle19.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle19.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtg_todo.DefaultCellStyle = dataGridViewCellStyle19;
            this.dtg_todo.EnableHeadersVisualStyles = false;
            this.dtg_todo.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dtg_todo.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dtg_todo.Location = new System.Drawing.Point(53, 124);
            this.dtg_todo.Name = "dtg_todo";
            this.dtg_todo.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle20.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle20.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtg_todo.RowHeadersDefaultCellStyle = dataGridViewCellStyle20;
            this.dtg_todo.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dtg_todo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtg_todo.Size = new System.Drawing.Size(143, 382);
            this.dtg_todo.TabIndex = 23;
            // 
            // dtg_InProgress
            // 
            this.dtg_InProgress.AllowUserToResizeRows = false;
            this.dtg_InProgress.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dtg_InProgress.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dtg_InProgress.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dtg_InProgress.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle21.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle21.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle21.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle21.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle21.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle21.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtg_InProgress.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle21;
            this.dtg_InProgress.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle22.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle22.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle22.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle22.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle22.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle22.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtg_InProgress.DefaultCellStyle = dataGridViewCellStyle22;
            this.dtg_InProgress.EnableHeadersVisualStyles = false;
            this.dtg_InProgress.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dtg_InProgress.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dtg_InProgress.Location = new System.Drawing.Point(437, 124);
            this.dtg_InProgress.Name = "dtg_InProgress";
            this.dtg_InProgress.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle23.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle23.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle23.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle23.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle23.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle23.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtg_InProgress.RowHeadersDefaultCellStyle = dataGridViewCellStyle23;
            this.dtg_InProgress.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dtg_InProgress.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtg_InProgress.Size = new System.Drawing.Size(143, 382);
            this.dtg_InProgress.TabIndex = 25;
            // 
            // dtg_research
            // 
            this.dtg_research.AllowDrop = true;
            this.dtg_research.AllowUserToResizeRows = false;
            this.dtg_research.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dtg_research.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dtg_research.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dtg_research.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle24.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle24.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle24.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle24.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle24.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle24.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtg_research.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle24;
            this.dtg_research.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle25.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle25.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle25.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle25.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle25.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle25.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle25.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtg_research.DefaultCellStyle = dataGridViewCellStyle25;
            this.dtg_research.EnableHeadersVisualStyles = false;
            this.dtg_research.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dtg_research.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dtg_research.Location = new System.Drawing.Point(245, 124);
            this.dtg_research.Name = "dtg_research";
            this.dtg_research.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle26.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle26.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle26.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle26.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle26.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle26.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle26.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtg_research.RowHeadersDefaultCellStyle = dataGridViewCellStyle26;
            this.dtg_research.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dtg_research.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtg_research.Size = new System.Drawing.Size(143, 382);
            this.dtg_research.TabIndex = 26;
            // 
            // dtg_Check
            // 
            this.dtg_Check.AllowUserToResizeRows = false;
            this.dtg_Check.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dtg_Check.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dtg_Check.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dtg_Check.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle27.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle27.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle27.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle27.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle27.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle27.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle27.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtg_Check.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle27;
            this.dtg_Check.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle28.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle28.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle28.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle28.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle28.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle28.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle28.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtg_Check.DefaultCellStyle = dataGridViewCellStyle28;
            this.dtg_Check.EnableHeadersVisualStyles = false;
            this.dtg_Check.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dtg_Check.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dtg_Check.Location = new System.Drawing.Point(629, 124);
            this.dtg_Check.Name = "dtg_Check";
            this.dtg_Check.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle29.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle29.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle29.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle29.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle29.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle29.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle29.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtg_Check.RowHeadersDefaultCellStyle = dataGridViewCellStyle29;
            this.dtg_Check.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dtg_Check.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtg_Check.Size = new System.Drawing.Size(143, 382);
            this.dtg_Check.TabIndex = 27;
            // 
            // dtg_Done
            // 
            this.dtg_Done.AllowUserToResizeRows = false;
            this.dtg_Done.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dtg_Done.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dtg_Done.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dtg_Done.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle30.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle30.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle30.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle30.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle30.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle30.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle30.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtg_Done.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle30;
            this.dtg_Done.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle31.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle31.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle31.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle31.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle31.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle31.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle31.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtg_Done.DefaultCellStyle = dataGridViewCellStyle31;
            this.dtg_Done.EnableHeadersVisualStyles = false;
            this.dtg_Done.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dtg_Done.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dtg_Done.Location = new System.Drawing.Point(821, 124);
            this.dtg_Done.Name = "dtg_Done";
            this.dtg_Done.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle32.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle32.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle32.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle32.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle32.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle32.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle32.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtg_Done.RowHeadersDefaultCellStyle = dataGridViewCellStyle32;
            this.dtg_Done.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dtg_Done.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtg_Done.Size = new System.Drawing.Size(143, 382);
            this.dtg_Done.TabIndex = 28;
            // 
            // btn_2
            // 
            this.btn_2.BackgroundImage = global::ToDoApp.Properties.Resources.left_arrow;
            this.btn_2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_2.Location = new System.Drawing.Point(202, 290);
            this.btn_2.Name = "btn_2";
            this.btn_2.Size = new System.Drawing.Size(37, 42);
            this.btn_2.TabIndex = 30;
            this.btn_2.UseSelectable = true;
            this.btn_2.Click += new System.EventHandler(this.btn_2_Click);
            // 
            // btn_4
            // 
            this.btn_4.BackgroundImage = global::ToDoApp.Properties.Resources.left_arrow;
            this.btn_4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_4.Location = new System.Drawing.Point(394, 290);
            this.btn_4.Name = "btn_4";
            this.btn_4.Size = new System.Drawing.Size(37, 42);
            this.btn_4.TabIndex = 32;
            this.btn_4.UseSelectable = true;
            this.btn_4.Click += new System.EventHandler(this.btn_4_Click);
            // 
            // btn_3
            // 
            this.btn_3.BackgroundImage = global::ToDoApp.Properties.Resources.right_arrow;
            this.btn_3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_3.Location = new System.Drawing.Point(394, 242);
            this.btn_3.Name = "btn_3";
            this.btn_3.Size = new System.Drawing.Size(37, 42);
            this.btn_3.TabIndex = 31;
            this.btn_3.UseSelectable = true;
            this.btn_3.Click += new System.EventHandler(this.btn_3_Click);
            // 
            // btn_6
            // 
            this.btn_6.BackgroundImage = global::ToDoApp.Properties.Resources.left_arrow;
            this.btn_6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_6.Location = new System.Drawing.Point(586, 290);
            this.btn_6.Name = "btn_6";
            this.btn_6.Size = new System.Drawing.Size(37, 42);
            this.btn_6.TabIndex = 34;
            this.btn_6.UseSelectable = true;
            this.btn_6.Click += new System.EventHandler(this.btn_6_Click);
            // 
            // btn_5
            // 
            this.btn_5.BackgroundImage = global::ToDoApp.Properties.Resources.right_arrow;
            this.btn_5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_5.Location = new System.Drawing.Point(586, 242);
            this.btn_5.Name = "btn_5";
            this.btn_5.Size = new System.Drawing.Size(37, 42);
            this.btn_5.TabIndex = 33;
            this.btn_5.UseSelectable = true;
            this.btn_5.Click += new System.EventHandler(this.btn_5_Click);
            // 
            // btn_8
            // 
            this.btn_8.BackgroundImage = global::ToDoApp.Properties.Resources.left_arrow;
            this.btn_8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_8.Location = new System.Drawing.Point(778, 290);
            this.btn_8.Name = "btn_8";
            this.btn_8.Size = new System.Drawing.Size(37, 42);
            this.btn_8.TabIndex = 36;
            this.btn_8.UseSelectable = true;
            this.btn_8.Click += new System.EventHandler(this.btn_8_Click);
            // 
            // btn_7
            // 
            this.btn_7.BackgroundImage = global::ToDoApp.Properties.Resources.right_arrow;
            this.btn_7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_7.Location = new System.Drawing.Point(778, 242);
            this.btn_7.Name = "btn_7";
            this.btn_7.Size = new System.Drawing.Size(37, 42);
            this.btn_7.TabIndex = 35;
            this.btn_7.UseSelectable = true;
            this.btn_7.Click += new System.EventHandler(this.btn_7_Click);
            // 
            // btn_1
            // 
            this.btn_1.BackgroundImage = global::ToDoApp.Properties.Resources.right_arrow;
            this.btn_1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_1.Location = new System.Drawing.Point(202, 242);
            this.btn_1.Name = "btn_1";
            this.btn_1.Size = new System.Drawing.Size(37, 42);
            this.btn_1.TabIndex = 29;
            this.btn_1.UseSelectable = true;
            this.btn_1.Click += new System.EventHandler(this.btn_1_Click);
            // 
            // Panel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1013, 589);
            this.Controls.Add(this.btn_8);
            this.Controls.Add(this.btn_7);
            this.Controls.Add(this.btn_6);
            this.Controls.Add(this.btn_5);
            this.Controls.Add(this.btn_4);
            this.Controls.Add(this.btn_3);
            this.Controls.Add(this.btn_2);
            this.Controls.Add(this.btn_1);
            this.Controls.Add(this.dtg_Done);
            this.Controls.Add(this.dtg_Check);
            this.Controls.Add(this.dtg_research);
            this.Controls.Add(this.dtg_InProgress);
            this.Controls.Add(this.dtg_todo);
            this.Controls.Add(this.lbl_check);
            this.Controls.Add(this.lbl_done);
            this.Controls.Add(this.lbl_inprogress);
            this.Controls.Add(this.lbl_research);
            this.Controls.Add(this.lbl_todo);
            this.Controls.Add(this.lbl_aktifproje);
            this.Controls.Add(this.lbl_aktifprojekodu);
            this.Controls.Add(this.btn_geri);
            this.Name = "Panel";
            this.Text = "To Do Panel";
            this.Load += new System.EventHandler(this.Panel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_todo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_InProgress)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_research)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_Check)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_Done)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroButton btn_geri;
        private MetroFramework.Controls.MetroLabel lbl_aktifprojekodu;
        private MetroFramework.Controls.MetroLabel lbl_aktifproje;
        private MetroFramework.Controls.MetroLabel lbl_done;
        private MetroFramework.Controls.MetroLabel lbl_inprogress;
        private MetroFramework.Controls.MetroLabel lbl_research;
        private MetroFramework.Controls.MetroLabel lbl_todo;
        private MetroFramework.Controls.MetroLabel lbl_check;
        private MetroFramework.Controls.MetroGrid dtg_todo;
        private MetroFramework.Controls.MetroGrid dtg_InProgress;
        private MetroFramework.Controls.MetroGrid dtg_research;
        private MetroFramework.Controls.MetroGrid dtg_Check;
        private MetroFramework.Controls.MetroGrid dtg_Done;
        private MetroFramework.Controls.MetroButton btn_1;
        private MetroFramework.Controls.MetroButton btn_2;
        private MetroFramework.Controls.MetroButton btn_4;
        private MetroFramework.Controls.MetroButton btn_3;
        private MetroFramework.Controls.MetroButton btn_6;
        private MetroFramework.Controls.MetroButton btn_5;
        private MetroFramework.Controls.MetroButton btn_8;
        private MetroFramework.Controls.MetroButton btn_7;
    }
}