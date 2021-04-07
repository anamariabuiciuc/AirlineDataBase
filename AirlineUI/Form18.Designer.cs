
namespace Airline
{
    partial class RezervarileMele
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
            System.Windows.Forms.Label metoda_achizitieLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RezervarileMele));
            System.Windows.Forms.Label data_achizitieLabel;
            System.Windows.Forms.Label pretLabel;
            System.Windows.Forms.Label id_clientLabel;
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.companieaerianaDataSet = new Airline.companieaerianaDataSet();
            this.rezervareBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rezervareTableAdapter = new Airline.companieaerianaDataSetTableAdapters.RezervareTableAdapter();
            this.tableAdapterManager = new Airline.companieaerianaDataSetTableAdapters.TableAdapterManager();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.rezervareBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.rezervareBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.pretTextBox = new System.Windows.Forms.TextBox();
            this.data_achizitieDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.id_clientTextBox = new System.Windows.Forms.TextBox();
            this.metoda_achizitieComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.button3 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            metoda_achizitieLabel = new System.Windows.Forms.Label();
            data_achizitieLabel = new System.Windows.Forms.Label();
            pretLabel = new System.Windows.Forms.Label();
            id_clientLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.companieaerianaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rezervareBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rezervareBindingNavigator)).BeginInit();
            this.rezervareBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(142, 171);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(539, 150);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(407, 124);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(189, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Introduceti id-ul de client al dumneavoastra:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(544, 117);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Cautare";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(265, 357);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Introduceti id-ul rezervarii:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(407, 354);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 4;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(535, 351);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "Cautare";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(142, 400);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(539, 167);
            this.dataGridView2.TabIndex = 7;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
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
            // metoda_achizitieLabel
            // 
            metoda_achizitieLabel.AutoSize = true;
            metoda_achizitieLabel.BackColor = System.Drawing.Color.Transparent;
            metoda_achizitieLabel.Location = new System.Drawing.Point(781, 257);
            metoda_achizitieLabel.Name = "metoda_achizitieLabel";
            metoda_achizitieLabel.Size = new System.Drawing.Size(87, 13);
            metoda_achizitieLabel.TabIndex = 15;
            metoda_achizitieLabel.Text = "Metoda achizitie:";
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
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
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
            // rezervareBindingNavigator
            // 
            this.rezervareBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.rezervareBindingNavigator.BindingSource = this.rezervareBindingSource;
            this.rezervareBindingNavigator.CountItem = null;
            this.rezervareBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.rezervareBindingNavigator.Dock = System.Windows.Forms.DockStyle.None;
            this.rezervareBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.rezervareBindingNavigatorSaveItem});
            this.rezervareBindingNavigator.Location = new System.Drawing.Point(1010, 171);
            this.rezervareBindingNavigator.MoveFirstItem = null;
            this.rezervareBindingNavigator.MoveLastItem = null;
            this.rezervareBindingNavigator.MoveNextItem = null;
            this.rezervareBindingNavigator.MovePreviousItem = null;
            this.rezervareBindingNavigator.Name = "rezervareBindingNavigator";
            this.rezervareBindingNavigator.PositionItem = null;
            this.rezervareBindingNavigator.Size = new System.Drawing.Size(81, 25);
            this.rezervareBindingNavigator.TabIndex = 8;
            this.rezervareBindingNavigator.Text = "bindingNavigator1";
            // 
            // data_achizitieLabel
            // 
            data_achizitieLabel.AutoSize = true;
            data_achizitieLabel.BackColor = System.Drawing.Color.Transparent;
            data_achizitieLabel.Location = new System.Drawing.Point(781, 232);
            data_achizitieLabel.Name = "data_achizitieLabel";
            data_achizitieLabel.Size = new System.Drawing.Size(74, 13);
            data_achizitieLabel.TabIndex = 13;
            data_achizitieLabel.Text = "Data achizitie:";
            // 
            // pretLabel
            // 
            pretLabel.AutoSize = true;
            pretLabel.BackColor = System.Drawing.Color.Transparent;
            pretLabel.Location = new System.Drawing.Point(781, 283);
            pretLabel.Name = "pretLabel";
            pretLabel.Size = new System.Drawing.Size(29, 13);
            pretLabel.TabIndex = 17;
            pretLabel.Text = "Pret:";
            // 
            // pretTextBox
            // 
            this.pretTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.rezervareBindingSource, "Pret", true));
            this.pretTextBox.Location = new System.Drawing.Point(874, 280);
            this.pretTextBox.Name = "pretTextBox";
            this.pretTextBox.Size = new System.Drawing.Size(200, 20);
            this.pretTextBox.TabIndex = 18;
            // 
            // data_achizitieDateTimePicker
            // 
            this.data_achizitieDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.rezervareBindingSource, "Data_achizitie", true));
            this.data_achizitieDateTimePicker.Location = new System.Drawing.Point(874, 228);
            this.data_achizitieDateTimePicker.MaxDate = new System.DateTime(2021, 12, 31, 0, 0, 0, 0);
            this.data_achizitieDateTimePicker.MinDate = new System.DateTime(2021, 1, 1, 0, 0, 0, 0);
            this.data_achizitieDateTimePicker.Name = "data_achizitieDateTimePicker";
            this.data_achizitieDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.data_achizitieDateTimePicker.TabIndex = 14;
            // 
            // id_clientLabel
            // 
            id_clientLabel.AutoSize = true;
            id_clientLabel.BackColor = System.Drawing.Color.Transparent;
            id_clientLabel.Location = new System.Drawing.Point(742, 205);
            id_clientLabel.Name = "id_clientLabel";
            id_clientLabel.Size = new System.Drawing.Size(113, 13);
            id_clientLabel.TabIndex = 18;
            id_clientLabel.Text = "Reintroduceti Id client:";
            // 
            // id_clientTextBox
            // 
            this.id_clientTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.rezervareBindingSource, "Id_client", true));
            this.id_clientTextBox.Location = new System.Drawing.Point(874, 202);
            this.id_clientTextBox.Name = "id_clientTextBox";
            this.id_clientTextBox.Size = new System.Drawing.Size(100, 20);
            this.id_clientTextBox.TabIndex = 19;
            // 
            // metoda_achizitieComboBox
            // 
            this.metoda_achizitieComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.rezervareBindingSource, "Metoda_achizitie", true));
            this.metoda_achizitieComboBox.FormattingEnabled = true;
            this.metoda_achizitieComboBox.Items.AddRange(new object[] {
            "Cash",
            "Ordin plata",
            "Online"});
            this.metoda_achizitieComboBox.Location = new System.Drawing.Point(874, 257);
            this.metoda_achizitieComboBox.Name = "metoda_achizitieComboBox";
            this.metoda_achizitieComboBox.Size = new System.Drawing.Size(121, 21);
            this.metoda_achizitieComboBox.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(844, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 20);
            this.label3.TabIndex = 21;
            this.label3.Text = "Fa o rezervare:";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(895, 375);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 22;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(854, 378);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "Data:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(895, 421);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 24;
            this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(802, 424);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 13);
            this.label5.TabIndex = 25;
            this.label5.Text = "Tara de plecare:";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(895, 469);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 20);
            this.textBox5.TabIndex = 26;
            this.textBox5.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(792, 474);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 13);
            this.label6.TabIndex = 27;
            this.label6.Text = "Tara de destinatie:";
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(734, 509);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(370, 150);
            this.dataGridView3.TabIndex = 28;
            this.dataGridView3.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView3_CellContentClick);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(1016, 469);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 29;
            this.button3.Text = "Cautare";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(881, 337);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(127, 20);
            this.label7.TabIndex = 30;
            this.label7.Text = "Cauta un zbor:";
            // 
            // RezervarileMele
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1131, 749);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.metoda_achizitieComboBox);
            this.Controls.Add(id_clientLabel);
            this.Controls.Add(this.id_clientTextBox);
            this.Controls.Add(data_achizitieLabel);
            this.Controls.Add(this.data_achizitieDateTimePicker);
            this.Controls.Add(metoda_achizitieLabel);
            this.Controls.Add(pretLabel);
            this.Controls.Add(this.pretTextBox);
            this.Controls.Add(this.rezervareBindingNavigator);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "RezervarileMele";
            this.Text = "Rezervarile mele";
            this.Load += new System.EventHandler(this.RezervarileMele_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.companieaerianaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rezervareBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rezervareBindingNavigator)).EndInit();
            this.rezervareBindingNavigator.ResumeLayout(false);
            this.rezervareBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private companieaerianaDataSet companieaerianaDataSet;
        private System.Windows.Forms.BindingSource rezervareBindingSource;
        private companieaerianaDataSetTableAdapters.RezervareTableAdapter rezervareTableAdapter;
        private companieaerianaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton rezervareBindingNavigatorSaveItem;
        private System.Windows.Forms.BindingNavigator rezervareBindingNavigator;
        private System.Windows.Forms.TextBox pretTextBox;
        private System.Windows.Forms.DateTimePicker data_achizitieDateTimePicker;
        private System.Windows.Forms.TextBox id_clientTextBox;
        private System.Windows.Forms.ComboBox metoda_achizitieComboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label7;
    }
}