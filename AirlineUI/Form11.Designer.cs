
namespace Airline
{
    partial class AdminPiloti
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
            System.Windows.Forms.Label id_aeronavaLabel;
            System.Windows.Forms.Label numeLabel;
            System.Windows.Forms.Label prenumeLabel;
            System.Windows.Forms.Label data_nastereLabel;
            System.Windows.Forms.Label cNPLabel;
            System.Windows.Forms.Label data_angajareLabel;
            System.Windows.Forms.Label nr_telefonLabel;
            System.Windows.Forms.Label genLabel1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminPiloti));
            this.pilotBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.pilotBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.companieaerianaDataSet3 = new Airline.companieaerianaDataSet3();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.pilotBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.id_aeronavaTextBox = new System.Windows.Forms.TextBox();
            this.numeTextBox = new System.Windows.Forms.TextBox();
            this.prenumeTextBox = new System.Windows.Forms.TextBox();
            this.data_nastereDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.cNPTextBox = new System.Windows.Forms.TextBox();
            this.data_angajareDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.nr_telefonTextBox = new System.Windows.Forms.TextBox();
            this.pilotTableAdapter = new Airline.companieaerianaDataSet3TableAdapters.PilotTableAdapter();
            this.tableAdapterManager = new Airline.companieaerianaDataSet3TableAdapters.TableAdapterManager();
            this.pilotDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.genComboBox = new System.Windows.Forms.ComboBox();
            id_aeronavaLabel = new System.Windows.Forms.Label();
            numeLabel = new System.Windows.Forms.Label();
            prenumeLabel = new System.Windows.Forms.Label();
            data_nastereLabel = new System.Windows.Forms.Label();
            cNPLabel = new System.Windows.Forms.Label();
            data_angajareLabel = new System.Windows.Forms.Label();
            nr_telefonLabel = new System.Windows.Forms.Label();
            genLabel1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pilotBindingNavigator)).BeginInit();
            this.pilotBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pilotBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.companieaerianaDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pilotDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // id_aeronavaLabel
            // 
            id_aeronavaLabel.AutoSize = true;
            id_aeronavaLabel.Location = new System.Drawing.Point(70, 70);
            id_aeronavaLabel.Name = "id_aeronavaLabel";
            id_aeronavaLabel.Size = new System.Drawing.Size(67, 13);
            id_aeronavaLabel.TabIndex = 3;
            id_aeronavaLabel.Text = "Id aeronava:";
            // 
            // numeLabel
            // 
            numeLabel.AutoSize = true;
            numeLabel.Location = new System.Drawing.Point(70, 96);
            numeLabel.Name = "numeLabel";
            numeLabel.Size = new System.Drawing.Size(38, 13);
            numeLabel.TabIndex = 5;
            numeLabel.Text = "Nume:";
            // 
            // prenumeLabel
            // 
            prenumeLabel.AutoSize = true;
            prenumeLabel.Location = new System.Drawing.Point(70, 122);
            prenumeLabel.Name = "prenumeLabel";
            prenumeLabel.Size = new System.Drawing.Size(52, 13);
            prenumeLabel.TabIndex = 7;
            prenumeLabel.Text = "Prenume:";
            // 
            // data_nastereLabel
            // 
            data_nastereLabel.AutoSize = true;
            data_nastereLabel.Location = new System.Drawing.Point(431, 67);
            data_nastereLabel.Name = "data_nastereLabel";
            data_nastereLabel.Size = new System.Drawing.Size(71, 13);
            data_nastereLabel.TabIndex = 11;
            data_nastereLabel.Text = "Data nastere:";
            // 
            // cNPLabel
            // 
            cNPLabel.AutoSize = true;
            cNPLabel.Location = new System.Drawing.Point(431, 92);
            cNPLabel.Name = "cNPLabel";
            cNPLabel.Size = new System.Drawing.Size(32, 13);
            cNPLabel.TabIndex = 13;
            cNPLabel.Text = "CNP:";
            // 
            // data_angajareLabel
            // 
            data_angajareLabel.AutoSize = true;
            data_angajareLabel.Location = new System.Drawing.Point(431, 119);
            data_angajareLabel.Name = "data_angajareLabel";
            data_angajareLabel.Size = new System.Drawing.Size(77, 13);
            data_angajareLabel.TabIndex = 15;
            data_angajareLabel.Text = "Data angajare:";
            // 
            // nr_telefonLabel
            // 
            nr_telefonLabel.AutoSize = true;
            nr_telefonLabel.Location = new System.Drawing.Point(431, 144);
            nr_telefonLabel.Name = "nr_telefonLabel";
            nr_telefonLabel.Size = new System.Drawing.Size(56, 13);
            nr_telefonLabel.TabIndex = 17;
            nr_telefonLabel.Text = "Nr telefon:";
            // 
            // genLabel1
            // 
            genLabel1.AutoSize = true;
            genLabel1.Location = new System.Drawing.Point(70, 157);
            genLabel1.Name = "genLabel1";
            genLabel1.Size = new System.Drawing.Size(30, 13);
            genLabel1.TabIndex = 22;
            genLabel1.Text = "Gen:";
            genLabel1.Click += new System.EventHandler(this.genLabel1_Click);
            // 
            // pilotBindingNavigator
            // 
            this.pilotBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.pilotBindingNavigator.BindingSource = this.pilotBindingSource;
            this.pilotBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.pilotBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.pilotBindingNavigator.Dock = System.Windows.Forms.DockStyle.None;
            this.pilotBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.pilotBindingNavigatorSaveItem});
            this.pilotBindingNavigator.Location = new System.Drawing.Point(109, 20);
            this.pilotBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.pilotBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.pilotBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.pilotBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.pilotBindingNavigator.Name = "pilotBindingNavigator";
            this.pilotBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.pilotBindingNavigator.Size = new System.Drawing.Size(278, 25);
            this.pilotBindingNavigator.TabIndex = 0;
            this.pilotBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // pilotBindingSource
            // 
            this.pilotBindingSource.DataMember = "Pilot";
            this.pilotBindingSource.DataSource = this.companieaerianaDataSet3;
            // 
            // companieaerianaDataSet3
            // 
            this.companieaerianaDataSet3.DataSetName = "companieaerianaDataSet3";
            this.companieaerianaDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // pilotBindingNavigatorSaveItem
            // 
            this.pilotBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.pilotBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("pilotBindingNavigatorSaveItem.Image")));
            this.pilotBindingNavigatorSaveItem.Name = "pilotBindingNavigatorSaveItem";
            this.pilotBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.pilotBindingNavigatorSaveItem.Text = "Save Data";
            this.pilotBindingNavigatorSaveItem.Click += new System.EventHandler(this.pilotBindingNavigatorSaveItem_Click);
            // 
            // id_aeronavaTextBox
            // 
            this.id_aeronavaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pilotBindingSource, "Id_aeronava", true));
            this.id_aeronavaTextBox.Location = new System.Drawing.Point(153, 67);
            this.id_aeronavaTextBox.Name = "id_aeronavaTextBox";
            this.id_aeronavaTextBox.Size = new System.Drawing.Size(200, 20);
            this.id_aeronavaTextBox.TabIndex = 4;
            // 
            // numeTextBox
            // 
            this.numeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pilotBindingSource, "Nume", true));
            this.numeTextBox.Location = new System.Drawing.Point(153, 93);
            this.numeTextBox.Name = "numeTextBox";
            this.numeTextBox.Size = new System.Drawing.Size(200, 20);
            this.numeTextBox.TabIndex = 6;
            // 
            // prenumeTextBox
            // 
            this.prenumeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pilotBindingSource, "Prenume", true));
            this.prenumeTextBox.Location = new System.Drawing.Point(153, 119);
            this.prenumeTextBox.Name = "prenumeTextBox";
            this.prenumeTextBox.Size = new System.Drawing.Size(200, 20);
            this.prenumeTextBox.TabIndex = 8;
            // 
            // data_nastereDateTimePicker
            // 
            this.data_nastereDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.pilotBindingSource, "Data_nastere", true));
            this.data_nastereDateTimePicker.Location = new System.Drawing.Point(514, 63);
            this.data_nastereDateTimePicker.MaxDate = new System.DateTime(2000, 12, 31, 0, 0, 0, 0);
            this.data_nastereDateTimePicker.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.data_nastereDateTimePicker.Name = "data_nastereDateTimePicker";
            this.data_nastereDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.data_nastereDateTimePicker.TabIndex = 12;
            this.data_nastereDateTimePicker.Value = new System.DateTime(2000, 12, 31, 0, 0, 0, 0);
            // 
            // cNPTextBox
            // 
            this.cNPTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pilotBindingSource, "CNP", true));
            this.cNPTextBox.Location = new System.Drawing.Point(514, 89);
            this.cNPTextBox.Name = "cNPTextBox";
            this.cNPTextBox.Size = new System.Drawing.Size(200, 20);
            this.cNPTextBox.TabIndex = 14;
            // 
            // data_angajareDateTimePicker
            // 
            this.data_angajareDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.pilotBindingSource, "Data_angajare", true));
            this.data_angajareDateTimePicker.Location = new System.Drawing.Point(514, 115);
            this.data_angajareDateTimePicker.MaxDate = new System.DateTime(2021, 1, 4, 0, 0, 0, 0);
            this.data_angajareDateTimePicker.MinDate = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            this.data_angajareDateTimePicker.Name = "data_angajareDateTimePicker";
            this.data_angajareDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.data_angajareDateTimePicker.TabIndex = 16;
            this.data_angajareDateTimePicker.Value = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            // 
            // nr_telefonTextBox
            // 
            this.nr_telefonTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pilotBindingSource, "Nr_telefon", true));
            this.nr_telefonTextBox.Location = new System.Drawing.Point(514, 141);
            this.nr_telefonTextBox.Name = "nr_telefonTextBox";
            this.nr_telefonTextBox.Size = new System.Drawing.Size(200, 20);
            this.nr_telefonTextBox.TabIndex = 18;
            // 
            // pilotTableAdapter
            // 
            this.pilotTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.PilotTableAdapter = this.pilotTableAdapter;
            this.tableAdapterManager.UpdateOrder = Airline.companieaerianaDataSet3TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // pilotDataGridView
            // 
            this.pilotDataGridView.AutoGenerateColumns = false;
            this.pilotDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pilotDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9});
            this.pilotDataGridView.DataSource = this.pilotBindingSource;
            this.pilotDataGridView.Location = new System.Drawing.Point(36, 275);
            this.pilotDataGridView.Name = "pilotDataGridView";
            this.pilotDataGridView.Size = new System.Drawing.Size(955, 177);
            this.pilotDataGridView.TabIndex = 18;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id_pilot";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id_pilot";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Id_aeronava";
            this.dataGridViewTextBoxColumn2.HeaderText = "Id_aeronava";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Nume";
            this.dataGridViewTextBoxColumn3.HeaderText = "Nume";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Prenume";
            this.dataGridViewTextBoxColumn4.HeaderText = "Prenume";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Gen";
            this.dataGridViewTextBoxColumn5.HeaderText = "Gen";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Data_nastere";
            this.dataGridViewTextBoxColumn6.HeaderText = "Data_nastere";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "CNP";
            this.dataGridViewTextBoxColumn7.HeaderText = "CNP";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Data_angajare";
            this.dataGridViewTextBoxColumn8.HeaderText = "Data_angajare";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Nr_telefon";
            this.dataGridViewTextBoxColumn9.HeaderText = "Nr_telefon";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(200, 236);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 19;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(538, 236);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 20;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(584, 205);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "Mod:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(223, 205);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Sortare dupa:";
            // 
            // genComboBox
            // 
            this.genComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pilotBindingSource, "Gen", true));
            this.genComboBox.FormattingEnabled = true;
            this.genComboBox.Items.AddRange(new object[] {
            "F",
            "M"});
            this.genComboBox.Location = new System.Drawing.Point(153, 154);
            this.genComboBox.Name = "genComboBox";
            this.genComboBox.Size = new System.Drawing.Size(71, 21);
            this.genComboBox.TabIndex = 23;
            // 
            // AdminPiloti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1018, 476);
            this.Controls.Add(genLabel1);
            this.Controls.Add(this.genComboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.pilotDataGridView);
            this.Controls.Add(id_aeronavaLabel);
            this.Controls.Add(this.id_aeronavaTextBox);
            this.Controls.Add(numeLabel);
            this.Controls.Add(this.numeTextBox);
            this.Controls.Add(prenumeLabel);
            this.Controls.Add(this.prenumeTextBox);
            this.Controls.Add(data_nastereLabel);
            this.Controls.Add(this.data_nastereDateTimePicker);
            this.Controls.Add(cNPLabel);
            this.Controls.Add(this.cNPTextBox);
            this.Controls.Add(data_angajareLabel);
            this.Controls.Add(this.data_angajareDateTimePicker);
            this.Controls.Add(nr_telefonLabel);
            this.Controls.Add(this.nr_telefonTextBox);
            this.Controls.Add(this.pilotBindingNavigator);
            this.Name = "AdminPiloti";
            this.Text = "Administrare - piloti";
            this.Load += new System.EventHandler(this.AdminPiloti_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pilotBindingNavigator)).EndInit();
            this.pilotBindingNavigator.ResumeLayout(false);
            this.pilotBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pilotBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.companieaerianaDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pilotDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private companieaerianaDataSet3 companieaerianaDataSet3;
        private System.Windows.Forms.BindingSource pilotBindingSource;
        private companieaerianaDataSet3TableAdapters.PilotTableAdapter pilotTableAdapter;
        private companieaerianaDataSet3TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator pilotBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton pilotBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox id_aeronavaTextBox;
        private System.Windows.Forms.TextBox numeTextBox;
        private System.Windows.Forms.TextBox prenumeTextBox;
        private System.Windows.Forms.DateTimePicker data_nastereDateTimePicker;
        private System.Windows.Forms.TextBox cNPTextBox;
        private System.Windows.Forms.DateTimePicker data_angajareDateTimePicker;
        private System.Windows.Forms.TextBox nr_telefonTextBox;
        private System.Windows.Forms.DataGridView pilotDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox genComboBox;
    }
}