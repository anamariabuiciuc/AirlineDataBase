
namespace Airline
{
    partial class AdminBilete
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
            System.Windows.Forms.Label id_rezervareLabel;
            System.Windows.Forms.Label id_zborLabel;
            System.Windows.Forms.Label nr_locLabel;
            System.Windows.Forms.Label tip_biletLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminBilete));
            this.biletBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.biletBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.companieaerianaDataSet1 = new Airline.companieaerianaDataSet1();
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
            this.biletBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.id_rezervareTextBox = new System.Windows.Forms.TextBox();
            this.id_zborTextBox = new System.Windows.Forms.TextBox();
            this.nr_locTextBox = new System.Windows.Forms.TextBox();
            this.tip_biletTextBox = new System.Windows.Forms.TextBox();
            this.biletDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.biletTableAdapter = new Airline.companieaerianaDataSet1TableAdapters.BiletTableAdapter();
            this.tableAdapterManager = new Airline.companieaerianaDataSet1TableAdapters.TableAdapterManager();
            id_rezervareLabel = new System.Windows.Forms.Label();
            id_zborLabel = new System.Windows.Forms.Label();
            nr_locLabel = new System.Windows.Forms.Label();
            tip_biletLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.biletBindingNavigator)).BeginInit();
            this.biletBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.biletBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.companieaerianaDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.biletDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // id_rezervareLabel
            // 
            id_rezervareLabel.AutoSize = true;
            id_rezervareLabel.Location = new System.Drawing.Point(114, 185);
            id_rezervareLabel.Name = "id_rezervareLabel";
            id_rezervareLabel.Size = new System.Drawing.Size(66, 13);
            id_rezervareLabel.TabIndex = 3;
            id_rezervareLabel.Text = "Id rezervare:";
            // 
            // id_zborLabel
            // 
            id_zborLabel.AutoSize = true;
            id_zborLabel.Location = new System.Drawing.Point(114, 211);
            id_zborLabel.Name = "id_zborLabel";
            id_zborLabel.Size = new System.Drawing.Size(42, 13);
            id_zborLabel.TabIndex = 5;
            id_zborLabel.Text = "Id zbor:";
            // 
            // nr_locLabel
            // 
            nr_locLabel.AutoSize = true;
            nr_locLabel.Location = new System.Drawing.Point(114, 237);
            nr_locLabel.Name = "nr_locLabel";
            nr_locLabel.Size = new System.Drawing.Size(38, 13);
            nr_locLabel.TabIndex = 7;
            nr_locLabel.Text = "Nr loc:";
            // 
            // tip_biletLabel
            // 
            tip_biletLabel.AutoSize = true;
            tip_biletLabel.Location = new System.Drawing.Point(114, 263);
            tip_biletLabel.Name = "tip_biletLabel";
            tip_biletLabel.Size = new System.Drawing.Size(47, 13);
            tip_biletLabel.TabIndex = 9;
            tip_biletLabel.Text = "Tip bilet:";
            // 
            // biletBindingNavigator
            // 
            this.biletBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.biletBindingNavigator.BindingSource = this.biletBindingSource;
            this.biletBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.biletBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.biletBindingNavigator.Dock = System.Windows.Forms.DockStyle.None;
            this.biletBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.biletBindingNavigatorSaveItem});
            this.biletBindingNavigator.Location = new System.Drawing.Point(57, 127);
            this.biletBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.biletBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.biletBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.biletBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.biletBindingNavigator.Name = "biletBindingNavigator";
            this.biletBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.biletBindingNavigator.Size = new System.Drawing.Size(278, 25);
            this.biletBindingNavigator.TabIndex = 0;
            this.biletBindingNavigator.Text = "bindingNavigator1";
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
            // biletBindingSource
            // 
            this.biletBindingSource.DataMember = "Bilet";
            this.biletBindingSource.DataSource = this.companieaerianaDataSet1;
            // 
            // companieaerianaDataSet1
            // 
            this.companieaerianaDataSet1.DataSetName = "companieaerianaDataSet1";
            this.companieaerianaDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // biletBindingNavigatorSaveItem
            // 
            this.biletBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.biletBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("biletBindingNavigatorSaveItem.Image")));
            this.biletBindingNavigatorSaveItem.Name = "biletBindingNavigatorSaveItem";
            this.biletBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.biletBindingNavigatorSaveItem.Text = "Save Data";
            this.biletBindingNavigatorSaveItem.Click += new System.EventHandler(this.biletBindingNavigatorSaveItem_Click);
            // 
            // id_rezervareTextBox
            // 
            this.id_rezervareTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.biletBindingSource, "Id_rezervare", true));
            this.id_rezervareTextBox.Location = new System.Drawing.Point(186, 182);
            this.id_rezervareTextBox.Name = "id_rezervareTextBox";
            this.id_rezervareTextBox.Size = new System.Drawing.Size(100, 20);
            this.id_rezervareTextBox.TabIndex = 4;
            // 
            // id_zborTextBox
            // 
            this.id_zborTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.biletBindingSource, "Id_zbor", true));
            this.id_zborTextBox.Location = new System.Drawing.Point(186, 208);
            this.id_zborTextBox.Name = "id_zborTextBox";
            this.id_zborTextBox.Size = new System.Drawing.Size(100, 20);
            this.id_zborTextBox.TabIndex = 6;
            // 
            // nr_locTextBox
            // 
            this.nr_locTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.biletBindingSource, "Nr_loc", true));
            this.nr_locTextBox.Location = new System.Drawing.Point(186, 234);
            this.nr_locTextBox.Name = "nr_locTextBox";
            this.nr_locTextBox.Size = new System.Drawing.Size(100, 20);
            this.nr_locTextBox.TabIndex = 8;
            // 
            // tip_biletTextBox
            // 
            this.tip_biletTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.biletBindingSource, "Tip_bilet", true));
            this.tip_biletTextBox.Location = new System.Drawing.Point(186, 260);
            this.tip_biletTextBox.Name = "tip_biletTextBox";
            this.tip_biletTextBox.Size = new System.Drawing.Size(100, 20);
            this.tip_biletTextBox.TabIndex = 10;
            // 
            // biletDataGridView
            // 
            this.biletDataGridView.AutoGenerateColumns = false;
            this.biletDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.biletDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.biletDataGridView.DataSource = this.biletBindingSource;
            this.biletDataGridView.Location = new System.Drawing.Point(486, 139);
            this.biletDataGridView.Name = "biletDataGridView";
            this.biletDataGridView.Size = new System.Drawing.Size(555, 220);
            this.biletDataGridView.TabIndex = 10;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id_bilet";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id_bilet";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Id_rezervare";
            this.dataGridViewTextBoxColumn2.HeaderText = "Id_rezervare";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Id_zbor";
            this.dataGridViewTextBoxColumn3.HeaderText = "Id_zbor";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Nr_loc";
            this.dataGridViewTextBoxColumn4.HeaderText = "Nr_loc";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Tip_bilet";
            this.dataGridViewTextBoxColumn5.HeaderText = "Tip_bilet";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(600, 85);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 11;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(795, 85);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 12;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(630, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Sortare dupa:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(843, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Mod:";
            // 
            // biletTableAdapter
            // 
            this.biletTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BiletTableAdapter = this.biletTableAdapter;
            this.tableAdapterManager.UpdateOrder = Airline.companieaerianaDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // AdminBilete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1057, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.biletDataGridView);
            this.Controls.Add(id_rezervareLabel);
            this.Controls.Add(this.id_rezervareTextBox);
            this.Controls.Add(id_zborLabel);
            this.Controls.Add(this.id_zborTextBox);
            this.Controls.Add(nr_locLabel);
            this.Controls.Add(this.nr_locTextBox);
            this.Controls.Add(tip_biletLabel);
            this.Controls.Add(this.tip_biletTextBox);
            this.Controls.Add(this.biletBindingNavigator);
            this.Name = "AdminBilete";
            this.Text = "Administrare - bilete";
            this.Load += new System.EventHandler(this.AdminBilete_Load);
            ((System.ComponentModel.ISupportInitialize)(this.biletBindingNavigator)).EndInit();
            this.biletBindingNavigator.ResumeLayout(false);
            this.biletBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.biletBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.companieaerianaDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.biletDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private companieaerianaDataSet1 companieaerianaDataSet1;
        private System.Windows.Forms.BindingSource biletBindingSource;
        private companieaerianaDataSet1TableAdapters.BiletTableAdapter biletTableAdapter;
        private companieaerianaDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator biletBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton biletBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox id_rezervareTextBox;
        private System.Windows.Forms.TextBox id_zborTextBox;
        private System.Windows.Forms.TextBox nr_locTextBox;
        private System.Windows.Forms.TextBox tip_biletTextBox;
        private System.Windows.Forms.DataGridView biletDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}