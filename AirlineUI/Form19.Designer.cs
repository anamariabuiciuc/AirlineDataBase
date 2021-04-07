
namespace Airline
{
    partial class Form19
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form19));
            System.Windows.Forms.Label id_clientLabel;
            System.Windows.Forms.Label data_achizitieLabel;
            System.Windows.Forms.Label metoda_achizitieLabel;
            System.Windows.Forms.Label pretLabel;
            this.companieaerianaDataSet = new Airline.companieaerianaDataSet();
            this.rezervareBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rezervareTableAdapter = new Airline.companieaerianaDataSetTableAdapters.RezervareTableAdapter();
            this.tableAdapterManager = new Airline.companieaerianaDataSetTableAdapters.TableAdapterManager();
            this.rezervareBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.rezervareBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.id_clientTextBox = new System.Windows.Forms.TextBox();
            this.data_achizitieDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.metoda_achizitieTextBox = new System.Windows.Forms.TextBox();
            this.pretTextBox = new System.Windows.Forms.TextBox();
            id_clientLabel = new System.Windows.Forms.Label();
            data_achizitieLabel = new System.Windows.Forms.Label();
            metoda_achizitieLabel = new System.Windows.Forms.Label();
            pretLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.companieaerianaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rezervareBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rezervareBindingNavigator)).BeginInit();
            this.rezervareBindingNavigator.SuspendLayout();
            this.SuspendLayout();
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
            this.rezervareBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.rezervareBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.rezervareBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.rezervareBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.rezervareBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.rezervareBindingNavigator.Name = "rezervareBindingNavigator";
            this.rezervareBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.rezervareBindingNavigator.Size = new System.Drawing.Size(800, 25);
            this.rezervareBindingNavigator.TabIndex = 0;
            this.rezervareBindingNavigator.Text = "bindingNavigator1";
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
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 15);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
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
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // rezervareBindingNavigatorSaveItem
            // 
            this.rezervareBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.rezervareBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("rezervareBindingNavigatorSaveItem.Image")));
            this.rezervareBindingNavigatorSaveItem.Name = "rezervareBindingNavigatorSaveItem";
            this.rezervareBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.rezervareBindingNavigatorSaveItem.Text = "Save Data";
            this.rezervareBindingNavigatorSaveItem.Click += new System.EventHandler(this.rezervareBindingNavigatorSaveItem_Click);
            // 
            // id_clientLabel
            // 
            id_clientLabel.AutoSize = true;
            id_clientLabel.Location = new System.Drawing.Point(146, 87);
            id_clientLabel.Name = "id_clientLabel";
            id_clientLabel.Size = new System.Drawing.Size(113, 13);
            id_clientLabel.TabIndex = 3;
            id_clientLabel.Text = "Reintroduceti Id client:";
            // 
            // id_clientTextBox
            // 
            this.id_clientTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.rezervareBindingSource, "Id_client", true));
            this.id_clientTextBox.Location = new System.Drawing.Point(265, 84);
            this.id_clientTextBox.Name = "id_clientTextBox";
            this.id_clientTextBox.Size = new System.Drawing.Size(200, 20);
            this.id_clientTextBox.TabIndex = 4;
            // 
            // data_achizitieLabel
            // 
            data_achizitieLabel.AutoSize = true;
            data_achizitieLabel.Location = new System.Drawing.Point(172, 138);
            data_achizitieLabel.Name = "data_achizitieLabel";
            data_achizitieLabel.Size = new System.Drawing.Size(74, 13);
            data_achizitieLabel.TabIndex = 5;
            data_achizitieLabel.Text = "Data achizitie:";
            // 
            // data_achizitieDateTimePicker
            // 
            this.data_achizitieDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.rezervareBindingSource, "Data_achizitie", true));
            this.data_achizitieDateTimePicker.Location = new System.Drawing.Point(265, 134);
            this.data_achizitieDateTimePicker.Name = "data_achizitieDateTimePicker";
            this.data_achizitieDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.data_achizitieDateTimePicker.TabIndex = 6;
            // 
            // metoda_achizitieLabel
            // 
            metoda_achizitieLabel.AutoSize = true;
            metoda_achizitieLabel.Location = new System.Drawing.Point(172, 163);
            metoda_achizitieLabel.Name = "metoda_achizitieLabel";
            metoda_achizitieLabel.Size = new System.Drawing.Size(87, 13);
            metoda_achizitieLabel.TabIndex = 7;
            metoda_achizitieLabel.Text = "Metoda achizitie:";
            // 
            // metoda_achizitieTextBox
            // 
            this.metoda_achizitieTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.rezervareBindingSource, "Metoda_achizitie", true));
            this.metoda_achizitieTextBox.Location = new System.Drawing.Point(265, 160);
            this.metoda_achizitieTextBox.Name = "metoda_achizitieTextBox";
            this.metoda_achizitieTextBox.Size = new System.Drawing.Size(200, 20);
            this.metoda_achizitieTextBox.TabIndex = 8;
            // 
            // pretLabel
            // 
            pretLabel.AutoSize = true;
            pretLabel.Location = new System.Drawing.Point(172, 189);
            pretLabel.Name = "pretLabel";
            pretLabel.Size = new System.Drawing.Size(29, 13);
            pretLabel.TabIndex = 9;
            pretLabel.Text = "Pret:";
            // 
            // pretTextBox
            // 
            this.pretTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.rezervareBindingSource, "Pret", true));
            this.pretTextBox.Location = new System.Drawing.Point(265, 186);
            this.pretTextBox.Name = "pretTextBox";
            this.pretTextBox.Size = new System.Drawing.Size(200, 20);
            this.pretTextBox.TabIndex = 10;
            // 
            // Form19
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(id_clientLabel);
            this.Controls.Add(this.id_clientTextBox);
            this.Controls.Add(data_achizitieLabel);
            this.Controls.Add(this.data_achizitieDateTimePicker);
            this.Controls.Add(metoda_achizitieLabel);
            this.Controls.Add(this.metoda_achizitieTextBox);
            this.Controls.Add(pretLabel);
            this.Controls.Add(this.pretTextBox);
            this.Controls.Add(this.rezervareBindingNavigator);
            this.Name = "Form19";
            this.Text = "Form19";
            this.Load += new System.EventHandler(this.Form19_Load);
            ((System.ComponentModel.ISupportInitialize)(this.companieaerianaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rezervareBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rezervareBindingNavigator)).EndInit();
            this.rezervareBindingNavigator.ResumeLayout(false);
            this.rezervareBindingNavigator.PerformLayout();
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
        private System.Windows.Forms.TextBox id_clientTextBox;
        private System.Windows.Forms.DateTimePicker data_achizitieDateTimePicker;
        private System.Windows.Forms.TextBox metoda_achizitieTextBox;
        private System.Windows.Forms.TextBox pretTextBox;
    }
}