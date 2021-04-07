
namespace Airline
{
    partial class AdministrareClienti
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
            System.Windows.Forms.Label numeLabel;
            System.Windows.Forms.Label prenumeLabel;
            System.Windows.Forms.Label genLabel;
            System.Windows.Forms.Label data_nasteriiLabel;
            System.Windows.Forms.Label cNPLabel;
            System.Windows.Forms.Label nume_insotitorLabel;
            System.Windows.Forms.Label taraLabel;
            System.Windows.Forms.Label regiuneLabel;
            System.Windows.Forms.Label localitateLabel;
            System.Windows.Forms.Label stradaLabel;
            System.Windows.Forms.Label numarLabel;
            System.Windows.Forms.Label nr_telefonLabel;
            System.Windows.Forms.Label adresa_mailLabel;
            System.Windows.Forms.Label id_clientLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdministrareClienti));
            this.companieaerianaClient_ClientNou = new Airline.companieaerianaClient_ClientNou();
            this.clientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clientTableAdapter = new Airline.companieaerianaClient_ClientNouTableAdapters.ClientTableAdapter();
            this.tableAdapterManager = new Airline.companieaerianaClient_ClientNouTableAdapters.TableAdapterManager();
            this.clientBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.clientBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.numeTextBox = new System.Windows.Forms.TextBox();
            this.prenumeTextBox = new System.Windows.Forms.TextBox();
            this.genTextBox = new System.Windows.Forms.TextBox();
            this.data_nasteriiDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.cNPTextBox = new System.Windows.Forms.TextBox();
            this.nume_insotitorTextBox = new System.Windows.Forms.TextBox();
            this.taraTextBox = new System.Windows.Forms.TextBox();
            this.regiuneTextBox = new System.Windows.Forms.TextBox();
            this.localitateTextBox = new System.Windows.Forms.TextBox();
            this.stradaTextBox = new System.Windows.Forms.TextBox();
            this.numarTextBox = new System.Windows.Forms.TextBox();
            this.nr_telefonTextBox = new System.Windows.Forms.TextBox();
            this.adresa_mailTextBox = new System.Windows.Forms.TextBox();
            this.id_clientTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            numeLabel = new System.Windows.Forms.Label();
            prenumeLabel = new System.Windows.Forms.Label();
            genLabel = new System.Windows.Forms.Label();
            data_nasteriiLabel = new System.Windows.Forms.Label();
            cNPLabel = new System.Windows.Forms.Label();
            nume_insotitorLabel = new System.Windows.Forms.Label();
            taraLabel = new System.Windows.Forms.Label();
            regiuneLabel = new System.Windows.Forms.Label();
            localitateLabel = new System.Windows.Forms.Label();
            stradaLabel = new System.Windows.Forms.Label();
            numarLabel = new System.Windows.Forms.Label();
            nr_telefonLabel = new System.Windows.Forms.Label();
            adresa_mailLabel = new System.Windows.Forms.Label();
            id_clientLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.companieaerianaClient_ClientNou)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingNavigator)).BeginInit();
            this.clientBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // numeLabel
            // 
            numeLabel.AutoSize = true;
            numeLabel.Location = new System.Drawing.Point(278, 72);
            numeLabel.Name = "numeLabel";
            numeLabel.Size = new System.Drawing.Size(38, 13);
            numeLabel.TabIndex = 3;
            numeLabel.Text = "Nume:";
            // 
            // prenumeLabel
            // 
            prenumeLabel.AutoSize = true;
            prenumeLabel.Location = new System.Drawing.Point(278, 98);
            prenumeLabel.Name = "prenumeLabel";
            prenumeLabel.Size = new System.Drawing.Size(52, 13);
            prenumeLabel.TabIndex = 5;
            prenumeLabel.Text = "Prenume:";
            // 
            // genLabel
            // 
            genLabel.AutoSize = true;
            genLabel.Location = new System.Drawing.Point(278, 124);
            genLabel.Name = "genLabel";
            genLabel.Size = new System.Drawing.Size(30, 13);
            genLabel.TabIndex = 7;
            genLabel.Text = "Gen:";
            // 
            // data_nasteriiLabel
            // 
            data_nasteriiLabel.AutoSize = true;
            data_nasteriiLabel.Location = new System.Drawing.Point(278, 151);
            data_nasteriiLabel.Name = "data_nasteriiLabel";
            data_nasteriiLabel.Size = new System.Drawing.Size(69, 13);
            data_nasteriiLabel.TabIndex = 9;
            data_nasteriiLabel.Text = "Data nasterii:";
            // 
            // cNPLabel
            // 
            cNPLabel.AutoSize = true;
            cNPLabel.Location = new System.Drawing.Point(278, 176);
            cNPLabel.Name = "cNPLabel";
            cNPLabel.Size = new System.Drawing.Size(32, 13);
            cNPLabel.TabIndex = 11;
            cNPLabel.Text = "CNP:";
            // 
            // nume_insotitorLabel
            // 
            nume_insotitorLabel.AutoSize = true;
            nume_insotitorLabel.Location = new System.Drawing.Point(278, 202);
            nume_insotitorLabel.Name = "nume_insotitorLabel";
            nume_insotitorLabel.Size = new System.Drawing.Size(77, 13);
            nume_insotitorLabel.TabIndex = 13;
            nume_insotitorLabel.Text = "Nume insotitor:";
            // 
            // taraLabel
            // 
            taraLabel.AutoSize = true;
            taraLabel.Location = new System.Drawing.Point(278, 228);
            taraLabel.Name = "taraLabel";
            taraLabel.Size = new System.Drawing.Size(32, 13);
            taraLabel.TabIndex = 15;
            taraLabel.Text = "Tara:";
            // 
            // regiuneLabel
            // 
            regiuneLabel.AutoSize = true;
            regiuneLabel.Location = new System.Drawing.Point(278, 254);
            regiuneLabel.Name = "regiuneLabel";
            regiuneLabel.Size = new System.Drawing.Size(50, 13);
            regiuneLabel.TabIndex = 17;
            regiuneLabel.Text = "Regiune:";
            // 
            // localitateLabel
            // 
            localitateLabel.AutoSize = true;
            localitateLabel.Location = new System.Drawing.Point(278, 280);
            localitateLabel.Name = "localitateLabel";
            localitateLabel.Size = new System.Drawing.Size(56, 13);
            localitateLabel.TabIndex = 19;
            localitateLabel.Text = "Localitate:";
            // 
            // stradaLabel
            // 
            stradaLabel.AutoSize = true;
            stradaLabel.Location = new System.Drawing.Point(278, 306);
            stradaLabel.Name = "stradaLabel";
            stradaLabel.Size = new System.Drawing.Size(41, 13);
            stradaLabel.TabIndex = 21;
            stradaLabel.Text = "Strada:";
            // 
            // numarLabel
            // 
            numarLabel.AutoSize = true;
            numarLabel.Location = new System.Drawing.Point(278, 332);
            numarLabel.Name = "numarLabel";
            numarLabel.Size = new System.Drawing.Size(41, 13);
            numarLabel.TabIndex = 23;
            numarLabel.Text = "Numar:";
            // 
            // nr_telefonLabel
            // 
            nr_telefonLabel.AutoSize = true;
            nr_telefonLabel.Location = new System.Drawing.Point(278, 358);
            nr_telefonLabel.Name = "nr_telefonLabel";
            nr_telefonLabel.Size = new System.Drawing.Size(56, 13);
            nr_telefonLabel.TabIndex = 25;
            nr_telefonLabel.Text = "Nr telefon:";
            // 
            // adresa_mailLabel
            // 
            adresa_mailLabel.AutoSize = true;
            adresa_mailLabel.Location = new System.Drawing.Point(278, 384);
            adresa_mailLabel.Name = "adresa_mailLabel";
            adresa_mailLabel.Size = new System.Drawing.Size(64, 13);
            adresa_mailLabel.TabIndex = 27;
            adresa_mailLabel.Text = "Adresa mail:";
            // 
            // id_clientLabel
            // 
            id_clientLabel.AutoSize = true;
            id_clientLabel.Location = new System.Drawing.Point(278, 48);
            id_clientLabel.Name = "id_clientLabel";
            id_clientLabel.Size = new System.Drawing.Size(47, 13);
            id_clientLabel.TabIndex = 28;
            id_clientLabel.Text = "Id client:";
            id_clientLabel.Click += new System.EventHandler(this.id_clientLabel_Click);
            // 
            // companieaerianaClient_ClientNou
            // 
            this.companieaerianaClient_ClientNou.DataSetName = "companieaerianaClient_ClientNou";
            this.companieaerianaClient_ClientNou.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clientBindingSource
            // 
            this.clientBindingSource.DataMember = "Client";
            this.clientBindingSource.DataSource = this.companieaerianaClient_ClientNou;
            // 
            // clientTableAdapter
            // 
            this.clientTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ClientTableAdapter = this.clientTableAdapter;
            this.tableAdapterManager.UpdateOrder = Airline.companieaerianaClient_ClientNouTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // clientBindingNavigator
            // 
            this.clientBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.clientBindingNavigator.BindingSource = this.clientBindingSource;
            this.clientBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.clientBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.clientBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.clientBindingNavigatorSaveItem});
            this.clientBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.clientBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.clientBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.clientBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.clientBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.clientBindingNavigator.Name = "clientBindingNavigator";
            this.clientBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.clientBindingNavigator.Size = new System.Drawing.Size(800, 25);
            this.clientBindingNavigator.TabIndex = 0;
            this.clientBindingNavigator.Text = "bindingNavigator1";
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
            // clientBindingNavigatorSaveItem
            // 
            this.clientBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.clientBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("clientBindingNavigatorSaveItem.Image")));
            this.clientBindingNavigatorSaveItem.Name = "clientBindingNavigatorSaveItem";
            this.clientBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.clientBindingNavigatorSaveItem.Text = "Save Data";
            this.clientBindingNavigatorSaveItem.Click += new System.EventHandler(this.clientBindingNavigatorSaveItem_Click);
            // 
            // numeTextBox
            // 
            this.numeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientBindingSource, "Nume", true));
            this.numeTextBox.Location = new System.Drawing.Point(361, 69);
            this.numeTextBox.Name = "numeTextBox";
            this.numeTextBox.Size = new System.Drawing.Size(200, 20);
            this.numeTextBox.TabIndex = 4;
            // 
            // prenumeTextBox
            // 
            this.prenumeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientBindingSource, "Prenume", true));
            this.prenumeTextBox.Location = new System.Drawing.Point(361, 95);
            this.prenumeTextBox.Name = "prenumeTextBox";
            this.prenumeTextBox.Size = new System.Drawing.Size(200, 20);
            this.prenumeTextBox.TabIndex = 6;
            // 
            // genTextBox
            // 
            this.genTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientBindingSource, "Gen", true));
            this.genTextBox.Location = new System.Drawing.Point(361, 121);
            this.genTextBox.Name = "genTextBox";
            this.genTextBox.Size = new System.Drawing.Size(200, 20);
            this.genTextBox.TabIndex = 8;
            // 
            // data_nasteriiDateTimePicker
            // 
            this.data_nasteriiDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.clientBindingSource, "Data_nasterii", true));
            this.data_nasteriiDateTimePicker.Location = new System.Drawing.Point(361, 147);
            this.data_nasteriiDateTimePicker.MaxDate = new System.DateTime(2020, 12, 31, 0, 0, 0, 0);
            this.data_nasteriiDateTimePicker.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.data_nasteriiDateTimePicker.Name = "data_nasteriiDateTimePicker";
            this.data_nasteriiDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.data_nasteriiDateTimePicker.TabIndex = 10;
            this.data_nasteriiDateTimePicker.Value = new System.DateTime(2020, 12, 31, 0, 0, 0, 0);
            // 
            // cNPTextBox
            // 
            this.cNPTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientBindingSource, "CNP", true));
            this.cNPTextBox.Location = new System.Drawing.Point(361, 173);
            this.cNPTextBox.Name = "cNPTextBox";
            this.cNPTextBox.Size = new System.Drawing.Size(200, 20);
            this.cNPTextBox.TabIndex = 12;
            // 
            // nume_insotitorTextBox
            // 
            this.nume_insotitorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientBindingSource, "Nume_insotitor", true));
            this.nume_insotitorTextBox.Location = new System.Drawing.Point(361, 199);
            this.nume_insotitorTextBox.Name = "nume_insotitorTextBox";
            this.nume_insotitorTextBox.Size = new System.Drawing.Size(200, 20);
            this.nume_insotitorTextBox.TabIndex = 14;
            // 
            // taraTextBox
            // 
            this.taraTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientBindingSource, "Tara", true));
            this.taraTextBox.Location = new System.Drawing.Point(361, 225);
            this.taraTextBox.Name = "taraTextBox";
            this.taraTextBox.Size = new System.Drawing.Size(200, 20);
            this.taraTextBox.TabIndex = 16;
            // 
            // regiuneTextBox
            // 
            this.regiuneTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientBindingSource, "Regiune", true));
            this.regiuneTextBox.Location = new System.Drawing.Point(361, 251);
            this.regiuneTextBox.Name = "regiuneTextBox";
            this.regiuneTextBox.Size = new System.Drawing.Size(200, 20);
            this.regiuneTextBox.TabIndex = 18;
            // 
            // localitateTextBox
            // 
            this.localitateTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientBindingSource, "Localitate", true));
            this.localitateTextBox.Location = new System.Drawing.Point(361, 277);
            this.localitateTextBox.Name = "localitateTextBox";
            this.localitateTextBox.Size = new System.Drawing.Size(200, 20);
            this.localitateTextBox.TabIndex = 20;
            // 
            // stradaTextBox
            // 
            this.stradaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientBindingSource, "Strada", true));
            this.stradaTextBox.Location = new System.Drawing.Point(361, 303);
            this.stradaTextBox.Name = "stradaTextBox";
            this.stradaTextBox.Size = new System.Drawing.Size(200, 20);
            this.stradaTextBox.TabIndex = 22;
            // 
            // numarTextBox
            // 
            this.numarTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientBindingSource, "Numar", true));
            this.numarTextBox.Location = new System.Drawing.Point(361, 329);
            this.numarTextBox.Name = "numarTextBox";
            this.numarTextBox.Size = new System.Drawing.Size(200, 20);
            this.numarTextBox.TabIndex = 24;
            // 
            // nr_telefonTextBox
            // 
            this.nr_telefonTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientBindingSource, "Nr_telefon", true));
            this.nr_telefonTextBox.Location = new System.Drawing.Point(361, 355);
            this.nr_telefonTextBox.Name = "nr_telefonTextBox";
            this.nr_telefonTextBox.Size = new System.Drawing.Size(200, 20);
            this.nr_telefonTextBox.TabIndex = 26;
            // 
            // adresa_mailTextBox
            // 
            this.adresa_mailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientBindingSource, "Adresa_mail", true));
            this.adresa_mailTextBox.Location = new System.Drawing.Point(361, 381);
            this.adresa_mailTextBox.Name = "adresa_mailTextBox";
            this.adresa_mailTextBox.Size = new System.Drawing.Size(200, 20);
            this.adresa_mailTextBox.TabIndex = 28;
            // 
            // id_clientTextBox
            // 
            this.id_clientTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientBindingSource, "Id_client", true));
            this.id_clientTextBox.Location = new System.Drawing.Point(361, 45);
            this.id_clientTextBox.Name = "id_clientTextBox";
            this.id_clientTextBox.Size = new System.Drawing.Size(200, 20);
            this.id_clientTextBox.TabIndex = 29;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(622, 29);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 23);
            this.button1.TabIndex = 30;
            this.button1.Text = "Fa o rezervare.";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // AdministrareClienti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(id_clientLabel);
            this.Controls.Add(this.id_clientTextBox);
            this.Controls.Add(numeLabel);
            this.Controls.Add(this.numeTextBox);
            this.Controls.Add(prenumeLabel);
            this.Controls.Add(this.prenumeTextBox);
            this.Controls.Add(genLabel);
            this.Controls.Add(this.genTextBox);
            this.Controls.Add(data_nasteriiLabel);
            this.Controls.Add(this.data_nasteriiDateTimePicker);
            this.Controls.Add(cNPLabel);
            this.Controls.Add(this.cNPTextBox);
            this.Controls.Add(nume_insotitorLabel);
            this.Controls.Add(this.nume_insotitorTextBox);
            this.Controls.Add(taraLabel);
            this.Controls.Add(this.taraTextBox);
            this.Controls.Add(regiuneLabel);
            this.Controls.Add(this.regiuneTextBox);
            this.Controls.Add(localitateLabel);
            this.Controls.Add(this.localitateTextBox);
            this.Controls.Add(stradaLabel);
            this.Controls.Add(this.stradaTextBox);
            this.Controls.Add(numarLabel);
            this.Controls.Add(this.numarTextBox);
            this.Controls.Add(nr_telefonLabel);
            this.Controls.Add(this.nr_telefonTextBox);
            this.Controls.Add(adresa_mailLabel);
            this.Controls.Add(this.adresa_mailTextBox);
            this.Controls.Add(this.clientBindingNavigator);
            this.Name = "AdministrareClienti";
            this.Text = "Administrare - Clienti";
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.companieaerianaClient_ClientNou)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingNavigator)).EndInit();
            this.clientBindingNavigator.ResumeLayout(false);
            this.clientBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private companieaerianaClient_ClientNou companieaerianaClient_ClientNou;
        private System.Windows.Forms.BindingSource clientBindingSource;
        private companieaerianaClient_ClientNouTableAdapters.ClientTableAdapter clientTableAdapter;
        private companieaerianaClient_ClientNouTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator clientBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton clientBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox numeTextBox;
        private System.Windows.Forms.TextBox prenumeTextBox;
        private System.Windows.Forms.TextBox genTextBox;
        private System.Windows.Forms.DateTimePicker data_nasteriiDateTimePicker;
        private System.Windows.Forms.TextBox cNPTextBox;
        private System.Windows.Forms.TextBox nume_insotitorTextBox;
        private System.Windows.Forms.TextBox taraTextBox;
        private System.Windows.Forms.TextBox regiuneTextBox;
        private System.Windows.Forms.TextBox localitateTextBox;
        private System.Windows.Forms.TextBox stradaTextBox;
        private System.Windows.Forms.TextBox numarTextBox;
        private System.Windows.Forms.TextBox nr_telefonTextBox;
        private System.Windows.Forms.TextBox adresa_mailTextBox;
        private System.Windows.Forms.TextBox id_clientTextBox;
        private System.Windows.Forms.Button button1;
    }
}