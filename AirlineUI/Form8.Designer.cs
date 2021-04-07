
namespace Airline
{
    partial class AdminRezervari
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
            System.Windows.Forms.Label id_clientLabel;
            System.Windows.Forms.Label data_achizitieLabel;
            System.Windows.Forms.Label metoda_achizitieLabel;
            System.Windows.Forms.Label pretLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminRezervari));
            this.companieaerianaDataSet = new Airline.companieaerianaDataSet();
            this.rezervareBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rezervareTableAdapter = new Airline.companieaerianaDataSetTableAdapters.RezervareTableAdapter();
            this.tableAdapterManager = new Airline.companieaerianaDataSetTableAdapters.TableAdapterManager();
            this.rezervareBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.rezervareBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.rezervareDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.id_clientTextBox = new System.Windows.Forms.TextBox();
            this.data_achizitieDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.metoda_achizitieTextBox = new System.Windows.Forms.TextBox();
            this.pretTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            id_clientLabel = new System.Windows.Forms.Label();
            data_achizitieLabel = new System.Windows.Forms.Label();
            metoda_achizitieLabel = new System.Windows.Forms.Label();
            pretLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.companieaerianaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rezervareBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rezervareBindingNavigator)).BeginInit();
            this.rezervareBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rezervareDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // id_clientLabel
            // 
            id_clientLabel.AutoSize = true;
            id_clientLabel.BackColor = System.Drawing.Color.Transparent;
            id_clientLabel.Location = new System.Drawing.Point(84, 287);
            id_clientLabel.Name = "id_clientLabel";
            id_clientLabel.Size = new System.Drawing.Size(47, 13);
            id_clientLabel.TabIndex = 8;
            id_clientLabel.Text = "Id client:";
            // 
            // data_achizitieLabel
            // 
            data_achizitieLabel.AutoSize = true;
            data_achizitieLabel.BackColor = System.Drawing.Color.Transparent;
            data_achizitieLabel.Location = new System.Drawing.Point(84, 314);
            data_achizitieLabel.Name = "data_achizitieLabel";
            data_achizitieLabel.Size = new System.Drawing.Size(74, 13);
            data_achizitieLabel.TabIndex = 10;
            data_achizitieLabel.Text = "Data achizitie:";
            // 
            // metoda_achizitieLabel
            // 
            metoda_achizitieLabel.AutoSize = true;
            metoda_achizitieLabel.BackColor = System.Drawing.Color.Transparent;
            metoda_achizitieLabel.Location = new System.Drawing.Point(84, 339);
            metoda_achizitieLabel.Name = "metoda_achizitieLabel";
            metoda_achizitieLabel.Size = new System.Drawing.Size(87, 13);
            metoda_achizitieLabel.TabIndex = 12;
            metoda_achizitieLabel.Text = "Metoda achizitie:";
            // 
            // pretLabel
            // 
            pretLabel.AutoSize = true;
            pretLabel.BackColor = System.Drawing.Color.Transparent;
            pretLabel.Location = new System.Drawing.Point(84, 365);
            pretLabel.Name = "pretLabel";
            pretLabel.Size = new System.Drawing.Size(29, 13);
            pretLabel.TabIndex = 14;
            pretLabel.Text = "Pret:";
            // 
            // companieaerianaDataSet
            // 
            this.companieaerianaDataSet.DataSetName = "companieaerianaDataSet";
            this.companieaerianaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rezervareBindingSource
            // 
            this.rezervareBindingSource.DataMember = "Rezervare";
            this.rezervareBindingSource.DataSource = this.companieaerianaDataSet;
            // 
            // rezervareTableAdapter
            // 
            this.rezervareTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.RezervareTableAdapter = this.rezervareTableAdapter;
            this.tableAdapterManager.UpdateOrder = Airline.companieaerianaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // rezervareBindingNavigator
            // 
            this.rezervareBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.rezervareBindingNavigator.BindingSource = this.rezervareBindingSource;
            this.rezervareBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.rezervareBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.rezervareBindingNavigator.Dock = System.Windows.Forms.DockStyle.None;
            this.rezervareBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.rezervareBindingNavigatorSaveItem});
            this.rezervareBindingNavigator.Location = new System.Drawing.Point(87, 200);
            this.rezervareBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.rezervareBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.rezervareBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.rezervareBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.rezervareBindingNavigator.Name = "rezervareBindingNavigator";
            this.rezervareBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.rezervareBindingNavigator.Size = new System.Drawing.Size(278, 25);
            this.rezervareBindingNavigator.TabIndex = 0;
            this.rezervareBindingNavigator.Text = "bindingNavigator1";
            this.rezervareBindingNavigator.RefreshItems += new System.EventHandler(this.rezervareBindingNavigator_RefreshItems);
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
            // rezervareBindingNavigatorSaveItem
            // 
            this.rezervareBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.rezervareBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("rezervareBindingNavigatorSaveItem.Image")));
            this.rezervareBindingNavigatorSaveItem.Name = "rezervareBindingNavigatorSaveItem";
            this.rezervareBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.rezervareBindingNavigatorSaveItem.Text = "Save Data";
            this.rezervareBindingNavigatorSaveItem.Click += new System.EventHandler(this.rezervareBindingNavigatorSaveItem_Click);
            // 
            // rezervareDataGridView
            // 
            this.rezervareDataGridView.AutoGenerateColumns = false;
            this.rezervareDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.rezervareDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.rezervareDataGridView.DataSource = this.rezervareBindingSource;
            this.rezervareDataGridView.Location = new System.Drawing.Point(593, 226);
            this.rezervareDataGridView.Name = "rezervareDataGridView";
            this.rezervareDataGridView.Size = new System.Drawing.Size(564, 220);
            this.rezervareDataGridView.TabIndex = 1;
            this.rezervareDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.rezervareDataGridView_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id_rezervare";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id_rezervare";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Id_client";
            this.dataGridViewTextBoxColumn2.HeaderText = "Id_client";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Data_achizitie";
            this.dataGridViewTextBoxColumn3.HeaderText = "Data_achizitie";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Metoda_achizitie";
            this.dataGridViewTextBoxColumn4.HeaderText = "Metoda_achizitie";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Pret";
            this.dataGridViewTextBoxColumn5.HeaderText = "Pret";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(718, 180);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(996, 171);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 3;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(620, 183);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Sortare dupa:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(949, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Mod:";
            // 
            // id_clientTextBox
            // 
            this.id_clientTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.rezervareBindingSource, "Id_client", true));
            this.id_clientTextBox.Location = new System.Drawing.Point(177, 284);
            this.id_clientTextBox.Name = "id_clientTextBox";
            this.id_clientTextBox.Size = new System.Drawing.Size(200, 20);
            this.id_clientTextBox.TabIndex = 9;
            // 
            // data_achizitieDateTimePicker
            // 
            this.data_achizitieDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.rezervareBindingSource, "Data_achizitie", true));
            this.data_achizitieDateTimePicker.Location = new System.Drawing.Point(177, 310);
            this.data_achizitieDateTimePicker.MaxDate = new System.DateTime(2021, 1, 10, 0, 0, 0, 0);
            this.data_achizitieDateTimePicker.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.data_achizitieDateTimePicker.Name = "data_achizitieDateTimePicker";
            this.data_achizitieDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.data_achizitieDateTimePicker.TabIndex = 11;
            this.data_achizitieDateTimePicker.ValueChanged += new System.EventHandler(this.data_achizitieDateTimePicker_ValueChanged);
            // 
            // metoda_achizitieTextBox
            // 
            this.metoda_achizitieTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.rezervareBindingSource, "Metoda_achizitie", true));
            this.metoda_achizitieTextBox.Location = new System.Drawing.Point(177, 336);
            this.metoda_achizitieTextBox.Name = "metoda_achizitieTextBox";
            this.metoda_achizitieTextBox.Size = new System.Drawing.Size(200, 20);
            this.metoda_achizitieTextBox.TabIndex = 13;
            // 
            // pretTextBox
            // 
            this.pretTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.rezervareBindingSource, "Pret", true));
            this.pretTextBox.Location = new System.Drawing.Point(177, 362);
            this.pretTextBox.Name = "pretTextBox";
            this.pretTextBox.Size = new System.Drawing.Size(200, 20);
            this.pretTextBox.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(84, 248);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Adauga o rezervare:";
            // 
            // AdminRezervari
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1220, 663);
            this.Controls.Add(this.label3);
            this.Controls.Add(id_clientLabel);
            this.Controls.Add(this.id_clientTextBox);
            this.Controls.Add(data_achizitieLabel);
            this.Controls.Add(this.data_achizitieDateTimePicker);
            this.Controls.Add(metoda_achizitieLabel);
            this.Controls.Add(this.metoda_achizitieTextBox);
            this.Controls.Add(pretLabel);
            this.Controls.Add(this.pretTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.rezervareDataGridView);
            this.Controls.Add(this.rezervareBindingNavigator);
            this.Name = "AdminRezervari";
            this.Text = "Rezervari";
            this.Load += new System.EventHandler(this.Form8_Load);
            ((System.ComponentModel.ISupportInitialize)(this.companieaerianaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rezervareBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rezervareBindingNavigator)).EndInit();
            this.rezervareBindingNavigator.ResumeLayout(false);
            this.rezervareBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rezervareDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private companieaerianaDataSet companieaerianaDataSet;
        private System.Windows.Forms.BindingSource rezervareBindingSource;
        private companieaerianaDataSetTableAdapters.RezervareTableAdapter rezervareTableAdapter;
        private companieaerianaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator rezervareBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton rezervareBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView rezervareDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox id_clientTextBox;
        private System.Windows.Forms.DateTimePicker data_achizitieDateTimePicker;
        private System.Windows.Forms.TextBox metoda_achizitieTextBox;
        private System.Windows.Forms.TextBox pretTextBox;
        private System.Windows.Forms.Label label3;
    }
}