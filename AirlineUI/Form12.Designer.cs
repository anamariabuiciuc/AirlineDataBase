
namespace Airline
{
    partial class AdminAeroport
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
            System.Windows.Forms.Label cod_aeroportLabel;
            System.Windows.Forms.Label nume_aeroportLabel;
            System.Windows.Forms.Label taraLabel;
            System.Windows.Forms.Label regiuneLabel;
            System.Windows.Forms.Label localitateLabel;
            System.Windows.Forms.Label stradaLabel;
            System.Windows.Forms.Label nrLabel;
            System.Windows.Forms.Label nr_telefonLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminAeroport));
            this.companieaerianaDataSet4 = new Airline.companieaerianaDataSet4();
            this.aeroportBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aeroportTableAdapter = new Airline.companieaerianaDataSet4TableAdapters.AeroportTableAdapter();
            this.tableAdapterManager = new Airline.companieaerianaDataSet4TableAdapters.TableAdapterManager();
            this.aeroportBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
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
            this.aeroportBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.cod_aeroportTextBox = new System.Windows.Forms.TextBox();
            this.nume_aeroportTextBox = new System.Windows.Forms.TextBox();
            this.taraTextBox = new System.Windows.Forms.TextBox();
            this.regiuneTextBox = new System.Windows.Forms.TextBox();
            this.localitateTextBox = new System.Windows.Forms.TextBox();
            this.stradaTextBox = new System.Windows.Forms.TextBox();
            this.nrTextBox = new System.Windows.Forms.TextBox();
            this.nr_telefonTextBox = new System.Windows.Forms.TextBox();
            this.aeroportDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            cod_aeroportLabel = new System.Windows.Forms.Label();
            nume_aeroportLabel = new System.Windows.Forms.Label();
            taraLabel = new System.Windows.Forms.Label();
            regiuneLabel = new System.Windows.Forms.Label();
            localitateLabel = new System.Windows.Forms.Label();
            stradaLabel = new System.Windows.Forms.Label();
            nrLabel = new System.Windows.Forms.Label();
            nr_telefonLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.companieaerianaDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aeroportBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aeroportBindingNavigator)).BeginInit();
            this.aeroportBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.aeroportDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // cod_aeroportLabel
            // 
            cod_aeroportLabel.AutoSize = true;
            cod_aeroportLabel.Location = new System.Drawing.Point(466, 80);
            cod_aeroportLabel.Name = "cod_aeroportLabel";
            cod_aeroportLabel.Size = new System.Drawing.Size(71, 13);
            cod_aeroportLabel.TabIndex = 1;
            cod_aeroportLabel.Text = "Cod aeroport:";
            // 
            // nume_aeroportLabel
            // 
            nume_aeroportLabel.AutoSize = true;
            nume_aeroportLabel.Location = new System.Drawing.Point(466, 106);
            nume_aeroportLabel.Name = "nume_aeroportLabel";
            nume_aeroportLabel.Size = new System.Drawing.Size(80, 13);
            nume_aeroportLabel.TabIndex = 3;
            nume_aeroportLabel.Text = "Nume aeroport:";
            // 
            // taraLabel
            // 
            taraLabel.AutoSize = true;
            taraLabel.Location = new System.Drawing.Point(466, 132);
            taraLabel.Name = "taraLabel";
            taraLabel.Size = new System.Drawing.Size(32, 13);
            taraLabel.TabIndex = 5;
            taraLabel.Text = "Tara:";
            // 
            // regiuneLabel
            // 
            regiuneLabel.AutoSize = true;
            regiuneLabel.Location = new System.Drawing.Point(466, 158);
            regiuneLabel.Name = "regiuneLabel";
            regiuneLabel.Size = new System.Drawing.Size(50, 13);
            regiuneLabel.TabIndex = 7;
            regiuneLabel.Text = "Regiune:";
            // 
            // localitateLabel
            // 
            localitateLabel.AutoSize = true;
            localitateLabel.Location = new System.Drawing.Point(466, 184);
            localitateLabel.Name = "localitateLabel";
            localitateLabel.Size = new System.Drawing.Size(56, 13);
            localitateLabel.TabIndex = 9;
            localitateLabel.Text = "Localitate:";
            // 
            // stradaLabel
            // 
            stradaLabel.AutoSize = true;
            stradaLabel.Location = new System.Drawing.Point(466, 210);
            stradaLabel.Name = "stradaLabel";
            stradaLabel.Size = new System.Drawing.Size(41, 13);
            stradaLabel.TabIndex = 11;
            stradaLabel.Text = "Strada:";
            // 
            // nrLabel
            // 
            nrLabel.AutoSize = true;
            nrLabel.Location = new System.Drawing.Point(466, 236);
            nrLabel.Name = "nrLabel";
            nrLabel.Size = new System.Drawing.Size(21, 13);
            nrLabel.TabIndex = 13;
            nrLabel.Text = "Nr:";
            // 
            // nr_telefonLabel
            // 
            nr_telefonLabel.AutoSize = true;
            nr_telefonLabel.Location = new System.Drawing.Point(466, 262);
            nr_telefonLabel.Name = "nr_telefonLabel";
            nr_telefonLabel.Size = new System.Drawing.Size(56, 13);
            nr_telefonLabel.TabIndex = 15;
            nr_telefonLabel.Text = "Nr telefon:";
            // 
            // companieaerianaDataSet4
            // 
            this.companieaerianaDataSet4.DataSetName = "companieaerianaDataSet4";
            this.companieaerianaDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // aeroportBindingSource
            // 
            this.aeroportBindingSource.DataMember = "Aeroport";
            this.aeroportBindingSource.DataSource = this.companieaerianaDataSet4;
            // 
            // aeroportTableAdapter
            // 
            this.aeroportTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AeroportTableAdapter = this.aeroportTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = Airline.companieaerianaDataSet4TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // aeroportBindingNavigator
            // 
            this.aeroportBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.aeroportBindingNavigator.BindingSource = this.aeroportBindingSource;
            this.aeroportBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.aeroportBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.aeroportBindingNavigator.Dock = System.Windows.Forms.DockStyle.None;
            this.aeroportBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.aeroportBindingNavigatorSaveItem});
            this.aeroportBindingNavigator.Location = new System.Drawing.Point(416, 9);
            this.aeroportBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.aeroportBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.aeroportBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.aeroportBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.aeroportBindingNavigator.Name = "aeroportBindingNavigator";
            this.aeroportBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.aeroportBindingNavigator.Size = new System.Drawing.Size(278, 25);
            this.aeroportBindingNavigator.TabIndex = 0;
            this.aeroportBindingNavigator.Text = "bindingNavigator1";
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
            // aeroportBindingNavigatorSaveItem
            // 
            this.aeroportBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.aeroportBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("aeroportBindingNavigatorSaveItem.Image")));
            this.aeroportBindingNavigatorSaveItem.Name = "aeroportBindingNavigatorSaveItem";
            this.aeroportBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.aeroportBindingNavigatorSaveItem.Text = "Save Data";
            this.aeroportBindingNavigatorSaveItem.Click += new System.EventHandler(this.aeroportBindingNavigatorSaveItem_Click);
            // 
            // cod_aeroportTextBox
            // 
            this.cod_aeroportTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.aeroportBindingSource, "Cod_aeroport", true));
            this.cod_aeroportTextBox.Location = new System.Drawing.Point(552, 77);
            this.cod_aeroportTextBox.Name = "cod_aeroportTextBox";
            this.cod_aeroportTextBox.Size = new System.Drawing.Size(100, 20);
            this.cod_aeroportTextBox.TabIndex = 2;
            // 
            // nume_aeroportTextBox
            // 
            this.nume_aeroportTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.aeroportBindingSource, "Nume_aeroport", true));
            this.nume_aeroportTextBox.Location = new System.Drawing.Point(552, 103);
            this.nume_aeroportTextBox.Name = "nume_aeroportTextBox";
            this.nume_aeroportTextBox.Size = new System.Drawing.Size(100, 20);
            this.nume_aeroportTextBox.TabIndex = 4;
            // 
            // taraTextBox
            // 
            this.taraTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.aeroportBindingSource, "Tara", true));
            this.taraTextBox.Location = new System.Drawing.Point(552, 129);
            this.taraTextBox.Name = "taraTextBox";
            this.taraTextBox.Size = new System.Drawing.Size(100, 20);
            this.taraTextBox.TabIndex = 6;
            // 
            // regiuneTextBox
            // 
            this.regiuneTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.aeroportBindingSource, "Regiune", true));
            this.regiuneTextBox.Location = new System.Drawing.Point(552, 155);
            this.regiuneTextBox.Name = "regiuneTextBox";
            this.regiuneTextBox.Size = new System.Drawing.Size(100, 20);
            this.regiuneTextBox.TabIndex = 8;
            // 
            // localitateTextBox
            // 
            this.localitateTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.aeroportBindingSource, "Localitate", true));
            this.localitateTextBox.Location = new System.Drawing.Point(552, 181);
            this.localitateTextBox.Name = "localitateTextBox";
            this.localitateTextBox.Size = new System.Drawing.Size(100, 20);
            this.localitateTextBox.TabIndex = 10;
            // 
            // stradaTextBox
            // 
            this.stradaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.aeroportBindingSource, "Strada", true));
            this.stradaTextBox.Location = new System.Drawing.Point(552, 207);
            this.stradaTextBox.Name = "stradaTextBox";
            this.stradaTextBox.Size = new System.Drawing.Size(100, 20);
            this.stradaTextBox.TabIndex = 12;
            // 
            // nrTextBox
            // 
            this.nrTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.aeroportBindingSource, "Nr", true));
            this.nrTextBox.Location = new System.Drawing.Point(552, 233);
            this.nrTextBox.Name = "nrTextBox";
            this.nrTextBox.Size = new System.Drawing.Size(100, 20);
            this.nrTextBox.TabIndex = 14;
            // 
            // nr_telefonTextBox
            // 
            this.nr_telefonTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.aeroportBindingSource, "Nr_telefon", true));
            this.nr_telefonTextBox.Location = new System.Drawing.Point(552, 259);
            this.nr_telefonTextBox.Name = "nr_telefonTextBox";
            this.nr_telefonTextBox.Size = new System.Drawing.Size(100, 20);
            this.nr_telefonTextBox.TabIndex = 16;
            // 
            // aeroportDataGridView
            // 
            this.aeroportDataGridView.AutoGenerateColumns = false;
            this.aeroportDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.aeroportDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.aeroportDataGridView.DataSource = this.aeroportBindingSource;
            this.aeroportDataGridView.Location = new System.Drawing.Point(197, 378);
            this.aeroportDataGridView.Name = "aeroportDataGridView";
            this.aeroportDataGridView.Size = new System.Drawing.Size(856, 220);
            this.aeroportDataGridView.TabIndex = 17;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Cod_aeroport";
            this.dataGridViewTextBoxColumn1.HeaderText = "Cod_aeroport";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Nume_aeroport";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nume_aeroport";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Tara";
            this.dataGridViewTextBoxColumn3.HeaderText = "Tara";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Regiune";
            this.dataGridViewTextBoxColumn4.HeaderText = "Regiune";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Localitate";
            this.dataGridViewTextBoxColumn5.HeaderText = "Localitate";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Strada";
            this.dataGridViewTextBoxColumn6.HeaderText = "Strada";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Nr";
            this.dataGridViewTextBoxColumn7.HeaderText = "Nr";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Nr_telefon";
            this.dataGridViewTextBoxColumn8.HeaderText = "Nr_telefon";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(342, 332);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 18;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(887, 332);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 19;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(379, 295);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Sortare dupa:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(925, 295);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Mod:";
            // 
            // AdminAeroport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1208, 619);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.aeroportDataGridView);
            this.Controls.Add(cod_aeroportLabel);
            this.Controls.Add(this.cod_aeroportTextBox);
            this.Controls.Add(nume_aeroportLabel);
            this.Controls.Add(this.nume_aeroportTextBox);
            this.Controls.Add(taraLabel);
            this.Controls.Add(this.taraTextBox);
            this.Controls.Add(regiuneLabel);
            this.Controls.Add(this.regiuneTextBox);
            this.Controls.Add(localitateLabel);
            this.Controls.Add(this.localitateTextBox);
            this.Controls.Add(stradaLabel);
            this.Controls.Add(this.stradaTextBox);
            this.Controls.Add(nrLabel);
            this.Controls.Add(this.nrTextBox);
            this.Controls.Add(nr_telefonLabel);
            this.Controls.Add(this.nr_telefonTextBox);
            this.Controls.Add(this.aeroportBindingNavigator);
            this.Name = "AdminAeroport";
            this.Text = "Administrare - aeroporturi";
            this.Load += new System.EventHandler(this.Form12_Load);
            ((System.ComponentModel.ISupportInitialize)(this.companieaerianaDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aeroportBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aeroportBindingNavigator)).EndInit();
            this.aeroportBindingNavigator.ResumeLayout(false);
            this.aeroportBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.aeroportDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private companieaerianaDataSet4 companieaerianaDataSet4;
        private System.Windows.Forms.BindingSource aeroportBindingSource;
        private companieaerianaDataSet4TableAdapters.AeroportTableAdapter aeroportTableAdapter;
        private companieaerianaDataSet4TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator aeroportBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton aeroportBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox cod_aeroportTextBox;
        private System.Windows.Forms.TextBox nume_aeroportTextBox;
        private System.Windows.Forms.TextBox taraTextBox;
        private System.Windows.Forms.TextBox regiuneTextBox;
        private System.Windows.Forms.TextBox localitateTextBox;
        private System.Windows.Forms.TextBox stradaTextBox;
        private System.Windows.Forms.TextBox nrTextBox;
        private System.Windows.Forms.TextBox nr_telefonTextBox;
        private System.Windows.Forms.DataGridView aeroportDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}