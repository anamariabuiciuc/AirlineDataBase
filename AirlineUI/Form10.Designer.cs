
namespace Airline
{
    partial class AdminAeronave
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
            System.Windows.Forms.Label nume_aeronavaLabel;
            System.Windows.Forms.Label nr_locuriLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminAeronave));
            this.companieaerianaDataSet2 = new Airline.companieaerianaDataSet2();
            this.aeronavaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aeronavaTableAdapter = new Airline.companieaerianaDataSet2TableAdapters.AeronavaTableAdapter();
            this.tableAdapterManager = new Airline.companieaerianaDataSet2TableAdapters.TableAdapterManager();
            this.aeronavaBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.aeronavaBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.id_aeronavaTextBox = new System.Windows.Forms.TextBox();
            this.nume_aeronavaTextBox = new System.Windows.Forms.TextBox();
            this.nr_locuriTextBox = new System.Windows.Forms.TextBox();
            this.aeronavaDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            id_aeronavaLabel = new System.Windows.Forms.Label();
            nume_aeronavaLabel = new System.Windows.Forms.Label();
            nr_locuriLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.companieaerianaDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aeronavaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aeronavaBindingNavigator)).BeginInit();
            this.aeronavaBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.aeronavaDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // id_aeronavaLabel
            // 
            id_aeronavaLabel.AutoSize = true;
            id_aeronavaLabel.Location = new System.Drawing.Point(28, 101);
            id_aeronavaLabel.Name = "id_aeronavaLabel";
            id_aeronavaLabel.Size = new System.Drawing.Size(67, 13);
            id_aeronavaLabel.TabIndex = 1;
            id_aeronavaLabel.Text = "Id aeronava:";
            // 
            // nume_aeronavaLabel
            // 
            nume_aeronavaLabel.AutoSize = true;
            nume_aeronavaLabel.Location = new System.Drawing.Point(28, 127);
            nume_aeronavaLabel.Name = "nume_aeronavaLabel";
            nume_aeronavaLabel.Size = new System.Drawing.Size(86, 13);
            nume_aeronavaLabel.TabIndex = 3;
            nume_aeronavaLabel.Text = "Nume aeronava:";
            // 
            // nr_locuriLabel
            // 
            nr_locuriLabel.AutoSize = true;
            nr_locuriLabel.Location = new System.Drawing.Point(28, 153);
            nr_locuriLabel.Name = "nr_locuriLabel";
            nr_locuriLabel.Size = new System.Drawing.Size(49, 13);
            nr_locuriLabel.TabIndex = 5;
            nr_locuriLabel.Text = "Nr locuri:";
            // 
            // companieaerianaDataSet2
            // 
            this.companieaerianaDataSet2.DataSetName = "companieaerianaDataSet2";
            this.companieaerianaDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // aeronavaBindingSource
            // 
            this.aeronavaBindingSource.DataMember = "Aeronava";
            this.aeronavaBindingSource.DataSource = this.companieaerianaDataSet2;
            // 
            // aeronavaTableAdapter
            // 
            this.aeronavaTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AeronavaTableAdapter = this.aeronavaTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = Airline.companieaerianaDataSet2TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // aeronavaBindingNavigator
            // 
            this.aeronavaBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.aeronavaBindingNavigator.BindingSource = this.aeronavaBindingSource;
            this.aeronavaBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.aeronavaBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.aeronavaBindingNavigator.Dock = System.Windows.Forms.DockStyle.None;
            this.aeronavaBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.aeronavaBindingNavigatorSaveItem});
            this.aeronavaBindingNavigator.Location = new System.Drawing.Point(9, 49);
            this.aeronavaBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.aeronavaBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.aeronavaBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.aeronavaBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.aeronavaBindingNavigator.Name = "aeronavaBindingNavigator";
            this.aeronavaBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.aeronavaBindingNavigator.Size = new System.Drawing.Size(278, 25);
            this.aeronavaBindingNavigator.TabIndex = 0;
            this.aeronavaBindingNavigator.Text = "bindingNavigator1";
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
            // aeronavaBindingNavigatorSaveItem
            // 
            this.aeronavaBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.aeronavaBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("aeronavaBindingNavigatorSaveItem.Image")));
            this.aeronavaBindingNavigatorSaveItem.Name = "aeronavaBindingNavigatorSaveItem";
            this.aeronavaBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.aeronavaBindingNavigatorSaveItem.Text = "Save Data";
            this.aeronavaBindingNavigatorSaveItem.Click += new System.EventHandler(this.aeronavaBindingNavigatorSaveItem_Click);
            // 
            // id_aeronavaTextBox
            // 
            this.id_aeronavaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.aeronavaBindingSource, "Id_aeronava", true));
            this.id_aeronavaTextBox.Location = new System.Drawing.Point(120, 98);
            this.id_aeronavaTextBox.Name = "id_aeronavaTextBox";
            this.id_aeronavaTextBox.Size = new System.Drawing.Size(100, 20);
            this.id_aeronavaTextBox.TabIndex = 2;
            // 
            // nume_aeronavaTextBox
            // 
            this.nume_aeronavaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.aeronavaBindingSource, "Nume_aeronava", true));
            this.nume_aeronavaTextBox.Location = new System.Drawing.Point(120, 124);
            this.nume_aeronavaTextBox.Name = "nume_aeronavaTextBox";
            this.nume_aeronavaTextBox.Size = new System.Drawing.Size(100, 20);
            this.nume_aeronavaTextBox.TabIndex = 4;
            // 
            // nr_locuriTextBox
            // 
            this.nr_locuriTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.aeronavaBindingSource, "Nr_locuri", true));
            this.nr_locuriTextBox.Location = new System.Drawing.Point(120, 150);
            this.nr_locuriTextBox.Name = "nr_locuriTextBox";
            this.nr_locuriTextBox.Size = new System.Drawing.Size(100, 20);
            this.nr_locuriTextBox.TabIndex = 6;
            // 
            // aeronavaDataGridView
            // 
            this.aeronavaDataGridView.AutoGenerateColumns = false;
            this.aeronavaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.aeronavaDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.aeronavaDataGridView.DataSource = this.aeronavaBindingSource;
            this.aeronavaDataGridView.Location = new System.Drawing.Point(374, 101);
            this.aeronavaDataGridView.Name = "aeronavaDataGridView";
            this.aeronavaDataGridView.Size = new System.Drawing.Size(354, 220);
            this.aeronavaDataGridView.TabIndex = 7;
            this.aeronavaDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.aeronavaDataGridView_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id_aeronava";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id_aeronava";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Nume_aeronava";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nume_aeronava";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Nr_locuri";
            this.dataGridViewTextBoxColumn3.HeaderText = "Nr_locuri";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(397, 49);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 8;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(571, 49);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 8;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(629, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Mod:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(416, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Sortare dupa:";
            // 
            // AdminAeronave
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.aeronavaDataGridView);
            this.Controls.Add(id_aeronavaLabel);
            this.Controls.Add(this.id_aeronavaTextBox);
            this.Controls.Add(nume_aeronavaLabel);
            this.Controls.Add(this.nume_aeronavaTextBox);
            this.Controls.Add(nr_locuriLabel);
            this.Controls.Add(this.nr_locuriTextBox);
            this.Controls.Add(this.aeronavaBindingNavigator);
            this.Name = "AdminAeronave";
            this.Text = "Administrare - Aeronave";
            this.Load += new System.EventHandler(this.Form10_Load);
            ((System.ComponentModel.ISupportInitialize)(this.companieaerianaDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aeronavaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aeronavaBindingNavigator)).EndInit();
            this.aeronavaBindingNavigator.ResumeLayout(false);
            this.aeronavaBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.aeronavaDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private companieaerianaDataSet2 companieaerianaDataSet2;
        private System.Windows.Forms.BindingSource aeronavaBindingSource;
        private companieaerianaDataSet2TableAdapters.AeronavaTableAdapter aeronavaTableAdapter;
        private companieaerianaDataSet2TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator aeronavaBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton aeronavaBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox id_aeronavaTextBox;
        private System.Windows.Forms.TextBox nume_aeronavaTextBox;
        private System.Windows.Forms.TextBox nr_locuriTextBox;
        private System.Windows.Forms.DataGridView aeronavaDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}