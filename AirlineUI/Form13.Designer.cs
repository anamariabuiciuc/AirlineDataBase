
namespace Airline
{
    partial class AdminRuta
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
            System.Windows.Forms.Label id_rutaLabel;
            System.Windows.Forms.Label cod_plecareLabel;
            System.Windows.Forms.Label cod_destinatieLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminRuta));
            this.companieaerianaDataSet5 = new Airline.companieaerianaDataSet5();
            this.rutaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rutaTableAdapter = new Airline.companieaerianaDataSet5TableAdapters.RutaTableAdapter();
            this.tableAdapterManager = new Airline.companieaerianaDataSet5TableAdapters.TableAdapterManager();
            this.rutaBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.rutaBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.id_rutaTextBox = new System.Windows.Forms.TextBox();
            this.cod_plecareTextBox = new System.Windows.Forms.TextBox();
            this.cod_destinatieTextBox = new System.Windows.Forms.TextBox();
            this.rutaDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            id_rutaLabel = new System.Windows.Forms.Label();
            cod_plecareLabel = new System.Windows.Forms.Label();
            cod_destinatieLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.companieaerianaDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rutaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rutaBindingNavigator)).BeginInit();
            this.rutaBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rutaDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // id_rutaLabel
            // 
            id_rutaLabel.AutoSize = true;
            id_rutaLabel.Location = new System.Drawing.Point(61, 109);
            id_rutaLabel.Name = "id_rutaLabel";
            id_rutaLabel.Size = new System.Drawing.Size(40, 13);
            id_rutaLabel.TabIndex = 1;
            id_rutaLabel.Text = "Id ruta:";
            // 
            // cod_plecareLabel
            // 
            cod_plecareLabel.AutoSize = true;
            cod_plecareLabel.Location = new System.Drawing.Point(61, 135);
            cod_plecareLabel.Name = "cod_plecareLabel";
            cod_plecareLabel.Size = new System.Drawing.Size(67, 13);
            cod_plecareLabel.TabIndex = 3;
            cod_plecareLabel.Text = "Cod plecare:";
            // 
            // cod_destinatieLabel
            // 
            cod_destinatieLabel.AutoSize = true;
            cod_destinatieLabel.Location = new System.Drawing.Point(61, 161);
            cod_destinatieLabel.Name = "cod_destinatieLabel";
            cod_destinatieLabel.Size = new System.Drawing.Size(77, 13);
            cod_destinatieLabel.TabIndex = 5;
            cod_destinatieLabel.Text = "Cod destinatie:";
            // 
            // companieaerianaDataSet5
            // 
            this.companieaerianaDataSet5.DataSetName = "companieaerianaDataSet5";
            this.companieaerianaDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rutaBindingSource
            // 
            this.rutaBindingSource.DataMember = "Ruta";
            this.rutaBindingSource.DataSource = this.companieaerianaDataSet5;
            // 
            // rutaTableAdapter
            // 
            this.rutaTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.RutaTableAdapter = this.rutaTableAdapter;
            this.tableAdapterManager.UpdateOrder = Airline.companieaerianaDataSet5TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // rutaBindingNavigator
            // 
            this.rutaBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.rutaBindingNavigator.BindingSource = this.rutaBindingSource;
            this.rutaBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.rutaBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.rutaBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.rutaBindingNavigatorSaveItem});
            this.rutaBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.rutaBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.rutaBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.rutaBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.rutaBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.rutaBindingNavigator.Name = "rutaBindingNavigator";
            this.rutaBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.rutaBindingNavigator.Size = new System.Drawing.Size(886, 25);
            this.rutaBindingNavigator.TabIndex = 0;
            this.rutaBindingNavigator.Text = "bindingNavigator1";
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
            // rutaBindingNavigatorSaveItem
            // 
            this.rutaBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.rutaBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("rutaBindingNavigatorSaveItem.Image")));
            this.rutaBindingNavigatorSaveItem.Name = "rutaBindingNavigatorSaveItem";
            this.rutaBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.rutaBindingNavigatorSaveItem.Text = "Save Data";
            this.rutaBindingNavigatorSaveItem.Click += new System.EventHandler(this.rutaBindingNavigatorSaveItem_Click);
            // 
            // id_rutaTextBox
            // 
            this.id_rutaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.rutaBindingSource, "Id_ruta", true));
            this.id_rutaTextBox.Location = new System.Drawing.Point(144, 106);
            this.id_rutaTextBox.Name = "id_rutaTextBox";
            this.id_rutaTextBox.Size = new System.Drawing.Size(100, 20);
            this.id_rutaTextBox.TabIndex = 2;
            this.id_rutaTextBox.TextChanged += new System.EventHandler(this.id_rutaTextBox_TextChanged);
            // 
            // cod_plecareTextBox
            // 
            this.cod_plecareTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.rutaBindingSource, "Cod_plecare", true));
            this.cod_plecareTextBox.Location = new System.Drawing.Point(144, 132);
            this.cod_plecareTextBox.Name = "cod_plecareTextBox";
            this.cod_plecareTextBox.Size = new System.Drawing.Size(100, 20);
            this.cod_plecareTextBox.TabIndex = 4;
            // 
            // cod_destinatieTextBox
            // 
            this.cod_destinatieTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.rutaBindingSource, "Cod_destinatie", true));
            this.cod_destinatieTextBox.Location = new System.Drawing.Point(144, 158);
            this.cod_destinatieTextBox.Name = "cod_destinatieTextBox";
            this.cod_destinatieTextBox.Size = new System.Drawing.Size(100, 20);
            this.cod_destinatieTextBox.TabIndex = 6;
            // 
            // rutaDataGridView
            // 
            this.rutaDataGridView.AutoGenerateColumns = false;
            this.rutaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.rutaDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.rutaDataGridView.DataSource = this.rutaBindingSource;
            this.rutaDataGridView.Location = new System.Drawing.Point(441, 82);
            this.rutaDataGridView.Name = "rutaDataGridView";
            this.rutaDataGridView.Size = new System.Drawing.Size(369, 164);
            this.rutaDataGridView.TabIndex = 7;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id_ruta";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id_ruta";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Cod_plecare";
            this.dataGridViewTextBoxColumn2.HeaderText = "Cod_plecare";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Cod_destinatie";
            this.dataGridViewTextBoxColumn3.HeaderText = "Cod_destinatie";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(453, 50);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 8;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(626, 50);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 9;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(672, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "Mod:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(484, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "Sortare dupa:";
            // 
            // AdminRuta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(886, 438);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.rutaDataGridView);
            this.Controls.Add(id_rutaLabel);
            this.Controls.Add(this.id_rutaTextBox);
            this.Controls.Add(cod_plecareLabel);
            this.Controls.Add(this.cod_plecareTextBox);
            this.Controls.Add(cod_destinatieLabel);
            this.Controls.Add(this.cod_destinatieTextBox);
            this.Controls.Add(this.rutaBindingNavigator);
            this.Name = "AdminRuta";
            this.Text = "Administrare - Rute";
            this.Load += new System.EventHandler(this.Form13_Load);
            ((System.ComponentModel.ISupportInitialize)(this.companieaerianaDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rutaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rutaBindingNavigator)).EndInit();
            this.rutaBindingNavigator.ResumeLayout(false);
            this.rutaBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rutaDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private companieaerianaDataSet5 companieaerianaDataSet5;
        private System.Windows.Forms.BindingSource rutaBindingSource;
        private companieaerianaDataSet5TableAdapters.RutaTableAdapter rutaTableAdapter;
        private companieaerianaDataSet5TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator rutaBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton rutaBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox id_rutaTextBox;
        private System.Windows.Forms.TextBox cod_plecareTextBox;
        private System.Windows.Forms.TextBox cod_destinatieTextBox;
        private System.Windows.Forms.DataGridView rutaDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}