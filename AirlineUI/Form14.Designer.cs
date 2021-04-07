
namespace Airline
{
    partial class AdminZbor
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
            System.Windows.Forms.Label id_rutaLabel;
            System.Windows.Forms.Label data_zborLabel;
            System.Windows.Forms.Label ora_decolareLabel;
            System.Windows.Forms.Label ora_aterizareLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminZbor));
            this.zborBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.zborBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.companieaerianaDataSet6 = new Airline.companieaerianaDataSet6();
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
            this.zborBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.id_aeronavaTextBox = new System.Windows.Forms.TextBox();
            this.id_rutaTextBox = new System.Windows.Forms.TextBox();
            this.data_zborDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.ora_decolareTextBox = new System.Windows.Forms.TextBox();
            this.ora_aterizareTextBox = new System.Windows.Forms.TextBox();
            this.zborDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.zborTableAdapter = new Airline.companieaerianaDataSet6TableAdapters.ZborTableAdapter();
            this.tableAdapterManager = new Airline.companieaerianaDataSet6TableAdapters.TableAdapterManager();
            this.buttonCautareZbor = new System.Windows.Forms.Button();
            id_aeronavaLabel = new System.Windows.Forms.Label();
            id_rutaLabel = new System.Windows.Forms.Label();
            data_zborLabel = new System.Windows.Forms.Label();
            ora_decolareLabel = new System.Windows.Forms.Label();
            ora_aterizareLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.zborBindingNavigator)).BeginInit();
            this.zborBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.zborBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.companieaerianaDataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zborDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // id_aeronavaLabel
            // 
            id_aeronavaLabel.AutoSize = true;
            id_aeronavaLabel.Location = new System.Drawing.Point(194, 120);
            id_aeronavaLabel.Name = "id_aeronavaLabel";
            id_aeronavaLabel.Size = new System.Drawing.Size(67, 13);
            id_aeronavaLabel.TabIndex = 3;
            id_aeronavaLabel.Text = "Id aeronava:";
            // 
            // id_rutaLabel
            // 
            id_rutaLabel.AutoSize = true;
            id_rutaLabel.Location = new System.Drawing.Point(194, 146);
            id_rutaLabel.Name = "id_rutaLabel";
            id_rutaLabel.Size = new System.Drawing.Size(40, 13);
            id_rutaLabel.TabIndex = 5;
            id_rutaLabel.Text = "Id ruta:";
            // 
            // data_zborLabel
            // 
            data_zborLabel.AutoSize = true;
            data_zborLabel.Location = new System.Drawing.Point(194, 173);
            data_zborLabel.Name = "data_zborLabel";
            data_zborLabel.Size = new System.Drawing.Size(56, 13);
            data_zborLabel.TabIndex = 7;
            data_zborLabel.Text = "Data zbor:";
            // 
            // ora_decolareLabel
            // 
            ora_decolareLabel.AutoSize = true;
            ora_decolareLabel.Location = new System.Drawing.Point(194, 198);
            ora_decolareLabel.Name = "ora_decolareLabel";
            ora_decolareLabel.Size = new System.Drawing.Size(71, 13);
            ora_decolareLabel.TabIndex = 9;
            ora_decolareLabel.Text = "Ora decolare:";
            // 
            // ora_aterizareLabel
            // 
            ora_aterizareLabel.AutoSize = true;
            ora_aterizareLabel.Location = new System.Drawing.Point(194, 224);
            ora_aterizareLabel.Name = "ora_aterizareLabel";
            ora_aterizareLabel.Size = new System.Drawing.Size(70, 13);
            ora_aterizareLabel.TabIndex = 11;
            ora_aterizareLabel.Text = "Ora aterizare:";
            // 
            // zborBindingNavigator
            // 
            this.zborBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.zborBindingNavigator.BindingSource = this.zborBindingSource;
            this.zborBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.zborBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.zborBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.zborBindingNavigatorSaveItem});
            this.zborBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.zborBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.zborBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.zborBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.zborBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.zborBindingNavigator.Name = "zborBindingNavigator";
            this.zborBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.zborBindingNavigator.Size = new System.Drawing.Size(800, 25);
            this.zborBindingNavigator.TabIndex = 0;
            this.zborBindingNavigator.Text = "bindingNavigator1";
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
            // zborBindingSource
            // 
            this.zborBindingSource.DataMember = "Zbor";
            this.zborBindingSource.DataSource = this.companieaerianaDataSet6;
            // 
            // companieaerianaDataSet6
            // 
            this.companieaerianaDataSet6.DataSetName = "companieaerianaDataSet6";
            this.companieaerianaDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // zborBindingNavigatorSaveItem
            // 
            this.zborBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.zborBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("zborBindingNavigatorSaveItem.Image")));
            this.zborBindingNavigatorSaveItem.Name = "zborBindingNavigatorSaveItem";
            this.zborBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.zborBindingNavigatorSaveItem.Text = "Save Data";
            this.zborBindingNavigatorSaveItem.Click += new System.EventHandler(this.zborBindingNavigatorSaveItem_Click);
            // 
            // id_aeronavaTextBox
            // 
            this.id_aeronavaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.zborBindingSource, "Id_aeronava", true));
            this.id_aeronavaTextBox.Location = new System.Drawing.Point(271, 117);
            this.id_aeronavaTextBox.Name = "id_aeronavaTextBox";
            this.id_aeronavaTextBox.Size = new System.Drawing.Size(200, 20);
            this.id_aeronavaTextBox.TabIndex = 4;
            // 
            // id_rutaTextBox
            // 
            this.id_rutaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.zborBindingSource, "Id_ruta", true));
            this.id_rutaTextBox.Location = new System.Drawing.Point(271, 143);
            this.id_rutaTextBox.Name = "id_rutaTextBox";
            this.id_rutaTextBox.Size = new System.Drawing.Size(200, 20);
            this.id_rutaTextBox.TabIndex = 6;
            // 
            // data_zborDateTimePicker
            // 
            this.data_zborDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.zborBindingSource, "Data_zbor", true));
            this.data_zborDateTimePicker.Location = new System.Drawing.Point(271, 169);
            this.data_zborDateTimePicker.MaxDate = new System.DateTime(2021, 12, 31, 0, 0, 0, 0);
            this.data_zborDateTimePicker.MinDate = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            this.data_zborDateTimePicker.Name = "data_zborDateTimePicker";
            this.data_zborDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.data_zborDateTimePicker.TabIndex = 8;
            // 
            // ora_decolareTextBox
            // 
            this.ora_decolareTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.zborBindingSource, "Ora_decolare", true));
            this.ora_decolareTextBox.Location = new System.Drawing.Point(271, 195);
            this.ora_decolareTextBox.Name = "ora_decolareTextBox";
            this.ora_decolareTextBox.Size = new System.Drawing.Size(200, 20);
            this.ora_decolareTextBox.TabIndex = 10;
            // 
            // ora_aterizareTextBox
            // 
            this.ora_aterizareTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.zborBindingSource, "Ora_aterizare", true));
            this.ora_aterizareTextBox.Location = new System.Drawing.Point(271, 221);
            this.ora_aterizareTextBox.Name = "ora_aterizareTextBox";
            this.ora_aterizareTextBox.Size = new System.Drawing.Size(200, 20);
            this.ora_aterizareTextBox.TabIndex = 12;
            // 
            // zborDataGridView
            // 
            this.zborDataGridView.AutoGenerateColumns = false;
            this.zborDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.zborDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.zborDataGridView.DataSource = this.zborBindingSource;
            this.zborDataGridView.Location = new System.Drawing.Point(66, 316);
            this.zborDataGridView.Name = "zborDataGridView";
            this.zborDataGridView.Size = new System.Drawing.Size(656, 220);
            this.zborDataGridView.TabIndex = 12;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id_zbor";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id_zbor";
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
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Id_ruta";
            this.dataGridViewTextBoxColumn3.HeaderText = "Id_ruta";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Data_zbor";
            this.dataGridViewTextBoxColumn4.HeaderText = "Data_zbor";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Ora_decolare";
            this.dataGridViewTextBoxColumn5.HeaderText = "Ora_decolare";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Ora_aterizare";
            this.dataGridViewTextBoxColumn6.HeaderText = "Ora_aterizare";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(229, 267);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Sortare dupa:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(481, 267);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Mod:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(197, 283);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 15;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(447, 283);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 16;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // zborTableAdapter
            // 
            this.zborTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = Airline.companieaerianaDataSet6TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.ZborTableAdapter = this.zborTableAdapter;
            // 
            // buttonCautareZbor
            // 
            this.buttonCautareZbor.Location = new System.Drawing.Point(647, 267);
            this.buttonCautareZbor.Name = "buttonCautareZbor";
            this.buttonCautareZbor.Size = new System.Drawing.Size(75, 23);
            this.buttonCautareZbor.TabIndex = 17;
            this.buttonCautareZbor.Text = "Cautare";
            this.buttonCautareZbor.UseVisualStyleBackColor = true;
            this.buttonCautareZbor.Click += new System.EventHandler(this.buttonCautareZbor_Click);
            // 
            // AdminZbor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 573);
            this.Controls.Add(this.buttonCautareZbor);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.zborDataGridView);
            this.Controls.Add(id_aeronavaLabel);
            this.Controls.Add(this.id_aeronavaTextBox);
            this.Controls.Add(id_rutaLabel);
            this.Controls.Add(this.id_rutaTextBox);
            this.Controls.Add(data_zborLabel);
            this.Controls.Add(this.data_zborDateTimePicker);
            this.Controls.Add(ora_decolareLabel);
            this.Controls.Add(this.ora_decolareTextBox);
            this.Controls.Add(ora_aterizareLabel);
            this.Controls.Add(this.ora_aterizareTextBox);
            this.Controls.Add(this.zborBindingNavigator);
            this.Name = "AdminZbor";
            this.Text = "Administrare - zboruri";
            this.Load += new System.EventHandler(this.Form14_Load);
            ((System.ComponentModel.ISupportInitialize)(this.zborBindingNavigator)).EndInit();
            this.zborBindingNavigator.ResumeLayout(false);
            this.zborBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.zborBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.companieaerianaDataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zborDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private companieaerianaDataSet6 companieaerianaDataSet6;
        private System.Windows.Forms.BindingSource zborBindingSource;
        private companieaerianaDataSet6TableAdapters.ZborTableAdapter zborTableAdapter;
        private companieaerianaDataSet6TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator zborBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton zborBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox id_aeronavaTextBox;
        private System.Windows.Forms.TextBox id_rutaTextBox;
        private System.Windows.Forms.DateTimePicker data_zborDateTimePicker;
        private System.Windows.Forms.TextBox ora_decolareTextBox;
        private System.Windows.Forms.TextBox ora_aterizareTextBox;
        private System.Windows.Forms.DataGridView zborDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button buttonCautareZbor;
    }
}