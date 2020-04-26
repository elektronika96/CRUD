namespace ProgramCRUD
{
    partial class Dokumenty
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle43 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle44 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle45 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle46 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle47 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle48 = new System.Windows.Forms.DataGridViewCellStyle();
            this.mGrid_Naglowki = new MetroFramework.Controls.MetroGrid();
            this.nagIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nagDataDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nagNumerKlientaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nagNazwaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nagCenaNettoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nagCenaBruttoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.naglowekBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dokumentyDataSet = new ProgramCRUD.DokumentyDataSet();
            this.mGrid_Pozycje = new MetroFramework.Controls.MetroGrid();
            this.pozIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pozNagIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pozNazwaArtykuluDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pozLiczbaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pozCenaNettoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pozCenaBruttoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pozycjaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.baza = new ProgramCRUD.Baza();
            this.mPanel = new MetroFramework.Controls.MetroPanel();
            this.dateTime = new System.Windows.Forms.DateTimePicker();
            this.txt_Nazwa = new MetroFramework.Controls.MetroTextBox();
            this.txt_NumerKlienta = new MetroFramework.Controls.MetroTextBox();
            this.mLab_Nazwa = new MetroFramework.Controls.MetroLabel();
            this.mLab_NumerKlienta = new MetroFramework.Controls.MetroLabel();
            this.mLab_Data = new MetroFramework.Controls.MetroLabel();
            this.btn_Dodaj = new MetroFramework.Controls.MetroButton();
            this.btn_Edytuj = new MetroFramework.Controls.MetroButton();
            this.btn_Usun = new MetroFramework.Controls.MetroButton();
            this.btn_Anuluj = new MetroFramework.Controls.MetroButton();
            this.btn_Zapisz = new MetroFramework.Controls.MetroButton();
            this.naglowekTableAdapter = new ProgramCRUD.DokumentyDataSetTableAdapters.NaglowekTableAdapter();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.btn_ZapiszP = new MetroFramework.Controls.MetroButton();
            this.btn_AnulujP = new MetroFramework.Controls.MetroButton();
            this.btn_UsunP = new MetroFramework.Controls.MetroButton();
            this.btn_EdytujP = new MetroFramework.Controls.MetroButton();
            this.btn_DodajP = new MetroFramework.Controls.MetroButton();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.mComBox_NazNag = new MetroFramework.Controls.MetroComboBox();
            this.mTxt_CenaBruttoP = new MetroFramework.Controls.MetroTextBox();
            this.mTxt_CenaNettoP = new MetroFramework.Controls.MetroTextBox();
            this.mTxt_Liczba = new MetroFramework.Controls.MetroTextBox();
            this.mTxt_NazwaArtykulu = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.mLab_NazwaNag = new MetroFramework.Controls.MetroLabel();
            this.pozycjaTableAdapter = new ProgramCRUD.BazaTableAdapters.PozycjaTableAdapter();
            this.labUser = new MetroFramework.Controls.MetroLabel();
            this.lab_CreateDate = new MetroFramework.Controls.MetroLabel();
            this.lab_URL = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.mGrid_Naglowki)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.naglowekBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dokumentyDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mGrid_Pozycje)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pozycjaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.baza)).BeginInit();
            this.mPanel.SuspendLayout();
            this.metroPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mGrid_Naglowki
            // 
            this.mGrid_Naglowki.AllowUserToAddRows = false;
            this.mGrid_Naglowki.AllowUserToDeleteRows = false;
            this.mGrid_Naglowki.AllowUserToResizeColumns = false;
            this.mGrid_Naglowki.AllowUserToResizeRows = false;
            this.mGrid_Naglowki.AutoGenerateColumns = false;
            this.mGrid_Naglowki.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mGrid_Naglowki.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mGrid_Naglowki.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.mGrid_Naglowki.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle43.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle43.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle43.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle43.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle43.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle43.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle43.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mGrid_Naglowki.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle43;
            this.mGrid_Naglowki.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mGrid_Naglowki.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nagIDDataGridViewTextBoxColumn,
            this.nagDataDataGridViewTextBoxColumn,
            this.nagNumerKlientaDataGridViewTextBoxColumn,
            this.nagNazwaDataGridViewTextBoxColumn,
            this.nagCenaNettoDataGridViewTextBoxColumn,
            this.nagCenaBruttoDataGridViewTextBoxColumn});
            this.mGrid_Naglowki.DataSource = this.naglowekBindingSource;
            dataGridViewCellStyle44.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle44.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle44.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle44.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle44.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle44.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle44.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.mGrid_Naglowki.DefaultCellStyle = dataGridViewCellStyle44;
            this.mGrid_Naglowki.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.mGrid_Naglowki.EnableHeadersVisualStyles = false;
            this.mGrid_Naglowki.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.mGrid_Naglowki.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mGrid_Naglowki.Location = new System.Drawing.Point(24, 81);
            this.mGrid_Naglowki.MultiSelect = false;
            this.mGrid_Naglowki.Name = "mGrid_Naglowki";
            this.mGrid_Naglowki.ReadOnly = true;
            this.mGrid_Naglowki.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle45.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle45.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle45.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle45.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle45.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle45.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle45.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mGrid_Naglowki.RowHeadersDefaultCellStyle = dataGridViewCellStyle45;
            this.mGrid_Naglowki.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.mGrid_Naglowki.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.mGrid_Naglowki.Size = new System.Drawing.Size(630, 218);
            this.mGrid_Naglowki.TabIndex = 0;
            // 
            // nagIDDataGridViewTextBoxColumn
            // 
            this.nagIDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.nagIDDataGridViewTextBoxColumn.DataPropertyName = "Nag_ID";
            this.nagIDDataGridViewTextBoxColumn.HeaderText = "Nag_ID";
            this.nagIDDataGridViewTextBoxColumn.Name = "nagIDDataGridViewTextBoxColumn";
            this.nagIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.nagIDDataGridViewTextBoxColumn.Width = 67;
            // 
            // nagDataDataGridViewTextBoxColumn
            // 
            this.nagDataDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.nagDataDataGridViewTextBoxColumn.DataPropertyName = "Nag_Data";
            this.nagDataDataGridViewTextBoxColumn.HeaderText = "Nag_Data";
            this.nagDataDataGridViewTextBoxColumn.Name = "nagDataDataGridViewTextBoxColumn";
            this.nagDataDataGridViewTextBoxColumn.ReadOnly = true;
            this.nagDataDataGridViewTextBoxColumn.Width = 80;
            // 
            // nagNumerKlientaDataGridViewTextBoxColumn
            // 
            this.nagNumerKlientaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.nagNumerKlientaDataGridViewTextBoxColumn.DataPropertyName = "Nag_NumerKlienta";
            this.nagNumerKlientaDataGridViewTextBoxColumn.HeaderText = "Nag_NumerKlienta";
            this.nagNumerKlientaDataGridViewTextBoxColumn.Name = "nagNumerKlientaDataGridViewTextBoxColumn";
            this.nagNumerKlientaDataGridViewTextBoxColumn.ReadOnly = true;
            this.nagNumerKlientaDataGridViewTextBoxColumn.Width = 125;
            // 
            // nagNazwaDataGridViewTextBoxColumn
            // 
            this.nagNazwaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.nagNazwaDataGridViewTextBoxColumn.DataPropertyName = "Nag_Nazwa";
            this.nagNazwaDataGridViewTextBoxColumn.HeaderText = "Nag_Nazwa";
            this.nagNazwaDataGridViewTextBoxColumn.Name = "nagNazwaDataGridViewTextBoxColumn";
            this.nagNazwaDataGridViewTextBoxColumn.ReadOnly = true;
            this.nagNazwaDataGridViewTextBoxColumn.Width = 90;
            // 
            // nagCenaNettoDataGridViewTextBoxColumn
            // 
            this.nagCenaNettoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.nagCenaNettoDataGridViewTextBoxColumn.DataPropertyName = "Nag_CenaNetto";
            this.nagCenaNettoDataGridViewTextBoxColumn.HeaderText = "Nag_CenaNetto";
            this.nagCenaNettoDataGridViewTextBoxColumn.Name = "nagCenaNettoDataGridViewTextBoxColumn";
            this.nagCenaNettoDataGridViewTextBoxColumn.ReadOnly = true;
            this.nagCenaNettoDataGridViewTextBoxColumn.Width = 111;
            // 
            // nagCenaBruttoDataGridViewTextBoxColumn
            // 
            this.nagCenaBruttoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.nagCenaBruttoDataGridViewTextBoxColumn.DataPropertyName = "Nag_CenaBrutto";
            this.nagCenaBruttoDataGridViewTextBoxColumn.HeaderText = "Nag_CenaBrutto";
            this.nagCenaBruttoDataGridViewTextBoxColumn.Name = "nagCenaBruttoDataGridViewTextBoxColumn";
            this.nagCenaBruttoDataGridViewTextBoxColumn.ReadOnly = true;
            this.nagCenaBruttoDataGridViewTextBoxColumn.Width = 114;
            // 
            // naglowekBindingSource
            // 
            this.naglowekBindingSource.DataMember = "Naglowek";
            this.naglowekBindingSource.DataSource = this.dokumentyDataSet;
            // 
            // dokumentyDataSet
            // 
            this.dokumentyDataSet.DataSetName = "DokumentyDataSet";
            this.dokumentyDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mGrid_Pozycje
            // 
            this.mGrid_Pozycje.AllowUserToAddRows = false;
            this.mGrid_Pozycje.AllowUserToDeleteRows = false;
            this.mGrid_Pozycje.AllowUserToResizeRows = false;
            this.mGrid_Pozycje.AutoGenerateColumns = false;
            this.mGrid_Pozycje.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mGrid_Pozycje.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mGrid_Pozycje.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.mGrid_Pozycje.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle46.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle46.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle46.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle46.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle46.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle46.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle46.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mGrid_Pozycje.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle46;
            this.mGrid_Pozycje.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mGrid_Pozycje.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pozIDDataGridViewTextBoxColumn,
            this.pozNagIDDataGridViewTextBoxColumn,
            this.pozNazwaArtykuluDataGridViewTextBoxColumn,
            this.pozLiczbaDataGridViewTextBoxColumn,
            this.pozCenaNettoDataGridViewTextBoxColumn,
            this.pozCenaBruttoDataGridViewTextBoxColumn});
            this.mGrid_Pozycje.DataSource = this.pozycjaBindingSource;
            dataGridViewCellStyle47.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle47.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle47.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle47.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle47.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle47.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle47.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.mGrid_Pozycje.DefaultCellStyle = dataGridViewCellStyle47;
            this.mGrid_Pozycje.EnableHeadersVisualStyles = false;
            this.mGrid_Pozycje.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.mGrid_Pozycje.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mGrid_Pozycje.Location = new System.Drawing.Point(23, 342);
            this.mGrid_Pozycje.Name = "mGrid_Pozycje";
            this.mGrid_Pozycje.ReadOnly = true;
            this.mGrid_Pozycje.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle48.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle48.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle48.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle48.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle48.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle48.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle48.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mGrid_Pozycje.RowHeadersDefaultCellStyle = dataGridViewCellStyle48;
            this.mGrid_Pozycje.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.mGrid_Pozycje.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.mGrid_Pozycje.Size = new System.Drawing.Size(630, 220);
            this.mGrid_Pozycje.TabIndex = 1;
            // 
            // pozIDDataGridViewTextBoxColumn
            // 
            this.pozIDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.pozIDDataGridViewTextBoxColumn.DataPropertyName = "Poz_ID";
            this.pozIDDataGridViewTextBoxColumn.HeaderText = "Poz_ID";
            this.pozIDDataGridViewTextBoxColumn.Name = "pozIDDataGridViewTextBoxColumn";
            this.pozIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.pozIDDataGridViewTextBoxColumn.Width = 64;
            // 
            // pozNagIDDataGridViewTextBoxColumn
            // 
            this.pozNagIDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.pozNagIDDataGridViewTextBoxColumn.DataPropertyName = "Poz_NagID";
            this.pozNagIDDataGridViewTextBoxColumn.HeaderText = "Poz_NagID";
            this.pozNagIDDataGridViewTextBoxColumn.Name = "pozNagIDDataGridViewTextBoxColumn";
            this.pozNagIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.pozNagIDDataGridViewTextBoxColumn.Width = 85;
            // 
            // pozNazwaArtykuluDataGridViewTextBoxColumn
            // 
            this.pozNazwaArtykuluDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.pozNazwaArtykuluDataGridViewTextBoxColumn.DataPropertyName = "Poz_NazwaArtykulu";
            this.pozNazwaArtykuluDataGridViewTextBoxColumn.HeaderText = "Poz_NazwaArtykulu";
            this.pozNazwaArtykuluDataGridViewTextBoxColumn.Name = "pozNazwaArtykuluDataGridViewTextBoxColumn";
            this.pozNazwaArtykuluDataGridViewTextBoxColumn.ReadOnly = true;
            this.pozNazwaArtykuluDataGridViewTextBoxColumn.Width = 130;
            // 
            // pozLiczbaDataGridViewTextBoxColumn
            // 
            this.pozLiczbaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.pozLiczbaDataGridViewTextBoxColumn.DataPropertyName = "Poz_Liczba";
            this.pozLiczbaDataGridViewTextBoxColumn.HeaderText = "Poz_Liczba";
            this.pozLiczbaDataGridViewTextBoxColumn.Name = "pozLiczbaDataGridViewTextBoxColumn";
            this.pozLiczbaDataGridViewTextBoxColumn.ReadOnly = true;
            this.pozLiczbaDataGridViewTextBoxColumn.Width = 84;
            // 
            // pozCenaNettoDataGridViewTextBoxColumn
            // 
            this.pozCenaNettoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.pozCenaNettoDataGridViewTextBoxColumn.DataPropertyName = "Poz_CenaNetto";
            this.pozCenaNettoDataGridViewTextBoxColumn.HeaderText = "Poz_CenaNetto";
            this.pozCenaNettoDataGridViewTextBoxColumn.Name = "pozCenaNettoDataGridViewTextBoxColumn";
            this.pozCenaNettoDataGridViewTextBoxColumn.ReadOnly = true;
            this.pozCenaNettoDataGridViewTextBoxColumn.Width = 108;
            // 
            // pozCenaBruttoDataGridViewTextBoxColumn
            // 
            this.pozCenaBruttoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.pozCenaBruttoDataGridViewTextBoxColumn.DataPropertyName = "Poz_CenaBrutto";
            this.pozCenaBruttoDataGridViewTextBoxColumn.HeaderText = "Poz_CenaBrutto";
            this.pozCenaBruttoDataGridViewTextBoxColumn.Name = "pozCenaBruttoDataGridViewTextBoxColumn";
            this.pozCenaBruttoDataGridViewTextBoxColumn.ReadOnly = true;
            this.pozCenaBruttoDataGridViewTextBoxColumn.Width = 111;
            // 
            // pozycjaBindingSource
            // 
            this.pozycjaBindingSource.DataMember = "Pozycja";
            this.pozycjaBindingSource.DataSource = this.baza;
            // 
            // baza
            // 
            this.baza.DataSetName = "Baza";
            this.baza.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mPanel
            // 
            this.mPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mPanel.Controls.Add(this.dateTime);
            this.mPanel.Controls.Add(this.txt_Nazwa);
            this.mPanel.Controls.Add(this.txt_NumerKlienta);
            this.mPanel.Controls.Add(this.mLab_Nazwa);
            this.mPanel.Controls.Add(this.mLab_NumerKlienta);
            this.mPanel.Controls.Add(this.mLab_Data);
            this.mPanel.HorizontalScrollbarBarColor = true;
            this.mPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.mPanel.HorizontalScrollbarSize = 10;
            this.mPanel.Location = new System.Drawing.Point(832, 81);
            this.mPanel.Name = "mPanel";
            this.mPanel.Size = new System.Drawing.Size(426, 218);
            this.mPanel.TabIndex = 2;
            this.mPanel.VerticalScrollbarBarColor = true;
            this.mPanel.VerticalScrollbarHighlightOnWheel = false;
            this.mPanel.VerticalScrollbarSize = 10;
            // 
            // dateTime
            // 
            this.dateTime.Location = new System.Drawing.Point(162, 22);
            this.dateTime.Name = "dateTime";
            this.dateTime.Size = new System.Drawing.Size(242, 20);
            this.dateTime.TabIndex = 16;
            // 
            // txt_Nazwa
            // 
            // 
            // 
            // 
            this.txt_Nazwa.CustomButton.Image = null;
            this.txt_Nazwa.CustomButton.Location = new System.Drawing.Point(220, 1);
            this.txt_Nazwa.CustomButton.Name = "";
            this.txt_Nazwa.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_Nazwa.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_Nazwa.CustomButton.TabIndex = 1;
            this.txt_Nazwa.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_Nazwa.CustomButton.UseSelectable = true;
            this.txt_Nazwa.CustomButton.Visible = false;
            this.txt_Nazwa.Lines = new string[0];
            this.txt_Nazwa.Location = new System.Drawing.Point(162, 82);
            this.txt_Nazwa.MaxLength = 32767;
            this.txt_Nazwa.Name = "txt_Nazwa";
            this.txt_Nazwa.PasswordChar = '\0';
            this.txt_Nazwa.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_Nazwa.SelectedText = "";
            this.txt_Nazwa.SelectionLength = 0;
            this.txt_Nazwa.SelectionStart = 0;
            this.txt_Nazwa.ShortcutsEnabled = true;
            this.txt_Nazwa.Size = new System.Drawing.Size(242, 23);
            this.txt_Nazwa.TabIndex = 13;
            this.txt_Nazwa.UseSelectable = true;
            this.txt_Nazwa.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_Nazwa.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txt_NumerKlienta
            // 
            // 
            // 
            // 
            this.txt_NumerKlienta.CustomButton.Image = null;
            this.txt_NumerKlienta.CustomButton.Location = new System.Drawing.Point(220, 1);
            this.txt_NumerKlienta.CustomButton.Name = "";
            this.txt_NumerKlienta.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_NumerKlienta.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_NumerKlienta.CustomButton.TabIndex = 1;
            this.txt_NumerKlienta.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_NumerKlienta.CustomButton.UseSelectable = true;
            this.txt_NumerKlienta.CustomButton.Visible = false;
            this.txt_NumerKlienta.Lines = new string[0];
            this.txt_NumerKlienta.Location = new System.Drawing.Point(162, 53);
            this.txt_NumerKlienta.MaxLength = 32767;
            this.txt_NumerKlienta.Name = "txt_NumerKlienta";
            this.txt_NumerKlienta.PasswordChar = '\0';
            this.txt_NumerKlienta.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_NumerKlienta.SelectedText = "";
            this.txt_NumerKlienta.SelectionLength = 0;
            this.txt_NumerKlienta.SelectionStart = 0;
            this.txt_NumerKlienta.ShortcutsEnabled = true;
            this.txt_NumerKlienta.Size = new System.Drawing.Size(242, 23);
            this.txt_NumerKlienta.TabIndex = 12;
            this.txt_NumerKlienta.UseSelectable = true;
            this.txt_NumerKlienta.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_NumerKlienta.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // mLab_Nazwa
            // 
            this.mLab_Nazwa.AutoSize = true;
            this.mLab_Nazwa.Location = new System.Drawing.Point(3, 82);
            this.mLab_Nazwa.Name = "mLab_Nazwa";
            this.mLab_Nazwa.Size = new System.Drawing.Size(48, 19);
            this.mLab_Nazwa.TabIndex = 6;
            this.mLab_Nazwa.Text = "Nazwa";
            // 
            // mLab_NumerKlienta
            // 
            this.mLab_NumerKlienta.AutoSize = true;
            this.mLab_NumerKlienta.Location = new System.Drawing.Point(3, 51);
            this.mLab_NumerKlienta.Name = "mLab_NumerKlienta";
            this.mLab_NumerKlienta.Size = new System.Drawing.Size(91, 19);
            this.mLab_NumerKlienta.TabIndex = 4;
            this.mLab_NumerKlienta.Text = "Numer klienta";
            // 
            // mLab_Data
            // 
            this.mLab_Data.AutoSize = true;
            this.mLab_Data.Location = new System.Drawing.Point(3, 23);
            this.mLab_Data.Name = "mLab_Data";
            this.mLab_Data.Size = new System.Drawing.Size(106, 19);
            this.mLab_Data.TabIndex = 2;
            this.mLab_Data.Text = "Data dokumentu";
            // 
            // btn_Dodaj
            // 
            this.btn_Dodaj.Location = new System.Drawing.Point(669, 105);
            this.btn_Dodaj.Name = "btn_Dodaj";
            this.btn_Dodaj.Size = new System.Drawing.Size(147, 28);
            this.btn_Dodaj.TabIndex = 3;
            this.btn_Dodaj.Text = "Dodaj";
            this.btn_Dodaj.UseSelectable = true;
            this.btn_Dodaj.Click += new System.EventHandler(this.btn_Dodaj_Click);
            // 
            // btn_Edytuj
            // 
            this.btn_Edytuj.Location = new System.Drawing.Point(669, 139);
            this.btn_Edytuj.Name = "btn_Edytuj";
            this.btn_Edytuj.Size = new System.Drawing.Size(147, 28);
            this.btn_Edytuj.TabIndex = 4;
            this.btn_Edytuj.Text = "Edytuj";
            this.btn_Edytuj.UseSelectable = true;
            this.btn_Edytuj.Click += new System.EventHandler(this.btn_Edytuj_Click);
            // 
            // btn_Usun
            // 
            this.btn_Usun.Location = new System.Drawing.Point(669, 173);
            this.btn_Usun.Name = "btn_Usun";
            this.btn_Usun.Size = new System.Drawing.Size(147, 28);
            this.btn_Usun.TabIndex = 5;
            this.btn_Usun.Text = "Usuń";
            this.btn_Usun.UseSelectable = true;
            this.btn_Usun.Click += new System.EventHandler(this.btn_Usun_Click);
            // 
            // btn_Anuluj
            // 
            this.btn_Anuluj.Location = new System.Drawing.Point(669, 207);
            this.btn_Anuluj.Name = "btn_Anuluj";
            this.btn_Anuluj.Size = new System.Drawing.Size(147, 28);
            this.btn_Anuluj.TabIndex = 6;
            this.btn_Anuluj.Text = "Wyczyść";
            this.btn_Anuluj.UseSelectable = true;
            this.btn_Anuluj.Click += new System.EventHandler(this.btn_Anuluj_Click);
            // 
            // btn_Zapisz
            // 
            this.btn_Zapisz.Enabled = false;
            this.btn_Zapisz.Location = new System.Drawing.Point(669, 241);
            this.btn_Zapisz.Name = "btn_Zapisz";
            this.btn_Zapisz.Size = new System.Drawing.Size(147, 28);
            this.btn_Zapisz.TabIndex = 7;
            this.btn_Zapisz.Text = "Zapisz";
            this.btn_Zapisz.UseSelectable = true;
            this.btn_Zapisz.Click += new System.EventHandler(this.btn_Zapisz_Click);
            // 
            // naglowekTableAdapter
            // 
            this.naglowekTableAdapter.ClearBeforeFill = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.Location = new System.Drawing.Point(23, 302);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(68, 25);
            this.metroLabel1.TabIndex = 8;
            this.metroLabel1.Text = "Pozycje";
            // 
            // btn_ZapiszP
            // 
            this.btn_ZapiszP.Enabled = false;
            this.btn_ZapiszP.Location = new System.Drawing.Point(669, 500);
            this.btn_ZapiszP.Name = "btn_ZapiszP";
            this.btn_ZapiszP.Size = new System.Drawing.Size(147, 28);
            this.btn_ZapiszP.TabIndex = 13;
            this.btn_ZapiszP.Text = "Zapisz";
            this.btn_ZapiszP.UseSelectable = true;
            this.btn_ZapiszP.Click += new System.EventHandler(this.btnZapiszP_Click);
            // 
            // btn_AnulujP
            // 
            this.btn_AnulujP.Location = new System.Drawing.Point(669, 466);
            this.btn_AnulujP.Name = "btn_AnulujP";
            this.btn_AnulujP.Size = new System.Drawing.Size(147, 28);
            this.btn_AnulujP.TabIndex = 12;
            this.btn_AnulujP.Text = "Wyczyść";
            this.btn_AnulujP.UseSelectable = true;
            this.btn_AnulujP.Click += new System.EventHandler(this.btn_AnulujP_Click);
            // 
            // btn_UsunP
            // 
            this.btn_UsunP.Location = new System.Drawing.Point(669, 432);
            this.btn_UsunP.Name = "btn_UsunP";
            this.btn_UsunP.Size = new System.Drawing.Size(147, 28);
            this.btn_UsunP.TabIndex = 11;
            this.btn_UsunP.Text = "Usuń";
            this.btn_UsunP.UseSelectable = true;
            this.btn_UsunP.Click += new System.EventHandler(this.btn_UsunP_Click);
            // 
            // btn_EdytujP
            // 
            this.btn_EdytujP.Location = new System.Drawing.Point(669, 398);
            this.btn_EdytujP.Name = "btn_EdytujP";
            this.btn_EdytujP.Size = new System.Drawing.Size(147, 28);
            this.btn_EdytujP.TabIndex = 10;
            this.btn_EdytujP.Text = "Edytuj";
            this.btn_EdytujP.UseSelectable = true;
            this.btn_EdytujP.Click += new System.EventHandler(this.btn_EdytujP_Click);
            // 
            // btn_DodajP
            // 
            this.btn_DodajP.Location = new System.Drawing.Point(669, 364);
            this.btn_DodajP.Name = "btn_DodajP";
            this.btn_DodajP.Size = new System.Drawing.Size(147, 28);
            this.btn_DodajP.TabIndex = 9;
            this.btn_DodajP.Text = "Dodaj";
            this.btn_DodajP.UseSelectable = true;
            this.btn_DodajP.Click += new System.EventHandler(this.btn_DodajP_Click);
            // 
            // metroPanel1
            // 
            this.metroPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.metroPanel1.Controls.Add(this.mComBox_NazNag);
            this.metroPanel1.Controls.Add(this.mTxt_CenaBruttoP);
            this.metroPanel1.Controls.Add(this.mTxt_CenaNettoP);
            this.metroPanel1.Controls.Add(this.mTxt_Liczba);
            this.metroPanel1.Controls.Add(this.mTxt_NazwaArtykulu);
            this.metroPanel1.Controls.Add(this.metroLabel2);
            this.metroPanel1.Controls.Add(this.metroLabel3);
            this.metroPanel1.Controls.Add(this.metroLabel4);
            this.metroPanel1.Controls.Add(this.metroLabel5);
            this.metroPanel1.Controls.Add(this.mLab_NazwaNag);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(832, 344);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(426, 218);
            this.metroPanel1.TabIndex = 17;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // mComBox_NazNag
            // 
            this.mComBox_NazNag.FormattingEnabled = true;
            this.mComBox_NazNag.ItemHeight = 23;
            this.mComBox_NazNag.Location = new System.Drawing.Point(162, 23);
            this.mComBox_NazNag.Name = "mComBox_NazNag";
            this.mComBox_NazNag.Size = new System.Drawing.Size(242, 29);
            this.mComBox_NazNag.TabIndex = 16;
            this.mComBox_NazNag.UseSelectable = true;
            // 
            // mTxt_CenaBruttoP
            // 
            // 
            // 
            // 
            this.mTxt_CenaBruttoP.CustomButton.Image = null;
            this.mTxt_CenaBruttoP.CustomButton.Location = new System.Drawing.Point(220, 1);
            this.mTxt_CenaBruttoP.CustomButton.Name = "";
            this.mTxt_CenaBruttoP.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.mTxt_CenaBruttoP.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mTxt_CenaBruttoP.CustomButton.TabIndex = 1;
            this.mTxt_CenaBruttoP.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mTxt_CenaBruttoP.CustomButton.UseSelectable = true;
            this.mTxt_CenaBruttoP.CustomButton.Visible = false;
            this.mTxt_CenaBruttoP.Lines = new string[0];
            this.mTxt_CenaBruttoP.Location = new System.Drawing.Point(162, 141);
            this.mTxt_CenaBruttoP.MaxLength = 32767;
            this.mTxt_CenaBruttoP.Name = "mTxt_CenaBruttoP";
            this.mTxt_CenaBruttoP.PasswordChar = '\0';
            this.mTxt_CenaBruttoP.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mTxt_CenaBruttoP.SelectedText = "";
            this.mTxt_CenaBruttoP.SelectionLength = 0;
            this.mTxt_CenaBruttoP.SelectionStart = 0;
            this.mTxt_CenaBruttoP.ShortcutsEnabled = true;
            this.mTxt_CenaBruttoP.Size = new System.Drawing.Size(242, 23);
            this.mTxt_CenaBruttoP.TabIndex = 15;
            this.mTxt_CenaBruttoP.UseSelectable = true;
            this.mTxt_CenaBruttoP.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mTxt_CenaBruttoP.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // mTxt_CenaNettoP
            // 
            // 
            // 
            // 
            this.mTxt_CenaNettoP.CustomButton.Image = null;
            this.mTxt_CenaNettoP.CustomButton.Location = new System.Drawing.Point(220, 1);
            this.mTxt_CenaNettoP.CustomButton.Name = "";
            this.mTxt_CenaNettoP.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.mTxt_CenaNettoP.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mTxt_CenaNettoP.CustomButton.TabIndex = 1;
            this.mTxt_CenaNettoP.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mTxt_CenaNettoP.CustomButton.UseSelectable = true;
            this.mTxt_CenaNettoP.CustomButton.Visible = false;
            this.mTxt_CenaNettoP.Lines = new string[0];
            this.mTxt_CenaNettoP.Location = new System.Drawing.Point(162, 112);
            this.mTxt_CenaNettoP.MaxLength = 32767;
            this.mTxt_CenaNettoP.Name = "mTxt_CenaNettoP";
            this.mTxt_CenaNettoP.PasswordChar = '\0';
            this.mTxt_CenaNettoP.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mTxt_CenaNettoP.SelectedText = "";
            this.mTxt_CenaNettoP.SelectionLength = 0;
            this.mTxt_CenaNettoP.SelectionStart = 0;
            this.mTxt_CenaNettoP.ShortcutsEnabled = true;
            this.mTxt_CenaNettoP.Size = new System.Drawing.Size(242, 23);
            this.mTxt_CenaNettoP.TabIndex = 14;
            this.mTxt_CenaNettoP.UseSelectable = true;
            this.mTxt_CenaNettoP.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mTxt_CenaNettoP.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // mTxt_Liczba
            // 
            // 
            // 
            // 
            this.mTxt_Liczba.CustomButton.Image = null;
            this.mTxt_Liczba.CustomButton.Location = new System.Drawing.Point(220, 1);
            this.mTxt_Liczba.CustomButton.Name = "";
            this.mTxt_Liczba.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.mTxt_Liczba.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mTxt_Liczba.CustomButton.TabIndex = 1;
            this.mTxt_Liczba.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mTxt_Liczba.CustomButton.UseSelectable = true;
            this.mTxt_Liczba.CustomButton.Visible = false;
            this.mTxt_Liczba.Lines = new string[0];
            this.mTxt_Liczba.Location = new System.Drawing.Point(162, 82);
            this.mTxt_Liczba.MaxLength = 32767;
            this.mTxt_Liczba.Name = "mTxt_Liczba";
            this.mTxt_Liczba.PasswordChar = '\0';
            this.mTxt_Liczba.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mTxt_Liczba.SelectedText = "";
            this.mTxt_Liczba.SelectionLength = 0;
            this.mTxt_Liczba.SelectionStart = 0;
            this.mTxt_Liczba.ShortcutsEnabled = true;
            this.mTxt_Liczba.Size = new System.Drawing.Size(242, 23);
            this.mTxt_Liczba.TabIndex = 13;
            this.mTxt_Liczba.UseSelectable = true;
            this.mTxt_Liczba.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mTxt_Liczba.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // mTxt_NazwaArtykulu
            // 
            // 
            // 
            // 
            this.mTxt_NazwaArtykulu.CustomButton.Image = null;
            this.mTxt_NazwaArtykulu.CustomButton.Location = new System.Drawing.Point(220, 1);
            this.mTxt_NazwaArtykulu.CustomButton.Name = "";
            this.mTxt_NazwaArtykulu.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.mTxt_NazwaArtykulu.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mTxt_NazwaArtykulu.CustomButton.TabIndex = 1;
            this.mTxt_NazwaArtykulu.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mTxt_NazwaArtykulu.CustomButton.UseSelectable = true;
            this.mTxt_NazwaArtykulu.CustomButton.Visible = false;
            this.mTxt_NazwaArtykulu.Lines = new string[0];
            this.mTxt_NazwaArtykulu.Location = new System.Drawing.Point(162, 53);
            this.mTxt_NazwaArtykulu.MaxLength = 32767;
            this.mTxt_NazwaArtykulu.Name = "mTxt_NazwaArtykulu";
            this.mTxt_NazwaArtykulu.PasswordChar = '\0';
            this.mTxt_NazwaArtykulu.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mTxt_NazwaArtykulu.SelectedText = "";
            this.mTxt_NazwaArtykulu.SelectionLength = 0;
            this.mTxt_NazwaArtykulu.SelectionStart = 0;
            this.mTxt_NazwaArtykulu.ShortcutsEnabled = true;
            this.mTxt_NazwaArtykulu.Size = new System.Drawing.Size(242, 23);
            this.mTxt_NazwaArtykulu.TabIndex = 12;
            this.mTxt_NazwaArtykulu.UseSelectable = true;
            this.mTxt_NazwaArtykulu.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mTxt_NazwaArtykulu.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(3, 140);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(79, 19);
            this.metroLabel2.TabIndex = 10;
            this.metroLabel2.Text = "Cena brutto";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(3, 112);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(73, 19);
            this.metroLabel3.TabIndex = 8;
            this.metroLabel3.Text = "Cena netto";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(3, 82);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(45, 19);
            this.metroLabel4.TabIndex = 6;
            this.metroLabel4.Text = "Liczba";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(3, 51);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(98, 19);
            this.metroLabel5.TabIndex = 4;
            this.metroLabel5.Text = "Nazwa artykułu";
            // 
            // mLab_NazwaNag
            // 
            this.mLab_NazwaNag.AutoSize = true;
            this.mLab_NazwaNag.Location = new System.Drawing.Point(3, 23);
            this.mLab_NazwaNag.Name = "mLab_NazwaNag";
            this.mLab_NazwaNag.Size = new System.Drawing.Size(107, 19);
            this.mLab_NazwaNag.TabIndex = 2;
            this.mLab_NazwaNag.Text = "Nazwa nagłówka";
            // 
            // pozycjaTableAdapter
            // 
            this.pozycjaTableAdapter.ClearBeforeFill = true;
            // 
            // labUser
            // 
            this.labUser.AutoSize = true;
            this.labUser.Location = new System.Drawing.Point(168, 13);
            this.labUser.Name = "labUser";
            this.labUser.Size = new System.Drawing.Size(155, 19);
            this.labUser.TabIndex = 18;
            this.labUser.Text = "Właściciel repozytorium: ";
            // 
            // lab_CreateDate
            // 
            this.lab_CreateDate.AutoSize = true;
            this.lab_CreateDate.Location = new System.Drawing.Point(437, 13);
            this.lab_CreateDate.Name = "lab_CreateDate";
            this.lab_CreateDate.Size = new System.Drawing.Size(110, 19);
            this.lab_CreateDate.TabIndex = 19;
            this.lab_CreateDate.Text = "Data utworzenia: ";
            // 
            // lab_URL
            // 
            this.lab_URL.AutoSize = true;
            this.lab_URL.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lab_URL.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lab_URL.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lab_URL.Location = new System.Drawing.Point(711, 13);
            this.lab_URL.Name = "lab_URL";
            this.lab_URL.Size = new System.Drawing.Size(0, 0);
            this.lab_URL.Style = MetroFramework.MetroColorStyle.Blue;
            this.lab_URL.TabIndex = 20;
            this.lab_URL.Click += new System.EventHandler(this.lab_URL_Click);
            // 
            // Dokumenty
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1271, 571);
            this.Controls.Add(this.lab_URL);
            this.Controls.Add(this.lab_CreateDate);
            this.Controls.Add(this.labUser);
            this.Controls.Add(this.metroPanel1);
            this.Controls.Add(this.btn_ZapiszP);
            this.Controls.Add(this.btn_AnulujP);
            this.Controls.Add(this.btn_UsunP);
            this.Controls.Add(this.btn_EdytujP);
            this.Controls.Add(this.btn_DodajP);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.btn_Zapisz);
            this.Controls.Add(this.btn_Anuluj);
            this.Controls.Add(this.btn_Usun);
            this.Controls.Add(this.btn_Edytuj);
            this.Controls.Add(this.btn_Dodaj);
            this.Controls.Add(this.mPanel);
            this.Controls.Add(this.mGrid_Pozycje);
            this.Controls.Add(this.mGrid_Naglowki);
            this.Name = "Dokumenty";
            this.Text = "Dokumenty";
            this.Load += new System.EventHandler(this.Dokumenty_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mGrid_Naglowki)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.naglowekBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dokumentyDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mGrid_Pozycje)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pozycjaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.baza)).EndInit();
            this.mPanel.ResumeLayout(false);
            this.mPanel.PerformLayout();
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroGrid mGrid_Naglowki;
        private MetroFramework.Controls.MetroGrid mGrid_Pozycje;
        private MetroFramework.Controls.MetroPanel mPanel;
        private MetroFramework.Controls.MetroLabel mLab_NumerKlienta;
        private MetroFramework.Controls.MetroLabel mLab_Data;
        private MetroFramework.Controls.MetroLabel mLab_Nazwa;
        private MetroFramework.Controls.MetroTextBox txt_Nazwa;
        private MetroFramework.Controls.MetroButton btn_Dodaj;
        private MetroFramework.Controls.MetroButton btn_Edytuj;
        private MetroFramework.Controls.MetroButton btn_Usun;
        private MetroFramework.Controls.MetroButton btn_Anuluj;
        private MetroFramework.Controls.MetroButton btn_Zapisz;
        private DokumentyDataSet dokumentyDataSet;
        private System.Windows.Forms.BindingSource naglowekBindingSource;
        private DokumentyDataSetTableAdapters.NaglowekTableAdapter naglowekTableAdapter;
        private System.Windows.Forms.DateTimePicker dateTime;
        private MetroFramework.Controls.MetroTextBox txt_NumerKlienta;
        private System.Windows.Forms.DataGridViewTextBoxColumn nagIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nagDataDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nagNumerKlientaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nagNazwaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nagCenaNettoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nagCenaBruttoDataGridViewTextBoxColumn;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private Baza baza;
        private System.Windows.Forms.BindingSource pozycjaBindingSource;
        private BazaTableAdapters.PozycjaTableAdapter pozycjaTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn pozIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pozNagIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pozNazwaArtykuluDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pozLiczbaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pozCenaNettoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pozCenaBruttoDataGridViewTextBoxColumn;
        private MetroFramework.Controls.MetroButton btn_ZapiszP;
        private MetroFramework.Controls.MetroButton btn_AnulujP;
        private MetroFramework.Controls.MetroButton btn_UsunP;
        private MetroFramework.Controls.MetroButton btn_EdytujP;
        private MetroFramework.Controls.MetroButton btn_DodajP;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroTextBox mTxt_CenaBruttoP;
        private MetroFramework.Controls.MetroTextBox mTxt_CenaNettoP;
        private MetroFramework.Controls.MetroTextBox mTxt_Liczba;
        private MetroFramework.Controls.MetroTextBox mTxt_NazwaArtykulu;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel mLab_NazwaNag;
        private MetroFramework.Controls.MetroComboBox mComBox_NazNag;
        private MetroFramework.Controls.MetroLabel labUser;
        private MetroFramework.Controls.MetroLabel lab_CreateDate;
        private MetroFramework.Controls.MetroLabel lab_URL;
    }
}

