﻿namespace hellenicair2
{
    partial class Form25
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
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
            System.Windows.Forms.Label flightIDLabel;
            System.Windows.Forms.Label lastNameLabel;
            System.Windows.Forms.Label firstNameLabel;
            System.Windows.Forms.Label economyClassLabel;
            System.Windows.Forms.Label businessClassLabel;
            System.Windows.Forms.Label adultsLabel;
            System.Windows.Forms.Label childrenLabel;
            System.Windows.Forms.Label infantsLabel;
            System.Windows.Forms.Label telephoneLabel;
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label countryLabel;
            System.Windows.Forms.Label addressLabel;
            System.Windows.Forms.Label roundTripLabel;
            System.Windows.Forms.Label oneWayLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form25));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.conmanageDataSet = new hellenicair2.conmanageDataSet();
            this.conmanageBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.conmanageTableAdapter = new hellenicair2.conmanageDataSetTableAdapters.conmanageTableAdapter();
            this.tableAdapterManager = new hellenicair2.conmanageDataSetTableAdapters.TableAdapterManager();
            this.flightIDTextBox = new System.Windows.Forms.TextBox();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.economyClassCheckBox = new System.Windows.Forms.CheckBox();
            this.businessClassCheckBox = new System.Windows.Forms.CheckBox();
            this.adultsTextBox = new System.Windows.Forms.TextBox();
            this.childrenTextBox = new System.Windows.Forms.TextBox();
            this.infantsTextBox = new System.Windows.Forms.TextBox();
            this.telephoneTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.countryTextBox = new System.Windows.Forms.TextBox();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.roundTripCheckBox = new System.Windows.Forms.CheckBox();
            this.oneWayCheckBox = new System.Windows.Forms.CheckBox();
            this.conmanageDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewCheckBoxColumn2 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn3 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewCheckBoxColumn4 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            flightIDLabel = new System.Windows.Forms.Label();
            lastNameLabel = new System.Windows.Forms.Label();
            firstNameLabel = new System.Windows.Forms.Label();
            economyClassLabel = new System.Windows.Forms.Label();
            businessClassLabel = new System.Windows.Forms.Label();
            adultsLabel = new System.Windows.Forms.Label();
            childrenLabel = new System.Windows.Forms.Label();
            infantsLabel = new System.Windows.Forms.Label();
            telephoneLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            countryLabel = new System.Windows.Forms.Label();
            addressLabel = new System.Windows.Forms.Label();
            roundTripLabel = new System.Windows.Forms.Label();
            oneWayLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.conmanageDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.conmanageBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.conmanageDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // flightIDLabel
            // 
            flightIDLabel.AutoSize = true;
            flightIDLabel.Location = new System.Drawing.Point(38, 192);
            flightIDLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            flightIDLabel.Name = "flightIDLabel";
            flightIDLabel.Size = new System.Drawing.Size(68, 13);
            flightIDLabel.TabIndex = 43;
            flightIDLabel.Text = "Vol de Code:";
            // 
            // lastNameLabel
            // 
            lastNameLabel.AutoSize = true;
            lastNameLabel.Location = new System.Drawing.Point(38, 214);
            lastNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new System.Drawing.Size(32, 13);
            lastNameLabel.TabIndex = 45;
            lastNameLabel.Text = "Nom:";
            // 
            // firstNameLabel
            // 
            firstNameLabel.AutoSize = true;
            firstNameLabel.Location = new System.Drawing.Point(38, 237);
            firstNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            firstNameLabel.Name = "firstNameLabel";
            firstNameLabel.Size = new System.Drawing.Size(70, 13);
            firstNameLabel.TabIndex = 47;
            firstNameLabel.Text = "Nom Original:";
            // 
            // economyClassLabel
            // 
            economyClassLabel.AutoSize = true;
            economyClassLabel.Location = new System.Drawing.Point(38, 262);
            economyClassLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            economyClassLabel.Name = "economyClassLabel";
            economyClassLabel.Size = new System.Drawing.Size(99, 13);
            economyClassLabel.TabIndex = 49;
            economyClassLabel.Text = "Position Financière:";
            // 
            // businessClassLabel
            // 
            businessClassLabel.AutoSize = true;
            businessClassLabel.Location = new System.Drawing.Point(38, 286);
            businessClassLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            businessClassLabel.Name = "businessClassLabel";
            businessClassLabel.Size = new System.Drawing.Size(96, 13);
            businessClassLabel.TabIndex = 51;
            businessClassLabel.Text = "Position Distinctes:";
            // 
            // adultsLabel
            // 
            adultsLabel.AutoSize = true;
            adultsLabel.Location = new System.Drawing.Point(38, 309);
            adultsLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            adultsLabel.Name = "adultsLabel";
            adultsLabel.Size = new System.Drawing.Size(45, 13);
            adultsLabel.TabIndex = 53;
            adultsLabel.Text = "Adultes:";
            // 
            // childrenLabel
            // 
            childrenLabel.AutoSize = true;
            childrenLabel.Location = new System.Drawing.Point(38, 332);
            childrenLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            childrenLabel.Name = "childrenLabel";
            childrenLabel.Size = new System.Drawing.Size(47, 13);
            childrenLabel.TabIndex = 55;
            childrenLabel.Text = "Mineurs:";
            // 
            // infantsLabel
            // 
            infantsLabel.AutoSize = true;
            infantsLabel.Location = new System.Drawing.Point(38, 354);
            infantsLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            infantsLabel.Name = "infantsLabel";
            infantsLabel.Size = new System.Drawing.Size(65, 13);
            infantsLabel.TabIndex = 57;
            infantsLabel.Text = "Nourrissons:";
            // 
            // telephoneLabel
            // 
            telephoneLabel.AutoSize = true;
            telephoneLabel.Location = new System.Drawing.Point(38, 377);
            telephoneLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            telephoneLabel.Name = "telephoneLabel";
            telephoneLabel.Size = new System.Drawing.Size(61, 13);
            telephoneLabel.TabIndex = 59;
            telephoneLabel.Text = "Téléphone:";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new System.Drawing.Point(38, 400);
            emailLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(35, 13);
            emailLabel.TabIndex = 61;
            emailLabel.Text = "Email:";
            // 
            // countryLabel
            // 
            countryLabel.AutoSize = true;
            countryLabel.Location = new System.Drawing.Point(38, 422);
            countryLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            countryLabel.Name = "countryLabel";
            countryLabel.Size = new System.Drawing.Size(33, 13);
            countryLabel.TabIndex = 63;
            countryLabel.Text = "Pays:";
            // 
            // addressLabel
            // 
            addressLabel.AutoSize = true;
            addressLabel.Location = new System.Drawing.Point(38, 445);
            addressLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            addressLabel.Name = "addressLabel";
            addressLabel.Size = new System.Drawing.Size(48, 13);
            addressLabel.TabIndex = 65;
            addressLabel.Text = "Adresse:";
            // 
            // roundTripLabel
            // 
            roundTripLabel.AutoSize = true;
            roundTripLabel.Location = new System.Drawing.Point(38, 470);
            roundTripLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            roundTripLabel.Name = "roundTripLabel";
            roundTripLabel.Size = new System.Drawing.Size(65, 13);
            roundTripLabel.TabIndex = 67;
            roundTripLabel.Text = "Aller-Retour:";
            // 
            // oneWayLabel
            // 
            oneWayLabel.AutoSize = true;
            oneWayLabel.Location = new System.Drawing.Point(38, 494);
            oneWayLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            oneWayLabel.Name = "oneWayLabel";
            oneWayLabel.Size = new System.Drawing.Size(65, 13);
            oneWayLabel.TabIndex = 69;
            oneWayLabel.Text = "Non-Retour:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-1, 1);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(212, 126);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(201, 110);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(548, 17);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 40;
            this.pictureBox3.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label3.Location = new System.Drawing.Point(370, 44);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(215, 19);
            this.label3.TabIndex = 41;
            this.label3.Text = "Gestion des Réservations";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label2.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label2.Location = new System.Drawing.Point(362, 154);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(246, 18);
            this.label2.TabIndex = 42;
            this.label2.Text = "Liste des Utilisateurs qui ont Réservé";
            // 
            // conmanageDataSet
            // 
            this.conmanageDataSet.DataSetName = "conmanageDataSet";
            this.conmanageDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // conmanageBindingSource
            // 
            this.conmanageBindingSource.DataMember = "conmanage";
            this.conmanageBindingSource.DataSource = this.conmanageDataSet;
            // 
            // conmanageTableAdapter
            // 
            this.conmanageTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.conmanageTableAdapter = this.conmanageTableAdapter;
            this.tableAdapterManager.UpdateOrder = hellenicair2.conmanageDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // flightIDTextBox
            // 
            this.flightIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.conmanageBindingSource, "FlightID", true));
            this.flightIDTextBox.Location = new System.Drawing.Point(124, 189);
            this.flightIDTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.flightIDTextBox.Name = "flightIDTextBox";
            this.flightIDTextBox.Size = new System.Drawing.Size(79, 20);
            this.flightIDTextBox.TabIndex = 44;
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.conmanageBindingSource, "LastName", true));
            this.lastNameTextBox.Location = new System.Drawing.Point(124, 212);
            this.lastNameTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(79, 20);
            this.lastNameTextBox.TabIndex = 46;
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.conmanageBindingSource, "FirstName", true));
            this.firstNameTextBox.Location = new System.Drawing.Point(124, 235);
            this.firstNameTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(79, 20);
            this.firstNameTextBox.TabIndex = 48;
            // 
            // economyClassCheckBox
            // 
            this.economyClassCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.conmanageBindingSource, "EconomyClass", true));
            this.economyClassCheckBox.Location = new System.Drawing.Point(142, 259);
            this.economyClassCheckBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.economyClassCheckBox.Name = "economyClassCheckBox";
            this.economyClassCheckBox.Size = new System.Drawing.Size(78, 20);
            this.economyClassCheckBox.TabIndex = 50;
            this.economyClassCheckBox.UseVisualStyleBackColor = true;
            // 
            // businessClassCheckBox
            // 
            this.businessClassCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.conmanageBindingSource, "BusinessClass", true));
            this.businessClassCheckBox.Location = new System.Drawing.Point(142, 284);
            this.businessClassCheckBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.businessClassCheckBox.Name = "businessClassCheckBox";
            this.businessClassCheckBox.Size = new System.Drawing.Size(78, 20);
            this.businessClassCheckBox.TabIndex = 52;
            this.businessClassCheckBox.UseVisualStyleBackColor = true;
            // 
            // adultsTextBox
            // 
            this.adultsTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.conmanageBindingSource, "Adults", true));
            this.adultsTextBox.Location = new System.Drawing.Point(124, 306);
            this.adultsTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.adultsTextBox.Name = "adultsTextBox";
            this.adultsTextBox.Size = new System.Drawing.Size(79, 20);
            this.adultsTextBox.TabIndex = 54;
            // 
            // childrenTextBox
            // 
            this.childrenTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.conmanageBindingSource, "Children", true));
            this.childrenTextBox.Location = new System.Drawing.Point(124, 329);
            this.childrenTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.childrenTextBox.Name = "childrenTextBox";
            this.childrenTextBox.Size = new System.Drawing.Size(79, 20);
            this.childrenTextBox.TabIndex = 56;
            // 
            // infantsTextBox
            // 
            this.infantsTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.conmanageBindingSource, "Infants", true));
            this.infantsTextBox.Location = new System.Drawing.Point(124, 352);
            this.infantsTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.infantsTextBox.Name = "infantsTextBox";
            this.infantsTextBox.Size = new System.Drawing.Size(79, 20);
            this.infantsTextBox.TabIndex = 58;
            // 
            // telephoneTextBox
            // 
            this.telephoneTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.conmanageBindingSource, "Telephone", true));
            this.telephoneTextBox.Location = new System.Drawing.Point(124, 375);
            this.telephoneTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.telephoneTextBox.Name = "telephoneTextBox";
            this.telephoneTextBox.Size = new System.Drawing.Size(79, 20);
            this.telephoneTextBox.TabIndex = 60;
            // 
            // emailTextBox
            // 
            this.emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.conmanageBindingSource, "Email", true));
            this.emailTextBox.Location = new System.Drawing.Point(124, 397);
            this.emailTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(79, 20);
            this.emailTextBox.TabIndex = 62;
            // 
            // countryTextBox
            // 
            this.countryTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.conmanageBindingSource, "Country", true));
            this.countryTextBox.Location = new System.Drawing.Point(124, 420);
            this.countryTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.countryTextBox.Name = "countryTextBox";
            this.countryTextBox.Size = new System.Drawing.Size(79, 20);
            this.countryTextBox.TabIndex = 64;
            // 
            // addressTextBox
            // 
            this.addressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.conmanageBindingSource, "Address", true));
            this.addressTextBox.Location = new System.Drawing.Point(124, 443);
            this.addressTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(79, 20);
            this.addressTextBox.TabIndex = 66;
            // 
            // roundTripCheckBox
            // 
            this.roundTripCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.conmanageBindingSource, "RoundTrip", true));
            this.roundTripCheckBox.Location = new System.Drawing.Point(142, 466);
            this.roundTripCheckBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.roundTripCheckBox.Name = "roundTripCheckBox";
            this.roundTripCheckBox.Size = new System.Drawing.Size(78, 20);
            this.roundTripCheckBox.TabIndex = 68;
            this.roundTripCheckBox.UseVisualStyleBackColor = true;
            // 
            // oneWayCheckBox
            // 
            this.oneWayCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.conmanageBindingSource, "OneWay", true));
            this.oneWayCheckBox.Location = new System.Drawing.Point(142, 492);
            this.oneWayCheckBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.oneWayCheckBox.Name = "oneWayCheckBox";
            this.oneWayCheckBox.Size = new System.Drawing.Size(78, 20);
            this.oneWayCheckBox.TabIndex = 70;
            this.oneWayCheckBox.UseVisualStyleBackColor = true;
            // 
            // conmanageDataGridView
            // 
            this.conmanageDataGridView.AutoGenerateColumns = false;
            this.conmanageDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.conmanageDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewCheckBoxColumn1,
            this.dataGridViewCheckBoxColumn2,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewCheckBoxColumn3,
            this.dataGridViewCheckBoxColumn4});
            this.conmanageDataGridView.DataSource = this.conmanageBindingSource;
            this.conmanageDataGridView.Location = new System.Drawing.Point(242, 189);
            this.conmanageDataGridView.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.conmanageDataGridView.Name = "conmanageDataGridView";
            this.conmanageDataGridView.RowTemplate.Height = 24;
            this.conmanageDataGridView.Size = new System.Drawing.Size(484, 179);
            this.conmanageDataGridView.TabIndex = 70;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "FlightID";
            this.dataGridViewTextBoxColumn1.HeaderText = "Vol de Code";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 120;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "LastName";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nom";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "FirstName";
            this.dataGridViewTextBoxColumn3.HeaderText = "Nom Original";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 130;
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "EconomyClass";
            this.dataGridViewCheckBoxColumn1.HeaderText = "Position Financière";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            this.dataGridViewCheckBoxColumn1.Width = 140;
            // 
            // dataGridViewCheckBoxColumn2
            // 
            this.dataGridViewCheckBoxColumn2.DataPropertyName = "BusinessClass";
            this.dataGridViewCheckBoxColumn2.HeaderText = "Position Distinctes";
            this.dataGridViewCheckBoxColumn2.Name = "dataGridViewCheckBoxColumn2";
            this.dataGridViewCheckBoxColumn2.Width = 140;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Adults";
            this.dataGridViewTextBoxColumn4.HeaderText = "Adultes";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Children";
            this.dataGridViewTextBoxColumn5.HeaderText = "Mineurs";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Infants";
            this.dataGridViewTextBoxColumn6.HeaderText = "Nourrissons";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Telephone";
            this.dataGridViewTextBoxColumn7.HeaderText = "Téléphone";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Email";
            this.dataGridViewTextBoxColumn8.HeaderText = "Email";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Country";
            this.dataGridViewTextBoxColumn9.HeaderText = "Pays";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Address";
            this.dataGridViewTextBoxColumn10.HeaderText = "Adresse";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // dataGridViewCheckBoxColumn3
            // 
            this.dataGridViewCheckBoxColumn3.DataPropertyName = "RoundTrip";
            this.dataGridViewCheckBoxColumn3.HeaderText = "Aller-Retour";
            this.dataGridViewCheckBoxColumn3.Name = "dataGridViewCheckBoxColumn3";
            // 
            // dataGridViewCheckBoxColumn4
            // 
            this.dataGridViewCheckBoxColumn4.DataPropertyName = "OneWay";
            this.dataGridViewCheckBoxColumn4.HeaderText = "Non-Retour";
            this.dataGridViewCheckBoxColumn4.Name = "dataGridViewCheckBoxColumn4";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(242, 373);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 24);
            this.button1.TabIndex = 73;
            this.button1.Text = "Ajouter";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(340, 373);
            this.button2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(84, 24);
            this.button2.TabIndex = 74;
            this.button2.Text = "Stockage";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(533, 375);
            this.button3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(94, 24);
            this.button3.TabIndex = 75;
            this.button3.Text = "Précédente";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(632, 375);
            this.button4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(94, 24);
            this.button4.TabIndex = 76;
            this.button4.Text = "Continuer";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Form25
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 531);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.conmanageDataGridView);
            this.Controls.Add(flightIDLabel);
            this.Controls.Add(this.flightIDTextBox);
            this.Controls.Add(lastNameLabel);
            this.Controls.Add(this.lastNameTextBox);
            this.Controls.Add(firstNameLabel);
            this.Controls.Add(this.firstNameTextBox);
            this.Controls.Add(economyClassLabel);
            this.Controls.Add(this.economyClassCheckBox);
            this.Controls.Add(businessClassLabel);
            this.Controls.Add(this.businessClassCheckBox);
            this.Controls.Add(adultsLabel);
            this.Controls.Add(this.adultsTextBox);
            this.Controls.Add(childrenLabel);
            this.Controls.Add(this.childrenTextBox);
            this.Controls.Add(infantsLabel);
            this.Controls.Add(this.infantsTextBox);
            this.Controls.Add(telephoneLabel);
            this.Controls.Add(this.telephoneTextBox);
            this.Controls.Add(emailLabel);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(countryLabel);
            this.Controls.Add(this.countryTextBox);
            this.Controls.Add(addressLabel);
            this.Controls.Add(this.addressTextBox);
            this.Controls.Add(roundTripLabel);
            this.Controls.Add(this.roundTripCheckBox);
            this.Controls.Add(oneWayLabel);
            this.Controls.Add(this.oneWayCheckBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form25";
            this.Padding = new System.Windows.Forms.Padding(9, 9, 9, 9);
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AERObook";
            this.Load += new System.EventHandler(this.Form25_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.conmanageDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.conmanageBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.conmanageDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private conmanageDataSet conmanageDataSet;
        private System.Windows.Forms.BindingSource conmanageBindingSource;
        private conmanageDataSetTableAdapters.conmanageTableAdapter conmanageTableAdapter;
        private conmanageDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox flightIDTextBox;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.CheckBox economyClassCheckBox;
        private System.Windows.Forms.CheckBox businessClassCheckBox;
        private System.Windows.Forms.TextBox adultsTextBox;
        private System.Windows.Forms.TextBox childrenTextBox;
        private System.Windows.Forms.TextBox infantsTextBox;
        private System.Windows.Forms.TextBox telephoneTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox countryTextBox;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.CheckBox roundTripCheckBox;
        private System.Windows.Forms.CheckBox oneWayCheckBox;
        private System.Windows.Forms.DataGridView conmanageDataGridView;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn3;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn4;

    }
}
